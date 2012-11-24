﻿using System;
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
		public PlacebleElement Element = null;

		public PlaceableForm()
		{
			InitializeComponent();
		}

		private void PlaceableForm_Load(object sender, EventArgs e)
		{
			pfName.Text = Element.Name;

			pfSprite.Items.Clear();
			pfMask.Items.Clear();

			pfSprite.Items.Add("<none>");
			pfMask.Items.Add("<same as sprite>");

			foreach (string res in Manager.Project.RegisteredResources)
			{
				pfSprite.Items.Add(res);
				pfMask.Items.Add(res);
			}
			pfSprite.SelectedIndex = pfSprite.FindStringExact(Element.Sprite);
			pfMask.SelectedIndex = pfMask.FindStringExact(Element.Mask);

			pfDepth.Text = Element.Depth.ToString();
			pfShadowSize.Text = Element.ShadowSize.ToString();

			pfWind.Checked = Element.Wind;
			pfMultidraw.Checked = Element.MultiDraw;
			pfSolid.Checked = Element.Solid;
			pfShadow.Checked = Element.Shadow;

			pfShadow_CheckedChanged(null, null);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Element.Name = pfName.Text;
			Element.Sprite = pfSprite.Text;
			Element.Mask = pfMask.Text;
			Element.Depth = int.Parse(pfDepth.Text);
			Element.ShadowSize = int.Parse(pfShadowSize.Text);
			Element.Wind = (pfWind.Checked) ? true : false;
			Element.MultiDraw = (pfMultidraw.Checked) ? true : false;
			Element.Solid = (pfSolid.Checked) ? true : false;
			Element.Shadow = (pfShadow.Checked) ? true : false;
		}

		private void pfShadow_CheckedChanged(object sender, EventArgs e)
		{
			pfShadowSize.Enabled = pfShadow.Checked;
		}
	}
}