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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForum));
            this.tlpanelFrmForum = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayPanCategorie = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxCategorie = new System.Windows.Forms.GroupBox();
            this.cbBoxRubrique = new System.Windows.Forms.ComboBox();
            this.tableLayPanSujet = new System.Windows.Forms.TableLayoutPanel();
            this.panelAddSujet = new System.Windows.Forms.Panel();
            this.grpBoxUtilisateur = new System.Windows.Forms.GroupBox();
            this.btnPostRep = new System.Windows.Forms.Button();
            this.btnAddSujet = new System.Windows.Forms.Button();
            this.grpBoxSujet = new System.Windows.Forms.GroupBox();
            this.grpBoxDescSujet = new System.Windows.Forms.GroupBox();
            this.txtBoxDescSujet = new System.Windows.Forms.TextBox();
            this.lblNoSujet = new System.Windows.Forms.Label();
            this.cbBoxSujet = new System.Windows.Forms.ComboBox();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            this.flowLayPanIdent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnIdent = new System.Windows.Forms.Button();
            this.btnChangerMDP = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.dataGridViewReponse = new System.Windows.Forms.DataGridView();
            this.grpBoxAdmin = new System.Windows.Forms.GroupBox();
            this.btnEditSujet = new System.Windows.Forms.Button();
            this.btnSupprReponse = new System.Windows.Forms.Button();
            this.btnSupprSujet = new System.Windows.Forms.Button();
            this.lblNoReponse = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tlpanelFrmForum.SuspendLayout();
            this.tableLayPanCategorie.SuspendLayout();
            this.grpBoxCategorie.SuspendLayout();
            this.tableLayPanSujet.SuspendLayout();
            this.panelAddSujet.SuspendLayout();
            this.grpBoxUtilisateur.SuspendLayout();
            this.grpBoxSujet.SuspendLayout();
            this.grpBoxDescSujet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.flowLayPanIdent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReponse)).BeginInit();
            this.grpBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpanelFrmForum
            // 
            this.tlpanelFrmForum.ColumnCount = 5;
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpanelFrmForum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmForum.Controls.Add(this.tableLayPanCategorie, 1, 1);
            this.tlpanelFrmForum.Controls.Add(this.tableLayPanSujet, 2, 1);
            this.tlpanelFrmForum.Controls.Add(this.picBoxHome, 3, 1);
            this.tlpanelFrmForum.Controls.Add(this.flowLayPanIdent, 3, 3);
            this.tlpanelFrmForum.Controls.Add(this.dataGridViewReponse, 2, 3);
            this.tlpanelFrmForum.Controls.Add(this.grpBoxAdmin, 1, 3);
            this.tlpanelFrmForum.Controls.Add(this.lblNoReponse, 2, 2);
            this.tlpanelFrmForum.Controls.Add(this.progressBar, 1, 2);
            this.tlpanelFrmForum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpanelFrmForum.Location = new System.Drawing.Point(0, 0);
            this.tlpanelFrmForum.Name = "tlpanelFrmForum";
            this.tlpanelFrmForum.RowCount = 6;
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpanelFrmForum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpanelFrmForum.Size = new System.Drawing.Size(1158, 581);
            this.tlpanelFrmForum.TabIndex = 0;
            // 
            // tableLayPanCategorie
            // 
            this.tableLayPanCategorie.ColumnCount = 1;
            this.tableLayPanCategorie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayPanCategorie.Controls.Add(this.grpBoxCategorie, 0, 0);
            this.tableLayPanCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayPanCategorie.Location = new System.Drawing.Point(23, 23);
            this.tableLayPanCategorie.Name = "tableLayPanCategorie";
            this.tableLayPanCategorie.RowCount = 1;
            this.tableLayPanCategorie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayPanCategorie.Size = new System.Drawing.Size(200, 100);
            this.tableLayPanCategorie.TabIndex = 1;
            // 
            // grpBoxCategorie
            // 
            this.grpBoxCategorie.Controls.Add(this.cbBoxRubrique);
            this.grpBoxCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxCategorie.Location = new System.Drawing.Point(3, 3);
            this.grpBoxCategorie.Name = "grpBoxCategorie";
            this.grpBoxCategorie.Size = new System.Drawing.Size(194, 94);
            this.grpBoxCategorie.TabIndex = 0;
            this.grpBoxCategorie.TabStop = false;
            this.grpBoxCategorie.Text = "Rubriques :";
            // 
            // cbBoxRubrique
            // 
            this.cbBoxRubrique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoxRubrique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxRubrique.FormattingEnabled = true;
            this.cbBoxRubrique.Location = new System.Drawing.Point(3, 16);
            this.cbBoxRubrique.Name = "cbBoxRubrique";
            this.cbBoxRubrique.Size = new System.Drawing.Size(188, 21);
            this.cbBoxRubrique.TabIndex = 1;
            this.cbBoxRubrique.TabStop = false;
            this.cbBoxRubrique.SelectedIndexChanged += new System.EventHandler(this.cbBoxRubrique_SelectedIndexChanged);
            // 
            // tableLayPanSujet
            // 
            this.tableLayPanSujet.ColumnCount = 2;
            this.tableLayPanSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanSujet.Controls.Add(this.panelAddSujet, 1, 0);
            this.tableLayPanSujet.Controls.Add(this.grpBoxSujet, 0, 0);
            this.tableLayPanSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayPanSujet.Location = new System.Drawing.Point(229, 23);
            this.tableLayPanSujet.Name = "tableLayPanSujet";
            this.tableLayPanSujet.RowCount = 1;
            this.tableLayPanSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayPanSujet.Size = new System.Drawing.Size(814, 100);
            this.tableLayPanSujet.TabIndex = 2;
            // 
            // panelAddSujet
            // 
            this.panelAddSujet.Controls.Add(this.grpBoxUtilisateur);
            this.panelAddSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddSujet.Location = new System.Drawing.Point(410, 3);
            this.panelAddSujet.Name = "panelAddSujet";
            this.panelAddSujet.Size = new System.Drawing.Size(401, 94);
            this.panelAddSujet.TabIndex = 1;
            // 
            // grpBoxUtilisateur
            // 
            this.grpBoxUtilisateur.Controls.Add(this.btnPostRep);
            this.grpBoxUtilisateur.Controls.Add(this.btnAddSujet);
            this.grpBoxUtilisateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.grpBoxUtilisateur.Name = "grpBoxUtilisateur";
            this.grpBoxUtilisateur.Size = new System.Drawing.Size(401, 94);
            this.grpBoxUtilisateur.TabIndex = 0;
            this.grpBoxUtilisateur.TabStop = false;
            this.grpBoxUtilisateur.Text = "Ajouter un sujet/Poster une réponse : ";
            // 
            // btnPostRep
            // 
            this.btnPostRep.AutoSize = true;
            this.btnPostRep.Location = new System.Drawing.Point(111, 32);
            this.btnPostRep.Name = "btnPostRep";
            this.btnPostRep.Size = new System.Drawing.Size(109, 23);
            this.btnPostRep.TabIndex = 4;
            this.btnPostRep.Text = "Poster une réponse";
            this.btnPostRep.UseVisualStyleBackColor = true;
            this.btnPostRep.Click += new System.EventHandler(this.btnPostRep_Click);
            // 
            // btnAddSujet
            // 
            this.btnAddSujet.AutoSize = true;
            this.btnAddSujet.Location = new System.Drawing.Point(6, 32);
            this.btnAddSujet.Name = "btnAddSujet";
            this.btnAddSujet.Size = new System.Drawing.Size(90, 23);
            this.btnAddSujet.TabIndex = 3;
            this.btnAddSujet.Text = "Ajouter un sujet";
            this.btnAddSujet.UseVisualStyleBackColor = true;
            this.btnAddSujet.Click += new System.EventHandler(this.btnAddSujet_Click);
            // 
            // grpBoxSujet
            // 
            this.grpBoxSujet.Controls.Add(this.grpBoxDescSujet);
            this.grpBoxSujet.Controls.Add(this.lblNoSujet);
            this.grpBoxSujet.Controls.Add(this.cbBoxSujet);
            this.grpBoxSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxSujet.Location = new System.Drawing.Point(3, 3);
            this.grpBoxSujet.Name = "grpBoxSujet";
            this.grpBoxSujet.Size = new System.Drawing.Size(401, 94);
            this.grpBoxSujet.TabIndex = 2;
            this.grpBoxSujet.TabStop = false;
            this.grpBoxSujet.Text = "Sujets : ";
            // 
            // grpBoxDescSujet
            // 
            this.grpBoxDescSujet.Controls.Add(this.txtBoxDescSujet);
            this.grpBoxDescSujet.Location = new System.Drawing.Point(123, 0);
            this.grpBoxDescSujet.Name = "grpBoxDescSujet";
            this.grpBoxDescSujet.Size = new System.Drawing.Size(278, 94);
            this.grpBoxDescSujet.TabIndex = 3;
            this.grpBoxDescSujet.TabStop = false;
            this.grpBoxDescSujet.Text = "Description du sujet : ";
            // 
            // txtBoxDescSujet
            // 
            this.txtBoxDescSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDescSujet.Enabled = false;
            this.txtBoxDescSujet.Location = new System.Drawing.Point(3, 16);
            this.txtBoxDescSujet.Multiline = true;
            this.txtBoxDescSujet.Name = "txtBoxDescSujet";
            this.txtBoxDescSujet.Size = new System.Drawing.Size(272, 75);
            this.txtBoxDescSujet.TabIndex = 0;
            this.txtBoxDescSujet.TabStop = false;
            // 
            // lblNoSujet
            // 
            this.lblNoSujet.AutoSize = true;
            this.lblNoSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSujet.ForeColor = System.Drawing.Color.Crimson;
            this.lblNoSujet.Location = new System.Drawing.Point(6, 42);
            this.lblNoSujet.Name = "lblNoSujet";
            this.lblNoSujet.Size = new System.Drawing.Size(292, 20);
            this.lblNoSujet.TabIndex = 2;
            this.lblNoSujet.Text = "Il n\'y pas de sujets dans la rubrique";
            this.lblNoSujet.Visible = false;
            // 
            // cbBoxSujet
            // 
            this.cbBoxSujet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSujet.FormattingEnabled = true;
            this.cbBoxSujet.Location = new System.Drawing.Point(9, 16);
            this.cbBoxSujet.Name = "cbBoxSujet";
            this.cbBoxSujet.Size = new System.Drawing.Size(108, 21);
            this.cbBoxSujet.TabIndex = 1;
            this.cbBoxSujet.TabStop = false;
            this.cbBoxSujet.SelectedIndexChanged += new System.EventHandler(this.cbBoxSujet_SelectedIndexChanged);
            // 
            // picBoxHome
            // 
            this.picBoxHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxHome.Image = global::RogueForumWinForm.Properties.Resources.RogueSquadron80x80;
            this.picBoxHome.Location = new System.Drawing.Point(1049, 23);
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
            this.flowLayPanIdent.Controls.Add(this.btnChangerMDP);
            this.flowLayPanIdent.Controls.Add(this.btnDeconnexion);
            this.flowLayPanIdent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayPanIdent.Location = new System.Drawing.Point(1049, 149);
            this.flowLayPanIdent.Name = "flowLayPanIdent";
            this.flowLayPanIdent.Size = new System.Drawing.Size(88, 421);
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
            // btnChangerMDP
            // 
            this.btnChangerMDP.Location = new System.Drawing.Point(3, 48);
            this.btnChangerMDP.Name = "btnChangerMDP";
            this.btnChangerMDP.Size = new System.Drawing.Size(85, 39);
            this.btnChangerMDP.TabIndex = 1;
            this.btnChangerMDP.Text = "Changer mot de passe";
            this.btnChangerMDP.UseVisualStyleBackColor = true;
            this.btnChangerMDP.Click += new System.EventHandler(this.btnChangerMDP_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(3, 93);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(85, 39);
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.Text = "Se deconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // dataGridViewReponse
            // 
            this.dataGridViewReponse.AllowUserToAddRows = false;
            this.dataGridViewReponse.AllowUserToDeleteRows = false;
            this.dataGridViewReponse.AllowUserToResizeColumns = false;
            this.dataGridViewReponse.AllowUserToResizeRows = false;
            this.dataGridViewReponse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReponse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewReponse.Location = new System.Drawing.Point(229, 149);
            this.dataGridViewReponse.MultiSelect = false;
            this.dataGridViewReponse.Name = "dataGridViewReponse";
            this.dataGridViewReponse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReponse.Size = new System.Drawing.Size(814, 421);
            this.dataGridViewReponse.TabIndex = 5;
            this.dataGridViewReponse.TabStop = false;
            this.dataGridViewReponse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReponse_CellClick);
            this.dataGridViewReponse.SelectionChanged += new System.EventHandler(this.dataGridViewReponse_SelectionChanged);
            // 
            // grpBoxAdmin
            // 
            this.grpBoxAdmin.Controls.Add(this.btnEditSujet);
            this.grpBoxAdmin.Controls.Add(this.btnSupprReponse);
            this.grpBoxAdmin.Controls.Add(this.btnSupprSujet);
            this.grpBoxAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxAdmin.Location = new System.Drawing.Point(23, 149);
            this.grpBoxAdmin.Name = "grpBoxAdmin";
            this.grpBoxAdmin.Size = new System.Drawing.Size(200, 421);
            this.grpBoxAdmin.TabIndex = 6;
            this.grpBoxAdmin.TabStop = false;
            this.grpBoxAdmin.Text = "Administration du forum";
            // 
            // btnEditSujet
            // 
            this.btnEditSujet.Location = new System.Drawing.Point(60, 35);
            this.btnEditSujet.Name = "btnEditSujet";
            this.btnEditSujet.Size = new System.Drawing.Size(75, 41);
            this.btnEditSujet.TabIndex = 5;
            this.btnEditSujet.Text = "Modifier le sujet";
            this.btnEditSujet.UseVisualStyleBackColor = true;
            this.btnEditSujet.Click += new System.EventHandler(this.btnEditSujet_Click);
            // 
            // btnSupprReponse
            // 
            this.btnSupprReponse.Location = new System.Drawing.Point(60, 129);
            this.btnSupprReponse.Name = "btnSupprReponse";
            this.btnSupprReponse.Size = new System.Drawing.Size(75, 41);
            this.btnSupprReponse.TabIndex = 7;
            this.btnSupprReponse.Text = "Supprimer la réponse";
            this.btnSupprReponse.UseVisualStyleBackColor = true;
            this.btnSupprReponse.Click += new System.EventHandler(this.btnSupprReponse_Click);
            // 
            // btnSupprSujet
            // 
            this.btnSupprSujet.Location = new System.Drawing.Point(60, 82);
            this.btnSupprSujet.Name = "btnSupprSujet";
            this.btnSupprSujet.Size = new System.Drawing.Size(75, 41);
            this.btnSupprSujet.TabIndex = 6;
            this.btnSupprSujet.Text = "Supprimer le sujet";
            this.btnSupprSujet.UseVisualStyleBackColor = true;
            this.btnSupprSujet.Click += new System.EventHandler(this.btnSupprSujet_Click);
            // 
            // lblNoReponse
            // 
            this.lblNoReponse.AutoSize = true;
            this.lblNoReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoReponse.ForeColor = System.Drawing.Color.Crimson;
            this.lblNoReponse.Location = new System.Drawing.Point(229, 126);
            this.lblNoReponse.Name = "lblNoReponse";
            this.lblNoReponse.Size = new System.Drawing.Size(814, 20);
            this.lblNoReponse.TabIndex = 8;
            this.lblNoReponse.Text = "Il n\'y a pas de réponses pour le sujet";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 129);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 14);
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // FrmForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 581);
            this.Controls.Add(this.tlpanelFrmForum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmForum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rogue Forum";
            this.Load += new System.EventHandler(this.FrmForum_Load);
            this.tlpanelFrmForum.ResumeLayout(false);
            this.tlpanelFrmForum.PerformLayout();
            this.tableLayPanCategorie.ResumeLayout(false);
            this.grpBoxCategorie.ResumeLayout(false);
            this.tableLayPanSujet.ResumeLayout(false);
            this.panelAddSujet.ResumeLayout(false);
            this.grpBoxUtilisateur.ResumeLayout(false);
            this.grpBoxUtilisateur.PerformLayout();
            this.grpBoxSujet.ResumeLayout(false);
            this.grpBoxSujet.PerformLayout();
            this.grpBoxDescSujet.ResumeLayout(false);
            this.grpBoxDescSujet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.flowLayPanIdent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReponse)).EndInit();
            this.grpBoxAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpanelFrmForum;
        private System.Windows.Forms.TableLayoutPanel tableLayPanCategorie;
        private System.Windows.Forms.TableLayoutPanel tableLayPanSujet;
        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayPanIdent;
        private System.Windows.Forms.Button btnIdent;
        private System.Windows.Forms.GroupBox grpBoxCategorie;
        private System.Windows.Forms.ComboBox cbBoxRubrique;
        private System.Windows.Forms.Panel panelAddSujet;
        private System.Windows.Forms.GroupBox grpBoxUtilisateur;
        private System.Windows.Forms.Button btnAddSujet;
        private System.Windows.Forms.GroupBox grpBoxSujet;
        private System.Windows.Forms.ComboBox cbBoxSujet;
        private System.Windows.Forms.Button btnPostRep;
        private System.Windows.Forms.Button btnChangerMDP;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.GroupBox grpBoxAdmin;
        private System.Windows.Forms.Button btnSupprReponse;
        private System.Windows.Forms.Button btnSupprSujet;
        private System.Windows.Forms.Button btnEditSujet;
        private System.Windows.Forms.DataGridView dataGridViewReponse;
        private System.Windows.Forms.Label lblNoReponse;
        private System.Windows.Forms.Label lblNoSujet;
        private System.Windows.Forms.GroupBox grpBoxDescSujet;
        private System.Windows.Forms.TextBox txtBoxDescSujet;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}