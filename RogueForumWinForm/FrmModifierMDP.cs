using RogueForumDAO;
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
    public partial class FrmModifierMDP : Form
    {
        public FrmModifierMDP()
        {
            InitializeComponent();
        }

        private void txtBoxMDP_TextChanged(object sender, EventArgs e)
        {
            btnValidMDP.Enabled =  !(string.IsNullOrWhiteSpace(txtBoxMDP.Text) || string.IsNullOrWhiteSpace(txtBoxVerifMDP.Text)) && txtBoxMDP.Text==txtBoxVerifMDP.Text;
            lblError.Visible = txtBoxMDP.Text != txtBoxVerifMDP.Text;
        }

        private void txtBoxVerifMDP_TextChanged(object sender, EventArgs e)
        {
            btnValidMDP.Enabled = !(string.IsNullOrWhiteSpace(txtBoxMDP.Text) || string.IsNullOrWhiteSpace(txtBoxVerifMDP.Text)) && txtBoxMDP.Text == txtBoxVerifMDP.Text;
            lblError.Visible = txtBoxMDP.Text != txtBoxVerifMDP.Text;
        }

        private void btnValidMDP_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr= MessageBox.Show(Properties.Resources.MsgBoxConfirmerChangementMDPTexte, Properties.Resources.MsgBoxConfirmerChangementMDPTitre, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                RogueForumController.Controller.ChangeMDP(frmMain.CurrentUser.Id, txtBoxMDP.Text);
                this.Close();
            }
        }
    }
}
