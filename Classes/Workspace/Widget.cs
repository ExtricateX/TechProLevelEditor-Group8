using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XNALevelEditor.Classes.Workspace
{
    public struct WidgetInfo
    {
        public string Name;
        public bool Active;
    }

    public struct WidgetToolInfo
    {
        public string Name;
        public string Method;
        public bool Active;
    }

    class Widget
    {
        // Refrence workspace
        public Classes.Workspace.Manager Workspace;

        // Widget list
        public List<WidgetInfo> WidgetList = new List<WidgetInfo>();
        public List<WidgetToolInfo> WidgetToolList = new List<WidgetToolInfo>();
        public WidgetInfo SelectedWidget = new WidgetInfo();
        public WidgetToolInfo SelectedToolWidget = new WidgetToolInfo();

        public Widget()
        {
            // Widget: ObjectMovement
            WidgetInfo tempWidget = new WidgetInfo();
            tempWidget.Name = "ObjectMovement";
            tempWidget.Active = false;
            WidgetList.Add(tempWidget);
            // Tools
            WidgetToolInfo tempWidgetTool = new WidgetToolInfo();
            tempWidgetTool.Name = "MoveObjectToObject";
            tempWidgetTool.Method = "Method_WidgetObjectMovement_FixPosToObj";
            tempWidgetTool.Active = false;
            WidgetToolList.Add(tempWidgetTool);
            tempWidgetTool.Name = "MoveObjectToGrid";
            tempWidgetTool.Method = "Method_WidgetObjectMovement_FixPosToGri";
            tempWidgetTool.Active = false;
            WidgetToolList.Add(tempWidgetTool);
            tempWidgetTool.Name = "MoveObjectToCenter";
            tempWidgetTool.Method = "Method_WidgetObjectMovement_FixPosToCen";
            tempWidgetTool.Active = false;
            WidgetToolList.Add(tempWidgetTool);
        }

        // Move object
        public void MoveObject(int ItemIndex, int Amount, string Direction)
        {
            switch (Direction)
            {
                case "Left":
                    Workspace.ObjectManager.ObjectList[ItemIndex].X -= Amount;
                    break;
                case "Up":
                    Workspace.ObjectManager.ObjectList[ItemIndex].Y -= Amount;
                    break;
                case "Down":
                    Workspace.ObjectManager.ObjectList[ItemIndex].Y += Amount;
                    break;
                case "Right":
                    Workspace.ObjectManager.ObjectList[ItemIndex].X += Amount;
                    break;
            }
        }

        // Widgets
        // Object movement
        public void Method_WidgetObjectMovement_FixPosToObj(int ItemIndex, Classes.Object.GameObject Target)
        {
            Workspace.ObjectManager.ObjectList[ItemIndex].X = Target.X;
            Workspace.ObjectManager.ObjectList[ItemIndex].Y = Target.Y;
        }
        // Object movement
        public void Method_WidgetObjectMovement_FixPosToGri(int ItemIndex, int X, int Y)
        {
            int XSubtract = X % Workspace.GridWidth, YSubtract = Y % Workspace.GridHeight;
            Workspace.ObjectManager.ObjectList[ItemIndex].X = X - XSubtract;
            Workspace.ObjectManager.ObjectList[ItemIndex].Y = Y - YSubtract;
        }
        // Object movement
        public void Method_WidgetObjectMovement_FixPosToCen(int ItemIndex, PictureBox RefrenceWorkspace)
        {
            int WidthSubtract = Workspace.ObjectManager.ObjectList[ItemIndex].Sprite[0].Width,
                HeightSubtract = Workspace.ObjectManager.ObjectList[ItemIndex].Sprite[0].Height;
            Workspace.ObjectManager.ObjectList[ItemIndex].X = (RefrenceWorkspace.Width - WidthSubtract) / 2;
            Workspace.ObjectManager.ObjectList[ItemIndex].Y = (RefrenceWorkspace.Height - HeightSubtract) / 2;
        }

        // DeSelect all widgets
        public void DeSelectAllWidgets()
        {
            for (int i = 0; i <= WidgetList.Count - 1; i++)
            {
                WidgetInfo tempWidget = new WidgetInfo();
                tempWidget.Name = WidgetList[i].Name;
                tempWidget.Active = false;
                WidgetList[i] = tempWidget;
            }
            SelectedWidget = default(WidgetInfo);
        }

        // DeSelect all widget tools
        public void DeSelectAllWidgetTools()
        {
            for (int i = 0; i <= WidgetToolList.Count - 1; i++)
            {
                WidgetToolInfo tempWidgetTool = new WidgetToolInfo();
                tempWidgetTool.Name = WidgetToolList[i].Name;
                tempWidgetTool.Method = WidgetToolList[i].Method;
                tempWidgetTool.Active = false;
                WidgetToolList[i] = tempWidgetTool;
            }
            SelectedToolWidget = default(WidgetToolInfo);
        }

        // Set widget selected
        public void SetWidgetSelected(string Name, bool Activation)
        {
            int WidgetInd = FindWidgetIndex(Name);
            if (WidgetInd > -1)
            {
                WidgetInfo tempWidget = new WidgetInfo();
                tempWidget.Name = Name;
                tempWidget.Active = Activation;
                WidgetList[WidgetInd] = tempWidget;
                if (Activation) SelectedWidget = WidgetList[WidgetInd];
            }
        }

        // Set widget tool selected
        public void SetWidgetToolSelected(string Name, string Method, bool Activation)
        {
            int WidgetToolInd = FindWidgetToolIndex(Name);
            if (WidgetToolInd > -1)
            {
                WidgetToolInfo tempWidgetTool = new WidgetToolInfo();
                tempWidgetTool.Name = Name;
                tempWidgetTool.Method = Method;
                tempWidgetTool.Active = Activation;
                WidgetToolList[WidgetToolInd] = tempWidgetTool;
                if (Activation) SelectedToolWidget = WidgetToolList[WidgetToolInd];
            }
        }

        // Find widget index
        public int FindWidgetIndex(string Name)
        {
            return WidgetList.FindIndex(delegate(WidgetInfo Widget) { return Widget.Name == Name; });
        }

        // Find widget tool index
        public int FindWidgetToolIndex(string Name)
        {
            return WidgetToolList.FindIndex(delegate(WidgetToolInfo WidgetTool) { return WidgetTool.Name == Name; });
        }

        // Properties
        public bool HaveSelection
        {
            get
            {
                for (int i = 0; i <= WidgetList.Count - 1; i++)
                {
                    if (WidgetList[i].Active)
                        return true;
                }
                return false;
            }
        }

        public bool HaveToolSelection
        {
            get
            {
                for (int i = 0; i <= WidgetToolList.Count - 1; i++)
                {
                    if (WidgetToolList[i].Active)
                        return true;
                }
                return false;
            }
        }
    }
}
