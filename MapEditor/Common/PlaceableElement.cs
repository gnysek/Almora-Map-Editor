using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MapEditor.Common
{
    public class SpriteTextureContainer
    {
        public string name = GMSpriteData.undefinedSprite;
        private GMSpriteData _spriteData;
        public string textureId;
        public GMObjectData gmobject = null;

        public string Sprite
        {
            get { return (this._spriteData == null) ? GMSpriteData.undefinedSprite : this._spriteData.Name; }
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
    }


	public class PlaceableElement
	{
		public const string SprDefName = GMSpriteData.undefinedSprite;
		//public const string MaskDefName = "<same as sprite>";
		
		private GMSpriteData _spriteData = null;
		//public bool useDefaultObjectSprite = true;
		//private string _mask = "";
		//public bool useDefaultObjectMask = true;
		private string _parent = "";

		public string Name = "undefined";
		//public bool Visible = true;
		//public bool useDefaultObjectVisible = true;
		//public bool Solid = false;
		//public bool useDefaultObjectSolid = true;
		//public int Depth = 0;
		//public bool useDefaultObjectDepth = true;

		//public bool Wind = false;
		//public bool MultiDraw = false;
		//public bool Shadow = false;
		//public int ShadowSize = 0;
		
		public string textureId = null;
		//public string addCode = "";

		public GMObjectData gmobject = null;

		public string Parent
		{
			get { return (this._parent == "") ? Manager.Project.defaultPlaceable : this._parent; }
			// TODO: when defPlac changed, set again
			set { this._parent = (value == Manager.Project.defaultPlaceable) ? "" : value; }
		}

		public bool hasDefaultParent()
		{
			return (this._parent == "");
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

		/*public string Mask
		{
			get { return (this._mask == PlaceableElement.MaskDefName) ? "" : this._mask; }
			set { this._mask = (value == PlaceableElement.MaskDefName) ? "" : value; }
		}*/

		private XmlElement createChild(XmlDocument doc, string name, string value) {
			XmlElement e = doc.CreateElement(name);
			e.InnerText = value;
			return e;
		}

		private XmlElement createChild(XmlDocument doc, string name, bool value)
		{
			return createChild(doc, name, (value) ? "1" : "0");
		}

		public XmlElement toXml(XmlDocument doc)
		{
			XmlElement self = doc.CreateElement("placeable");

			XmlElement sprite = doc.CreateElement("sprite");
			sprite.InnerText = Sprite;

			//XmlElement sprDef = doc.CreateElement("defsprite");
			//sprDef.InnerText = (useDefaultObjectSprite) ? "1" : "0";

			//XmlElement mask = doc.CreateElement("mask");
			//mask.InnerText = Mask;

			//XmlElement maskDef = doc.CreateElement("defmask");
			//maskDef.InnerText = (useDefaultObjectSprite) ? "1" : "0";

			//XmlElement depth = doc.CreateElement("depth");
			//depth.InnerText = Depth.ToString();

			//XmlElement ss = doc.CreateElement("shadowsize");
			//ss.InnerText = ShadowSize.ToString();

			//XmlElement solid = doc.CreateElement("solid");
			//solid.InnerText = (Solid) ? "1" : "0";

			//XmlElement wind = doc.CreateElement("wind");
			//wind.InnerText = (Wind) ? "1" : "0";

			//XmlElement multidraw = doc.CreateElement("multidraw");
			//multidraw.InnerText = (MultiDraw) ? "1" : "0";

			//XmlElement shadow = doc.CreateElement("shadow");
			//shadow.InnerText = (Shadow) ? "1" : "0";

			//XmlElement visible = doc.CreateElement("visible");
			//visible.InnerText = (Visible) ? "1" : "0";

			XmlElement parent = doc.CreateElement("parent");
			parent.InnerText = (hasDefaultParent()) ? "" : Parent;

			self.AppendChild(sprite);
			//self.AppendChild(createChild(doc, "defsprite", useDefaultObjectSprite));
			//self.AppendChild(mask);
			//self.AppendChild(createChild(doc, "defmask", useDefaultObjectMask));
			//self.AppendChild(depth);
			//self.AppendChild(createChild(doc, "defdepth", useDefaultObjectDepth));
			//self.AppendChild(ss);
			//self.AppendChild(solid);
			//self.AppendChild(createChild(doc, "defsolid", useDefaultObjectSolid));
			//self.AppendChild(wind);
			//self.AppendChild(multidraw);
			//self.AppendChild(shadow);
			//self.AppendChild(visible);
			//self.AppendChild(createChild(doc, "defvisible", useDefaultObjectVisible));
			self.AppendChild(parent);
			self.SetAttribute("name", Name);

			return self;
		}
	}
}
