using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MapEditor.Common
{
	public static class Manager
	{
		public static ProjectData Project = null;
		public static MapEditorMain MainWindow = null;

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

		public static bool dropProject()
		{
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

			/*Project =*/
			new ProjectData(filename, load);
			return true;
		}

		public static MapRoom Room
		{
			get { return (Project == null) ? null : Project.Room; }
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
		private static extern Int32 SendMessage(IntPtr hwnd, Int32 wMsg, Int32 wParam, Int32 lParam);
		const int LVM_FIRST = 0x1000;
		const int LVM_SETICONSPACING = LVM_FIRST + 53;

		public static void SetSpacing(ListView listView, Int16 x, Int16 y)
		{
			SendMessage(listView.Handle, LVM_SETICONSPACING, 0, x * 65536 + y);
			listView.Refresh();
		}


	}
}
