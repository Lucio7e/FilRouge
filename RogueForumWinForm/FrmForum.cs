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
           
            if (Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue)!= null)
            {
                dataGridViewReponse.Visible = true;
                lblNoReponse.Visible = !dataGridViewReponse.Visible;

                reponses = Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue);
                dataGridViewReponse.DataSource = reponses;
                dataGridViewReponse.Columns["ID"].Visible = false;
                dataGridViewReponse.Columns["SUJET"].Visible = false;
                dataGridViewReponse.Columns["UTILISATEUR"].Visible = false;

            }
            else
            {
                dataGridViewReponse.Visible = false;
                lblNoReponse.Visible = !dataGridViewReponse.Visible;
            }
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
            MessageBox.Show(Properties.Resources.MsgBoxDeconnexionText, Properties.Resources.MsgBoxDeconnexionTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddSujet_Click(object sender, EventArgs e)
        {
            using (FrmAddSujet frmAddSujet = new FrmAddSujet())
            {
                frmAddSujet.rubrique = (Rubrique)cbBoxCategorie.SelectedItem;
                frmAddSujet.Text = string.Format("Ajouter un sujet dans la rubrique {0}",frmAddSujet.rubrique.Libelle);
                frmAddSujet.ShowDialog();
                cbBoxSujet.DataSource = Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue);
            }
        }

        private void btnPostRep_Click(object sender, EventArgs e)
        {
            using (frmAddReponse frmAddReponse = new frmAddReponse())
            {
                frmAddReponse.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmAddReponse.Text = string.Format("Poster une réponse au sujet {0}", frmAddReponse.sujet.Titre); 
                frmAddReponse.ShowDialog();
                dataGridViewReponse.DataSource = Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue);
            }
        }

        private void btnSupprSujet_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr =MessageBox.Show(Properties.Resources.MsgBoxSupprSujetText, Properties.Resources.MsgBoxSupprSujetTitre, MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if(dr == DialogResult.OK)
            {
               if( Controller.DeleteSujet((int)cbBoxSujet.SelectedValue) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurSupprSujetText, Properties.Resources.MsgBoxErreurSupprSujetTitre);
                }
                cbBoxSujet.DataSource = Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue);
            }
        }

        private void btnSupprReponse_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxSupprSujetText, Properties.Resources.MsgBoxSupprSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                if (Controller.DeleteReponseByReponseID((int)dataGridViewReponse.CurrentRow.Cells["ID"].Value) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurSupprSujetText, Properties.Resources.MsgBoxErreurSupprSujetTitre);
                }
                dataGridViewReponse.DataSource = Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue);

            }
        }
    }
}
