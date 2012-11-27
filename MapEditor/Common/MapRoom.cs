using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MapEditor.Common
{
	public class MapRoom
	{
		public string Name;
		public int Width;
		public int Height;
		private int _instanceCount;

		public int InstanceCount
		{
			get { return _instanceCount; }
		}

		public XmlElement toXml(XmlDocument doc)
		{
			XmlElement self = doc.CreateElement("room");
			self.SetAttribute("name", Name);
			self.SetAttribute("width", Width.ToString());
			self.SetAttribute("height", Height.ToString());
			return self;
		}
	}
}
