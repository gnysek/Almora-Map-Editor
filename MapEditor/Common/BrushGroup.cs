using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MapEditor.Common
{
	public class BrushGroup
	{
		public string GroupName = "Default";
		public bool isDefault = false;
		public List<string> objects = new List<string>();

		public bool addObject(string name)
		{
			if (objects.IndexOf(name) == -1)
			{
				objects.Add(name);
				return true;
			}

			return false;
		}

		public void AddRange(List<string> list)
		{
			foreach (string name in list)
			{
				this.addObject(name);
			}
		}

		public XmlElement toXml(XmlDocument doc)
		{
			XmlElement self = doc.CreateElement("group");
			self.SetAttribute("name", GroupName);
			XmlElement objs = doc.CreateElement("objects");
			foreach (string obj in objects)
			{
				XmlElement current = doc.CreateElement("object");
				current.SetAttribute("name", obj);
				objs.AppendChild(current);
			}
			self.AppendChild(objs);
			return self;
		}
	}
}
