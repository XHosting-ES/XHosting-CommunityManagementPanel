using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XHostingCommunityPanel.src;
using XHostingCommunityPanel.Opciones;
using XHosting_Software;

namespace XHostingCommunityPanel.Opciones
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            string sPass = Encrypt.GetSHA256(passwordBox.Text.Trim());

            using (XHostingAPPEntities db = new XHostingAPPEntities())
            {
                var lst = from d in db.user
                          where d.gmail == usuarioBox.Text
                          && d.password == sPass
                          select d;

                if (lst.Count() >0)
                {
                    MessageBox.Show("Logueado, espera mientras cargamos el panel de administracion");
                    Admin admin = new Admin();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Este usuario no existe o contraseña incorrecta");
                }
            }
        }
    }
}
