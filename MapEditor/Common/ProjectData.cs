﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;
using MapEditor.Components;
using MapEditor.Graphics;
using System.Drawing;
using MapEditor.Forms;
using System.Collections.ObjectModel;

namespace MapEditor.Common
{
	public class ProjectData
	{
		public string ProjectFilename = "";
		public string GmxFilename = "";
		public string ProjectSource = "";
		public bool Saved = false;
		public bool Loaded = false;
		private MapRoom _Room = null;
		private PlaceableElement _Instance = null;
		private PlaceableInstance _HighlightedInstance = null;
		private PlaceableInstance _SelectedInstance = null;
		public List<PlaceableElement> PlaceableList = new List<PlaceableElement>();
		//public List<PlaceableInstance> PlacedInstances = new List<PlaceableInstance>();
		public List<MapRoom> RoomList = new List<MapRoom>();
		//public List<string> RegisteredResources = new List<string>();
		public List<GMSpriteData> GMXSprites = new List<GMSpriteData>();
		public List<GMObjectData> GMXObjects = new List<GMObjectData>();
		//public List<string> GMObjects = new List<string>();
		public ObservableCollection<BrushGroup> BrushGroups = new ObservableCollection<BrushGroup>();
		public ObservableCollection<MapLayers> RoomLayers = new ObservableCollection<MapLayers>();
		public GMItem allItems = null;
		public string defaultPlaceable = "oEnvMain";

		#region Magical Properties

		public MapRoom Room
		{
			get { return _Room; }
			set
			{
				_Room = value;
				if (PlaceableList.Count > 0)
				{
					Instance = PlaceableList[0];
				}
				regenerateLayerList();
			}
		}

		public PlaceableElement Instance
		{
			get { return (_Room == null) ? null : _Instance; }
			set { _Instance = (_Room == null) ? null : value; }
		}

		public PlaceableInstance HighlightedInstance
		{
			get { return (_Room == null) ? null : _HighlightedInstance; }
			set { _HighlightedInstance = value; }
		}

		public PlaceableInstance SelectedInstance
		{
			get { return (_Room == null) ? null : _SelectedInstance; }
			set
			{
				_SelectedInstance = value;
				Manager.MainWindow.brushPlaceableUpdatePositionAndRotation();
			}
		}

		#endregion

		public ProjectData(string srcPath)
		{
			createNewProject(srcPath, false);
		}

		public ProjectData(string srcPath, bool load)
		{
			createNewProject(srcPath, load);
		}

		public bool createNewProject(string sourcePath, bool load)
		{
			//resetUsedRes();
			ProjectSource = Path.GetDirectoryName(sourcePath);

			Manager.Project = this;

			if (load)
			{
				ProjectFilename = Path.GetFileName(sourcePath);
				GmxFilename = Path.GetFileNameWithoutExtension(ProjectFilename) + ".gmx";
				_readGMX();
				if (Manager.Project != null)
				{
					_readAME();
					//_checkForRegisteredRes(allItems.getSubitems());
				}
			}
			else
			{
				GmxFilename = Path.GetFileName(sourcePath);
				ProjectFilename = Path.GetFileNameWithoutExtension(GmxFilename) + ".ame";
				_readGMX();
			}

			return true;
		}

