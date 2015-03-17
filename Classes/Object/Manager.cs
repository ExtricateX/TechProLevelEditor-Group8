using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace XNALevelEditor.Classes.Object
{
    class Manager
    {
        // GameObject list
        public List<Classes.Object.GameObject> ObjectList = new List<Classes.Object.GameObject>();

        // Add game object
        public void AddObject(string Name, string GraphicAssetName, int Depth, float X, float Y, bool Solid, bool Visible, bool Locked, List<Image> Sprite)
        {
            if (Name != "" && Depth > -1 && Sprite.Count > 0)
            {
                Classes.Object.GameObject tempGameObject = new Classes.Object.GameObject();
                tempGameObject.ID = ObjectList.Count;
                tempGameObject.Name = Name;
                tempGameObject.GraphicAssetName = GraphicAssetName;
                tempGameObject.Depth = Depth;
                tempGameObject.X = X; tempGameObject.Y = Y;
                tempGameObject.Solid = Solid;
                tempGameObject.Visible = Visible;
                tempGameObject.Locked = Locked;
                tempGameObject.Sprite = Sprite;
                ObjectList.Add(tempGameObject);
            }
            else
            {
                throw new Exception("Incorrect Object.");
            }
        }

        // Add game object
        public void AddObject(GameObject Object)
        {
            if (Object != null)
            {
                ObjectList.Add(Object);
            }
            else
            {
                throw new Exception("Incorrect Object.");
            }
        }

        // Remove game object
        public void RemoveObject(int ItemIndex)
        {
            ObjectList.RemoveAt(ItemIndex);
        }

        // Clear game object list
        public void ClearObject()
        {
            ObjectList.Clear();
        }

        // Edit game object
        public void EditObject(int ItemIndex, string Name, string GraphicAssetName, int Depth, bool Solid, bool Visible, bool Locked, List<Image> Sprite)
        {
            if (ItemIndex > -1 && Name != "")
            {
                ObjectList[ItemIndex].Name = Name;
                ObjectList[ItemIndex].GraphicAssetName = GraphicAssetName;
                ObjectList[ItemIndex].Depth = Depth;
                ObjectList[ItemIndex].Solid = Solid;
                ObjectList[ItemIndex].Visible = Visible;
                ObjectList[ItemIndex].Locked = Locked;
                ObjectList[ItemIndex].Sprite = Sprite;
            }
        }

        // Get instance
        public Classes.Object.GameObject GetInstance(int ItemIndex)
        {
            Classes.Object.GameObject tempObject = new Classes.Object.GameObject();
            tempObject.ID = ObjectList[ItemIndex].ID;
            tempObject.Name = ObjectList[ItemIndex].Name;
            tempObject.GraphicAssetName = ObjectList[ItemIndex].GraphicAssetName;
            tempObject.Depth = ObjectList[ItemIndex].Depth;
            tempObject.Solid = ObjectList[ItemIndex].Solid;
            tempObject.Visible = ObjectList[ItemIndex].Visible;
            tempObject.Locked = ObjectList[ItemIndex].Locked;
            tempObject.Sprite = ObjectList[ItemIndex].Sprite;
            return tempObject;
        }
    }
}
