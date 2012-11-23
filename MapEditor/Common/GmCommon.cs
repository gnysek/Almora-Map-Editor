using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

	public class GMItem
	{
		public bool isGroup = false;
		public bool used = false;
		public string Name = "unknown";
        public GMItemType ResourceType = GMItemType.Group;
		public List<GMItem> subitems = null;

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
	}
}