		public bool saveProjectToXML()
		{
			string path;
			path = Path.GetDirectoryName(ProjectSource);

			XmlDocument file = new XmlDocument();
			XmlComment comment = file.CreateComment("This Document is generated by Almora Map Editor, if you edit it by hand then you do so at your own risk!");
			XmlElement assets = file.CreateElement("assets");
			XmlElement options = file.CreateElement("options");

			List<XmlElement> optionsElements = new List<XmlElement>();

			options.AppendChild(_addXmlElement(file, "gmsProjectFile", GmxFilename));
			options.AppendChild(_addXmlElement(file, "gridEnabled", "0"));

			//XmlElement resources = file.CreateElement("resources");
			/*foreach (string name in RegisteredResources)
			{
				resources.AppendChild(_addXmlElement(file, "resource", name));
			}*/

			/*XmlElement placeables = file.CreateElement("placeables");
			foreach (PlaceableElement elem in PlaceableList)
			{
				placeables.AppendChild(elem.toXml(file));
			}*/

			XmlElement rooms = file.CreateElement("rooms");
			foreach (MapRoom elem in RoomList)
			{
				rooms.AppendChild(elem.toXml(file));
				elem.saveRoomInstancesToXml();
			}

			XmlElement brushes = file.CreateElement("brushgroups");
			foreach (BrushGroup elem in BrushGroups)
			{
				brushes.AppendChild(elem.toXml(file));
			}

			XmlElement layers = file.CreateElement("layers");
			foreach (MapLayers layer in RoomLayers)
			{
				XmlElement elem = file.CreateElement("layer");
				elem.SetAttribute("name", layer.LayerName);
				elem.SetAttribute("depth", layer.LayerDepth.ToString());
				layers.AppendChild(elem);
			}
			
			assets.AppendChild(options);
			//assets.AppendChild(resources);
			//assets.AppendChild(placeables);
			assets.AppendChild(rooms);
			assets.AppendChild(brushes);
			assets.AppendChild(layers);

			file.AppendChild(comment);
			file.AppendChild(assets);

			// now save script
			//List<string> lines = new List<string>(){ 
			//    "\n\n",
			//    "\t//env init",
			//    "\tglobal.envMap = ds_map_create();",
			//    "\n\t//id, nazwa, depth, solid, mask, wind, multidraw, shadow, shadowsize",
			//};
			//int counter = 1;
			//foreach (PlaceableElement elem in PlaceableList)
			//{
			//    lines.Add("\tscEnvMapAdd(" + counter.ToString() + ", " + elem.Sprite + ", " + elem.Depth.ToString() + ", 1, sprMask1, 0, 1, 0, 0);");
			//    counter++;
			//}
			//System.IO.File.WriteAllLines(ProjectSource + "\\amedata\\scEnvMapAdd.gml", lines);

			try
			{
				file.Save(ProjectSource + "\\" + ProjectFilename);
			}
			catch (Exception)
			{
				return false;
			}

			return true;
		}

		private XmlElement _addXmlElement(XmlDocument xml, string nodeName, string nodeValue)
		{
			XmlElement elem = xml.CreateElement(nodeName);
			elem.InnerText = nodeValue;
			return elem;
		}

		private string tryReadingNode(XmlNode n, string nodeName, string defaultValue)
		{
			try
			{
				return n.SelectSingleNode(nodeName).InnerText;
			}
			catch (Exception)
			{
				return defaultValue;
			}
		}

		private int tryReadingNode(XmlNode n, string nodeName, int defaultValue)
		{
			try
			{
				int.TryParse(n.SelectSingleNode(nodeName).InnerText, out defaultValue);
			}
			catch (Exception)
			{

			}

			return defaultValue;
		}

		private bool tryReadingNode(XmlNode n, string nodeName, bool defaultValue)
		{
			try
			{
				return (n.SelectSingleNode(nodeName).InnerText == "1") ? true : false;
			}
			catch (Exception)
			{
				return defaultValue;
			}
		}

