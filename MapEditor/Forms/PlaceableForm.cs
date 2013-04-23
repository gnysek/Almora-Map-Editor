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

			pfSpriteDefault.Checked = Element.useDefaultObjectSprite;
			pfMaskDefault.Checked = Element.useDefaultObjectMask;

			pfDepth.Text = Element.Depth.ToString();
			pfDepthDefault.Checked = Element.useDefaultObjectDepth;

			pfSolid.Checked = Element.Solid;
			pfSolidDefault.Checked = Element.useDefaultObjectSolid;
			pfVisible.Checked = Element.Visible;
			pfVisibleDefault.Checked = Element.useDefaultObjectVisible;

			pfWind.Checked = Element.Wind;
			pfMultidraw.Checked = Element.MultiDraw;

			pfShadow.Checked = Element.Shadow;
			pfShadowSize.Text = Element.ShadowSize.ToString();

			pfCode.Text = Element.addCode;

			if (pfParent.Items.Count == 0)
			{
				Manager.Project.renderObjectsTree(pfParent);
			}

			pfDefaultParent.Checked = Element.hasDefaultParent();
			pfParent.SelectedIndex = pfParent.Items.IndexOf(Element.Parent);

			pfShadow_CheckedChanged(null, null);
		}

		/// <summary>
		/// Submit form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pfOK_Click(object sender, EventArgs e)
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
			Element.useDefaultObjectSprite = pfSpriteDefault.Checked;
			Element.useDefaultObjectMask = pfMaskDefault.Checked;
			Element.useDefaultObjectSolid = pfSolidDefault.Checked;
			Element.useDefaultObjectDepth = pfDepthDefault.Checked;
			Element.useDefaultObjectVisible = pfVisibleDefault.Checked;
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

		private void pfDefault_CheckedChanged(object sender, EventArgs e)
		{
			pfSprite.Visible = !(sender as CheckBox).Checked;
		}

		private void pfMaskDefault_CheckedChanged(object sender, EventArgs e)
		{
			pfMask.Visible = !(sender as CheckBox).Checked;
		}

		private void pfSolidDefault_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox c = sender as CheckBox;
			if (c.Checked)
			{
				pfSolid.Checked = pfSolid.Enabled = false;
			}
			else
			{
				pfSolid.Checked = Element.Solid;
				pfSolid.Enabled = true;
			}
		}

		private void pfVisibleDefault_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox c = sender as CheckBox;
			if (c.Checked)
			{
				pfVisible.Checked = pfVisible.Enabled = false;
			}
			else
			{
				pfVisible.Checked = Element.Visible;
				pfVisible.Enabled = true;
			}
		}

		private void pfDepthDefault_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox c = sender as CheckBox;
			if (c.Checked)
			{
				pfDepth.Enabled = false;
			}
			else
			{
				pfDepth.Text = Element.Depth.ToString();
				pfDepth.Enabled = true;
			}
		}
	}
}
