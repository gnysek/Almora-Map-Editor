using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapEditor.Common
{
	public static class Manager
	{
		public static ProjectData Project = null;

		public static void saveProject()
		{
			if (Project == null)
			{
				MessageBox.Show("ProjectData isn't loaded yet");
				return;
			}

			//XMLFormatter xml = new XMLFormatter();
		}

		public static void newProject(string filename)
		{
			if (Project != null)
			{
				MessageBox.Show("Please close your project first!");
				return;
			}

			Project = new ProjectData(filename);
		}
	}
}
