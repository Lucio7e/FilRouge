namespace RogueForumWinForm
{
    partial class frmAddReponse
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
            this.tabLayPanAddSujet = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxReponse = new System.Windows.Forms.GroupBox();
            this.txtBoxReponse = new System.Windows.Forms.TextBox();
            this.flowLayPan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddReponse = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tabLayPanAddSujet.SuspendLayout();
            this.grpBoxReponse.SuspendLayout();
            this.flowLayPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayPanAddSujet
            // 
            this.tabLayPanAddSujet.ColumnCount = 3;
            this.tabLayPanAddSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanAddSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPanAddSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanAddSujet.Controls.Add(this.grpBoxReponse, 1, 2);
            this.tabLayPanAddSujet.Controls.Add(this.flowLayPan, 1, 3);
            this.tabLayPanAddSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanAddSujet.Location = new System.Drawing.Point(0, 0);
            this.tabLayPanAddSujet.Name = "tabLayPanAddSujet";
            this.tabLayPanAddSujet.RowCount = 5;
            this.tabLayPanAddSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanAddSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPanAddSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tabLayPanAddSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tabLayPanAddSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanAddSujet.Size = new System.Drawing.Size(382, 374);
            this.tabLayPanAddSujet.TabIndex = 1;
            // 
            // grpBoxReponse
            // 
            this.grpBoxReponse.Controls.Add(this.txtBoxReponse);
            this.grpBoxReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxReponse.Location = new System.Drawing.Point(23, 93);
            this.grpBoxReponse.Name = "grpBoxReponse";
            this.grpBoxReponse.Size = new System.Drawing.Size(336, 140);
            this.grpBoxReponse.TabIndex = 1;
            this.grpBoxReponse.TabStop = false;
            this.grpBoxReponse.Text = "Votre réponse :";
            // 
            // txtBoxReponse
            // 
            this.txtBoxReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxReponse.Location = new System.Drawing.Point(3, 16);
            this.txtBoxReponse.Multiline = true;
            this.txtBoxReponse.Name = "txtBoxReponse";
            this.txtBoxReponse.Size = new System.Drawing.Size(330, 121);
            this.txtBoxReponse.TabIndex = 1;
            // 
            // flowLayPan
            // 
            this.flowLayPan.Controls.Add(this.btnAddReponse);
            this.flowLayPan.Controls.Add(this.btnAnnuler);
            this.flowLayPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayPan.Location = new System.Drawing.Point(23, 239);
            this.flowLayPan.Name = "flowLayPan";
            this.flowLayPan.Size = new System.Drawing.Size(336, 112);
            this.flowLayPan.TabIndex = 2;
            // 
            // btnAddReponse
            // 
            this.btnAddReponse.Location = new System.Drawing.Point(20, 20);
            this.btnAddReponse.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.btnAddReponse.Name = "btnAddReponse";
            this.btnAddReponse.Size = new System.Drawing.Size(120, 45);
            this.btnAddReponse.TabIndex = 0;
            this.btnAddReponse.Text = "Valider l\'ajout de la réponse";
            this.btnAddReponse.UseVisualStyleBackColor = true;
            this.btnAddReponse.Click += new System.EventHandler(this.btnAddReponse_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(193, 20);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(50, 20, 20, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(120, 45);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmAddReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 374);
            this.Controls.Add(this.tabLayPanAddSujet);
            this.Name = "frmAddReponse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Poster une réponse";
            this.tabLayPanAddSujet.ResumeLayout(false);
            this.grpBoxReponse.ResumeLayout(false);
            this.grpBoxReponse.PerformLayout();
            this.flowLayPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayPanAddSujet;
        private System.Windows.Forms.GroupBox grpBoxReponse;
        private System.Windows.Forms.TextBox txtBoxReponse;
        private System.Windows.Forms.FlowLayoutPanel flowLayPan;
        private System.Windows.Forms.Button btnAddReponse;
        private System.Windows.Forms.Button btnAnnuler;
    }
}