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

		public static bool newProject(string filename)
		{
			return loadProject(filename, false);
		}

		public static bool loadProject(string filename)
		{
			return loadProject(filename, true);
		}

		public static bool dropProject() {
			Project = null;
			return true;
		}

		public static bool loadProject(string filename, bool load)
		{
			if (Project != null)
			{
				MessageBox.Show("Please close your project first!");
				return false;
			}

			Project = new ProjectData(filename, load);
			return true;
		}

	}
}
