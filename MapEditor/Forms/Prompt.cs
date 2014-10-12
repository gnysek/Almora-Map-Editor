using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapEditor.Forms
{
	public partial class Prompt : Form
	{
		public Prompt()
		{
			InitializeComponent();
		}

		public static string ShowDialog(string pdesc, string pvalue)
		{
			Prompt prompt = new Prompt();
			prompt.description.Text = pdesc;
			prompt.value.Text = pvalue;
			prompt.Text = pdesc;
			prompt.value.Focus();

			DialogResult res = prompt.ShowDialog();
			if (res == DialogResult.OK)
			{
				return prompt.value.Text;
			}

			return null;
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
