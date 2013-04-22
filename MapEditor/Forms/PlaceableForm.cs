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
	public partial class PlaceableForm : Form
	{
		public PlaceableElement Element = null;

		public PlaceableForm()
		{
			InitializeComponent();
		}

		private void PlaceableForm_Load(object sender, EventArgs e)
		{
			pfName.Text = Element.Name;

			pfSprite.Items.Clear();
			pfMask.Items.Clear();

			pfSprite.Items.Add(PlaceableElement.SprDefName);
			pfMask.Items.Add(PlaceableElement.MaskDefName);

			foreach (string res in Manager.Project.RegisteredResources)
			{
				pfSprite.Items.Add(res);
				pfMask.Items.Add(res);
			}
			pfSprite.SelectedIndex = pfSprite.FindStringExact(Element.Sprite);
			if (Element.Mask == "")
			{
				pfMask.SelectedIndex = 0;
			}
			else
			{
				pfMask.SelectedIndex = pfMask.FindStringExact(Element.Mask);
			}

			pfDepth.Text = Element.Depth.ToString();
			pfShadowSize.Text = Element.ShadowSize.ToString();

			pfWind.Checked = Element.Wind;
			pfMultidraw.Checked = Element.MultiDraw;
			pfSolid.Checked = Element.Solid;
			pfShadow.Checked = Element.Shadow;
			pfVisible.Checked = Element.Visible;

			pfCode.Text = Element.addCode;

			if (pfParent.Items.Count == 0)
			{
				Manager.Project.renderObjectsTree(pfParent);
			}

			if (Element.Parent != "")
			{
				pfDefaultParent.Checked = false;
				pfParent.SelectedIndex = pfParent.Items.IndexOf(Element.Parent);
			}
			else
			{
				pfDefaultParent.Checked = true;
			}

			pfShadow_CheckedChanged(null, null);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Element.Name = pfName.Text;
			Element.Sprite = pfSprite.Text;
			Element.Mask = pfMask.Text;
			Element.Depth = int.Parse(pfDepth.Text);
			Element.ShadowSize = int.Parse(pfShadowSize.Text);
			Element.Wind = pfWind.Checked;
			Element.MultiDraw = pfMultidraw.Checked;
			Element.Solid = pfSolid.Checked;
			Element.Shadow = pfShadow.Checked;
			Element.Visible = pfVisible.Checked;
			Element.addCode = pfCode.Text;
			Element.Parent = pfParent.SelectedItem.ToString();
		}

		private void pfShadow_CheckedChanged(object sender, EventArgs e)
		{
			pfShadowSize.Enabled = pfShadow.Checked;
		}

		private void pfDefaultParent_CheckedChanged(object sender, EventArgs e)
		{
			pfParent.Enabled = !pfDefaultParent.Checked;

			if (pfDefaultParent.Checked)
			{
				pfParent.SelectedIndex = pfParent.Items.IndexOf(Manager.Project.defaultPlaceable);
			}
		}
	}
}
