using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapEditor.Components;
using MapEditor.Forms;
using MapEditor.Common;
using MapEditor.Graphics;

namespace MapEditor
{
	public partial class MapEditorMain : Form
	{
		public MapEditorMain()
		{
			InitializeComponent();
			Manager.MainWindow = this;
		}

		public BrushMode CurrentBrush
		{
			get { return roomEditor1._rPanel.CurrentBrush; }
			set
			{
				if (Manager.Room != null)
				{
					roomEditor1._rPanel.CurrentBrush = value;
					tbSelectMap.Checked = (value == BrushMode.Select);
					tbPaintMap.Checked = (value == BrushMode.Paint);
					tbRotateMap.Checked = (value == BrushMode.Rotate);
					tbMoveMap.Checked = (value == BrushMode.Move);
					roomEditor1._rPanel.RefreshCursor();
					roomEditor1._rPanel.Invalidate();
				}
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (AboutWindow form = new AboutWindow())
			{
				form.ShowDialog();
			}
		}

		public void ensureButtonsDisabled()
		{
			if (Manager.Project == null)
			{
				tbSaveProject.Enabled = false;
				tsOptions.Enabled = tsEditors.Enabled = tsMap.Enabled = false;
				if (treeViewGMX.Nodes.Count > 0)
				{
					treeViewGMX.Nodes.Clear();
				}
				tsMap.Enabled = false;
				tabControlMain.Visible = tabControlMain.Enabled = false;
			}
			else
			{
				tbSaveProject.Enabled = true;
				tsEditors.Enabled = true;
				tsOptions.Enabled = true;
				tsMap.Enabled = (Manager.Room != null);
				tabControlEnv.Enabled = (Manager.Room != null);
				tabControlMain.Visible = tabControlMain.Enabled = true;
			}

			_ensureMenusDisabled();
			ensureZoomButtons();
		}

		private void _ensureMenusDisabled()
		{
			tmCloseProject.Enabled = tmSaveProject.Enabled = tbSaveProject.Enabled;
			tmSaveProjectAs.Enabled = false;
			tmEdit.Enabled = (Manager.Project != null);
		}

		private void tbNewProject_Click(object sender, EventArgs e)
		{
			//if (MessageBox.Show("Are you sure to create new project?\nThis will save some additional *.ame files inside your project directory. This shouldn't affect your GM:S project, but remember - we take no responsibility for any damage caused!", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			//    == DialogResult.Yes)
			//{
			// ok, create new project
			openFileDialog1.DefaultExt = ".project.gmx";
			openFileDialog1.Filter = "GM:S Project|*.project.gmx";
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				if (Manager.newProject(openFileDialog1.FileName))
				{
					Manager.Project.renderItemsTree(treeViewGMX);
					treeViewGMX.Nodes[0].Expand();
					ensureButtonsDisabled();
				}
			}
			//}
		}

		private void tbOpenProject_Click(object sender, EventArgs e)
		{
			openFileDialog1.DefaultExt = ".project.ame";
			openFileDialog1.Filter = "AME Project|*.project.ame";
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				if (Manager.loadProject(openFileDialog1.FileName))
				{
					if (Manager.Project != null)
					{
						Manager.Project.renderItemsTree(treeViewGMX);
						treeViewGMX.Nodes[0].Expand();
					}
					ensureButtonsDisabled();
					if (lbRooms.Items.Count > 0)
					{
						lbRooms.SelectedIndex = 0;
						lbRooms_DoubleClick(lbRooms, new EventArgs());
					}

					//GraphicsManager.LoadTexture(new Bitmap(Manager.Project.ProjectSource + "\\sprites\\images\\sprPlant2_0.png"), 0);
				}
			}
		}

		private void MapEditorMain_Load(object sender, EventArgs e)
		{
			ensureButtonsDisabled();
		}

