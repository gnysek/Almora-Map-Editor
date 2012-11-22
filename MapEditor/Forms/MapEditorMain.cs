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
			else
			{
				tbSaveProject.Enabled = true;
				tsEditors.Enabled = true;
			}

			_ensureMenusDisabled();
		}

		private void _ensureMenusDisabled()
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
				if (Manager.newProject(openFileDialog1.FileName))
				{
					Manager.Project.renderItemsTree(treeViewGMX);

					treeViewGMX.Nodes[0].Expand();

					ensureButtonsDisabled();
				}
			}
			//}
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
				}
			}
		}
	}
}
