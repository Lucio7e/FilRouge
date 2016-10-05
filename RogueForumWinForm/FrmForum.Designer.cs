namespace RogueForumWinForm
{
    partial class FrmForum
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
            this.tlpanelFrmForum = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayPanCategorie = new System.Windows.Forms.TableLayoutPanel();
            this.cbBoxCategorie = new System.Windows.Forms.ComboBox();
            this.tableLayPanSujet = new System.Windows.Forms.TableLayoutPanel();
            this.cbBoxSujet = new System.Windows.Forms.ComboBox();
            this.btnAddSujet = new System.Windows.Forms.Button();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            this.flowLayPanIdent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIdent = new System.Windows.Forms.Button();
            this.tlpanelFrmForum.SuspendLayout();
            this.tableLayPanCategorie.SuspendLayout();
            this.tableLayPanSujet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.flowLayPanIdent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpanelFrmForum
            // 
            this.tlpanelFrmForum.ColumnCount = 5;
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.82337F));
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.57603F));
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.663594F));
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpanelFrmForum.Controls.Add(this.tableLayPanCategorie, 1, 1);
            this.tlpanelFrmForum.Controls.Add(this.tableLayPanSujet, 2, 1);
            this.tlpanelFrmForum.Controls.Add(this.picBoxHome, 3, 1);
            this.tlpanelFrmForum.Controls.Add(this.flowLayPanIdent, 3, 2);
            this.tlpanelFrmForum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpanelFrmForum.Location = new System.Drawing.Point(0, 0);
            this.tlpanelFrmForum.Name = "tlpanelFrmForum";
            this.tlpanelFrmForum.RowCount = 4;
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmForum.Size = new System.Drawing.Size(1128, 581);
            this.tlpanelFrmForum.TabIndex = 0;
            // 
            // tableLayPanCategorie
            // 
            this.tableLayPanCategorie.ColumnCount = 1;
            this.tableLayPanCategorie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayPanCategorie.Controls.Add(this.cbBoxCategorie, 0, 0);
            this.tableLayPanCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayPanCategorie.Location = new System.Drawing.Point(23, 11);
            this.tableLayPanCategorie.Name = "tableLayPanCategorie";
            this.tableLayPanCategorie.RowCount = 1;
            this.tableLayPanCategorie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayPanCategorie.Size = new System.Drawing.Size(165, 100);
            this.tableLayPanCategorie.TabIndex = 1;
            // 
            // cbBoxCategorie
            // 
            this.cbBoxCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoxCategorie.FormattingEnabled = true;
            this.cbBoxCategorie.Location = new System.Drawing.Point(3, 3);
            this.cbBoxCategorie.Name = "cbBoxCategorie";
            this.cbBoxCategorie.Size = new System.Drawing.Size(159, 21);
            this.cbBoxCategorie.TabIndex = 0;
            this.cbBoxCategorie.Text = "Sélectionnez une catégorie";
            this.cbBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.cbBoxCategorie_SelectedIndexChanged);
            // 
            // tableLayPanSujet
            // 
            this.tableLayPanSujet.ColumnCount = 2;
            this.tableLayPanSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanSujet.Controls.Add(this.cbBoxSujet, 0, 0);
            this.tableLayPanSujet.Controls.Add(this.btnAddSujet, 1, 0);
            this.tableLayPanSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayPanSujet.Location = new System.Drawing.Point(194, 11);
            this.tableLayPanSujet.Name = "tableLayPanSujet";
            this.tableLayPanSujet.RowCount = 1;
            this.tableLayPanSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanSujet.Size = new System.Drawing.Size(814, 100);
            this.tableLayPanSujet.TabIndex = 2;
            // 
            // cbBoxSujet
            // 
            this.cbBoxSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoxSujet.FormattingEnabled = true;
            this.cbBoxSujet.Location = new System.Drawing.Point(3, 3);
            this.cbBoxSujet.Name = "cbBoxSujet";
            this.cbBoxSujet.Size = new System.Drawing.Size(401, 21);
            this.cbBoxSujet.TabIndex = 0;
            this.cbBoxSujet.Text = "Sélectionnez un sujet";
            // 
            // btnAddSujet
            // 
            this.btnAddSujet.AutoSize = true;
            this.btnAddSujet.Location = new System.Drawing.Point(410, 3);
            this.btnAddSujet.Name = "btnAddSujet";
            this.btnAddSujet.Size = new System.Drawing.Size(90, 23);
            this.btnAddSujet.TabIndex = 1;
            this.btnAddSujet.Text = "Ajouter un sujet";
            this.btnAddSujet.UseVisualStyleBackColor = true;
            // 
            // picBoxHome
            // 
            this.picBoxHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxHome.Image = global::RogueForumWinForm.Properties.Resources.RogueSquadron80x80;
            this.picBoxHome.Location = new System.Drawing.Point(1014, 11);
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.Size = new System.Drawing.Size(88, 100);
            this.picBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxHome.TabIndex = 3;
            this.picBoxHome.TabStop = false;
            this.picBoxHome.Click += new System.EventHandler(this.picBoxHome_Click);
            // 
            // flowLayPanIdent
            // 
            this.flowLayPanIdent.Controls.Add(this.btnIdent);
            this.flowLayPanIdent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayPanIdent.Location = new System.Drawing.Point(1014, 117);
            this.flowLayPanIdent.Name = "flowLayPanIdent";
            this.flowLayPanIdent.Size = new System.Drawing.Size(88, 441);
            this.flowLayPanIdent.TabIndex = 4;
            // 
            // btnIdent
            // 
            this.btnIdent.Location = new System.Drawing.Point(3, 3);
            this.btnIdent.Name = "btnIdent";
            this.btnIdent.Size = new System.Drawing.Size(85, 39);
            this.btnIdent.TabIndex = 0;
            this.btnIdent.Text = "Identifiez vous";
            this.btnIdent.UseVisualStyleBackColor = true;
            this.btnIdent.Click += new System.EventHandler(this.btnIdent_Click);
            // 
            // FrmForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 581);
            this.Controls.Add(this.tlpanelFrmForum);
            this.Name = "FrmForum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rogue Forum";
            this.Load += new System.EventHandler(this.FrmForum_Load);
            this.tlpanelFrmForum.ResumeLayout(false);
            this.tableLayPanCategorie.ResumeLayout(false);
            this.tableLayPanSujet.ResumeLayout(false);
            this.tableLayPanSujet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.flowLayPanIdent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpanelFrmForum;
        private System.Windows.Forms.TableLayoutPanel tableLayPanCategorie;
        private System.Windows.Forms.ComboBox cbBoxCategorie;
        private System.Windows.Forms.TableLayoutPanel tableLayPanSujet;
        private System.Windows.Forms.ComboBox cbBoxSujet;
        private System.Windows.Forms.Button btnAddSujet;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayPanIdent;
        private System.Windows.Forms.Button btnIdent;
    }
}