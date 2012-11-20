using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MapEditor.Components;
using MapEditor.Forms;

namespace MapEditor
{
	public partial class MapEditorMain : Form
	{
		public MapEditorMain()
		{
			InitializeComponent();
		}

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutWindow form = new AboutWindow())
            {
                form.ShowDialog();
            }
        }
	}
}
