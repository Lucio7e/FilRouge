namespace RogueForumWinForm
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabLayPanLogin = new System.Windows.Forms.TableLayoutPanel();
            this.tabLayPanUsername = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.tabLayPanPwd = new System.Windows.Forms.TableLayoutPanel();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtBoxPwd = new System.Windows.Forms.TextBox();
            this.tabLayPanConn = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabLayPanLogin.SuspendLayout();
            this.tabLayPanUsername.SuspendLayout();
            this.tabLayPanPwd.SuspendLayout();
            this.tabLayPanConn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayPanLogin
            // 
            this.tabLayPanLogin.ColumnCount = 1;
            this.tabLayPanLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPanLogin.Controls.Add(this.tabLayPanUsername, 0, 1);
            this.tabLayPanLogin.Controls.Add(this.tabLayPanPwd, 0, 2);
            this.tabLayPanLogin.Controls.Add(this.tabLayPanConn, 0, 3);
            this.tabLayPanLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanLogin.Location = new System.Drawing.Point(0, 0);
            this.tabLayPanLogin.Name = "tabLayPanLogin";
            this.tabLayPanLogin.RowCount = 4;
            this.tabLayPanLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5902F));
            this.tabLayPanLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.349666F));
            this.tabLayPanLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.349666F));
            this.tabLayPanLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.1559F));
            this.tabLayPanLogin.Size = new System.Drawing.Size(327, 449);
            this.tabLayPanLogin.TabIndex = 0;
            // 
            // tabLayPanUsername
            // 
            this.tabLayPanUsername.ColumnCount = 2;
            this.tabLayPanUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanUsername.Controls.Add(this.txtBoxUsername, 0, 0);
            this.tabLayPanUsername.Controls.Add(this.lblUsername, 0, 0);
            this.tabLayPanUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanUsername.Location = new System.Drawing.Point(3, 72);
            this.tabLayPanUsername.Name = "tabLayPanUsername";
            this.tabLayPanUsername.RowCount = 1;
            this.tabLayPanUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanUsername.Size = new System.Drawing.Size(321, 26);
            this.tabLayPanUsername.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(154, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Nom d\'utilisateur :";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxUsername.Location = new System.Drawing.Point(163, 3);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(155, 20);
            this.txtBoxUsername.TabIndex = 3;
            // 
            // tabLayPanPwd
            // 
            this.tabLayPanPwd.ColumnCount = 2;
            this.tabLayPanPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanPwd.Controls.Add(this.txtBoxPwd, 0, 0);
            this.tabLayPanPwd.Controls.Add(this.lblPwd, 0, 0);
            this.tabLayPanPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanPwd.Location = new System.Drawing.Point(3, 104);
            this.tabLayPanPwd.Name = "tabLayPanPwd";
            this.tabLayPanPwd.RowCount = 1;
            this.tabLayPanPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanPwd.Size = new System.Drawing.Size(321, 26);
            this.tabLayPanPwd.TabIndex = 1;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPwd.Location = new System.Drawing.Point(3, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(154, 26);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Mot de passe :";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPwd
            // 
            this.txtBoxPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPwd.Location = new System.Drawing.Point(163, 3);
            this.txtBoxPwd.Name = "txtBoxPwd";
            this.txtBoxPwd.Size = new System.Drawing.Size(155, 20);
            this.txtBoxPwd.TabIndex = 4;
            // 
            // tabLayPanConn
            // 
            this.tabLayPanConn.ColumnCount = 3;
            this.tabLayPanConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tabLayPanConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.34694F));
            this.tabLayPanConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tabLayPanConn.Controls.Add(this.btnConnect, 1, 1);
            this.tabLayPanConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanConn.Location = new System.Drawing.Point(3, 136);
            this.tabLayPanConn.Name = "tabLayPanConn";
            this.tabLayPanConn.RowCount = 3;
            this.tabLayPanConn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.97521F));
            this.tabLayPanConn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.02479F));
            this.tabLayPanConn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tabLayPanConn.Size = new System.Drawing.Size(321, 310);
            this.tabLayPanConn.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.Location = new System.Drawing.Point(55, 80);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(210, 38);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Se connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 449);
            this.Controls.Add(this.tabLayPanLogin);
            this.Name = "FrmLogin";
            this.Text = "Connectez vous";
            this.tabLayPanLogin.ResumeLayout(false);
            this.tabLayPanUsername.ResumeLayout(false);
            this.tabLayPanUsername.PerformLayout();
            this.tabLayPanPwd.ResumeLayout(false);
            this.tabLayPanPwd.PerformLayout();
            this.tabLayPanConn.ResumeLayout(false);
            this.tabLayPanConn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayPanLogin;
        private System.Windows.Forms.TableLayoutPanel tabLayPanUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TableLayoutPanel tabLayPanPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtBoxPwd;
        private System.Windows.Forms.TableLayoutPanel tabLayPanConn;
        private System.Windows.Forms.Button btnConnect;
    }
}