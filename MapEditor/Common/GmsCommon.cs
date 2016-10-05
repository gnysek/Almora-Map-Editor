using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Xml;

namespace MapEditor.Common
{
    public enum GmsResourceType
    {
        Group = 0,
        undefined,
        Sprite,
        Background,
        Script,
        Object,
        Room
    };

    public class GmsResource
    {
        public const string undefined = "<undefined>";
        public string name;
        public GmsResourceType resourceType = GmsResourceType.undefined;

        public GmsResource(string new_name)
        {
            name = new_name;
        }
    }

    public class GmsResourceGroup : GmsResource
    {
        public List<GmsResource> subitems = new List<GmsResource>();

        public GmsResourceGroup(string name) : base(name) { }
    }

    public class GmsBackground : GmsResource
    {
        public string image;

        public GmsBackground(string new_name)
            : base(new_name)
        {
            _load(new_name);
        }

        protected virtual void _load(string new_name)
        {
            XmlDocument XMLfile = new XmlDocument();
            XMLfile.Load(Manager.Project.ProjectSource + "\\background\\" + new_name + ".background.gmx");

            XmlNode node = XMLfile.SelectSingleNode("background/data");

            if (node != null)
            {
                image = Manager.Project.ProjectSource + "\\background\\" + node.InnerText;
            }
        }
    }

    public class GmsSprite : GmsBackground
    {
        public int origin_x = 0, origin_y = 0;
        public List<string> images = new List<string>();

        public new string image
        {
            get { return (images.Count > 0) ? images[0] : null; }
            set { if (images.Count > 0) images[0] = value; else images.Add(value); }
        }

        public GmsSprite(string new_name)
            : base(new_name)
        {
        }

        protected override void _load(string new_name)
        {
            if (new_name != GmsResource.undefined)
            {
                XmlDocument XMLfile = new XmlDocument();
                XMLfile.Load(Manager.Project.ProjectSource + "\\sprites\\" + new_name + ".sprite.gmx");

                XmlNode node = XMLfile.SelectSingleNode("sprite/frames/frame[@index='0']");

                if (node != null)
                {
                    images.Add(Manager.Project.ProjectSource + "\\sprites\\" + node.InnerText);
                    origin_x = int.Parse(XMLfile.SelectSingleNode("sprite/xorig").InnerText);
                    origin_y = int.Parse(XMLfile.SelectSingleNode("sprite/yorigin").InnerText);
                }
            }
        }
    }

    public class GmsObject : GmsResource
    {
        public GmsSprite sprite_index;
        public int depth = 0;

        public GmsObject(string new_name)
            : base(new_name)
        {
            XmlDocument XMLfile = new XmlDocument();
            XMLfile.Load(Manager.Project.ProjectSource + "\\objects\\" + new_name + ".object.gmx");

            XmlNode node = XMLfile.SelectSingleNode("object/spriteName");

            sprite_index = Manager.Project.GmsResourceSpriteList[0];
            string spriteName = "";

            if (node != null)
            {
                spriteName = node.InnerText;
                sprite_index = Manager.Project.GmsResourceSpriteList.Find(item => item.name == spriteName);
            }

            node = XMLfile.SelectSingleNode("object/depth");
            if (node != null)
            {
                depth = int.Parse(node.InnerText);
            }
            
        }
    }

    public class GmsRoomInstance
    {
        public GmsObject instance_of;
        public int x, y;
        public string objName = "", name = "";
        public bool locked = false;
        public string code = "";
        public float scaleX, scaleY, rotation;
        public uint colour;

        public GMRoomInstanceEditorData editor_data;
        public GmsRoomInstance()
        {
            editor_data = new GMRoomInstanceEditorData() { parent = this };
        }
    }

    public class GmsRoom : GmsResource
    {
        public int width, height;
        public GmsBackground background;
        public List<GmsRoomInstance> instances = new List<GmsRoomInstance>();
        public AmeRoom _e;

        public GmsRoom(string name) : base(name) { }

        //todo: remove
        public ObservableCollection<MapLayers> Layers
        {
            get { return Manager.Project.RoomLayers; }
        }
        public int LastUsedLayer = 0;
    }

    public class AmeRoom
    {
        public int layers = 0;
    }
}
