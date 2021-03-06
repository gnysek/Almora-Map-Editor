﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace MapEditor.Common
{
	public class MapLayers
	{
		public string LayerName = "Unknown";
		public int LayerDepth = -1;
		public bool Active = true;

		public static int SortByLayerDepth(MapLayers a, MapLayers b)
		{
			if (a == null)
			{
				if (b == null)
				{
					return 0; //equal
				}
				else
				{
					return 1; //a is less, b is greater
				}
			}
			else
			{
				if (b == null)
				{
					return -1; //a is greater
				}
				else
				{
					if (a.LayerDepth == b.LayerDepth) return 0;
					return (a.LayerDepth > b.LayerDepth) ? -1 : 1;
				}
			}
		}
	}

	public class MapRoom
	{
		public int Width;
		public int Height;
        //public List<PlaceableInstance> Instances = new List<PlaceableInstance>();
		public string LinkedWith = null;
		//public List<MapLayers> Layers = new List<MapLayers>();
		public int LastUsedLayer = -1;
		public int InternalCounter = 0;

		public MapLayers ActiveLayer
		{
			get { return null; }
		}

		public ObservableCollection<MapLayers> Layers
		{
			get { return Manager.Project.RoomLayers; }
		}

		public int InstanceCount
		{
            get { return 0; }// Instances.Count; }
		}

        //public void addInstance(PlaceableInstance instance)
        //{
        //    Instances.Add(instance);
        //    if (instance.ID == -1)
        //    {
        //        InternalCounter++;
        //        instance.ID = InternalCounter;
        //    }
        //    else if (InternalCounter < instance.ID)
        //    {
        //        InternalCounter = instance.ID;
        //    }
        //}

		public XmlElement toXml(XmlDocument doc)
		{
			XmlElement self = doc.CreateElement("room");
			self.SetAttribute("width", Width.ToString());
			self.SetAttribute("height", Height.ToString());
			self.SetAttribute("linked", LinkedWith);
			self.SetAttribute("layers", Layers.Count.ToString());
			self.SetAttribute("lastLayer", LastUsedLayer.ToString());
			self.SetAttribute("internalCounter", InternalCounter.ToString());
			return self;
		}

		public void saveRoomInstancesToGMX()
		{
			string path = Manager.Project.ProjectSource + "\\rooms\\" + LinkedWith + ".room.gmx";

			XmlDocument file = new XmlDocument();
			file.Load(path);

			// remove old items

			XmlNodeList nodes = file.GetElementsByTagName("instance");

			for (int i = 0; i < nodes.Count; i++)
			{
				if (nodes[i].Attributes["name"].Value.Contains("inst_AME"))
				{
					nodes[i].ParentNode.RemoveChild(nodes[i]);
					i--; // to prevent skipping items (next one iteration becames current one)
				}
			}

			// now add new things

			XmlNode node = file.SelectSingleNode("room/instances");

			int counter = 0;
			/*foreach (PlaceableInstance place in Instances)
			{
				string code = "";
				//if (place.Element.useDefaultObjectSprite == false) code += "sprite_index = " + place.Element.Sprite + ";";
				//if (place.Element.useDefaultObjectDepth == false) code += " depth = " + place.Element.Depth.ToString() + ";";
				//if (place.Element.Solid && place.Element.useDefaultObjectSolid == false) code += " solid = true;";
				//if (place.Element.Shadow) code += " drop_shadow = true; shadow = " + place.Element.ShadowSize.ToString() + ";";
				//if (place.Element.MultiDraw) code += " multi_draw = true;";
				//if (place.Element.Wind) code += " wind = true; scEnvWindSet();";
				//if (place.Element.Visible == false && place.Element.useDefaultObjectVisible == false) code += " visible = false;";
				//if (place.Element.useDefaultObjectMask == false) code += " mask_index = " + ((place.Element.Mask == "") ? place.Element.Sprite : place.Element.Mask) + ";";

				XmlElement elem = file.CreateElement("instance");
				elem.SetAttribute("objName", place.Element.Name); // returns default or overriden
				elem.SetAttribute("x", place.X.ToString());
				elem.SetAttribute("y", place.Y.ToString());
				elem.SetAttribute("name", "inst_AME" + counter.ToString("X"));
				elem.SetAttribute("locked", "1");
				elem.SetAttribute("code", code);
				elem.SetAttribute("scaleX", "1");
				elem.SetAttribute("scaleY", "1");
				elem.SetAttribute("colour", "4294967295");
				elem.SetAttribute("rotation", place.Rotation.ToString());

				node.AppendChild(elem);

				counter++;
			}*/

			file.Save(path);
		}

		public void saveRoomInstancesToXml()
		{
			string path = Manager.Project.ProjectSource + "\\amedata";

			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			// wtf? it saves every room from every room? should be removed :/
			//foreach (MapRoom room in Manager.Project.RoomList)
			//{
			XmlDocument file = new XmlDocument();

			XmlComment comment = file.CreateComment("This Document is generated by Awesome Map Editor, if you edit it by hand then you do so at your own risk!");
			XmlElement assets = file.CreateElement("assets");

			XmlElement instances = file.CreateElement("instances");
			//int counter = 0;
            //foreach (PlaceableInstance place in /*room.*/Instances)
            //{
            //    XmlElement elem = file.CreateElement("instance");
            //    elem.SetAttribute("name", place.Element.Name);
            //    elem.SetAttribute("object", place.Element.Name);
            //    elem.SetAttribute("x", place.X.ToString());
            //    elem.SetAttribute("y", place.Y.ToString());
            //    //elem.SetAttribute("sprite", place.Element.Sprite);
            //    elem.SetAttribute("id", place.ID.ToString());
            //    elem.SetAttribute("rotate", place.Rotation.ToString());
            //    try
            //    {
            //        elem.SetAttribute("layer", place.Layer.ToString());
            //    }
            //    catch
            //    {
            //        elem.SetAttribute("layer", "-1");
            //    }
            //    instances.AppendChild(elem);
            //}
			assets.AppendChild(instances);

			/*XmlElement layers = file.CreateElement("layers");
			foreach (MapLayers layer in Layers)
			{
				XmlElement elem = file.CreateElement("layer");
				elem.SetAttribute("name", layer.LayerName);
				elem.SetAttribute("depth", layer.LayerDepth.ToString());
				layers.AppendChild(elem);
			}
			assets.AppendChild(layers);*/

			// everything added to asseds, now compile rest of file

			file.AppendChild(comment);
			file.AppendChild(assets);

			file.Save(path + "\\" + /*room.*/LinkedWith + ".room.ame");
			/*room.*/
			saveRoomInstancesToGMX();
			//}
		}
	}
}
