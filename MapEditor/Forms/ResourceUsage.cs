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
	public partial class ResourceUsage : Form
	{
		public ResourceUsage()
		{
			InitializeComponent();
		}

		private TreeNode tempTreeNode = null;

		private void ResourceUsage_Shown(object sender, EventArgs e)
		{
			// fill rsListView
			//if (rsListView.Groups.Count == 0)
			//{
			//    rsListView.Groups.Paint("sprites", "Sprites");
			//    rsListView.Groups.Paint("backgrounds", "Backgrounds");
			//    rsListView.Groups.Paint("scripts", "Scripts");
			//    rsListView.Groups.Paint("objects", "Objects");
			//    rsListView.Groups.Paint("rooms", "Rooms");

			//    _addResourceItem(Manager.Project.allItems);
			if (treeView1.Nodes.Count == 0)
			{
				Manager.Project.renderItemsTree(treeView1, true);
			}
			//    treeView1.Nodes[0].Expand();

			//    rsListView.Refresh();
			//}
		}

		//private void _addResourceItem(GMItem item)
		//{
		//    _addResourceItem(item.getSubitems());
		//}

		//private void _addResourceItem(List<GMItem> items)
		//{
		//    foreach (GMItem item in items)
		//    {
		//        if (item.ResourceType == GMItemType.Group)
		//        {
		//            _addResourceItem(item.getSubitems());
		//        }
		//        else
		//        {
		//            ListViewItem added = rsListView.Items.Paint(item.Name);

		//            switch (item.ResourceType)
		//            {
		//                case GMItemType.Sprite: added.Group = rsListView.Groups[0]; break;
		//                case GMItemType.Background: added.Group = rsListView.Groups[1]; break;
		//                case GMItemType.Script: added.Group = rsListView.Groups[2]; break;
		//                case GMItemType.Object: added.Group = rsListView.Groups[3]; break;
		//                case GMItemType.Room: added.Group = rsListView.Groups[4]; break;
		//            }
		//        }
		//    }
		//}

		private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (tempTreeNode == null)
			{
				tempTreeNode = e.Node;
				CheckTreeViewNode(e.Node, e.Node.Checked);
				if (e.Node.Checked == false)
				{
					CheckTreeViewNodeParent(e.Node);
				}
				tempTreeNode = null;
			}
		}

		private void CheckTreeViewNodeParent(TreeNode node)
		{
			if (node.Parent != null && node.Checked == false)
			{
				node.Parent.Checked = false;
				CheckTreeViewNodeParent(node.Parent);
			}
		}

		private void CheckTreeViewNode(TreeNode node, Boolean isChecked)
		{
			foreach (TreeNode item in node.Nodes)
			{
				item.Checked = isChecked;

				if (item.Nodes.Count > 0)
				{
					this.CheckTreeViewNode(item, isChecked);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Manager.Project.resetUsedRes();

			string[] nodes = { "sprites", "backgrounds", "scripts", "objects", "rooms" };
			foreach (string node in nodes)
			{
				if (treeView1.Nodes[0].Nodes[node].Nodes != null)
				{
					_checkForChecked(treeView1.Nodes[0].Nodes[node]);
				}
			}
		}

		private void _checkForChecked(TreeNode MainNode)
		{
			foreach (TreeNode node in MainNode.Nodes)
			{
				if (node.Nodes.Count > 0)
				{
					_checkForChecked(node);
				}
				else if (node.Checked)
				{
					Manager.Project.addUsedRes(node.Text);
				}
			}
		}
	}
}
