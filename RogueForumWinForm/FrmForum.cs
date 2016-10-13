using RogueForumController;

using RogueForumDLL;
using System;
using System.Collections;
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
    public partial class FrmForum : Form
    {
        public FrmForum()
        {
            InitializeComponent();
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIdent_Click(object sender, EventArgs e)
        {
            using (FrmLogin frmLogin = new FrmLogin())
            {
                frmLogin.ShowDialog();
            }
        }

        private void FrmForum_Load(object sender, EventArgs e)
        {
            cbBoxCategorie.ValueMember = "Id";
            cbBoxCategorie.DisplayMember = "Libelle";

            cbBoxSujet.ValueMember = "Id";
            cbBoxSujet.DisplayMember = "Titre";

            cbBoxCategorie.DataSource = Controller.GetAllRubriques();
            cbBoxSujet.DataSource = Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue);
        }

        private void cbBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue) != null)
            {
               
                cbBoxSujet.DataSource = Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue);
            }else
            {
                Sujet s = new Sujet(0, "Pas de sujet");
                List<Sujet> ss = new List<Sujet>();
                ss.Add(s);
                cbBoxSujet.DataSource = ss;
                                
            }
            
        }

        private void cbBoxSujet_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Reponse> reponses = new List<Reponse>();
            //Todo Rajouter ELSE
            if (Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue)!= null)
            {
                reponses = Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue);
                
            }else
            {
                reponses.Add(new Reponse(0, "Pas de réponses"));
            }
            dataGridViewReponse.DataSource = reponses;
            dataGridViewReponse.Columns.Remove("ID");
            dataGridViewReponse.Columns.Remove("SUJET");
            dataGridViewReponse.Columns.Remove("UTILISATEUR");
        }

        private void FrmForum_Activated(object sender, EventArgs e)
        {
            panelAddSujet.Visible = frmMain.IsConnected;
            btnChangerMDP.Visible = frmMain.IsConnected;
            btnDeconnexion.Visible = frmMain.IsConnected;
            grpBoxAdmin.Visible = frmMain.IsModo;
            btnIdent.Visible = !frmMain.IsConnected;
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmMain.IsConnected = false;
            frmMain.IsModo = false;
            MessageBox.Show("Deconnecté avec succès", "Deconnexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddSujet_Click(object sender, EventArgs e)
        {
            using (FrmAddSujet frmAddSujet = new FrmAddSujet())
            {
                frmAddSujet.rubrique = (Rubrique)cbBoxCategorie.SelectedItem;
                frmAddSujet.ShowDialog();
                cbBoxSujet.DataSource = Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue);
            }
        }

        private void btnPostRep_Click(object sender, EventArgs e)
        {
            using (frmAddReponse frmAddReponse = new frmAddReponse())
            {
                frmAddReponse.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmAddReponse.ShowDialog();
                dataGridViewReponse.DataSource = Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue);
            }
        }
    }
}
