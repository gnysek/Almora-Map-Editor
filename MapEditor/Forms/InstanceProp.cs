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
		public PlaceableInstance Instance;
		public InstanceProp()
		{
			InitializeComponent();
		}

		private void InstanceProp_Shown(object sender, EventArgs e)
		{
			instElement.Text = Instance.Element.Name;
			instX.Text = Instance.X.ToString();
			instY.Text = Instance.Y.ToString();
			instRotate.Text = Instance.Rotation.ToString();
			instLabel.Text = "Instance: AME_" + Instance.ID.ToString();
		}

		private void instOK_Click(object sender, EventArgs e)
		{
			Instance.X = int.Parse(instX.Text);
			Instance.Y = int.Parse(instY.Text);
			Instance.Rotation = int.Parse(instRotate.Text);
		}
	}
}
