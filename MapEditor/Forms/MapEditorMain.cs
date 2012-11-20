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

namespace MapEditor
{
	public partial class MapEditorMain : Form
	{
		public MapEditorMain()
		{
			InitializeComponent();
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
			}

			ensureMenusDisabled();
		}

		public void ensureMenusDisabled()
		{
			tmSaveProject.Enabled = tbSaveProject.Enabled;
			tmSaveProjectAs.Enabled = false;
			tmEdit.Enabled = (Manager.Project != null);
		}

		private void tbNewProject_Click(object sender, EventArgs e)
		{
			//if (MessageBox.Show("Are you sure to create new project?\nThis will save some additional *.ame files inside your project directory. This shouldn't affect your GM:S project, but remember - we take no responsibility for any damage caused!", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			//    == DialogResult.Yes)
			//{
			// ok, create new project
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				Manager.newProject(openFileDialog1.FileName);

				treeViewGMX.Nodes.Clear();
				TreeNode NodGM = treeViewGMX.Nodes.Add("NodeGM", "Project: " + Manager.Project.gmxFilename);
				treeViewGMX.Nodes.Add("NodeInternal","Internal Files");

				TreeNode t = treeViewGMX.Nodes["NodeGM"].Nodes.Add(Manager.Project.allItems.Name);
				treeViewGMX.ExpandAll();

				_treeAddGMItemGroup(t, Manager.Project.allItems.getSubitems());

				//treeViewGMX.ExpandAll();
			}
			//}
		}

		private void _treeAddGMItemGroup(TreeNode t, List<GMItem> items)
		{
			foreach (GMItem item in items)
			{
				TreeNode newT = t.Nodes.Add(item.Name);
				if (item.isGroup)
				{
					newT.ImageIndex = 0;
					newT.SelectedImageIndex = 1;
					//newT.StateImageIndex = 2;
					_treeAddGMItemGroup(newT, item.getSubitems());
				}
				else
				{
					newT.ImageIndex = 3;
					newT.SelectedImageIndex = newT.ImageIndex;
				}
			}
		}

		private void MapEditorMain_Load(object sender, EventArgs e)
		{
			ensureButtonsDisabled();
		}
	}
}
