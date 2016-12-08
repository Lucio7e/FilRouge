
using RogueForumDLL;
using RogueForumMetierPortable;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        #region Click event
        /// <summary>
        /// Evenement clic sur le logo du forum qui permet de revenir à l'écran d'accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evenement clic sur le bouton d'identification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIdent_Click(object sender, EventArgs e)
        {
            using (FrmLogin frmLogin = new FrmLogin())
            {
                frmLogin.ShowDialog();
            }
            visibiliteAdmin();
        }
        /// <summary>
        /// Evenement clic sur le bouton déconnexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmMain.IsConnected = false;
            frmMain.IsModo = false;
            //Affichage d'un message de succès de la déconnexion
            MessageBox.Show(Properties.Resources.MsgBoxDeconnexionText, Properties.Resources.MsgBoxDeconnexionTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
            visibiliteAdmin();
        }
        /// <summary>
        /// Evenement clic sur le bouton d'ajout de sujet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSujet_Click(object sender, EventArgs e)
        {
            using (FrmAddSujet frmAddSujet = new FrmAddSujet())
            {
                frmAddSujet.rubrique = (Rubrique)cbBoxRubrique.SelectedItem;
                frmAddSujet.Text = string.Format("Ajouter un sujet dans la rubrique {0}", frmAddSujet.rubrique.Libelle);
                frmAddSujet.ShowDialog();                
                fillComboBoxSujet(Controller.GetSujetsByRubriqueID((int)cbBoxRubrique.SelectedValue));
            }
        }
        /// <summary>
        /// Evenement clic sur le bouton "Poster une réponse"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPostRep_Click(object sender, EventArgs e)
        {
            using (frmAddReponse frmAddReponse = new frmAddReponse())
            {
                frmAddReponse.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmAddReponse.Text = string.Format("Poster une réponse au sujet {0}", frmAddReponse.sujet.Titre);
                frmAddReponse.ShowDialog();
                fillDataGridReponses(Controller.GetTop10ReponsesBySujetID((int)cbBoxSujet.SelectedValue));
            }
            
        }

        private void dataGridViewReponse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int indexCurrentRow = e.RowIndex;
            DataGridViewRow row = dataGridViewReponse.Rows[indexCurrentRow];
            
            using (FrmReponse frmReponse = new FrmReponse())
            {
               
                frmReponse.txtBoxReponse.Text = row.Cells["Texte"].Value.ToString();
                frmReponse.lblNomAuteur.Text += row.Cells["NomAuteur"].Value.ToString();
                frmReponse.lblDatePost.Text += row.Cells["Date"].Value.ToString();

                frmReponse.ShowDialog();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnChangerMDP_Click(object sender, EventArgs e)
        {
            using (FrmModifierMDP frmModifMDP = new FrmModifierMDP())
            {
                frmModifMDP.ShowDialog();
            }
        }

        #region Methode admin
        private void btnSupprSujet_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxSupprSujetText, Properties.Resources.MsgBoxSupprSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                if (Controller.DeleteSujet((int)cbBoxSujet.SelectedValue) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurSupprSujetText, Properties.Resources.MsgBoxErreurSupprSujetTitre);
                }
                List<Sujet> sujets = Controller.GetSujetsByRubriqueID((int)cbBoxRubrique.SelectedValue);
                if (sujets != null)
                {
                    fillComboBoxSujet(sujets);
                }
            }
            if (visibiliteSujets())
            {
                turnPanelSujetVisible();
            }
            else
            {
                turnPanelSujetInvisible();
            }
        }

        private void btnSupprReponse_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxSupprReponseText, Properties.Resources.MsgBoxSupprReponseTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                if (Controller.DeleteReponseByReponseID((int)dataGridViewReponse.CurrentRow.Cells["ID"].Value) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxSupprReponseText, Properties.Resources.MsgBoxSupprReponseTitre);
                }
                List<Reponse> reponses = Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue);
                if (reponses != null)
                {
                    fillDataGridReponses(reponses);
                }
            }
            if (visibiliteReponses())
            {
                turnPanelReponseVisible();
            }
            else { turnPanelReponseInvisible(); }
        }

        private void btnEditSujet_Click(object sender, EventArgs e)
        {
            using (FrmAddSujet frmEditSujet = new FrmAddSujet())
            {
                frmEditSujet.rubrique = (Rubrique)cbBoxRubrique.SelectedItem;
                frmEditSujet.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmEditSujet.Text = string.Format("Modifier le sujet {0} dans la rubrique {1}",frmEditSujet.sujet.Titre, frmEditSujet.rubrique.Libelle);
                
                frmEditSujet.ShowDialog();
                fillComboBoxSujet(Controller.GetSujetsByRubriqueID((int)cbBoxRubrique.SelectedValue));
            }
        }
        #endregion
        #endregion

        #region FormLoad 
        private void FrmForum_Load(object sender, EventArgs e)
        {
            fillComboboxRubrique(Controller.GetAllRubriques());
            fillComboBoxSujet(Controller.GetSujetsByRubriqueID((int)cbBoxRubrique.SelectedValue));
            ComboBoxSujet_CommitSelection();
            visibiliteAdmin();

        }
        #endregion

        #region IndexChange event

        private void dataGridViewReponse_SelectionChanged(object sender, EventArgs e)
        {
            if (visibiliteReponses())
            {
                turnPanelReponseVisible();
            }
            else
            {
                turnPanelReponseInvisible();
            }
        }
        #endregion

        #region Methodes de visibilite
        private bool visibiliteReponses()
        {
            if(cbBoxSujet.SelectedIndex != -1) {
                if (Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue) != null)
                {
                    return true;
                }
            }
            return false;
        }

        private void turnPanelReponseVisible()
        {
            dataGridViewReponse.Visible = true;
            lblNoReponse.Visible = false;
            btnSupprReponse.Enabled = true;           
            posterUneRéponseToolStripMenuItem.Enabled = ajouterUnSujetToolStripMenuItem.Visible;
        }

        private void turnPanelReponseInvisible()
        {
            dataGridViewReponse.Visible = false;
            lblNoReponse.Visible = true;
            btnSupprReponse.Enabled = false;
            ajouterUnSujetToolStripMenuItem.Enabled = dataGridViewReponse.Visible;
            posterUneRéponseToolStripMenuItem.Enabled = ajouterUnSujetToolStripMenuItem.Visible;
        }

        private bool visibiliteSujets()
        {
            if(cbBoxRubrique.SelectedIndex != -1)
            {
                if (Controller.GetSujetsByRubriqueID((int)cbBoxRubrique.SelectedValue) != null)
                {
                    return true;
                }
            }
            return false;
        }
        private void turnPanelSujetVisible()
        {
            btnSupprSujet.Enabled = true;
            btnEditSujet.Enabled = true;
            cbBoxSujet.Visible = true;
            lblNoSujet.Visible = false;
            grpBoxDescSujet.Visible = true;
            modifierUnSujetToolStripMenuItem.Enabled = btnEditSujet.Visible;
            supprimerLeSujetToolStripMenuItem.Enabled = btnSupprSujet.Visible;
        }

        private void turnPanelSujetInvisible()
        {
            btnSupprSujet.Enabled = false;
            btnEditSujet.Enabled = false;
            cbBoxSujet.Visible = false;
            lblNoSujet.Visible = true;
            grpBoxDescSujet.Visible = false;
            modifierUnSujetToolStripMenuItem.Enabled = btnEditSujet.Visible;
            supprimerLeSujetToolStripMenuItem.Enabled = btnSupprSujet.Visible;
            turnPanelReponseInvisible();
        }

        private void visibiliteAdmin()
        {
            panelAddSujet.Visible = frmMain.IsConnected;
            btnChangerMDP.Visible = frmMain.IsConnected;
            btnDeconnexion.Visible = frmMain.IsConnected;
            grpBoxAdmin.Visible = frmMain.IsModo;
            btnIdent.Visible = !frmMain.IsConnected;
            changerMotDePasseToolStripMenuItem.Enabled = frmMain.IsConnected;
            déconnecterVousToolStripMenuItem.Enabled = frmMain.IsConnected;
            ajouterUnSujetToolStripMenuItem.Enabled = frmMain.IsConnected;
            modifierUnSujetToolStripMenuItem.Enabled = frmMain.IsModo;
            supprimerLeSujetToolStripMenuItem.Enabled = frmMain.IsModo;
            supprimerLaRéponseToolStripMenuItem.Enabled = frmMain.IsModo;
            posterUneRéponseToolStripMenuItem.Enabled = frmMain.IsConnected;
        }
        #endregion

        #region Fill ComboBox et Datagrid
        private void fillComboBoxSujet(List<Sujet> sujets)
        {
            cbBoxSujet.ValueMember = "Id";
            cbBoxSujet.DisplayMember = "Titre";
            cbBoxSujet.DataSource = sujets;
            Sujet sujet = (Sujet)cbBoxSujet.SelectedItem;
            txtBoxDescSujet.Text = sujet.Desc+ Environment.NewLine + "posté par : " + sujet.Utilisateur.Login + Environment.NewLine + "Le : " + sujet.Date;
        }

        private void fillComboboxRubrique(List<Rubrique> rubriques)
        {
                cbBoxRubrique.ValueMember = "Id";
                cbBoxRubrique.DisplayMember = "Libelle";
                cbBoxRubrique.DataSource = rubriques;
         }
       
       
        private void fillDataGridReponses(List<Reponse> reponses)
        {
            dataGridViewReponse.DataSource = reponses;
            dataGridViewReponse.Columns["ID"].Visible = false;
            dataGridViewReponse.Columns["SUJET"].Visible = false;
            dataGridViewReponse.Columns["UTILISATEUR"].Visible = false;
        }


        #endregion

        private void cbBoxRubrique_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboRubrique_CommitSelection();
            ComboBoxSujet_CommitSelection();
        }

        private void cbBoxSujet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxSujet_CommitSelection();
        }

        private void ComboBoxSujet_CommitSelection()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (visibiliteSujets())
            {
                turnPanelSujetVisible();
                Sujet sujet = (Sujet)cbBoxSujet.SelectedItem;
                txtBoxDescSujet.Text = sujet.Desc + Environment.NewLine + "posté par : " + sujet.NomAuteur;
                if (visibiliteReponses())
                {
                    turnPanelReponseVisible();
                    List<Reponse> reponses = sujet.Reponses;
                    if (reponses != null)
                    {
                        fillDataGridReponses(reponses);
                    }
                }
                else
                {
                    turnPanelReponseInvisible();
                }
            }
            else
            {
                turnPanelSujetInvisible();
            }
            Cursor.Current = Cursors.Default;
        }
        
        private void ComboRubrique_CommitSelection()
        {
            Cursor.Current = Cursors.WaitCursor;
            //stocke dans une Liste de sujets le resultats de l'appel de la méthode GetSujetByRubrique
            List<Sujet> sujets = Controller.GetSujetsByRubriqueID((int)cbBoxRubrique.SelectedValue);
            //On verifie que la liste des sujets n'est pas vide
            if (sujets != null)
            {
                turnPanelSujetVisible();
                //On rempli la comboBox des sujets avec la liste
                fillComboBoxSujet(sujets);
            }
            else
            {
                turnPanelSujetInvisible();
            }
            Cursor.Current = Cursors.Default;
        }

      
    }
}
