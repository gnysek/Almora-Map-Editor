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

		private void ResourceUsage_Shown(object sender, EventArgs e)
		{
			// fill rsListView
			if (rsListView.Groups.Count == 0)
			{
				rsListView.Groups.Add("sprites", "Sprites");
				rsListView.Groups.Add("backgrounds", "Backgrounds");
				rsListView.Groups.Add("scripts", "Scripts");
				rsListView.Groups.Add("objects", "Objects");
				rsListView.Groups.Add("rooms", "Rooms");

				_addResourceItem(Manager.Project.allItems);
				Manager.Project.renderItemsTree(treeView1);
				treeView1.Nodes[0].Expand();

				rsListView.Refresh();
			}
		}

		private void _addResourceItem(GMItem item)
		{
			_addResourceItem(item.getSubitems());
		}

		private void _addResourceItem(List<GMItem> items)
		{
			foreach (GMItem item in items)
			{
				if (item.ResourceType == GMItemType.Group)
				{
					_addResourceItem(item.getSubitems());
				}
				else
				{
					ListViewItem added = rsListView.Items.Add(item.Name);

					switch (item.ResourceType)
					{
						case GMItemType.Sprite: added.Group = rsListView.Groups[0]; break;
						case GMItemType.Background: added.Group = rsListView.Groups[1]; break;
						case GMItemType.Script: added.Group = rsListView.Groups[2]; break;
						case GMItemType.Object: added.Group = rsListView.Groups[3]; break;
						case GMItemType.Room: added.Group = rsListView.Groups[4]; break;
					}
				}
			}
		}
	}
}
