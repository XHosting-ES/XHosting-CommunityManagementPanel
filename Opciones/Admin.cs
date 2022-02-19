using System;
using System.Windows.Forms;
using XHostingCommunityPanel.Opciones.AdminLayouts;

namespace XHostingCommunityPanel.Opciones
{
    public partial class Admin : Form
    {
        private Form currentChildForm2;
        public Admin()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        public void OpenChildForm2(Form childForm)
        {
            if (currentChildForm2 != null)
            {
                currentChildForm2.Close();
            }
            currentChildForm2 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void user_managementButton_Click(object sender, EventArgs e)
        {
            OpenChildForm2(new UserManagement());
        }
    }
}
