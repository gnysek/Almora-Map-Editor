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
	public partial class LayerForm : Form
	{
		public MapLayers Element = null;

		public LayerForm()
		{
			InitializeComponent();
		}

		private void LayerForm_Shown(object sender, EventArgs e)
		{
			lfName.Text = Element.LayerName;
			lfDepth.Text = Element.LayerDepth.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Element.LayerName = lfName.Text;
			Element.LayerDepth = int.Parse(lfDepth.Text);
		}
	}
}
