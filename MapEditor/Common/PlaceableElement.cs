using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MapEditor.Common
{
	public class PlaceableElement
	{
		public const string SprDefName = "<no sprite>";
		public const string MaskDefName = "<same as sprite>";
		private string _name = "undefined";
		//private string _sprite = "";
		private GMSpriteData _spriteData = null;
		private string _mask = "";
		private int _depth = 0;
		private int _shadowSize = 0;
		private bool _solid = false;
		private bool _wind = false;
		private bool _multi = false;
		private bool _shadow = false;
		public int textureId = -1;
		public string addCode = "";
		private bool _visible = true;

		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		public string Sprite
		{
			// TODO: remove ""
			get { return (this._spriteData == null) ? "" : this._spriteData.Name; }
			set { _spriteData = Manager.Project.GMXSprites.Find(item => item.Name == value); }
		}

		public int offsetX
		{
			get { return (_spriteData == null) ? 0 : this._spriteData.offsetX; }
		}

		public int offsetY
		{
			get { return (_spriteData == null) ? 0 : this._spriteData.offsetY; }
		}

		public string Mask
		{
			get { return (this._mask == PlaceableElement.MaskDefName) ? "" : this._mask; }
			set { this._mask = (value == PlaceableElement.MaskDefName) ? "" : value; }
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

		public bool Visible
		{
			get { return this._visible; }
			set { this._visible = value; }
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

			XmlElement visible = doc.CreateElement("visible");
			visible.InnerText = (Visible) ? "1" : "0";

			self.AppendChild(sprite);
			self.AppendChild(mask);
			self.AppendChild(depth);
			self.AppendChild(ss);
			self.AppendChild(solid);
			self.AppendChild(wind);
			self.AppendChild(multidraw);
			self.AppendChild(shadow);
			self.AppendChild(visible);
			self.SetAttribute("name", Name);

			return self;
		}
	}
}
