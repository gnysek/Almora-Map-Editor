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
			}
			else
			{
				tbSaveProject.Enabled = true;
				tsEditors.Enabled = true;
				tsOptions.Enabled = true;
				tsMap.Enabled = (Manager.Room != null);
			}

			_ensureMenusDisabled();
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
					Manager.Project.renderItemsTree(treeViewGMX);
					treeViewGMX.Nodes[0].Expand();
					ensureButtonsDisabled();

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
			using (ResourceUsage form = new ResourceUsage())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					Manager.Project.checkForRegisteredRes();
					Manager.Project.renderItemsTree(treeViewGMX);
					Manager.Project.regenerateTextureList();
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
			Manager.Project.saveProject();
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
				addOrEditRoom(false);
			}
			else if (tabControlMain.SelectedTab == tabPlaceables)
			{
				if (tabControlEnv.SelectedIndex == 0)
				{
					addOrEditPlaceable(false);
				}
				else if (tabControlEnv.SelectedTab == tpRoomDataLayers)
				{
					addOrEditLayer(false);
				}
			}
		}

		private void lbPlaceables_DoubleClick(object sender, EventArgs e)
		{
			if (lbPlaceables.SelectedIndex > -1)
			{
				if (Manager.Room != null)
				{
					Manager.Project.Instance = Manager.Project.PlaceableList[lbPlaceables.SelectedIndex];
					CurrentBrush = BrushMode.Paint;
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
						case 1: addOrEditPlaceable(true); break;
					}
					break;
				case 2:
					switch (tabControlMain.SelectedIndex)
					{
						case 0: addOrEditRoom(true); break;
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
				if (Manager.Project.Room.LastUsedLayer > -1 && Manager.Project.Room.LastUsedLayer <= tbLayerDropDown.Items.Count)
				{
					tbLayerDropDown.SelectedIndex = Manager.Project.Room.LastUsedLayer;
				}
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
			}
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
			}
		}

	}
}
