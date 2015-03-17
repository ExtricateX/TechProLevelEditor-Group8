using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace XNALevelEditor
{
    public partial class MainForm : Form
    {
        #region Variables
        // Workspace
        Classes.Workspace.Manager Workspace = new Classes.Workspace.Manager();
        Bitmap WorkspaceGrid;

        // Scene
        Classes.Workspace.Scene Scene = new Classes.Workspace.Scene();

        // Widget
        Classes.Workspace.Widget Widget = new Classes.Workspace.Widget();

        // X, Y for temporary use
        float tX = 0, tY = 0, firstX = 0, firstY = 0;

        // View movement
        int moveXFactor = 1, moveYFactor = 1;

        // Cursors
        Cursor grabCursor;
        #endregion

        #region Form
        public MainForm()
        {
            InitializeComponent();

            // Set workspace
            Workspace.RefrenceMainForm = this;
            Workspace.RefrenceWorkspaceParent = mainPanel;
            Workspace.RefrenceWorkspace = picEnvironment;
            Workspace.RefrenceGameObjList = lstObjects;
            Workspace.RefrenceObjectsImageList = imgObjectList;
            Workspace.RefrenceGraphicResImageList = imgGraphicRes;
            Workspace.SceneManager = Scene;
            Workspace.WidgetManager = Widget;

            // Set scene
            Scene.Workspace = Workspace;
            Scene.Widget = Widget;

            // Set widget
            Widget.Workspace = Workspace;

           
        }

       

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Make grid
            WorkspaceGrid = Workspace.DrawGridLines(16, 16, picEnvrionmentGridColor.BackColor);
            // Set styles
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            // Set interface
            topSplitPanel.Top = topPanel.Top;
            leftPanel.Top = topPanel.Top;
            topSplitPanel.Height += topPanel.Height + 3;
            leftPanel.Height += topPanel.Height + 3;
        }
        #endregion

        #region picEnvironment
        private void picEnvironment_Paint(object sender, PaintEventArgs e)
        {
            // Draw grids
            if (!Workspace.SettingsIdentity.Setting_ShowGridOnContent)
            {
                if (WorkspaceGrid != null)
                {
                    e.Graphics.DrawImage(WorkspaceGrid, 0, 0, WorkspaceGrid.Width, WorkspaceGrid.Height);
                }
            }
            // Draw object
            Scene.DrawScene(e.Graphics, mainPanel.VerticalScroll.Value, mainPanel.HorizontalScroll.Value);
            // Draw grids
            if (Workspace.SettingsIdentity.Setting_ShowGridOnContent)
            {
                if (WorkspaceGrid != null)
                {
                    e.Graphics.DrawImage(WorkspaceGrid, 0, 0, WorkspaceGrid.Width, WorkspaceGrid.Height);
                }
            }
        }

        private void picEnvironment_MouseDown(object sender, MouseEventArgs e)
        {
            // Get first position
            firstX = e.X; firstY = e.Y;
            // Move view
            if (e.Button == MouseButtons.Middle)
            {
                picEnvironment.Cursor = grabCursor;
            }
            // Get object
            if (e.Button == MouseButtons.Left)
            {

                Scene.SelectObject(e.X, e.Y, picEnvironment.Width, picEnvironment.Height);
                if (Scene.SelectedObject != null)
                {
                    mainObjectLabel.Text = "Object: X = " + Scene.SelectedObject.X.ToString() + ", Y = " + Scene.SelectedObject.Y.ToString();
                    for (int i = 0; i <= lstObjects.Items.Count - 1; i++)
                    {
                        if (lstObjects.Items[i].Text == Scene.SelectedObject.Name)
                        {
                            lstObjects.Items[i].Selected = true;
                            lstObjects.EnsureVisible(i);
                            break;
                        }
                    }
                    if (Widget.HaveToolSelection)
                    {
                        object MethodTarget = this.Widget;
                        object[] Params = null;
                        switch (Widget.SelectedToolWidget.Name)
                        {
                            case "MoveObjectToObject":
                                if (Scene.LastSelectedObject != null)
                                {
                                    Params = new object[] { Scene.LastSelectedObjectIndex, Scene.SelectedObject };
                                    Widget.GetType().InvokeMember(Widget.SelectedToolWidget.Method, System.Reflection.BindingFlags.InvokeMethod, null, MethodTarget, Params);
                                }
                                break;
                            case "MoveObjectToGrid":
                                Params = new object[] { Scene.SelectedObjectIndex, e.X, e.Y };
                                Widget.GetType().InvokeMember(Widget.SelectedToolWidget.Method, System.Reflection.BindingFlags.InvokeMethod, null, MethodTarget, Params);
                                break;
                        }
                        if (Widget.HaveSelection && Scene.LastSelectedObject != null)
                        {
                            Scene.SelectedObject = Scene.LastSelectedObject;
                            lstObjects.Items[Scene.LastSelectedObjectIndex].Selected = true;
                            lstObjects.EnsureVisible(Scene.LastSelectedObjectIndex);
                        }
                    }
                }
                else
                {
                    if (!Widget.HaveSelection)
                    {
                        ClearFields();
                    }
                }
                picEnvironment.Invalidate();
            }
        }

        private void picEnvironment_MouseMove(object sender, MouseEventArgs e)
        {
            mainMouse.Text = "Mouse: X = " + e.X + ", Y = " + e.Y;
            // Move view
            if (e.Button == MouseButtons.Middle)
            {
                if (e.X < firstX && (mainPanel.HorizontalScroll.Value + moveXFactor) < mainPanel.HorizontalScroll.Maximum)
                    mainPanel.HorizontalScroll.Value = (mainPanel.HorizontalScroll.Value + moveXFactor);

                if (e.X > firstX && (mainPanel.HorizontalScroll.Value - moveXFactor) > 0)
                    mainPanel.HorizontalScroll.Value = (mainPanel.HorizontalScroll.Value - moveXFactor);

                if (e.Y < firstY && (mainPanel.VerticalScroll.Value + moveYFactor) < mainPanel.VerticalScroll.Maximum)
                    mainPanel.VerticalScroll.Value = (mainPanel.VerticalScroll.Value + moveYFactor);

                if (e.Y > firstY && (mainPanel.VerticalScroll.Value - moveYFactor) > 0)
                    mainPanel.VerticalScroll.Value = (mainPanel.VerticalScroll.Value - moveYFactor);
            }
            // Temporary X and Y
            tX = e.X; tY = e.Y;
            // Move object
            if (e.Button == MouseButtons.Left)
            {
                if (Scene.SelectedObject != null)
                {
                    Scene.MoveObject(e.X, e.Y);
                    mainObjectLabel.Text = "Object: X = " + Scene.SelectedObject.X.ToString() + ", Y = " + Scene.SelectedObject.Y.ToString();
                }
                picEnvironment.Invalidate();
            }
        }

        private void picEnvironment_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                picEnvironment.Cursor = DefaultCursor;
            }
        }
        #endregion

        #region mainPanel
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (Scene.SelectedObject != null)
            {
                ClearFields();
                picEnvironment.Invalidate();
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            mainMouse.Text = "Mouse: X = " + e.X + ", Y = " + e.Y;
        }
        #endregion



        #region RightTab: Resource
        private void lstGraphicRes_DoubleClick(object sender, EventArgs e)
        {

        }


        #endregion

        #region RightTab: Object
        private void lstObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstObjects.Items.Count > 0)
            {
                if (lstObjects.SelectedIndices.Count > 0)
                {
                    Scene.SelectedObject = Workspace.ObjectManager.ObjectList[lstObjects.SelectedItems[0].Index];
                    Scene.SelectedObjectIndex = lstObjects.SelectedItems[0].Index;
                    picEnvironment.Invalidate();
                }
            }
            if (lstObjects.SelectedIndices.Count == 0)
            {
                ClearFields();
                picEnvironment.Invalidate();
            }
        }

        private void cmdObjectAdd_Click(object sender, EventArgs e)
        {
            menuAddObject_Click(sender, e);
        }

        private void cmdObjectDelete_Click(object sender, EventArgs e)
        {
            if (lstObjects.SelectedIndices.Count > 0)
            {
                ClearFields();
                Workspace.RemoveObject(lstObjects.SelectedItems[0].Index);
                Workspace.RefreshObjectList();
            }
            else
            {
                MessageBox.Show("Please select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdObjectClear_Click(object sender, EventArgs e)
        {
            if (lstObjects.Items.Count > 0)
            {
                ClearFields();
                Workspace.ClearObject();
                Workspace.RefreshObjectList();
            }
            else
            {
                MessageBox.Show("There is no item to clear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        #endregion

        #region RightTab: Environment
        private void picEnvrionmentBackground_Click(object sender, EventArgs e)
        {
            dlgColor.Color = picEnvironmentBackground.BackColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                picEnvironmentBackground.BackColor = dlgColor.Color;
            }
        }

        private void cmdEnvrionmentOK_Click(object sender, EventArgs e)
        {
            // Set environment
            picEnvironment.Width = int.Parse(txtEnvrionmentEnvW.Text);
            picEnvironment.Height = int.Parse(txtEnvrionmentEnvH.Text);
            Workspace.LevelWidth = picEnvironment.Width;
            Workspace.LevelHeight = picEnvironment.Height;
            // Set background
            picEnvironment.BackColor = picEnvironmentBackground.BackColor;
            Workspace.LevelBackColor = picEnvironmentBackground.BackColor;
            // Make grid
            WorkspaceGrid = Workspace.DrawGridLines(int.Parse(txtEnvrionmentGridW.Text), int.Parse(txtEnvrionmentGridH.Text), picEnvrionmentGridColor.BackColor);
            Workspace.GridColor = picEnvrionmentGridColor.BackColor;
            // Invalidate
            picEnvironment.Invalidate();
        }

        private void picEnvironmentGridColor_Click(object sender, EventArgs e)
        {
            dlgColor.Color = picEnvrionmentGridColor.BackColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                picEnvrionmentGridColor.BackColor = dlgColor.Color;
            }
        }

        private void cmdEnvironmentRemoveOutsideObjects_Click(object sender, EventArgs e)
        {
            menuTool1_Click(sender, e);
        }
        #endregion

        #region Menu


    

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAddObject_Click(object sender, EventArgs e)
        {
            Forms.Add.frmeditobject formAddObject = new Forms.Add.frmeditobject();
            formAddObject.ShowDialog();
        }

     

        private void menuCopy_Click(object sender, EventArgs e)
        {
            if (Scene.SelectedObject != null)
            {
                Workspace.CopyObject(Scene.SelectedObjectIndex);
                Scene.SelectedObject = null;
            }
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            if (Workspace.ObjectClipboard != null)
            {
                Workspace.PasteObject(tX, tY);
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (Scene.SelectedObject != null)
            {
                ClearFields();
                Workspace.RemoveObject(Scene.SelectedObjectIndex);
            }
        }

        private void menuDeleteAll_Click(object sender, EventArgs e)
        {
            if (lstObjects.Items.Count > 0)
            {
                ClearFields();
                Workspace.ClearObject();
                Workspace.RefreshObjectList();
            }
            else
            {
                MessageBox.Show("There is no item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
      
        private void environmentMenuCutObject_Click(object sender, EventArgs e)
        {
           
        }

        private void environmentMenuCopyObject_Click(object sender, EventArgs e)
        {
            menuCopy_Click(sender, e);
        }

        private void environmentMenuPasteObject_Click(object sender, EventArgs e)
        {
            menuPaste_Click(sender, e);
        }

        private void environmentMenuDeleteObject_Click(object sender, EventArgs e)
        {
            menuDelete_Click(sender, e);
        }



        private void menuTool1_Click(object sender, EventArgs e)
        {
            if (Workspace.ObjectManager.ObjectList.Count > 0)
            {
                switch (MessageBox.Show("Are you sure, you want to remove objects outside of level?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        ClearFields();
                        Workspace.RemoveOutsideObjects();
                        break;
                }
            }
        }

        

        #endregion        


        #region LeftPanel
        private void cmdLeftPanelTool2_Click(object sender, EventArgs e)
        {
            if (topPanel.Visible)
            {
                topPanel.Visible = false;
                topSplitPanel.Top = topPanel.Top;
                leftPanel.Top = topPanel.Top;
                topSplitPanel.Height += topPanel.Height + 3;
                leftPanel.Height += topPanel.Height + 3;
      
                Widget.SetWidgetSelected("ObjectMovement", false);
                Widget.DeSelectAllWidgets();
            }
            else
            {
                topPanel.Visible = true;
                topSplitPanel.Top = topPanel.Top + topPanel.Height + 3;
                leftPanel.Top = topPanel.Top + topPanel.Height + 3;
                topSplitPanel.Height -= topPanel.Height + 3;
                leftPanel.Height -= topPanel.Height + 3;
                Widget.SetWidgetSelected("ObjectMovement", true);
            }
        }

        private void cmdLeftPanelTool1_Click(object sender, EventArgs e)
        {
            if (topPanel.Visible)
            {
                Widget.DeSelectAllWidgetTools();
            }
            ClearFields();
            picEnvironment.Invalidate();
        }
        #endregion

        #region MovementWidget
        private void cmdObjectMovementLeft_Click(object sender, EventArgs e)
        {
            if (Scene.SelectedObject != null)
            {
                Widget.MoveObject(Scene.SelectedObjectIndex, 1, "Left");
                picEnvironment.Invalidate();
            }
        }

        private void cmdObjectMovementUp_Click(object sender, EventArgs e)
        {
            if (Scene.SelectedObject != null)
            {
                Widget.MoveObject(Scene.SelectedObjectIndex, 1, "Up");
                picEnvironment.Invalidate();
            }
        }

        private void cmdObjectMovementDown_Click(object sender, EventArgs e)
        {
            if (Scene.SelectedObject != null)
            {
                Widget.MoveObject(Scene.SelectedObjectIndex, 1, "Down");
                picEnvironment.Invalidate();
            }
        }

        private void cmdObjectMovementRight_Click(object sender, EventArgs e)
        {
            if (Scene.SelectedObject != null)
            {
                Widget.MoveObject(Scene.SelectedObjectIndex, 1, "Right");
                picEnvironment.Invalidate();
            }
        }

        private void cmdObjectMovementFPO_Click(object sender, EventArgs e)
        {

        }

        private void cmdObjectMovementFPG_Click(object sender, EventArgs e)
        {

        }

        private void cmdObjectMovementFPC_Click(object sender, EventArgs e)
        {
            if (Scene.SelectedObject != null)
            {
                object MethodTarget = this.Widget;
                object[] Params = new object[] { Scene.SelectedObjectIndex, Workspace.RefrenceWorkspace };
               
                Widget.DeSelectAllWidgetTools();
                Widget.GetType().InvokeMember("Method_WidgetObjectMovement_FixPosToCen", BindingFlags.InvokeMethod, null, MethodTarget, Params);
                picEnvironment.Invalidate();
            }
        }
        #endregion

        #region Self
        // Perform inner settings
        public void PerformInnerSettings()
        {
            // Perform inner settings
            mainMouse.Visible = Workspace.SettingsIdentity.Setting_ShowStatusMouseLabel;
            mainObjectLabel.Visible = Workspace.SettingsIdentity.Setting_ShowStatusObjectLabel;
        }

        // Set environment by properties
        public void SetEnvironmentByProperties()
        {
            // Set environment
            txtEnvrionmentEnvW.Text = Workspace.LevelWidth.ToString();
            txtEnvrionmentEnvH.Text = Workspace.LevelHeight.ToString();
            txtEnvrionmentGridW.Text = Workspace.GridWidth.ToString();
            txtEnvrionmentGridH.Text = Workspace.GridHeight.ToString();
            picEnvironmentBackground.BackColor = Workspace.LevelBackColor;
            picEnvrionmentGridColor.BackColor = Workspace.GridColor;
            // Set level size
            picEnvironment.Width = int.Parse(txtEnvrionmentEnvW.Text);
            picEnvironment.Height = int.Parse(txtEnvrionmentEnvH.Text);
            // Set background
            picEnvironment.BackColor = picEnvironmentBackground.BackColor;
            // Make grid
            WorkspaceGrid = Workspace.DrawGridLines(int.Parse(txtEnvrionmentGridW.Text), int.Parse(txtEnvrionmentGridH.Text), picEnvrionmentGridColor.BackColor);
            // Invalidate
            picEnvironment.Invalidate();
        }

        // Reset environment
        public void ResetEnvorinment()
        {
            ClearFields();
            
            // Reset environment
            tabRight.SelectedIndex = 0;
            txtEnvrionmentEnvW.Text = "550";
            txtEnvrionmentEnvH.Text = "400";
            txtEnvrionmentGridW.Text = "20";
            txtEnvrionmentGridH.Text = "20";
            picEnvironmentBackground.BackColor = Color.White;
            picEnvrionmentGridColor.BackColor = Color.LightGray;
            // DeSelect widgets
            if (topPanel.Visible)
            {
                topPanel.Visible = false;
                topSplitPanel.Top = topPanel.Top;
                leftPanel.Top = topPanel.Top;
                topSplitPanel.Height += topPanel.Height + 3;
                leftPanel.Height += topPanel.Height + 3;
                Widget.DeSelectAllWidgets();
                Widget.DeSelectAllWidgetTools();
            }
            // Make grid
            WorkspaceGrid = Workspace.DrawGridLines(Workspace.GridWidth, Workspace.GridHeight, picEnvrionmentGridColor.BackColor);
            // Redraw
            picEnvironment.Invalidate();
        }



        // Clear fields
        private void ClearFields()
        {
            mainObjectLabel.Text = "Object: X = 0, Y = 0";
            Scene.SelectedObject = null;
        }

        // Properties
        public object WorkspaceRefrence
        {
            get { return this.Workspace; }
        }
        #endregion

        private void btnBottomTitle1_Load(object sender, EventArgs e)
        {

        }
    }
}