		private void tbUsedResList_Click(object sender, EventArgs e)
		{
			/*using (ResourceUsage form = new ResourceUsage())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					Manager.Project.checkForRegisteredRes();
					Manager.Project.renderItemsTree(treeViewGMX);
					Manager.Project.regenerateTextureList();
				}
			}*/

			using (BrushGroups form = new BrushGroups())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{

				}
			}
		}

		private void tbLayerList_Click(object sender, EventArgs e)
		{
			if (Manager.Room != null)
			{
				using (LayerForm form = new LayerForm())
				{
					if (form.ShowDialog() == DialogResult.OK)
					{
						Manager.Room.Layers.Add(new MapLayers() { LayerDepth = -Manager.Room.Layers.Count });
					}
				}
			}
		}

		private void tbSaveProject_Click(object sender, EventArgs e)
		{
			Manager.Project.saveProjectToXML();
		}

		private void tmCloseProject_Click(object sender, EventArgs e)
		{
			Manager.dropProject();
			lbPlaceables.Items.Clear();
			lbRooms.Items.Clear();
			roomEditor1.Invalidate();
			ensureButtonsDisabled();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void addOrEditRoom(bool edit)
		{
			string defName = "Undefined Room " + lbRooms.Items.Count.ToString();
			using (RoomForm form = new RoomForm())
			{
				MapRoom elem;
				if (edit)
				{
					elem = Manager.Project.RoomList[lbRooms.SelectedIndex];
					form.Element = elem;
					form.Text = "Edit Room Definition: " + defName;
				}
				else
				{
					elem = new MapRoom() { Width = 1024, Height = 768 };
					form.Element = elem;
					form.Text = "Paint new Room Definition: " + defName;
				}

				if (form.ShowDialog() == DialogResult.OK)
				{
					if (edit)
					{
						//TODO: since elem is referenced, it shouldn't be changed that way
						//elem = form.Element;
					}
					else
					{
						Manager.Project.RoomList.Add(form.Element);
					}
					Manager.Project.regenerateRoomList();
					Manager.Project.Room = elem;
				}
			}
		}

		private void addOrEditPlaceable(bool edit)
		{
			string defName = "Undefined Placeable " + lbPlaceables.Items.Count.ToString();

			if (edit)
			{
				if (lbPlaceables.Items.Count < 1 || lbPlaceables.SelectedIndex < 0) return;
			}

			using (PlaceableForm form = new PlaceableForm())
			{
				PlaceableElement elem;
				if (edit)
				{
					elem = Manager.Project.PlaceableList[lbPlaceables.SelectedIndex];
					form.Element = elem;
					form.Text = "Edit Placeable Definition: " + elem.Name;
				}
				else
				{
					elem = new PlaceableElement() { Name = defName };
					form.Element = elem;
					form.Text = "Create new Placeable Definition: " + defName;
				}

				if (form.ShowDialog() == DialogResult.OK)
				{
					if (edit)
					{
						//TODO: since elem is referenced, it shouldn't be changed that way
						//elem = form.Element;
					}
					else
					{
						Manager.Project.PlaceableList.Add(form.Element);
					}
					Manager.Project.regenerateEnvDefList();
				}
			}

			statusLabelPlaceables.Text = Manager.Project.PlaceableList.Count.ToString();
		}

		private void addOrEditLayer(bool edit)
		{
			string defName = "Undefined Layer " + lbLayers.Items.Count.ToString();

			if (edit)
			{
				if (lbLayers.Items.Count < 1 || lbLayers.SelectedIndex < 0) return;
			}

			using (LayerForm form = new LayerForm())
			{
				MapLayers elem;
				if (edit)
				{
					elem = Manager.Project.Room.Layers[lbLayers.SelectedIndex];
					form.Element = elem;
					form.Text = "Edit Layer Definition: " + elem.LayerName;
				}
				else
				{
					int depth = 0;
					if (lbLayers.Items.Count > 0)
					{
						depth = Manager.Project.Room.Layers[lbLayers.Items.Count - 1].LayerDepth + 1;
					}
					elem = new MapLayers() { LayerName = defName, LayerDepth = 1 };
					form.Text = "Create new Layer Definition: " + defName;
				}

				form.Element = elem;

				if (form.ShowDialog() == DialogResult.OK)
				{
					if (edit)
					{
						//TODO: since elem is referenced, it shouldn't be changed that way
						//elem = form.Element;
					}
					else
					{
						Manager.Project.Room.Layers.Add(form.Element);
					}
					Manager.Project.regenerateLayerList();
				}
			}
		}

		private void tbAddItem_Click(object sender, EventArgs e)
		{
			if (tabControlMain.SelectedTab == tabRooms)
			{
				if (tabControlRooms.SelectedTab == tpRoomList)
				{
					addOrEditRoom(false);
				}
				else if (tabControlRooms.SelectedTab == tpDefinitions)
				{
					addOrEditPlaceable(false);
				}
			}
			else if (tabControlMain.SelectedTab == tabRooms)
			{
				/*if (tabControlEnv.SelectedIndex == 0)
				{
					addOrEditPlaceable(false);
				}
				else */
				if (tabControlEnv.SelectedTab == tpRoomDataLayers)
				{
					addOrEditLayer(false);
				}
			}
		}

		private void lbPlaceables_DoubleClick(object sender, EventArgs e)
		{
			tbEditItem_Click(sender, e);
		}

		private void lbPlaceables_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (CurrentBrush == BrushMode.Paint && lbPlaceables.SelectedIndex > -1)
				{
					if (Manager.Room != null)
					{
						Manager.Project.Instance = Manager.Project.PlaceableList[lbPlaceables.SelectedIndex];
						CurrentBrush = BrushMode.Paint;
						brushObjectLabel.Text = Manager.Project.Instance.Name;
						//brushObjectSprite.Image = GraphicsManager.Sprites[Manager.Project.Instance.textureId];
					}
				}
			}
		}

		private void tbEditItem_Click(object sender, EventArgs e)
		{
			switch (tabControlMain.SelectedIndex)
			{
				case 1:
					switch (tabControlRooms.SelectedIndex)
					{
						case 0: addOrEditRoom(true); break;
						case 1: addOrEditPlaceable(true); break;
					}
					break;
				case 2:
					switch (tabControlEnv.SelectedIndex)
					{
						case 1: addOrEditLayer(true); break;
					}
					break;
			}
		}

		private void lbRooms_DoubleClick(object sender, EventArgs e)
		{
			if (lbRooms.SelectedIndex > -1)
			{
				if (Manager.Room != null)
				{
					if (Manager.Project.RoomList[lbRooms.SelectedIndex] == Manager.Project.Room) return;
					if (MessageBox.Show("Do you want to close current room?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.OK)
					{
						return;
					}
				}

				Manager.Project.Room = Manager.Project.RoomList[lbRooms.SelectedIndex];
				//if (Manager.Project.Room.LastUsedLayer > -1 && Manager.Project.Room.LastUsedLayer < tbLayerDropDown.Items.Count)
				//{
				Manager.Project.Room.LastUsedLayer = Math.Max(0, Math.Min(Manager.Project.Room.LastUsedLayer, tbLayerDropDown.Items.Count - 1));
				tbLayerDropDown.SelectedIndex = Manager.Project.Room.LastUsedLayer;

				//}

				if (Manager.Project.PlaceableList.Count > 0)
				{
					Manager.Project.Instance = Manager.Project.PlaceableList[0];
				}
				roomEditor1.Invalidate();
				ensureButtonsDisabled();
				CurrentBrush = BrushMode.Select;
				Manager.Project.regenerateInstanceList();
			}
		}

		private void tbSelectMap_Click(object sender, EventArgs e)
		{
			CurrentBrush = BrushMode.Select;
		}

		private void tbPaintMap_Click(object sender, EventArgs e)
		{
			CurrentBrush = BrushMode.Paint;
		}

		private void tbMoveMap_Click(object sender, EventArgs e)
		{
			CurrentBrush = BrushMode.Move;
		}

		private void tbRotateMap_Click(object sender, EventArgs e)
		{
			CurrentBrush = BrushMode.Rotate;
		}

		private void tbLayerDropDown_DropDownClosed(object sender, EventArgs e)
		{
			if (Manager.Room != null)
			{
				Manager.Room.LastUsedLayer = tbLayerDropDown.SelectedIndex;
				ensureCurrentLayerEnabled();
			}
		}

		public void tbEnabledLayersDropdown_SubItemClick(object sender, EventArgs e)
		{
			if (sender is ToolStripMenuItem)
			{
				ToolStripMenuItem item = sender as ToolStripMenuItem;

				if (item != null)
				{
					int index = (item.OwnerItem as ToolStripDropDownButton).DropDownItems.IndexOf(item);
					if (index > -1)
					{
						Manager.Project.Room.Layers[index].Active = item.Checked;
					}

					ensureCurrentLayerEnabled();
				}

			}
		}

		private void ensureCurrentLayerEnabled()
		{
			//TODO: indeterminate ?
			//ToolStripMenuItem item;
			//Manager.Project.Room.Layers[tbLayerDropDown.SelectedIndex].Active = true;
			//item = (ToolStripMenuItem)tbEnabledLayersDropdown.DropDownItems[tbLayerDropDown.SelectedIndex];
			//item.Checked = true;
		}

		private void MapEditorMain_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.S:
					CurrentBrush = BrushMode.Select;
					break;
				case Keys.R:
					CurrentBrush = BrushMode.Rotate;
					break;
				case Keys.A:
					CurrentBrush = BrushMode.Paint;
					break;
				case Keys.M:
					CurrentBrush = BrushMode.Move;
					break;
				case Keys.Escape:
					Manager.Project.SelectedInstance = null;
					break;
			}
		}

		private void tbEnvList_Click(object sender, EventArgs e)
		{
			Textures form = new Textures();
			form.ShowDialog();
		}

		private void tbDeleteMap_Click(object sender, EventArgs e)
		{
			if (Manager.Project.SelectedInstance != null)
			{
				Manager.Project.Room.Instances.Remove(Manager.Project.SelectedInstance);
				Manager.Project.SelectedInstance = null;
			}
		}

		private void tbLayerRoomEdit_Click(object sender, EventArgs e)
		{
			lbLayers.SelectedIndex = tbLayerDropDown.SelectedIndex;
			addOrEditLayer(true);
		}

		private void tbZoomOut_Click(object sender, EventArgs e)
		{
			roomEditor1._rPanel.Zoom = +1;
			ensureZoomButtons();
		}

		private void tbZoomReset_Click(object sender, EventArgs e)
		{
			roomEditor1._rPanel.Zoom = 0;
			ensureZoomButtons();
		}

		private void tbZoomIn_Click(object sender, EventArgs e)
		{
			roomEditor1._rPanel.Zoom = -1;
			ensureZoomButtons();
		}

		public void ensureZoomButtons()
		{
			tbZoomIn.Enabled = roomEditor1._rPanel.Zoom > 1;
			tbZoomOut.Enabled = roomEditor1._rPanel.Zoom < 4;
			tbZoomReset.Enabled = roomEditor1._rPanel.Zoom != 1;
			roomEditor1.Invalidate();
		}

		private void tbGridEnabled_Click(object sender, EventArgs e)
		{
			roomEditor1._rPanel.GridEnabled = tbGridEnabled.Checked;
		}

		public void brushPlaceableUpdatePositionAndRotation()
		{
			if (Manager.Project.SelectedInstance != null)
			{
				panelPreviewTab.Enabled = true;
				Manager.MainWindow.brushPlaceableX.Text = Manager.Project.SelectedInstance.X.ToString();
				Manager.MainWindow.brushPlaceableY.Text = Manager.Project.SelectedInstance.Y.ToString();
				Manager.MainWindow.brushPlaceableRotation.Text = Manager.Project.SelectedInstance.Rotation.ToString();
			}
			else
			{
				panelPreviewTab.Enabled = false;
			}
		}

		#region Rotation text
		private void brushPlaceable0dir_Click(object sender, EventArgs e)
		{
			brushPlaceableRotation.Text = "0";
		}

		private void brushPlaceable90dir_Click(object sender, EventArgs e)
		{
			brushPlaceableRotation.Text = "90";
		}

		private void brushPlaceable180dir_Click(object sender, EventArgs e)
		{
			brushPlaceableRotation.Text = "180";
		}

		private void brushPlaceable270dir_Click(object sender, EventArgs e)
		{
			brushPlaceableRotation.Text = "270";
		}
		#endregion

	}
}
