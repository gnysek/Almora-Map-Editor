using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace MapEditor.Common
{
	public class ProjectData
	{
		public string gmxFilename = "";
		public string Src = "";
		public bool Saved = false;
		public bool Loaded = false;

		public EnvElement[] EnvElementsList = null;
		public EventElement[] EventElementsList = null;
		public EnvInstance[] EnvInstancesList = null;
		public EventInstance[] EventInstancesList = null;
		public GMItem allItems = null;

		public ProjectData(string srcPath)
		{
			Src = srcPath;
			gmxFilename = Path.GetFileName(srcPath);
			_readGMX();
		}

		private void _readGMX()
		{
			XmlDocument XMLfile = new XmlDocument();
			XMLfile.Load(Src);

			string nodeElementsName;
			XmlNode root;
			allItems = new GMItem(Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(gmxFilename)));
			string[] resTree = new string[] { "sprites", "backgrounds", "scripts", "objects", "rooms" };


			foreach (string nodeName in resTree)
			{
				try
				{
					root = XMLfile.SelectSingleNode("assets/" + nodeName);

					if (root == null)
					{
						return;
					}

					nodeElementsName = root.Attributes["name"].InnerText;

					//TreeNode main = treeViewGMX.Nodes.Add(fup(nodeElementsName), fup(nodeElementsName));

					GMItem main = new GMItem(nodeElementsName);
					allItems.add(main);

					_readSubNode(root, nodeName, nodeElementsName, main);
				}
				catch (Exception e)
				{
					MessageBox.Show(nodeName + ": " + e.Message);
				}
			}
		}

		private void _readSubNode(XmlNode node, string nodeName, string nodeElementsName, GMItem main)
		{
			foreach (XmlNode n in node)
			{
				if (n.Attributes["name"] != null)
				{
					//TreeNode sub = main.Nodes.Add(n.Attributes["name"].InnerText);
					GMItem sub = new GMItem(n.Attributes["name"].InnerText);
					_readSubNode(n, nodeName, nodeElementsName, sub);
					main.add(sub);
				}
				else
				{
					//TreeNode sub = main.Nodes.Add(n.InnerText, Path.GetFileName(n.InnerText));
					//sub.ImageIndex = sub.SelectedImageIndex = 1;
					//sub.ContextMenuStrip = contextMenuStrip2;
					string name = (nodeName == "scripts") ? /*n.InnerText*/ Path.GetFileName(n.InnerText) /*+ ".gml"*/ : Path.GetFileName(n.InnerText)/*n.InnerText + "." + n.Name + ".gmx"*/;
					GMItem sub = new GMItem(name, GMItemType.Object);
					main.add(sub);
				}
			}
		}
	}
}
