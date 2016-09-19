namespace RogueForumWinForm
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpanelFrmMain = new System.Windows.Forms.TableLayoutPanel();
            this.picBoxFrmMain = new System.Windows.Forms.PictureBox();
            this.btnEnterForum = new System.Windows.Forms.Button();
            this.tlpanelFrmMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpanelFrmMain
            // 
            this.tlpanelFrmMain.ColumnCount = 5;
            this.tlpanelFrmMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpanelFrmMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpanelFrmMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpanelFrmMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmMain.Controls.Add(this.picBoxFrmMain, 2, 2);
            this.tlpanelFrmMain.Controls.Add(this.btnEnterForum, 3, 2);
            this.tlpanelFrmMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpanelFrmMain.Location = new System.Drawing.Point(0, 0);
            this.tlpanelFrmMain.Name = "tlpanelFrmMain";
            this.tlpanelFrmMain.RowCount = 5;
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmMain.Size = new System.Drawing.Size(984, 561);
            this.tlpanelFrmMain.TabIndex = 0;
            // 
            // picBoxFrmMain
            // 
            this.picBoxFrmMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxFrmMain.Image = global::RogueForumWinForm.Properties.Resources.RogueSquadron;
            this.picBoxFrmMain.Location = new System.Drawing.Point(259, 153);
            this.picBoxFrmMain.Name = "picBoxFrmMain";
            this.picBoxFrmMain.Size = new System.Drawing.Size(466, 254);
            this.picBoxFrmMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFrmMain.TabIndex = 0;
            this.picBoxFrmMain.TabStop = false;
            // 
            // btnEnterForum
            // 
            this.btnEnterForum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnterForum.Image = global::RogueForumWinForm.Properties.Resources.forum_button1;
            this.btnEnterForum.Location = new System.Drawing.Point(771, 153);
            this.btnEnterForum.Name = "btnEnterForum";
            this.btnEnterForum.Size = new System.Drawing.Size(150, 50);
            this.btnEnterForum.TabIndex = 1;
            this.btnEnterForum.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlpanelFrmMain);
            this.Name = "frmMain";
            this.Text = "Rogue Forum";
            this.tlpanelFrmMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpanelFrmMain;
        private System.Windows.Forms.Button btnEnterForum;
        private System.Windows.Forms.PictureBox picBoxFrmMain;
    }
}

