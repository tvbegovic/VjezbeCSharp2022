namespace SortiranjeRijeci
{
    partial class Glavna
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRijeci = new System.Windows.Forms.TextBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.lstSortirano = new System.Windows.Forms.ListBox();
            this.btnSortirajOrderBy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Riječi:";
            // 
            // txtRijeci
            // 
            this.txtRijeci.Location = new System.Drawing.Point(108, 44);
            this.txtRijeci.Multiline = true;
            this.txtRijeci.Name = "txtRijeci";
            this.txtRijeci.Size = new System.Drawing.Size(433, 174);
            this.txtRijeci.TabIndex = 1;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(587, 44);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(151, 55);
            this.btnSortiraj.TabIndex = 2;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // lstSortirano
            // 
            this.lstSortirano.FormattingEnabled = true;
            this.lstSortirano.Location = new System.Drawing.Point(108, 243);
            this.lstSortirano.Name = "lstSortirano";
            this.lstSortirano.Size = new System.Drawing.Size(433, 186);
            this.lstSortirano.TabIndex = 3;
            // 
            // btnSortirajOrderBy
            // 
            this.btnSortirajOrderBy.Location = new System.Drawing.Point(587, 116);
            this.btnSortirajOrderBy.Name = "btnSortirajOrderBy";
            this.btnSortirajOrderBy.Size = new System.Drawing.Size(151, 53);
            this.btnSortirajOrderBy.TabIndex = 4;
            this.btnSortirajOrderBy.Text = "Sortiraj-OrderBy";
            this.btnSortirajOrderBy.UseVisualStyleBackColor = true;
            this.btnSortirajOrderBy.Click += new System.EventHandler(this.btnSortirajOrderBy_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortirajOrderBy);
            this.Controls.Add(this.lstSortirano);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.txtRijeci);
            this.Controls.Add(this.label1);
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRijeci;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.ListBox lstSortirano;
        private System.Windows.Forms.Button btnSortirajOrderBy;
    }
}

