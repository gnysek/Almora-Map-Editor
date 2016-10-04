using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapEditor.Common;

namespace MapEditor.Forms
{
	public partial class BrushGroups : Form
	{
		public string lastGroup = "";
		public BrushGroup currentGroup = null;

		public BrushGroups()
		{
			InitializeComponent();

			Manager.SetSpacing(objectList, 48, 48);

			brushGroupsObjectTree.ImageList = Manager.MainWindow.imageListFolders;
			objectList.SmallImageList = objectList.LargeImageList = Manager.MainWindow.imageListObjects;
			Manager.Project.renderItemsTree(brushGroupsObjectTree, "objects");
			brushGroupsObjectTree.Nodes[0].ExpandAll();
			//brushGroupsObjectTree.Nodes[0].Nodes[0].Expand();

			/*groupList.Focus();
			groupList.Items[0].Selected = true;
			groupList_DoubleClick(groupList, new EventArgs());*/

			currentGroup = Manager.Project.BrushGroups[0];

			renderLayerList();
		}

		protected void ensureButtonsVisible()
		{
			bool groupSelected = currentGroup != null;

			objectList.Enabled = objectRemove.Enabled = groupSelected;

			groupRemove.Enabled = groupEdit.Enabled = groupUp.Enabled = groupDown.Enabled = groupSelected;

			if (groupSelected)
			{
				groupRemove.Enabled = currentGroup.isDefault == false;
			}
		}

		protected void renderLayerList()
		{
			groupList.Items.Clear();
			foreach (BrushGroup gr in Manager.Project.BrushGroups)
			{
				ListViewItem item = new ListViewItem()
				{
					Name = gr.GroupName,
					Text = gr.GroupName,
				};

				item.SubItems.Add(gr.objects.Count.ToString());
				groupList.Items.Add(item);
			}

			renderObjectList();
			ensureButtonsVisible();
		}

		protected void renderObjectList()
		{
			objectList.Items.Clear();

			if (currentGroup == null) return;

            foreach (GmsObject obj in Manager.Project.GmsResourceObjectList)
            {
                objectList.Items.Add(new ListViewItem() { Text = obj.name, ImageKey = (obj.sprite_index == null) ? GmsResource.undefined : obj.sprite_index.name });
            }

            //foreach (string name in currentGroup.objects)
            //{
            //    GMSpriteData sprite = Manager.Project.GMXObjects.Find(item => item.Name == name).sprite;
            //    objectList.Items.Add(new ListViewItem() { Text = name, ImageKey = (sprite == null) ? GmsResource.undefined : sprite.Name });
            //}
		}

		private void brushGroupsObjectTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (currentGroup != null)
			{
				TreeView node = sender as TreeView;

				if (node.SelectedNode.Nodes.Count == 0)
				{
					int count = currentGroup.objects.Count;

					currentGroup.addObject(node.SelectedNode.Text);

					if (currentGroup.objects.Count != count)
					{
						renderLayerList();
						renderObjectList();
					}
				}

			}

			ensureButtonsVisible();
		}

		private void groupList_DoubleClick(object sender, EventArgs e)
		{
			if (groupList.SelectedItems.Count > 0)
			{
				BrushGroup toSwitch = Manager.Project.BrushGroups[groupList.SelectedItems[0].Index];
				if (toSwitch != currentGroup)
				{
					currentGroup = toSwitch;
				}
			}

			renderObjectList();
			ensureButtonsVisible();
		}

		private void objectList_DoubleClick(object sender, EventArgs e)
		{
			if (currentGroup != null && objectList.SelectedItems.Count == 1)
			{
				currentGroup.objects.Remove(objectList.SelectedItems[0].Text);
				objectList.SelectedItems[0].Remove();
			}
		}

		private void groupAdd_Click(object sender, EventArgs e)
		{
			string name = Prompt.ShowDialog("New group name", "Group " + (groupList.Items.Count + 1).ToString());
			if (name != null)
			{
				if (!groupList.Items.ContainsKey(name))
				{
					Manager.Project.BrushGroups.Add(new BrushGroup() { GroupName = name });
					renderLayerList();
				}
				else
				{
					MessageBox.Show("Group " + name + " already exists.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
}
