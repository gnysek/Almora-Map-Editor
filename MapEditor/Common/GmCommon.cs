using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MapEditor.Common
{
	public enum GMItemType
	{
		Group = 0,
		Sprite,
		Background,
		Script,
		Object,
		Room
	};

	public class GMSpriteData
	{
		public const string undefinedSprite = "<undefined>";
		public GMItem owner = null;
		public string firstFramePath = null;
		public int offsetX = 0;
		public int offsetY = 0;

		public string Name
		{
			get { return owner.Name; }
		}
	}

	public class GMObjectData
	{
		public GMItem owner = null;
		public GMSpriteData sprite = null;

		public string Name
		{
			get { return owner.Name; }
		}
	}

	public enum GMItemUsage
	{
		unused, used, disposed
	}

	public class GMItem
	{
		public bool isGroup = false;
		public GMItemUsage used = GMItemUsage.unused;
		public string Name = GMSpriteData.undefinedSprite;
		public GMItemType ResourceType = GMItemType.Group;
		public List<GMItem> subitems = null;
		//private GMSpriteData _spd = null;

		//public GMSpriteData SpriteData
		//{
		//    get
		//    {
		//        if (ResourceType == GMItemType.Sprite || ResourceType == GMItemType.Background)
		//        {
		//            return _spd;
		//        }
		//        return null;
		//    }
		//    set
		//    {
		//        if (ResourceType == GMItemType.Sprite || ResourceType == GMItemType.Background)
		//        {
		//            _spd = value;
		//        }
		//    }
		//}

		public GMItem(string name, GMItemType type)
		{
			Name = name;
			ResourceType = type;
		}

		public GMItem(string name, string type)
		{
			GMItemType t;
			switch (type)
			{
				case "sprites": t = GMItemType.Sprite; break;
				case "backgrounds": t = GMItemType.Background; break;
				case "scripts": t = GMItemType.Script; break;
				case "rooms": t = GMItemType.Room; break;
				case "objects": t = GMItemType.Object; break;
				default: t = GMItemType.Group; break;
			}
			Name = name;
			ResourceType = t;

			if (ResourceType == GMItemType.Sprite)
			{
				XmlDocument XMLfile = new XmlDocument();
				XMLfile.Load(Manager.Project.ProjectSource + "\\sprites\\" + Name + ".sprite.gmx");

				XmlNode node = XMLfile.SelectSingleNode("sprite/frames/frame[@index='0']");

				string fnp = "";
				if (node != null)
				{
					fnp = Manager.Project.ProjectSource + "\\sprites\\" + node.InnerText;


					Manager.Project.GMXSprites.Add(new GMSpriteData()
					{
						offsetX = int.Parse(XMLfile.SelectSingleNode("sprite/xorig").InnerText),
						offsetY = int.Parse(XMLfile.SelectSingleNode("sprite/yorigin").InnerText),
						firstFramePath = fnp,
						owner = this
					});
				}
			}

			if (ResourceType == GMItemType.Object)
			{
				XmlDocument XMLfile = new XmlDocument();
				XMLfile.Load(Manager.Project.ProjectSource + "\\objects\\" + Name + ".object.gmx");

				XmlNode node = XMLfile.SelectSingleNode("object/spriteName");

				string spriteName = "";
				if (node != null)
				{
					spriteName = node.InnerText;

					Manager.Project.GMXObjects.Add(new GMObjectData()
					{
						owner = this,
						sprite = Manager.Project.GMXSprites.Find(item => item.Name == spriteName)
					});
				}
			}
		}

		// adds group
		public GMItem(string name)
		{
			isGroup = true;
			ResourceType = GMItemType.Group;
			subitems = new List<GMItem>();
			Name = name;
		}

		public void add(GMItem item)
		{
			subitems.Add(item);
		}

		public List<GMItem> getSubitems()
		{
			if (subitems == null)
			{
				return new List<GMItem>();
			}
			else return subitems;
		}

		public GMItem Find(string name)
		{
			if (subitems == null) return null;

			GMItem found = null;

			found = subitems.Find(item => item.Name == name);

			if (found != null)
			{
				return found;
			}
			else
			{
				List<GMItem> search = subitems.FindAll(item => item.isGroup == true);
				foreach (GMItem item in search)
				{
					found = item.Find(name);
					if (found != null)
					{
						return found;
					}
				}
			}

			return null;
		}
	}
}
