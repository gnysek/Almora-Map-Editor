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
			}
			else
			{
				tbSaveProject.Enabled = true;
				tsEditors.Enabled = true;
				tsOptions.Enabled = true;
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
					elem = new MapRoom() { Name = defName, Width = 1024, Height = 768 };
					form.Element = elem;
					form.Text = "Add new Room Definition: " + defName;
				}

				if (form.ShowDialog() == DialogResult.OK)
				{
					if (edit)
					{
						elem = form.Element;
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
			string defName = "Undefined Room " + lbPlaceables.Items.Count.ToString();
			using (PlaceableForm form = new PlaceableForm())
			{
				PlacebleElement elem;
				if (edit)
				{
					elem = Manager.Project.PlaceableList[lbPlaceables.SelectedIndex];
					form.Element = elem;
					form.Text = "Edit Placeable Definition: " + defName;
				}
				else
				{
					elem = new PlacebleElement() { Name = defName };
					form.Element = elem;
					form.Text = "Add new Placeable Definition: " + defName;
				}

				if (form.ShowDialog() == DialogResult.OK)
				{
					if (edit)
					{
						elem = form.Element;
					}
					else
					{
						Manager.Project.PlaceableList.Add(form.Element);
					}
					Manager.Project.regenerateEnvDefList();
				}
			}
		}

		private void tbAddItem_Click(object sender, EventArgs e)
		{
			if (tabControlMain.SelectedTab == tabRooms)
			{
				addOrEditRoom(false);
			}
			else if (tabControlMain.SelectedTab == tabPlaceables && tabControlEnv.SelectedIndex == 0)
			{
				addOrEditPlaceable(false);
			}
		}

		private void lbPlaceables_DoubleClick(object sender, EventArgs e)
		{
			//if (lbPlaceables.SelectedIndex > -1 && lbPlaceables.SelectedIndex < lbPlaceables.Items.Count)
			//{
			addOrEditPlaceable(true);
			//}
		}

		private void tbEditItem_Click(object sender, EventArgs e)
		{
			switch (tabControlMain.SelectedTab.Text)
			{
				case "Placeables": addOrEditPlaceable(true); break;
				case "Rooms": addOrEditRoom(true); break;
			}
		}

		private void lbRooms_DoubleClick(object sender, EventArgs e)
		{
			if (lbRooms.SelectedIndex > -1)
			{
				if (Manager.Room != null)
				{
					if (MessageBox.Show("Do you want to close current room?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.OK)
					{
						return;
					}
				}

				Manager.Project.Room = Manager.Project.RoomList[lbRooms.SelectedIndex];
				roomEditor1.Invalidate();
			}
		}


	}
}
