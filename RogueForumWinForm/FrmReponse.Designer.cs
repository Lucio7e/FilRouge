namespace RogueForumWinForm
{
    partial class FrmReponse
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
            this.tabLayPanReponse = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxReponse = new System.Windows.Forms.TextBox();
            this.tabLayPanReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayPanReponse
            // 
            this.tabLayPanReponse.ColumnCount = 3;
            this.tabLayPanReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPanReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanReponse.Controls.Add(this.txtBoxReponse, 1, 1);
            this.tabLayPanReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanReponse.Location = new System.Drawing.Point(0, 0);
            this.tabLayPanReponse.Name = "tabLayPanReponse";
            this.tabLayPanReponse.RowCount = 3;
            this.tabLayPanReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabLayPanReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanReponse.Size = new System.Drawing.Size(367, 275);
            this.tabLayPanReponse.TabIndex = 0;
            // 
            // txtBoxReponse
            // 
            this.txtBoxReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxReponse.Enabled = false;
            this.txtBoxReponse.Location = new System.Drawing.Point(23, 23);
            this.txtBoxReponse.Multiline = true;
            this.txtBoxReponse.Name = "txtBoxReponse";
            this.txtBoxReponse.Size = new System.Drawing.Size(321, 229);
            this.txtBoxReponse.TabIndex = 0;
            // 
            // FrmReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 275);
            this.Controls.Add(this.tabLayPanReponse);
            this.Name = "FrmReponse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Réponse";
            this.tabLayPanReponse.ResumeLayout(false);
            this.tabLayPanReponse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayPanReponse;
        internal System.Windows.Forms.TextBox txtBoxReponse;
    }
}