namespace Lista
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.btnDodajPozicija = new System.Windows.Forms.Button();
            this.btnDodajRijec = new System.Windows.Forms.Button();
            this.txtRijec = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajVise = new System.Windows.Forms.Button();
            this.txtViseRijeci = new System.Windows.Forms.TextBox();
            this.lstRijeci = new System.Windows.Forms.ListBox();
            this.btnIsprazni = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPozicija);
            this.groupBox1.Controls.Add(this.btnDodajPozicija);
            this.groupBox1.Controls.Add(this.btnDodajRijec);
            this.groupBox1.Controls.Add(this.txtRijec);
            this.groupBox1.Location = new System.Drawing.Point(44, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jedna riječ";
            // 
            // txtPozicija
            // 
            this.txtPozicija.Location = new System.Drawing.Point(332, 58);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(128, 20);
            this.txtPozicija.TabIndex = 2;
            // 
            // btnDodajPozicija
            // 
            this.btnDodajPozicija.Location = new System.Drawing.Point(170, 58);
            this.btnDodajPozicija.Name = "btnDodajPozicija";
            this.btnDodajPozicija.Size = new System.Drawing.Size(130, 31);
            this.btnDodajPozicija.TabIndex = 1;
            this.btnDodajPozicija.Text = "Dodaj riječ na poziciju";
            this.btnDodajPozicija.UseVisualStyleBackColor = true;
            this.btnDodajPozicija.Click += new System.EventHandler(this.btnDodajPozicija_Click);
            // 
            // btnDodajRijec
            // 
            this.btnDodajRijec.Location = new System.Drawing.Point(15, 58);
            this.btnDodajRijec.Name = "btnDodajRijec";
            this.btnDodajRijec.Size = new System.Drawing.Size(130, 31);
            this.btnDodajRijec.TabIndex = 1;
            this.btnDodajRijec.Text = "Dodaj riječ na kraj";
            this.btnDodajRijec.UseVisualStyleBackColor = true;
            this.btnDodajRijec.Click += new System.EventHandler(this.btnDodajRijec_Click);
            // 
            // txtRijec
            // 
            this.txtRijec.Location = new System.Drawing.Point(15, 19);
            this.txtRijec.Name = "txtRijec";
            this.txtRijec.Size = new System.Drawing.Size(445, 20);
            this.txtRijec.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajVise);
            this.groupBox2.Controls.Add(this.txtViseRijeci);
            this.groupBox2.Location = new System.Drawing.Point(44, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Više riječi";
            // 
            // btnDodajVise
            // 
            this.btnDodajVise.Location = new System.Drawing.Point(408, 20);
            this.btnDodajVise.Name = "btnDodajVise";
            this.btnDodajVise.Size = new System.Drawing.Size(96, 42);
            this.btnDodajVise.TabIndex = 1;
            this.btnDodajVise.Text = "Dodaj";
            this.btnDodajVise.UseVisualStyleBackColor = true;
            this.btnDodajVise.Click += new System.EventHandler(this.btnDodajVise_Click);
            // 
            // txtViseRijeci
            // 
            this.txtViseRijeci.Location = new System.Drawing.Point(7, 20);
            this.txtViseRijeci.Multiline = true;
            this.txtViseRijeci.Name = "txtViseRijeci";
            this.txtViseRijeci.Size = new System.Drawing.Size(385, 85);
            this.txtViseRijeci.TabIndex = 0;
            // 
            // lstRijeci
            // 
            this.lstRijeci.FormattingEnabled = true;
            this.lstRijeci.Location = new System.Drawing.Point(51, 309);
            this.lstRijeci.Name = "lstRijeci";
            this.lstRijeci.Size = new System.Drawing.Size(385, 212);
            this.lstRijeci.TabIndex = 2;
            // 
            // btnIsprazni
            // 
            this.btnIsprazni.Location = new System.Drawing.Point(452, 368);
            this.btnIsprazni.Name = "btnIsprazni";
            this.btnIsprazni.Size = new System.Drawing.Size(96, 42);
            this.btnIsprazni.TabIndex = 1;
            this.btnIsprazni.Text = "Isprazni listu";
            this.btnIsprazni.UseVisualStyleBackColor = true;
            this.btnIsprazni.Click += new System.EventHandler(this.btnIsprazni_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(452, 309);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(96, 42);
            this.btnUkloni.TabIndex = 1;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 551);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnIsprazni);
            this.Controls.Add(this.lstRijeci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Glavna";
            this.Text = "Lista riječi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.Button btnDodajPozicija;
        private System.Windows.Forms.Button btnDodajRijec;
        private System.Windows.Forms.TextBox txtRijec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajVise;
        private System.Windows.Forms.TextBox txtViseRijeci;
        private System.Windows.Forms.ListBox lstRijeci;
        private System.Windows.Forms.Button btnIsprazni;
        private System.Windows.Forms.Button btnUkloni;
    }
}

