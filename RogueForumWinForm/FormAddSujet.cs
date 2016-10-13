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
    public partial class FrmAddSujet : Form
    {
        internal Rubrique rubrique;
        public FrmAddSujet()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.Resources.MsgBoxCancelText, Properties.Resources.MsgBoxCancelTitre,MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                this.Close();

            }
            
        }

        private void btnAddSujet_Click(object sender, EventArgs e)
        {
           if( RogueForumController.Controller.AddSujet(frmMain.CurrentUser.Id,rubrique.Id, txtBoxTitreSujet.Text, txtBoxDescSujet.Text) == 1){
                MessageBox.Show("Le sujet a été ajouté avec succès");

                this.Close();
            }else
            {
                MessageBox.Show("Impossible d'ajouter un sujet");
            }
        }
    }
}
