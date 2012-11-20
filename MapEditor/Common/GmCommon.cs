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
		public string Name = "unknown";
		public List<GMItem> subitems = null;

		public GMItem(string name, GMItemType type)
		{
			Name = name;
		}

		public GMItem(string name)
		{
			isGroup = true;
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
