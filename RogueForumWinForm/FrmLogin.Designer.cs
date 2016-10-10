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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tabLayPanLogin = new System.Windows.Forms.TableLayoutPanel();
            this.tabLayPanUsername = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxUsername = new System.Windows.Forms.GroupBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.tabLayPanPwd = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxMDP = new System.Windows.Forms.GroupBox();
            this.txtBoxPwd = new System.Windows.Forms.TextBox();
            this.tabLayPanConn = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabLayPanLogin.SuspendLayout();
            this.tabLayPanUsername.SuspendLayout();
            this.grpBoxUsername.SuspendLayout();
            this.tabLayPanPwd.SuspendLayout();
            this.grpBoxMDP.SuspendLayout();
            this.tabLayPanConn.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tabLayPanLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tabLayPanLogin.Name = "tabLayPanLogin";
            this.tabLayPanLogin.RowCount = 4;
            this.tabLayPanLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tabLayPanLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tabLayPanLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.tabLayPanLogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayPanLogin.Size = new System.Drawing.Size(501, 629);
            this.tabLayPanLogin.TabIndex = 0;
            // 
            // tabLayPanUsername
            // 
            this.tabLayPanUsername.ColumnCount = 1;
            this.tabLayPanUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanUsername.Controls.Add(this.grpBoxUsername, 0, 0);
            this.tabLayPanUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanUsername.Location = new System.Drawing.Point(4, 61);
            this.tabLayPanUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tabLayPanUsername.Name = "tabLayPanUsername";
            this.tabLayPanUsername.RowCount = 1;
            this.tabLayPanUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanUsername.Size = new System.Drawing.Size(493, 60);
            this.tabLayPanUsername.TabIndex = 0;
            // 
            // grpBoxUsername
            // 
            this.grpBoxUsername.Controls.Add(this.txtBoxUsername);
            this.grpBoxUsername.Location = new System.Drawing.Point(110, 4);
            this.grpBoxUsername.Margin = new System.Windows.Forms.Padding(110, 4, 110, 4);
            this.grpBoxUsername.Name = "grpBoxUsername";
            this.grpBoxUsername.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxUsername.Size = new System.Drawing.Size(273, 52);
            this.grpBoxUsername.TabIndex = 0;
            this.grpBoxUsername.TabStop = false;
            this.grpBoxUsername.Text = "Nom d\'utilisateur :";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsername.Location = new System.Drawing.Point(4, 22);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(265, 24);
            this.txtBoxUsername.TabIndex = 4;
            // 
            // tabLayPanPwd
            // 
            this.tabLayPanPwd.ColumnCount = 1;
            this.tabLayPanPwd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanPwd.Controls.Add(this.grpBoxMDP, 0, 0);
            this.tabLayPanPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanPwd.Location = new System.Drawing.Point(4, 129);
            this.tabLayPanPwd.Margin = new System.Windows.Forms.Padding(4);
            this.tabLayPanPwd.Name = "tabLayPanPwd";
            this.tabLayPanPwd.RowCount = 1;
            this.tabLayPanPwd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanPwd.Size = new System.Drawing.Size(493, 60);
            this.tabLayPanPwd.TabIndex = 1;
            // 
            // grpBoxMDP
            // 
            this.grpBoxMDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxMDP.Controls.Add(this.txtBoxPwd);
            this.grpBoxMDP.Location = new System.Drawing.Point(110, 4);
            this.grpBoxMDP.Margin = new System.Windows.Forms.Padding(110, 4, 110, 4);
            this.grpBoxMDP.Name = "grpBoxMDP";
            this.grpBoxMDP.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxMDP.Size = new System.Drawing.Size(273, 52);
            this.grpBoxMDP.TabIndex = 0;
            this.grpBoxMDP.TabStop = false;
            this.grpBoxMDP.Text = "Mot de passe : ";
            // 
            // txtBoxPwd
            // 
            this.txtBoxPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPwd.Location = new System.Drawing.Point(4, 21);
            this.txtBoxPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPwd.Name = "txtBoxPwd";
            this.txtBoxPwd.Size = new System.Drawing.Size(265, 24);
            this.txtBoxPwd.TabIndex = 5;
            this.txtBoxPwd.UseSystemPasswordChar = true;
            // 
            // tabLayPanConn
            // 
            this.tabLayPanConn.ColumnCount = 3;
            this.tabLayPanConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayPanConn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanConn.Controls.Add(this.panel1, 1, 0);
            this.tabLayPanConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanConn.Location = new System.Drawing.Point(4, 197);
            this.tabLayPanConn.Margin = new System.Windows.Forms.Padding(4);
            this.tabLayPanConn.Name = "tabLayPanConn";
            this.tabLayPanConn.RowCount = 2;
            this.tabLayPanConn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPanConn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tabLayPanConn.Size = new System.Drawing.Size(493, 428);
            this.tabLayPanConn.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Location = new System.Drawing.Point(146, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 82);
            this.panel1.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.AutoSize = true;
            this.btnConnect.Location = new System.Drawing.Point(26, 13);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(75, 4, 75, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(148, 29);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Se connecter";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 629);
            this.Controls.Add(this.tabLayPanLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(517, 677);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connectez vous";
            this.tabLayPanLogin.ResumeLayout(false);
            this.tabLayPanUsername.ResumeLayout(false);
            this.grpBoxUsername.ResumeLayout(false);
            this.grpBoxUsername.PerformLayout();
            this.tabLayPanPwd.ResumeLayout(false);
            this.grpBoxMDP.ResumeLayout(false);
            this.grpBoxMDP.PerformLayout();
            this.tabLayPanConn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayPanLogin;
        private System.Windows.Forms.TableLayoutPanel tabLayPanUsername;
        private System.Windows.Forms.TableLayoutPanel tabLayPanPwd;
        private System.Windows.Forms.GroupBox grpBoxUsername;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.GroupBox grpBoxMDP;
        private System.Windows.Forms.TextBox txtBoxPwd;
        private System.Windows.Forms.TableLayoutPanel tabLayPanConn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnect;
    }
}