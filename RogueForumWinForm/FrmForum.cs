﻿using System;
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
    }
}