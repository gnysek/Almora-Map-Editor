using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    class GmsResource
    {
        public string name;
        public GmsResourceType resourceType = GmsResourceType.undefined;
        public List<GmsResource> subitems = null;
    }

    class GmsSprite : GmsResource
    {
        public int origin_x, origin_y;
        public List<string> images;

        public string image
        {
            get { return (images.Count > 0) ? images[0] : null; }
            set { if (images.Count > 0) images[0] = value; else images.Add(value); }
        }
    }

    class GmsBackground : GmsResource
    {
        public string image;
    }

    class GmsObject : GmsResource
    {
        public GmsSprite sprite_index;
    }

    class GmsRoomInstance {
        public GmsObject instance_of;
        public int x, y;
        public string objName = "", name = "";
        public bool locked = false;
        public string code = "";
        public float scaleX, scaleY, rotation;
        public uint colour;
    }

    class GmsRoom : GmsResource
    {
        public int width, height;
        public GmsBackground background;
        public List<GmsRoomInstance> instances = new List<GmsRoomInstance>();
        public AmeRoom _e;
    }

    class AmeRoom
    {
        public int layers = 0;
    }
}
