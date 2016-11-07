namespace RogueForumWinForm
{
    partial class FrmModifierMDP
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
            this.tabLayPanChangeMDP = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxMDP = new System.Windows.Forms.GroupBox();
            this.txtBoxMDP = new System.Windows.Forms.TextBox();
            this.grpBoxVerifMDP = new System.Windows.Forms.GroupBox();
            this.txtBoxVerifMDP = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnValidMDP = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tabLayPanChangeMDP.SuspendLayout();
            this.grpBoxMDP.SuspendLayout();
            this.grpBoxVerifMDP.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayPanChangeMDP
            // 
            this.tabLayPanChangeMDP.ColumnCount = 3;
            this.tabLayPanChangeMDP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanChangeMDP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabLayPanChangeMDP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanChangeMDP.Controls.Add(this.grpBoxMDP, 1, 1);
            this.tabLayPanChangeMDP.Controls.Add(this.grpBoxVerifMDP, 1, 2);
            this.tabLayPanChangeMDP.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tabLayPanChangeMDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanChangeMDP.Location = new System.Drawing.Point(0, 0);
            this.tabLayPanChangeMDP.Name = "tabLayPanChangeMDP";
            this.tabLayPanChangeMDP.RowCount = 5;
            this.tabLayPanChangeMDP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanChangeMDP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayPanChangeMDP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tabLayPanChangeMDP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tabLayPanChangeMDP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanChangeMDP.Size = new System.Drawing.Size(249, 311);
            this.tabLayPanChangeMDP.TabIndex = 0;
            // 
            // grpBoxMDP
            // 
            this.grpBoxMDP.Controls.Add(this.txtBoxMDP);
            this.grpBoxMDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxMDP.Location = new System.Drawing.Point(23, 23);
            this.grpBoxMDP.Name = "grpBoxMDP";
            this.grpBoxMDP.Size = new System.Drawing.Size(200, 100);
            this.grpBoxMDP.TabIndex = 0;
            this.grpBoxMDP.TabStop = false;
            this.grpBoxMDP.Text = "Saisir votre nouveau Mot de passe :";
            // 
            // txtBoxMDP
            // 
            this.txtBoxMDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxMDP.Location = new System.Drawing.Point(3, 16);
            this.txtBoxMDP.Name = "txtBoxMDP";
            this.txtBoxMDP.Size = new System.Drawing.Size(194, 20);
            this.txtBoxMDP.TabIndex = 0;
            this.txtBoxMDP.UseSystemPasswordChar = true;
            this.txtBoxMDP.TextChanged += new System.EventHandler(this.txtBoxMDP_TextChanged);
            // 
            // grpBoxVerifMDP
            // 
            this.grpBoxVerifMDP.Controls.Add(this.txtBoxVerifMDP);
            this.grpBoxVerifMDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxVerifMDP.Location = new System.Drawing.Point(23, 129);
            this.grpBoxVerifMDP.Name = "grpBoxVerifMDP";
            this.grpBoxVerifMDP.Size = new System.Drawing.Size(200, 100);
            this.grpBoxVerifMDP.TabIndex = 1;
            this.grpBoxVerifMDP.TabStop = false;
            this.grpBoxVerifMDP.Text = "Saisir à nouveau le mot de passe";
            // 
            // txtBoxVerifMDP
            // 
            this.txtBoxVerifMDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxVerifMDP.Location = new System.Drawing.Point(3, 16);
            this.txtBoxVerifMDP.Name = "txtBoxVerifMDP";
            this.txtBoxVerifMDP.Size = new System.Drawing.Size(194, 20);
            this.txtBoxVerifMDP.TabIndex = 0;
            this.txtBoxVerifMDP.UseSystemPasswordChar = true;
            this.txtBoxVerifMDP.TextChanged += new System.EventHandler(this.txtBoxVerifMDP_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnValidMDP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 44);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnValidMDP
            // 
            this.btnValidMDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValidMDP.Enabled = false;
            this.btnValidMDP.Location = new System.Drawing.Point(103, 3);
            this.btnValidMDP.Name = "btnValidMDP";
            this.btnValidMDP.Size = new System.Drawing.Size(94, 38);
            this.btnValidMDP.TabIndex = 3;
            this.btnValidMDP.Text = "Valider";
            this.btnValidMDP.UseVisualStyleBackColor = true;
            this.btnValidMDP.Click += new System.EventHandler(this.btnValidMDP_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(3, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(93, 39);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Les mots de passe ne sont pas identiques";
            this.lblError.Visible = false;
            // 
            // FrmModifierMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 311);
            this.Controls.Add(this.tabLayPanChangeMDP);
            this.MaximumSize = new System.Drawing.Size(265, 350);
            this.MinimumSize = new System.Drawing.Size(265, 350);
            this.Name = "FrmModifierMDP";
            this.Text = "FrmModifierMDP";
            this.tabLayPanChangeMDP.ResumeLayout(false);
            this.grpBoxMDP.ResumeLayout(false);
            this.grpBoxMDP.PerformLayout();
            this.grpBoxVerifMDP.ResumeLayout(false);
            this.grpBoxVerifMDP.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayPanChangeMDP;
        private System.Windows.Forms.GroupBox grpBoxMDP;
        private System.Windows.Forms.TextBox txtBoxMDP;
        private System.Windows.Forms.GroupBox grpBoxVerifMDP;
        private System.Windows.Forms.TextBox txtBoxVerifMDP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnValidMDP;
        private System.Windows.Forms.Label lblError;
    }
}