
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
using RogueForumMetierPortable;
namespace RogueForumWinForm
{
    public partial class FrmAddSujet : Form
    {
        internal Rubrique rubrique;
        internal Sujet sujet;
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
          if(sujet == null) { 
                if (Controller.AddSujet(frmMain.CurrentUser.Id, rubrique.Id, txtBoxTitreSujet.Text, txtBoxDescSujet.Text) == 1)
                {
                    MessageBox.Show("Le sujet a été ajouté avec succès");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Impossible d'ajouter un sujet");
                }
            }else
            {
                if (Controller.EditSujet(sujet.Id,sujet.Titre,sujet.Desc, txtBoxTitreSujet.Text, txtBoxDescSujet.Text) == 1)
                {
                    MessageBox.Show("Le sujet a été modifié avec succés");
                    this.Close();
                }else
                {
                    MessageBox.Show("Une erreur s'est produite lors de la modification du sujet");
                }
            }
        }

        private void FrmAddSujet_Load(object sender, EventArgs e)
        {
            if(sujet == null)
            {
                txtBoxTitreSujet.Text = string.Empty;
                txtBoxDescSujet.Text = string.Empty;
                btnAddSujet.Text = "Valider l'ajout du sujet";
            }else
            {
                txtBoxTitreSujet.Text = sujet.Titre;
                txtBoxDescSujet.Text = sujet.Desc;
                btnAddSujet.Text = "Valider la modification du sujet";
            }
        }
    }
}
