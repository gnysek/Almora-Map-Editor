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
		public GMRoomInstance Instance;
		public InstanceProp()
		{
			InitializeComponent();
		}

		private void InstanceProp_Shown(object sender, EventArgs e)
		{
            instElement.Text = Instance.editor_data.parent.objName;
			instX.Text = Instance.x.ToString();
			instY.Text = Instance.x.ToString();
			instRotate.Text = Instance.rotation.ToString();
			instLabel.Text = "Instance: AME_" + Instance.gms_id.ToString();
		}

		private void instOK_Click(object sender, EventArgs e)
		{
			Instance.x = int.Parse(instX.Text);
			Instance.y = int.Parse(instY.Text);
			Instance.rotation = int.Parse(instRotate.Text);
		}
	}
}
