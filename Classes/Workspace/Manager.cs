using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace XNALevelEditor.Classes.Workspace
{
    public struct IconInfo
    {
        public bool fIcon;
        public int xHotspot;
        public int yHotspot;
        public IntPtr hbmMask;
        public IntPtr hbmColor;
    }

    class Manager
    {
        // DLLs
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        // Refrence main from
        public MainForm RefrenceMainForm;
        // Refrence workspace parent
        public Panel RefrenceWorkspaceParent;
        // Refrence workspace
        public PictureBox RefrenceWorkspace;
        // Refrence game object list view
        public ListView RefrenceGameObjList;
        // Refrence graphic resource list view
        public ListView RefrenceGraphicResList;
        // Refrence objects image list
        public ImageList RefrenceObjectsImageList;
        // Refrence graphic resource image list
        public ImageList RefrenceGraphicResImageList;

        // Level properties
        public int LevelWidth = 640, LevelHeight = 480, GridWidth = 16, GridHeight = 16;
        public Color LevelBackColor, GridColor;

  
        public Classes.Workspace.Settings SettingsIdentity = new Classes.Workspace.Settings();

        // Object manager
        public Classes.Object.Manager ObjectManager = new Classes.Object.Manager();

        // Object clipboard
        public Classes.Object.GameObject ObjectClipboard = new Classes.Object.GameObject();
        string ClipboardAction = "";

        // Resource manager
        public Classes.Resource.Manager ResourceManager = new Classes.Resource.Manager();

        // Scene manager
        public Classes.Workspace.Scene SceneManager;

        // Widget manager
        public Classes.Workspace.Widget WidgetManager;

        // Initialize workspace
        public Manager()
        {
            //
        }

       
        // Add game object
        public void AddObject(string Name, string GraphicAssetName, int Depth, float X, float Y, bool Solid, bool Visible, bool Locked, List<Image> Sprite)
        {
            ObjectManager.AddObject(Name, GraphicAssetName, Depth, X, Y, Solid, Visible, Locked, Sprite);
            RefrenceObjectsImageList.Images.Add(ObjectManager.ObjectList[ObjectManager.ObjectList.Count - 1].Name, ObjectManager.ObjectList[ObjectManager.ObjectList.Count - 1].Sprite[0]);
            RefrenceWorkspace.Invalidate();
        }

        // Add game object
        public void AddObject(Classes.Object.GameObject Object)
        {
            ObjectManager.AddObject(Object);
            RefrenceObjectsImageList.Images.Add(ObjectManager.ObjectList[ObjectManager.ObjectList.Count - 1].Name, ObjectManager.ObjectList[ObjectManager.ObjectList.Count - 1].Sprite[0]);
            RefrenceWorkspace.Invalidate();
        }

        // Cut object
        public void CutObject(int ItemIndex)
        {
            ClipboardAction = "Cut";
            ObjectClipboard = ObjectManager.GetInstance(ItemIndex);
            RemoveObject(ItemIndex);
        }

        // Copy object
        public void CopyObject(int ItemIndex)
        {
            ClipboardAction = "Copy";
            ObjectClipboard = ObjectManager.GetInstance(ItemIndex);
        }

        // Paste object
        public void PasteObject(float X, float Y)
        {
            string Prefix = "Copy - ";
            if (ObjectClipboard != null)
            {
                if (ClipboardAction == "Cut") Prefix = "";
                AddObject(Prefix + ObjectClipboard.Name, ObjectClipboard.GraphicAssetName,
                    ObjectClipboard.Depth, X, Y, ObjectClipboard.Solid, ObjectClipboard.Visible,
                    ObjectClipboard.Locked, ObjectClipboard.Sprite);
                if (ClipboardAction == "Cut")
                {
                    ObjectClipboard = null;
                    ClipboardAction = "";
                }
                if (ClipboardAction == "Copy") ObjectClipboard.Name = Prefix + ObjectClipboard.Name; 
                RefreshObjectImageList();
                RefreshObjectList();
            }
        }

        // Remove game object
        public void RemoveObject(int ItemIndex)
        {
            RefrenceObjectsImageList.Images.RemoveByKey(ObjectManager.ObjectList[ItemIndex].Name);
            ObjectManager.RemoveObject(ItemIndex);
            RefreshObjectImageList();
            RefreshObjectList();
            RefrenceWorkspace.Invalidate();
        }

        // Clear game object list
        public void ClearObject()
        {
            switch (MessageBox.Show("Clear object tile?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    ObjectManager.ClearObject();
                    RefrenceObjectsImageList.Images.Clear();
                    RefrenceWorkspace.Invalidate();
                    break;
            }
        }


        // Refresh game object list
        public void RefreshObjectList()
        {
            RefrenceGameObjList.Items.Clear();
            for (int i = 0; i <= ObjectManager.ObjectList.Count - 1; i++)
            {
                RefrenceGameObjList.Items.Add(ObjectManager.ObjectList[i].Name, i);
            }
        }

        // Refresh game object image list
        public void RefreshObjectImageList()
        {
            RefrenceObjectsImageList.Images.Clear();
            for (int i = 0; i <= ObjectManager.ObjectList.Count - 1; i++)
            {
                RefrenceObjectsImageList.Images.Add(ObjectManager.ObjectList[i].Name, ObjectManager.ObjectList[i].Sprite[0]);
            }
        }


      
        // Draw grid lines
        public Bitmap DrawGridLines(int width, int height, Color dColor)
        {
            Bitmap tempBitmap = new Bitmap(RefrenceWorkspace.Width, RefrenceWorkspace.Height);
            Graphics tempGraphic = Graphics.FromImage(tempBitmap);
            Pen tempPen = new Pen(dColor);
            GridWidth = width;
            GridHeight = height;
            if (width == 0 && height == 0) return tempBitmap;
            if (width > 0)
            {
                for (int i = width; i <= RefrenceWorkspace.Width; i += width)
                {
                    tempGraphic.DrawLine(tempPen, new Point(i, 0), new Point(i, RefrenceWorkspace.Height));
                }
            }
            if (height > 0)
            {
                for (int j = height; j <= RefrenceWorkspace.Height; j += height)
                {
                    tempGraphic.DrawLine(tempPen, new Point(0, j), new Point(RefrenceWorkspace.Width, j));
                }
            }
            return tempBitmap;
        }

        // Remove outside objects
        public void RemoveOutsideObjects()
        {
            List<int> Indexes = new List<int>();
            for (int i = 0; i <= ObjectManager.ObjectList.Count - 1; i++)
            {
                Classes.Object.GameObject tempObject = ObjectManager.ObjectList[i];
                if (((tempObject.X + tempObject.Sprite[0].Width) < 0)
                    || ((tempObject.Y + tempObject.Sprite[0].Height) < 0)
                    || ((tempObject.X) > RefrenceWorkspace.Width)
                    || ((tempObject.Y) > RefrenceWorkspace.Height))
                {
                    Indexes.Add(i);
                }
            }
            for (int i = 0; i <= Indexes.Count - 1; i++)
            {
                ObjectManager.RemoveObject(Indexes[i]);
            }
            RefrenceObjectsImageList.Images.Clear();
            for (int i = 0; i <= ObjectManager.ObjectList.Count - 1; i++)
            {
                RefrenceObjectsImageList.Images.Add(ObjectManager.ObjectList[i].Name, ObjectManager.ObjectList[i].Sprite[0]);
            }
            RefrenceWorkspace.Invalidate();
            RefreshObjectList();
        }

        // Create cursor
        public Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }

    }
}
