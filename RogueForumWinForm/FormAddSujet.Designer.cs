namespace RogueForumWinForm
{
    partial class FrmAddSujet
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
            this.grpBoxTitreSujet = new System.Windows.Forms.GroupBox();
            this.txtBoxTitreSujet = new System.Windows.Forms.TextBox();
            this.grpBoxDescSujet = new System.Windows.Forms.GroupBox();
            this.txtBoxDescSujet = new System.Windows.Forms.TextBox();
            this.flowLayPan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddSujet = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tabLayPanAddSujet.SuspendLayout();
            this.grpBoxTitreSujet.SuspendLayout();
            this.grpBoxDescSujet.SuspendLayout();
            this.flowLayPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayPanAddSujet
            // 
            this.tabLayPanAddSujet.ColumnCount = 3;
            this.tabLayPanAddSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanAddSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPanAddSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanAddSujet.Controls.Add(this.grpBoxTitreSujet, 1, 1);
            this.tabLayPanAddSujet.Controls.Add(this.grpBoxDescSujet, 1, 2);
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
            this.tabLayPanAddSujet.Size = new System.Drawing.Size(384, 361);
            this.tabLayPanAddSujet.TabIndex = 0;
            // 
            // grpBoxTitreSujet
            // 
            this.grpBoxTitreSujet.Controls.Add(this.txtBoxTitreSujet);
            this.grpBoxTitreSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxTitreSujet.Location = new System.Drawing.Point(23, 23);
            this.grpBoxTitreSujet.Name = "grpBoxTitreSujet";
            this.grpBoxTitreSujet.Size = new System.Drawing.Size(338, 51);
            this.grpBoxTitreSujet.TabIndex = 0;
            this.grpBoxTitreSujet.TabStop = false;
            this.grpBoxTitreSujet.Text = "Titre du sujet :";
            // 
            // txtBoxTitreSujet
            // 
            this.txtBoxTitreSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTitreSujet.Location = new System.Drawing.Point(3, 16);
            this.txtBoxTitreSujet.Name = "txtBoxTitreSujet";
            this.txtBoxTitreSujet.Size = new System.Drawing.Size(332, 20);
            this.txtBoxTitreSujet.TabIndex = 0;
            // 
            // grpBoxDescSujet
            // 
            this.grpBoxDescSujet.Controls.Add(this.txtBoxDescSujet);
            this.grpBoxDescSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxDescSujet.Location = new System.Drawing.Point(23, 80);
            this.grpBoxDescSujet.Name = "grpBoxDescSujet";
            this.grpBoxDescSujet.Size = new System.Drawing.Size(338, 140);
            this.grpBoxDescSujet.TabIndex = 1;
            this.grpBoxDescSujet.TabStop = false;
            this.grpBoxDescSujet.Text = "Description :";
            // 
            // txtBoxDescSujet
            // 
            this.txtBoxDescSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDescSujet.Location = new System.Drawing.Point(3, 16);
            this.txtBoxDescSujet.Multiline = true;
            this.txtBoxDescSujet.Name = "txtBoxDescSujet";
            this.txtBoxDescSujet.Size = new System.Drawing.Size(332, 121);
            this.txtBoxDescSujet.TabIndex = 1;
            // 
            // flowLayPan
            // 
            this.flowLayPan.Controls.Add(this.btnAddSujet);
            this.flowLayPan.Controls.Add(this.btnAnnuler);
            this.flowLayPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayPan.Location = new System.Drawing.Point(23, 226);
            this.flowLayPan.Name = "flowLayPan";
            this.flowLayPan.Size = new System.Drawing.Size(338, 112);
            this.flowLayPan.TabIndex = 2;
            // 
            // btnAddSujet
            // 
            this.btnAddSujet.Location = new System.Drawing.Point(20, 20);
            this.btnAddSujet.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.btnAddSujet.Name = "btnAddSujet";
            this.btnAddSujet.Size = new System.Drawing.Size(120, 45);
            this.btnAddSujet.TabIndex = 0;
            this.btnAddSujet.Text = "Valider l\'ajout du sujet";
            this.btnAddSujet.UseVisualStyleBackColor = true;
            this.btnAddSujet.Click += new System.EventHandler(this.btnAddSujet_Click);
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
            // FrmAddSujet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tabLayPanAddSujet);
            this.Name = "FrmAddSujet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmAddSujet_Load);
            this.tabLayPanAddSujet.ResumeLayout(false);
            this.grpBoxTitreSujet.ResumeLayout(false);
            this.grpBoxTitreSujet.PerformLayout();
            this.grpBoxDescSujet.ResumeLayout(false);
            this.grpBoxDescSujet.PerformLayout();
            this.flowLayPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayPanAddSujet;
        private System.Windows.Forms.GroupBox grpBoxTitreSujet;
        private System.Windows.Forms.TextBox txtBoxTitreSujet;
        private System.Windows.Forms.GroupBox grpBoxDescSujet;
        private System.Windows.Forms.TextBox txtBoxDescSujet;
        private System.Windows.Forms.FlowLayoutPanel flowLayPan;
        private System.Windows.Forms.Button btnAddSujet;
        private System.Windows.Forms.Button btnAnnuler;
    }
}