		private void _readAME()
		{
			XmlDocument XMLfile = new XmlDocument();
			XMLfile.Load(ProjectSource + "\\" + ProjectFilename);

			XmlNode root = XMLfile.SelectSingleNode("assets/resources");

			/*foreach (XmlNode n in root)
			{
				addUsedRes(n.InnerText);
			}*/

			// don't use PlaceableElement definitions anymore, they are converted from Objects now
			/*try
			{
				root = XMLfile.SelectSingleNode("assets/placeables");
				foreach (XmlNode n in root)
				{
					PlaceableElement e = new PlaceableElement()
					{
						Name = n.Attributes["name"].Value,
						Sprite = n.SelectSingleNode("sprite").InnerText,
						Mask = n.SelectSingleNode("mask").InnerText,
						Depth = int.Parse(n.SelectSingleNode("depth").InnerText),
						ShadowSize = int.Parse(n.SelectSingleNode("shadowsize").InnerText),
						Solid = (n.SelectSingleNode("solid").InnerText == "1"),
						Wind = (n.SelectSingleNode("wind").InnerText == "1"),
						MultiDraw = (n.SelectSingleNode("multidraw").InnerText == "1"),
						Shadow = (n.SelectSingleNode("shadow").InnerText == "1"),
						Visible = (n.SelectSingleNode("visible").InnerText == "1") ? true : false,
						Parent = tryReadingNode(n, "parent", ""),
						useDefaultObjectDepth = tryReadingNode(n, "defdepth", false),
						useDefaultObjectMask = tryReadingNode(n, "defmask", false),
						useDefaultObjectSolid = tryReadingNode(n, "defsolid", false),
						useDefaultObjectSprite = tryReadingNode(n, "defsprite", false),
						useDefaultObjectVisible = tryReadingNode(n, "defvisible", false)
					};

					PlaceableList.Add(e);
				}
			}
			catch
			{

			}*/

			// read rooms
			try
			{
				root = XMLfile.SelectSingleNode("assets/rooms");
				foreach (XmlNode n in root)
				{
					MapRoom map = new MapRoom()
					{
						Width = int.Parse(n.Attributes["width"].Value),
						Height = int.Parse(n.Attributes["height"].Value),
						LinkedWith = n.Attributes["linked"].Value,
						LastUsedLayer = (n.Attributes["lastLayer"] == null) ? -1 : int.Parse(n.Attributes["lastLayer"].Value)//,
						//InternalCounter = (n.Attributes["internalCounter"].Value == null) ? 0 : int.Parse(n.Attributes["internalCounter"].Value)
					};

					RoomList.Add(map);
					_readAMERoom(map, ProjectSource + "\\amedata\\" + map.LinkedWith + ".room.ame");
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("reading room node from AME file failed: " + e.Message);
			}

			// read brushes
			try
			{
				root = XMLfile.SelectSingleNode("assets/brushgroups");
				foreach (XmlNode n in root)
				{
					string name = n.Attributes["name"].Value;
					BrushGroup brush;
					brush = BrushGroups.Where(item => item.GroupName == name).FirstOrDefault();
					if (brush == null)
					{
						brush = new BrushGroup() { GroupName = name };
						BrushGroups.Add(brush);
					}

					foreach (XmlNode obj in n.SelectSingleNode("objects"))
					{
						brush.objects.Add(obj.Attributes["name"].Value);
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show("Reading brush node from AME file failed: " + e.Message);
			}

			// read layers
			root = XMLfile.SelectSingleNode("assets/layers");
			foreach (XmlNode n in root)
			{
				RoomLayers.Add(new MapLayers()
				{
					LayerDepth = int.Parse(n.Attributes["depth"].Value),
					LayerName = n.Attributes["name"].Value
				});
			}

			regenerateEnvDefList();
			regenerateRoomList();
			regenerateTextureList();
			regenerateLayerList();
			regenerateBrushList();
		}

		private void _readAMERoom(MapRoom room, string path)
		{
			XmlDocument XMLfile = new XmlDocument();
			XMLfile.Load(path);

			// instances
			XmlNode root = XMLfile.SelectSingleNode("assets/instances");

			foreach (XmlNode n in root)
			{
				//PlaceableElement pl = PlaceableList.Find(item => item.Name == n.Attributes["name"].Value);
				PlaceableElement pl = PlaceableList.Find(item => item.Name == n.Attributes["object"].Value);

				//foreach (PlaceableElement pl in PlaceableList)
				//{
					//if (pl.Name == n.Attributes["name"].Value)
					if (pl != null)
					{
						PlaceableInstance inst = new PlaceableInstance()
						{
							X = int.Parse(n.Attributes["x"].Value)/* - pl.offsetX*/,
							Y = int.Parse(n.Attributes["y"].Value)/* - pl.offsetY*/,
							Layer = int.Parse(n.Attributes["layer"].Value),
							Element = pl,
							Rotation = int.Parse(n.Attributes["rotate"].Value),
							ID = int.Parse(n.Attributes["id"].Value)
						};
						room.addInstance(inst);
						//break;
					}
				//}
			}

			/// ! moved to main project !
			// layers
			/*root = XMLfile.SelectSingleNode("assets/layers");
			foreach (XmlNode n in root)
			{
				room.Layers.Add(new MapLayers()
				{
					LayerDepth = int.Parse(n.Attributes["depth"].Value),
					LayerName = n.Attributes["name"].Value
				});
			}*/

			//room.Layers.Sort(MapLayers.SortByLayerDepth);
		}

		private void _readGMX()
		{
			XmlDocument XMLfile = new XmlDocument();
			try
			{
				XMLfile.Load(ProjectSource + "\\" + GmxFilename);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				Manager.Project = null;
				return;
			}

			string nodeElementsName;
			XmlNode root;
			allItems = new GMItem(Path.GetFileNameWithoutExtension(Path.GetFileNameWithoutExtension(GmxFilename)));
			string[] resTree = new string[] { "sprites", "backgrounds", "scripts", "objects", "rooms" };

			// none sprite add
			GMItem noneSprite = new GMItem(GMSpriteData.undefinedSprite) { ResourceType = GMItemType.Sprite, isGroup = false };
			GMXSprites.Add( new GMSpriteData() { offsetX = 0, offsetY = 0, firstFramePath = "", owner = noneSprite });

			foreach (string nodeName in resTree)
			{
				try
				{
					root = XMLfile.SelectSingleNode("assets/" + nodeName);

					if (root == null)
					{
						return;
					}

					nodeElementsName = nodeName;//root.Attributes["name"].InnerText;

					//TreeNode main = treeViewGMX.Nodes.Paint(fup(nodeElementsName), fup(nodeElementsName));

					GMItem main = new GMItem(nodeElementsName);
					allItems.add(main);

					_readSubNode(root, nodeName, nodeElementsName, main);
				}
				catch (Exception e)
				{
					MessageBox.Show(nodeName + ": " + e.Message);
				}
			}

			BrushGroups = new ObservableCollection<BrushGroup>();
			BrushGroup defaultBrushGroup = new BrushGroup() { GroupName = "Default", isDefault = true };
			BrushGroups.Add(defaultBrushGroup);

			//List<string> objects = Manager.Project.renderItemsList("objects");
			//addUsedRes(GMSpriteData.undefinedSprite);

			foreach (GMObjectData obj in GMXObjects)
			{
				PlaceableElement el = new PlaceableElement()
				{
					Name = obj.Name,
					Sprite = (obj.sprite != null) ? obj.sprite.Name : GMSpriteData.undefinedSprite,
					//Mask = "",
					//Depth = 0,
					//ShadowSize = 0,
					//Solid = false,
					//Wind = false,
					//MultiDraw = false,
					//Shadow = false,
					//Visible = false,
					Parent = "",
					//useDefaultObjectDepth = false,
					//useDefaultObjectMask = false,
					//useDefaultObjectSolid = false,
					//useDefaultObjectSprite = false,
					//useDefaultObjectVisible = false,
				};

				PlaceableList.Add(el);
				if (obj.sprite != null)
				{
					//addUsedRes(obj.sprite.Name);
				}
			}
		}

		private void _readSubNode(XmlNode node, string nodeName, string nodeElementsName, GMItem main)
		{
			foreach (XmlNode n in node)
			{
				if (n.Attributes["name"] != null)
				{
					// group
					//TreeNode sub = main.Nodes.Paint(n.Attributes["name"].InnerText);
					GMItem sub = new GMItem(n.Attributes["name"].InnerText);
					_readSubNode(n, nodeName, nodeElementsName, sub);
					main.add(sub);
				}
				else
				{
					//TreeNode sub = main.Nodes.Paint(n.InnerText, Path.GetFileName(n.InnerText));
					//sub.ImageIndex = sub.SelectedImageIndex = 1;
					//sub.ContextMenuStrip = contextMenuStrip2;
					string name = (nodeName == "scripts") ? /*n.InnerText*/ Path.GetFileName(n.InnerText) /*+ ".gml"*/ : Path.GetFileName(n.InnerText)/*n.InnerText + "." + n.Name + ".gmx"*/;
					GMItem sub = new GMItem(name, nodeName);
					main.add(sub);
				}
			}
		}

		public void renderItemsTree(TreeView Tree)
		{
			renderItemsTree(Tree, false);
		}

		public void renderObjectsTree(ComboBox Dropdown)
		{
			Dropdown.Items.Clear();

			_renderObjectsForNode(Dropdown, Manager.Project.allItems.Find("objects"));

			Dropdown.SelectedIndex = Dropdown.Items.IndexOf(this.defaultPlaceable);
		}

		private void _renderObjectsForNode(ComboBox Dropdown, GMItem _node)
		{
			if (_node == null) return;

			foreach (GMItem _object in _node.getSubitems())
			{
				if (_object.isGroup)
				{
					_renderObjectsForNode(Dropdown, _object);
				}
				else
				{
					Dropdown.Items.Add(_object.Name);
				}
			}
		}

		public void renderItemsTree(TreeView Tree, bool skipNonProjectNodes)
		{
			Tree.Nodes.Clear();
			TreeNode NodeGM = Tree.Nodes.Add("NodeGM", "Project: " + Manager.Project.GmxFilename);

			if (skipNonProjectNodes == false)
			{
				Tree.Nodes.Add("NodeInternal", "Internal Files");
			}

			//TreeNode t = treeViewGMX.Nodes["NodeGM"].Nodes.Paint(Manager.Project.allItems.Name);
			Tree.ExpandAll();

			if (skipNonProjectNodes == false)
			{
				_treeAddGMItemGroup(NodeGM, Manager.Project.allItems.getSubitems());
			}
			else
			{
				_treeAddGMItemGroup(NodeGM, new List<GMItem>() { Manager.Project.allItems.Find("sprites") });
				_treeAddGMItemGroup(NodeGM, new List<GMItem>() { Manager.Project.allItems.Find("backgrounds") });
			}
		}

		public void renderItemsTree(TreeView Tree, string group)
		{
			Tree.Nodes.Clear();
			TreeNode NodeGM = Tree.Nodes.Add("NodeGM", "Project: " + Manager.Project.GmxFilename);

			_treeAddGMItemGroup(NodeGM, new List<GMItem>() { Manager.Project.allItems.Find(group) });
		}

		public List<string> renderItemsList(string group)
		{
			List<string> list = new List<string>();
			_renderItemList(list, Manager.Project.allItems.Find("objects"));
			return list;
		}

		protected void _renderItemList(List<string> list, GMItem _node)
		{
			if (_node == null) return;

			foreach (GMItem _object in _node.getSubitems())
			{
				if (_object.isGroup)
				{
					_renderItemList(list, _object);
				}
				else
				{
					list.Add(_object.Name);
				}
			}
		}

		private bool _treeAddGMItemGroup(TreeNode t, List<GMItem> items)
		{
			bool anyChecked = false;

			foreach (GMItem item in items)
			{
				TreeNode newT = t.Nodes.Add(item.Name, item.Name);

				if (item.isGroup)
				{
					bool anySubChecked = false;
					newT.ImageIndex = 0;
					newT.SelectedImageIndex = 1;
					anySubChecked = _treeAddGMItemGroup(newT, item.getSubitems());
					// Tree node doesn't support indeterminade :(
					//if (anySubChecked)
					//{
					//    newT.Check
					//}
					anyChecked |= anySubChecked;
				}
				else
				{
					newT.ImageIndex = 3;
					switch (item.ResourceType)
					{
						case GMItemType.Background:
						case GMItemType.Sprite: newT.ImageIndex = 6; break;
						case GMItemType.Script: newT.ImageIndex = 5; break;
					}
					newT.SelectedImageIndex = newT.ImageIndex;
					if (item.used == GMItemUsage.used)
					{
						if (t.TreeView.CheckBoxes)
						{
							newT.Checked = true;
							anyChecked = true;
						}
						newT.StateImageIndex = 7;
					}
				}
			}

			return anyChecked;
		}

		/*public void resetUsedRes()
		{
			RegisteredResources = new List<string>();
		}*/

		/*public void addUsedRes(string name)
		{
			if (RegisteredResources == null)
			{
				resetUsedRes();
			}


			//string spritePath = ProjectSource + "\\sprites\\images\\" + name + "_0.png";
			//if (File.Exists(spritePath))
			//{
			//    GraphicsManager.LoadTexture(new Bitmap(spritePath), RegisteredResources.Count);
			//}
			RegisteredResources.Add(name);
		}*/

		/*public void checkForRegisteredRes()
		{
			_checkForRegisteredRes(allItems.getSubitems());
		}

		private void _checkForRegisteredRes(List<GMItem> items)
		{
			foreach (GMItem item in items)
			{
				if (item.isGroup)
				{
					_checkForRegisteredRes(item.getSubitems());
				}
				else
				{
					if (RegisteredResources.IndexOf(item.Name) > -1)
					{
						item.used = GMItemUsage.used;
					}
					else { item.used = (item.used == GMItemUsage.used) ? GMItemUsage.disposed : GMItemUsage.unused; }
				}
			}
		}*/

		#region ENVinstances
		public void addEnvDef(string name)
		{
			PlaceableElement n = new PlaceableElement() { Name = name };
			PlaceableList.Add(n);
		}

		public void regenerateEnvDefList()
		{
			ListBoxEx list = Manager.MainWindow.lbPlaceables;
			list.Items.Clear();
			foreach (PlaceableElement elem in PlaceableList)
			{
				list.Items.Add(elem.Name);
			}


			Manager.MainWindow.statusLabelPlaceables.Text = PlaceableList.Count.ToString();
		}

		public void regenerateInstanceList()
		{
			if (Room == null) return;
			ListBoxEx list = Manager.MainWindow.lbInstances;
			list.Items.Clear();
			foreach (PlaceableInstance instance in Room.Instances)
			{
				list.Items.Add(instance.Element.Name);
			}
		}

		public void regenerateRoomList()
		{
			ListBoxEx list = Manager.MainWindow.lbRooms;
			list.Items.Clear();
			foreach (MapRoom elem in RoomList)
			{
				list.Items.Add(elem.LinkedWith);
			}
		}

		public void regenerateTextureList()
		{
			using (LoadingForm form = new LoadingForm())
			{
				form.Show();

				//GraphicsManager.DeleteTextures();

				/*foreach (GMSpriteData sp in this.GMXSprites)
				{
					if (sp.owner.used == GMItemUsage.disposed) GraphicsManager.DeleteTexture(sp.Name);
				}*/

				int i = 0;
				/*Manager.MainWindow.tsProgress.Maximum = RegisteredResources.Count;
				Manager.MainWindow.tsProgress.Value = 0;
				Manager.MainWindow.tsProgress.Visible = true;*/

				form.loadingBar.Maximum = this.GMXObjects.Count;// RegisteredResources.Count;
				form.loadingBar.Value = 0;

				//foreach (string file in RegisteredResources)
				List<string> objects = renderItemsList("objects");
				foreach (string gmobject in objects)
				{
					//GMSpriteData itm = this.GMXSprites.Find(item => item.Name == file);
					GMSpriteData itm = this.GMXObjects.Find(item => item.Name == gmobject).sprite;

					if (itm != null)
					{
						// prevent adding duplicates
						if (!GraphicsManager.Sprites.ContainsKey(itm.Name))
						{
							if (File.Exists(itm.firstFramePath))
							{
								GraphicsManager.LoadTexture(itm.Name, new Bitmap(itm.firstFramePath));
							}
							else if (itm.Name == GMSpriteData.undefinedSprite)
							{
								GraphicsManager.LoadTexture(itm.Name, new Bitmap(Manager.MainWindow.imageListObjects.Images[GMSpriteData.undefinedSprite]));
							}
						}

						if (!Manager.MainWindow.imageListObjects.Images.ContainsKey(itm.Name))
						{
							if (File.Exists(itm.firstFramePath))
							{
								Manager.MainWindow.imageListObjects.Images.Add(itm.Name, new Bitmap(itm.firstFramePath));
							}
						}
					}
					//Manager.MainWindow.tsProgress.Value++;
					form.loadingBar.Value++;
					if (i % 10 == 0 || i == this.GMXObjects.Count - 1/*RegisteredResources.Count - 1*/)
					{
						form.Refresh();
					}
					i++;
				}
				//Manager.MainWindow.tsProgress.Visible = false;

				foreach (PlaceableElement elem in PlaceableList)
				{
					elem.textureId = elem.Sprite;
				}

				form.Close();
			}

			/*using (LoadingForm form = new LoadingForm())
			{
				form.Show();

				List<string> objects = renderItemsList("objects");

				foreach (string gmobject in objects)
				{
					//GMSpriteData itm = this.GMXSprites.Find(item => item.Name == file);
					GMSpriteData itm = this.GMXObjects.Find(item => item.Name == gmobject).sprite;

					if (itm != null)
					{
						// prevent adding duplicates
						//if (!GraphicsManager.Sprites.ContainsKey(itm.Name))
						
					}
				}

				form.Close();
			}*/
		}

		public void regenerateLayerList()
		{
			if (Room == null) return;

			//Room.Layers.Sort(MapLayers.SortByLayerDepth);
			RoomLayers = new ObservableCollection<MapLayers>(RoomLayers.OrderByDescending(x => x.LayerDepth));

			ToolStripComboBox tb = Manager.MainWindow.tbLayerDropDown;
			ListBoxEx lb = Manager.MainWindow.lbLayers;
			ToolStripDropDownButton td = Manager.MainWindow.tbEnabledLayersDropdown;

			tb.Items.Clear();
			lb.Items.Clear();
			td.DropDownItems.Clear();

			foreach (MapLayers layer in Room.Layers)
			{
				tb.Items.Add(layer.LayerName + " (" + layer.LayerDepth.ToString() + ")");
				lb.Items.Add(layer.LayerName);
				ToolStripMenuItem item = new ToolStripMenuItem()
				{
					Text = layer.LayerName,
					Checked = true,
					CheckOnClick = true//,
					//OwnerItem = tb
				};
				item.Click += new EventHandler(Manager.MainWindow.tbEnabledLayersDropdown_SubItemClick);
				td.DropDownItems.Add(item);
			}

			if (tb.Items.Count > 0)
			{
				tb.SelectedIndex = 0;
			}


		}

		public void regenerateBrushList()
		{
			foreach (BrushGroup group in BrushGroups)
			{
				ListView l = Manager.MainWindow.brushGroupList;
				ListViewGroup gr = l.Groups.Add(group.GroupName, group.GroupName);
				foreach (string name in group.objects)
				{
					GMSpriteData sprite = Manager.Project.GMXObjects.Find(item => item.Name == name).sprite;
					ListViewItem o = new ListViewItem() { Text = name, ImageKey = (sprite == null) ? GMSpriteData.undefinedSprite : sprite.Name };
					o.Group = gr;
					l.Items.Add(o);
				}
			}
		}

		#endregion


	}
}
