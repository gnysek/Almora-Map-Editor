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
			Element.Name = rfName.Text;
			Element.Width = int.Parse(rfWidth.Text);
			Element.Height = int.Parse(rfHeight.Text);
		}

		private void RoomForm_Load(object sender, EventArgs e)
		{
			rfName.Text = Element.Name;
			rfWidth.Text = Element.Width.ToString();
			rfHeight.Text = Element.Height.ToString();
		}
	}
}
