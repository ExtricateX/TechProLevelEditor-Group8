using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace XNALevelEditor.Classes.Object
{
    class GameObject
    {
        // Properties
        public string Name;
        public string GraphicAssetName;
        public int Depth;
        public float X, Y;
        public bool Solid;
        public bool Visible = true;
        public List<Image> Sprite;
        // Editor properties
        public int ID;
        public bool Locked;
    }
}
