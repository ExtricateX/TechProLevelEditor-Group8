using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XNALevelEditor.Forms.Add
{
    public partial class frmeditobject : Form
    {
        // Workspace
        Classes.Workspace.Manager Workspace;

        public frmeditobject()
        {
            InitializeComponent();

            // Set workspace
            MainForm frmMain = (MainForm)Application.OpenForms["frmmain"];
            Workspace = (Classes.Workspace.Manager)frmMain.WorkspaceRefrence;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmaddobject_Load(object sender, EventArgs e)
        {
            txtName.Text = "Object" + Workspace.ObjectManager.ObjectList.Count.ToString();
            for (int i = 0; i <= Workspace.ResourceManager.GraphicResource.Count - 1; i++)
            {
                cmbSprite.Items.Add(Workspace.ResourceManager.GraphicResource[i].Name);
            }
            if(cmbSprite.Items.Count > 0) cmbSprite.SelectedIndex = 0;
        }

 

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (cmbSprite.SelectedIndex > -1)
            {
                Workspace.AddObject(txtName.Text, Workspace.ResourceManager.GraphicResource[cmbSprite.SelectedIndex].Name, int.Parse(txtDepth.Text),
                    (float)Workspace.RefrenceWorkspaceParent.HorizontalScroll.Value, (float)Workspace.RefrenceWorkspaceParent.VerticalScroll.Value,
                    chkSolid.Checked, chkVisible.Checked, chkLocked.Checked,
                    Workspace.ResourceManager.GraphicResource[cmbSprite.SelectedIndex].Images);
                Workspace.RefreshObjectList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a sprite.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
