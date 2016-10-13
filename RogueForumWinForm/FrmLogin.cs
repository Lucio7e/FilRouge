using RogueForumDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogueForumWinForm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           frmMain.CurrentUser = RogueForumController.Controller.Login(txtBoxUsername.Text, txtBoxPwd.Text);
            if (frmMain.CurrentUser != null)
            {
                frmMain.IsConnected = true;
                frmMain.IsModo = frmMain.CurrentUser.IsModo;
                this.Close();
            }
            else
            {
                 frmMain.IsConnected = false;
                MessageBox.Show("Login ou mot de passe incorrect", "Erreur d'identification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
