namespace Sportboot
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bootsnummer = new System.Windows.Forms.TextBox();
            this.txt_laenge = new System.Windows.Forms.TextBox();
            this.txt_leistung = new System.Windows.Forms.TextBox();
            this.btn_eingabe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_fuehrerschein = new System.Windows.Forms.Button();
            this.btn_gewicht = new System.Windows.Forms.Button();
            this.lbl_fuehrerschein = new System.Windows.Forms.Label();
            this.lbl_gewicht = new System.Windows.Forms.Label();
            this.txt_ausgabe = new System.Windows.Forms.TextBox();
            this.btn_speichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bootsnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Länge [m]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leistung [kW]";
            // 
            // txt_bootsnummer
            // 
            this.txt_bootsnummer.Location = new System.Drawing.Point(125, 23);
            this.txt_bootsnummer.Name = "txt_bootsnummer";
            this.txt_bootsnummer.Size = new System.Drawing.Size(100, 22);
            this.txt_bootsnummer.TabIndex = 3;
            // 
            // txt_laenge
            // 
            this.txt_laenge.Location = new System.Drawing.Point(125, 56);
            this.txt_laenge.Name = "txt_laenge";
            this.txt_laenge.Size = new System.Drawing.Size(100, 22);
            this.txt_laenge.TabIndex = 4;
            // 
            // txt_leistung
            // 
            this.txt_leistung.Location = new System.Drawing.Point(125, 96);
            this.txt_leistung.Name = "txt_leistung";
            this.txt_leistung.Size = new System.Drawing.Size(100, 22);
            this.txt_leistung.TabIndex = 5;
            // 
            // btn_eingabe
            // 
            this.btn_eingabe.Location = new System.Drawing.Point(125, 136);
            this.btn_eingabe.Name = "btn_eingabe";
            this.btn_eingabe.Size = new System.Drawing.Size(100, 32);
            this.btn_eingabe.TabIndex = 6;
            this.btn_eingabe.Text = "Eingabe";
            this.btn_eingabe.UseVisualStyleBackColor = true;
            this.btn_eingabe.Click += new System.EventHandler(this.btn_eingabe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Simulation";
            // 
            // btn_fuehrerschein
            // 
            this.btn_fuehrerschein.Location = new System.Drawing.Point(49, 339);
            this.btn_fuehrerschein.Name = "btn_fuehrerschein";
            this.btn_fuehrerschein.Size = new System.Drawing.Size(147, 32);
            this.btn_fuehrerschein.TabIndex = 8;
            this.btn_fuehrerschein.Text = "Führerscheinpflicht";
            this.btn_fuehrerschein.UseVisualStyleBackColor = true;
            this.btn_fuehrerschein.Click += new System.EventHandler(this.btn_fuehrerschein_Click);
            // 
            // btn_gewicht
            // 
            this.btn_gewicht.Location = new System.Drawing.Point(49, 377);
            this.btn_gewicht.Name = "btn_gewicht";
            this.btn_gewicht.Size = new System.Drawing.Size(147, 32);
            this.btn_gewicht.TabIndex = 9;
            this.btn_gewicht.Text = "Gewicht";
            this.btn_gewicht.UseVisualStyleBackColor = true;
            this.btn_gewicht.Click += new System.EventHandler(this.btn_gewicht_Click);
            // 
            // lbl_fuehrerschein
            // 
            this.lbl_fuehrerschein.AutoSize = true;
            this.lbl_fuehrerschein.Location = new System.Drawing.Point(202, 347);
            this.lbl_fuehrerschein.Name = "lbl_fuehrerschein";
            this.lbl_fuehrerschein.Size = new System.Drawing.Size(0, 16);
            this.lbl_fuehrerschein.TabIndex = 10;
            // 
            // lbl_gewicht
            // 
            this.lbl_gewicht.AutoSize = true;
            this.lbl_gewicht.Location = new System.Drawing.Point(202, 385);
            this.lbl_gewicht.Name = "lbl_gewicht";
            this.lbl_gewicht.Size = new System.Drawing.Size(0, 16);
            this.lbl_gewicht.TabIndex = 11;
            // 
            // txt_ausgabe
            // 
            this.txt_ausgabe.Location = new System.Drawing.Point(278, 23);
            this.txt_ausgabe.Multiline = true;
            this.txt_ausgabe.Name = "txt_ausgabe";
            this.txt_ausgabe.Size = new System.Drawing.Size(434, 254);
            this.txt_ausgabe.TabIndex = 12;
            // 
            // btn_speichern
            // 
            this.btn_speichern.Location = new System.Drawing.Point(565, 377);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(147, 32);
            this.btn_speichern.TabIndex = 13;
            this.btn_speichern.Text = "Speichern";
            this.btn_speichern.UseVisualStyleBackColor = true;
            this.btn_speichern.Click += new System.EventHandler(this.btn_speichern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 447);
            this.Controls.Add(this.btn_speichern);
            this.Controls.Add(this.txt_ausgabe);
            this.Controls.Add(this.lbl_gewicht);
            this.Controls.Add(this.lbl_fuehrerschein);
            this.Controls.Add(this.btn_gewicht);
            this.Controls.Add(this.btn_fuehrerschein);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_eingabe);
            this.Controls.Add(this.txt_leistung);
            this.Controls.Add(this.txt_laenge);
            this.Controls.Add(this.txt_bootsnummer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bootsnummer;
        private System.Windows.Forms.TextBox txt_laenge;
        private System.Windows.Forms.TextBox txt_leistung;
        private System.Windows.Forms.Button btn_eingabe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_fuehrerschein;
        private System.Windows.Forms.Button btn_gewicht;
        private System.Windows.Forms.Label lbl_fuehrerschein;
        private System.Windows.Forms.Label lbl_gewicht;
        private System.Windows.Forms.TextBox txt_ausgabe;
        private System.Windows.Forms.Button btn_speichern;
    }
}

