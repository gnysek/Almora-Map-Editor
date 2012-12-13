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
	public partial class RoomForm : Form
	{
		public MapRoom Element;

		public RoomForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Element.Width = int.Parse(rfWidth.Text);
			Element.Height = int.Parse(rfHeight.Text);
			Element.LinkedWith = rfMapped.Text;
		}

		private void RoomForm_Load(object sender, EventArgs e)
		{
			rfWidth.Text = Element.Width.ToString();
			rfHeight.Text = Element.Height.ToString();
			rfMapped.Items.Clear();

			rfMappedRender(Manager.Project.allItems.subitems);
		}

		private void rfMappedRender(List<GMItem> items)
		{
			foreach (GMItem item in items)
			{
				if (item.isGroup)
				{
					rfMappedRender(item.subitems);
				}
				else if (item.ResourceType == GMItemType.Room)
				{
					rfMapped.Items.Add(item.Name);
					if (item.Name == Element.LinkedWith)
					{
						rfMapped.SelectedItem = rfMapped.Items.Count - 1;
					}
				}
			}
		}

		private void RoomForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (rfMapped.SelectedIndex == -1)
			{
				e.Cancel = true;
				return;
			}
		}
	}
}
