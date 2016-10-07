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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tlpanelFrmMain = new System.Windows.Forms.TableLayoutPanel();
            this.picBoxFrmMain = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
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
            this.tlpanelFrmMain.Controls.Add(this.btnQuit, 3, 3);
            this.tlpanelFrmMain.Controls.Add(this.btnEnterForum, 2, 3);
            this.tlpanelFrmMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpanelFrmMain.Location = new System.Drawing.Point(0, 0);
            this.tlpanelFrmMain.Name = "tlpanelFrmMain";
            this.tlpanelFrmMain.RowCount = 5;
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpanelFrmMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmMain.Size = new System.Drawing.Size(984, 561);
            this.tlpanelFrmMain.TabIndex = 0;
            // 
            // picBoxFrmMain
            // 
            this.picBoxFrmMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxFrmMain.Image = global::RogueForumWinForm.Properties.Resources.RogueSquadron;
            this.picBoxFrmMain.Location = new System.Drawing.Point(259, 23);
            this.picBoxFrmMain.Name = "picBoxFrmMain";
            this.picBoxFrmMain.Size = new System.Drawing.Size(466, 459);
            this.picBoxFrmMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFrmMain.TabIndex = 0;
            this.picBoxFrmMain.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.AutoSize = true;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Image = global::RogueForumWinForm.Properties.Resources.Quitter_32x32;
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Location = new System.Drawing.Point(821, 488);
            this.btnQuit.MinimumSize = new System.Drawing.Size(100, 50);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(140, 50);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnEnterForum
            // 
            this.btnEnterForum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnterForum.Image = global::RogueForumWinForm.Properties.Resources.forum_button1;
            this.btnEnterForum.Location = new System.Drawing.Point(417, 488);
            this.btnEnterForum.MaximumSize = new System.Drawing.Size(150, 50);
            this.btnEnterForum.MinimumSize = new System.Drawing.Size(150, 50);
            this.btnEnterForum.Name = "btnEnterForum";
            this.btnEnterForum.Size = new System.Drawing.Size(150, 50);
            this.btnEnterForum.TabIndex = 1;
            this.btnEnterForum.UseVisualStyleBackColor = true;
            this.btnEnterForum.Click += new System.EventHandler(this.btnEnterForum_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlpanelFrmMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rogue Forum";
            this.tlpanelFrmMain.ResumeLayout(false);
            this.tlpanelFrmMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpanelFrmMain;
        private System.Windows.Forms.Button btnEnterForum;
        private System.Windows.Forms.PictureBox picBoxFrmMain;
        private System.Windows.Forms.Button btnQuit;
    }
}

