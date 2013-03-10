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
	public partial class InstanceProp : Form
	{
		public PlaceableInstance Element;
		public InstanceProp()
		{
			InitializeComponent();
		}

		private void InstanceProp_Shown(object sender, EventArgs e)
		{
			instX.Text = Element.X.ToString();
			instY.Text = Element.Y.ToString();
			instRotate.Text = Element.Rotation.ToString();
			instLabel.Text = "Element: AME_" + Element.ID.ToString();
		}

		private void instOK_Click(object sender, EventArgs e)
		{
			Element.X = int.Parse(instX.Text);
			Element.Y = int.Parse(instY.Text);
			Element.Rotation = int.Parse(instRotate.Text);
		}
	}
}
