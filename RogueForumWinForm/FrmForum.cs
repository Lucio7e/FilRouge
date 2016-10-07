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
            cbBoxCategorie.DataSource = Controller.GetAllRubriques();
        }

        private void cbBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbBoxSujet.ValueMember = "Id";
            cbBoxSujet.DisplayMember = "Titre";
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
    }
}
