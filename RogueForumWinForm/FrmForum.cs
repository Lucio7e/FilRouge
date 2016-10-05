using RogueForumController;

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
            cbBoxSujet.DataSource = Controller.GetSujetsByRubriqueID((int)cbBoxCategorie.SelectedValue);
        }
    }
}
