using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapEditor.Graphics;

namespace MapEditor.Forms
{
	public partial class Textures : Form
	{
		public Textures()
		{
			InitializeComponent();

			listBox1.Items.Clear();
			foreach (KeyValuePair<string, ResTexture> pair in GraphicsManager.Sprites)
			{
				listBox1.Items.Add(pair.Key);
			}
		}
	}
}
