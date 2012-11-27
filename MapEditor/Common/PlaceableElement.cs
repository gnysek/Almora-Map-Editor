using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MapEditor.Common
{
	public class PlacebleElement
	{
		public const string SprDefName = "<no sprite>";
		public const string MaskDefName = "<same as sprite>";
		private string _name = "undefied";
		private string _sprite = "";
		private string _mask = "";
		private int _depth = 0;
		private int _shadowSize = 0;
		private bool _solid = false;
		private bool _wind = false;
		private bool _multi = false;
		private bool _shadow = false;

		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		public string Sprite
		{
			get { return this._sprite; }
			set { this._sprite = value; }
		}

		public string Mask
		{
			get { return this._mask; }
			set { this._mask = value; }
		}

		public int Depth
		{
			get { return this._depth; }
			set { this._depth = value; }
		}

		public int ShadowSize
		{
			get { return this._shadowSize; }
			set { this._shadowSize = value; }
		}

		public bool Solid
		{
			get { return this._solid; }
			set { this._solid = value; }
		}
		public bool Wind
		{
			get { return this._wind; }
			set { this._wind = value; }
		}
		public bool MultiDraw
		{
			get { return this._multi; }
			set { this._multi = value; }
		}
		public bool Shadow
		{
			get { return this._shadow; }
			set { this._shadow = value; }
		}

		public XmlElement toXml(XmlDocument doc)
		{
			XmlElement self = doc.CreateElement("placeable");

			XmlElement sprite = doc.CreateElement("sprite");
			sprite.InnerText = Sprite;

			XmlElement mask = doc.CreateElement("mask");
			mask.InnerText = Mask;

			XmlElement depth = doc.CreateElement("depth");
			depth.InnerText = Depth.ToString();

			XmlElement ss = doc.CreateElement("shadowsize");
			ss.InnerText = ShadowSize.ToString();

			XmlElement solid = doc.CreateElement("solid");
			solid.InnerText = (Solid) ? "1" : "0";

			XmlElement wind = doc.CreateElement("wind");
			wind.InnerText = (Wind) ? "1" : "0";

			XmlElement multidraw = doc.CreateElement("multidraw");
			multidraw.InnerText = (MultiDraw) ? "1" : "0";

			XmlElement shadow = doc.CreateElement("shadow");
			shadow.InnerText = (Shadow) ? "1" : "0";

			self.AppendChild(sprite);
			self.AppendChild(mask);
			self.AppendChild(depth);
			self.AppendChild(ss);
			self.AppendChild(solid);
			self.AppendChild(wind);
			self.AppendChild(multidraw);
			self.AppendChild(shadow);
			self.SetAttribute("name", Name);

			return self;
		}
	}
}
