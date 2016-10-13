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
    public partial class frmAddReponse : Form
    {
        internal Sujet sujet;
        public frmAddReponse()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.Resources.MsgBoxCancelText, Properties.Resources.MsgBoxCancelTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void btnAddReponse_Click(object sender, EventArgs e)
        {
            if (RogueForumController.Controller.AddReponse(frmMain.CurrentUser.Id, sujet.Id, txtBoxReponse.Text) == 1)
            {
                MessageBox.Show("Votre réponse a été postée avec succés");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Impossible d'ajouter une réponse");
            }
        }
    }
}
