﻿using RogueForumController;

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

        #region Click event
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
            visibiliteAdmin();
        }
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmMain.IsConnected = false;
            frmMain.IsModo = false;
            MessageBox.Show(Properties.Resources.MsgBoxDeconnexionText, Properties.Resources.MsgBoxDeconnexionTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
            visibiliteAdmin();
        }

        private void btnAddSujet_Click(object sender, EventArgs e)
        {
            using (FrmAddSujet frmAddSujet = new FrmAddSujet())
            {
                frmAddSujet.rubrique = (Rubrique)cbBoxCategorie.SelectedItem;
                frmAddSujet.Text = string.Format("Ajouter un sujet dans la rubrique {0}", frmAddSujet.rubrique.Libelle);
                frmAddSujet.ShowDialog();
                fillComboBoxSujet(Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue));
            }
        }

        private void btnPostRep_Click(object sender, EventArgs e)
        {
            using (frmAddReponse frmAddReponse = new frmAddReponse())
            {
                frmAddReponse.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmAddReponse.Text = string.Format("Poster une réponse au sujet {0}", frmAddReponse.sujet.Titre);
                frmAddReponse.ShowDialog();
               fillDataGridReponses(Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue));
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
                List<Sujet> sujets = Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue);
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
                frmEditSujet.rubrique = (Rubrique)cbBoxCategorie.SelectedItem;
                frmEditSujet.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmEditSujet.Text = string.Format("Modifier le sujet {0} dans la rubrique {1}",frmEditSujet.sujet.Titre, frmEditSujet.rubrique.Libelle);
                
                frmEditSujet.ShowDialog();
                fillComboBoxSujet(Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue));
            }
        }
        #endregion
        #endregion

        #region FormLoad & FormActivate
        private void FrmForum_Load(object sender, EventArgs e)
        {
            fillComboboxCategorie(Controller.GetAllRubriques());
            fillComboBoxSujet( Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue));
            visibiliteAdmin();
        }
        #endregion

        #region IndexChange event
        private void cbBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Sujet> sujets = Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue);
            if ( sujets != null)
            {
                turnPanelSujetVisible();
                fillComboBoxSujet(sujets);
            }
            else
            {
                turnPanelSujetInvisible();
            }
        }

        private void cbBoxSujet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (visibiliteSujets())
            {
                turnPanelSujetVisible();
                Sujet sujet = (Sujet)cbBoxSujet.SelectedItem;
                txtBoxDescSujet.Text = sujet.Desc;
                if (visibiliteReponses())
                {
                    turnPanelReponseVisible();
                    List<Reponse> reponses = Controller.GetAllReponsesBySujetID((int)cbBoxSujet.SelectedValue);
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
            
            
        }

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
        }

        private void turnPanelReponseInvisible()
        {
            dataGridViewReponse.Visible = false;
            lblNoReponse.Visible = true;
            btnSupprReponse.Enabled = false;
            
        }

        private bool visibiliteSujets()
        {
            if(cbBoxCategorie.SelectedIndex != -1)
            {
                if (Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue) != null)
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
        }

        private void turnPanelSujetInvisible()
        {
            btnSupprSujet.Enabled = false;
            btnEditSujet.Enabled = false;
            cbBoxSujet.Visible = false;
            lblNoSujet.Visible = true;
            grpBoxDescSujet.Visible = false;
            turnPanelReponseInvisible();
        }

        private void visibiliteAdmin()
        {
                panelAddSujet.Visible = frmMain.IsConnected;
                btnChangerMDP.Visible = frmMain.IsConnected;
                btnDeconnexion.Visible = frmMain.IsConnected;
                grpBoxAdmin.Visible = frmMain.IsModo;
                btnIdent.Visible = !frmMain.IsConnected;
            
        }
        #endregion

        #region Fill ComboBox et Datagrid
        private void fillComboBoxSujet(List<Sujet> sujets)
        {
            cbBoxSujet.ValueMember = "Id";
            cbBoxSujet.DisplayMember = "Titre";
            cbBoxSujet.DataSource = sujets;
            Sujet sujet = (Sujet)cbBoxSujet.SelectedItem;
            txtBoxDescSujet.Text = sujet.Desc;
        }

        private void fillComboboxCategorie(List<Rubrique> rubriques)
        {
            cbBoxCategorie.ValueMember = "Id";
            cbBoxCategorie.DisplayMember = "Libelle";
            cbBoxCategorie.DataSource = rubriques;
        }

        private void fillDataGridReponses(List<Reponse> reponses)
        {
            dataGridViewReponse.DataSource = reponses;
            dataGridViewReponse.Columns["ID"].Visible = false;
            dataGridViewReponse.Columns["SUJET"].Visible = false;
            dataGridViewReponse.Columns["UTILISATEUR"].Visible = false;
        }

        #endregion

        

        private void dataGridViewReponse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexCurrentRow = e.RowIndex;
            DataGridViewRow row = dataGridViewReponse.Rows[indexCurrentRow];
            using (FrmReponse frmReponse = new FrmReponse())
            {
                frmReponse.txtBoxReponse.Text = row.Cells["Texte"].Value.ToString();
                frmReponse.ShowDialog();
            }
        }
    }
}
