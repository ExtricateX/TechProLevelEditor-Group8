using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace XNALevelEditor.Classes.Workspace
{
    class Scene
    {
        // Refrence workspace
        public Classes.Workspace.Manager Workspace;

        // Refrence workspace
        public Classes.Workspace.Widget Widget;

        // Selected object
        public int SelectedObjectIndex, LastSelectedObjectIndex;
        private float SelectedObjectAdditionalMouseX, SelectedObjectAdditionalMouseY;
        public Object.GameObject SelectedObject, LastSelectedObject;

        // Initialize scene
        public Scene()
        {
            //
        }

        // Draw scene
        public void DrawScene(Graphics Surface, int ViewportVer, int ViewportHor)
        {
            if (Workspace.ObjectManager.ObjectList.Count > 0)
            {
                List<Classes.Object.GameObject> ViewportObjects = new List<Object.GameObject>();
                // Find objects within viewport
                for (int i = 0; i <= Workspace.ObjectManager.ObjectList.Count - 1; i++)
                {
                    Classes.Object.GameObject tempObject = Workspace.ObjectManager.ObjectList[i];
                    if (tempObject.Visible)
                    {
                        if ((tempObject.X + tempObject.Sprite[0].Width) > ViewportHor
                            && (tempObject.Y + tempObject.Sprite[0].Height) > ViewportVer)
                        {
                            ViewportObjects.Add(tempObject);
                        }
                    }
                }
                // If there was anything in viewport
                if (ViewportObjects.Count > 0)
                {
                    // Sort depth order
                    SortDepthOrder(ref ViewportObjects);
                    for (int i = 0; i <= ViewportObjects.Count - 1; i++)
                    {
                        Classes.Object.GameObject tempObject = ViewportObjects[i];
                        Surface.DrawImage(tempObject.Sprite[0], tempObject.X, tempObject.Y, tempObject.Sprite[0].Width, tempObject.Sprite[0].Height);
                    }
                    DrawSelectedRectangle(ref Surface);
                }
            }
        }

        // Select object
        public void SelectObject(float X, float Y, int WorkspaceWidth, int WorkspaceHeight)
        {
            List<Classes.Object.GameObject> InsideObjects = new List<Object.GameObject>();
            for (int i = 0; i <= Workspace.ObjectManager.ObjectList.Count - 1; i++)
            {
                Classes.Object.GameObject tempObject = Workspace.ObjectManager.ObjectList[i];
                if (tempObject.X <= X && tempObject.Y <= Y
                    && (tempObject.X + tempObject.Sprite[0].Width) > X && (tempObject.Y + tempObject.Sprite[0].Height) > Y)
                {
                    InsideObjects.Add(tempObject);
                }
            }
            if (!Widget.HaveSelection) SelectedObject = null;
            if (InsideObjects.Count == 0) return;
            int Biggest = FindTheBiggestDepth(InsideObjects);
            Classes.Object.GameObject selectedObject = InsideObjects[Biggest];
            LastSelectedObjectIndex = SelectedObjectIndex;
            SelectedObjectIndex = FindObject(selectedObject.Name);
            if (LastSelectedObjectIndex == SelectedObjectIndex)
            {
                LastSelectedObjectIndex = -1;
            }
            LastSelectedObject = SelectedObject;
            SelectedObject = selectedObject;
            if (LastSelectedObject == SelectedObject)
            {
                LastSelectedObject = null;
            }
            SelectedObjectAdditionalMouseX = X - SelectedObject.X;
            SelectedObjectAdditionalMouseY = Y - SelectedObject.Y;
        }

        // Select object by index
        public void SelectObjectByIndex(int ItemIndex)
        {
            Classes.Object.GameObject selectedObject = Workspace.ObjectManager.ObjectList[ItemIndex];
            SelectedObjectIndex = ItemIndex;
            SelectedObject = selectedObject;
            SelectedObjectAdditionalMouseX = SelectedObject.X;
            SelectedObjectAdditionalMouseY = SelectedObject.Y;
        }

        // Move object
        public void MoveObject(float X, float Y)
        {
            float tempX, tempY;
            if (SelectedObject != null && !SelectedObject.Locked)
            {
                tempX = X - SelectedObjectAdditionalMouseX; tempY = Y - SelectedObjectAdditionalMouseY;
                if (Workspace.GridWidth > 0)
                {
                    if ((tempX + (Workspace.GridWidth * 2)) % Workspace.GridWidth == 0)
                    {
                        SelectedObject.X = tempX;
                        Workspace.ObjectManager.ObjectList[SelectedObjectIndex].X = tempX;
                    }
                }
                else
                {
                    SelectedObject.X = tempX;
                    Workspace.ObjectManager.ObjectList[SelectedObjectIndex].X = tempX;
                }
                if (Workspace.GridHeight > 0)
                {
                    if ((tempY + (Workspace.GridHeight * 2)) % Workspace.GridHeight == 0)
                    {
                        SelectedObject.Y = tempY;
                        Workspace.ObjectManager.ObjectList[SelectedObjectIndex].Y = tempY;
                    }
                }
                else
                {
                    SelectedObject.Y = tempY;
                    Workspace.ObjectManager.ObjectList[SelectedObjectIndex].Y = tempY;
                }
            }
        }

        // Draw select rectangle
        public void DrawSelectedRectangle(ref Graphics Surface)
        {
            if (SelectedObject != null)
            {
                Surface.DrawRectangle(Pens.DarkBlue, SelectedObject.X, SelectedObject.Y,
                    SelectedObject.Sprite[0].Width, SelectedObject.Sprite[0].Height);
                this.DrawObjectInfo(ref Surface, SelectedObject);
            }
        }

        // Draw object info
        private void DrawObjectInfo(ref Graphics Surface, Classes.Object.GameObject Object)
        {
            if (Surface != null && Object != null)
            {
                Font tempFont = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel);
                Surface.DrawString("X: " + Object.X.ToString() + ", Y: " + Object.Y.ToString(), tempFont, Brushes.Red, new PointF(Object.X, Object.Y));
            }
        }

        // Sort depth order
        private void SortDepthOrder(ref List<Classes.Object.GameObject> Objects)
        {
            List<Classes.Object.GameObject> CloneObjects = Objects;
            // Find depth order
            Objects.Sort(
                    delegate(Classes.Object.GameObject Object1, Classes.Object.GameObject Object2)
                    {
                        int Compare = Object1.Depth.CompareTo(Object2.Depth);
                        if (Compare == 0)
                        {
                            Compare = CloneObjects.IndexOf(Object1).CompareTo(CloneObjects.IndexOf(Object2));
                        }
                        return Compare;
                    }
                );
        }

        // Sort ID order
        private void SortSelectDepthOrder(ref List<Classes.Object.GameObject> Objects)
        {
            // Find ID order
            Objects.Sort(
                    delegate(Classes.Object.GameObject Object1, Classes.Object.GameObject Object2)
                    {
                        return Object1.Depth.CompareTo(Object2.Depth);
                    }
                );
        }

        // Find the biggest depth
        private int FindTheBiggestDepth(List<Classes.Object.GameObject> Objects)
        {
            SortSelectDepthOrder(ref Objects);
            int Max = Objects[0].Depth, ID = 0;
            for (int i = 1; i <= Objects.Count - 1; i++)
            {
                if (Objects[i].Depth > Max)
                {
                    Max = Objects[i].Depth;
                    ID = i;
                }
            }
            return ID;
        }

        // Find object
        private int FindObject(string Name)
        {
            for (int i = 0; i <= Workspace.ObjectManager.ObjectList.Count - 1; i++)
            {
                if (Workspace.ObjectManager.ObjectList[i].Name == Name)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
