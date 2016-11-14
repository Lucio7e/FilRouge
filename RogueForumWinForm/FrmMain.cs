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
    public partial class frmMain : Form
    {
        static internal bool IsConnected;
        static internal bool IsModo;
        static internal Utilisateur CurrentUser;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEnterForum_Click(object sender, EventArgs e)
        {
            using (FrmForum frmForum = new FrmForum())
            {
                Cursor.Current = Cursors.WaitCursor;
                frmForum.ShowDialog();
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
