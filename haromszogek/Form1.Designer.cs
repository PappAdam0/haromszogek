﻿namespace haromszogek
{
    partial class frmFo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAoldal = new System.Windows.Forms.TextBox();
            this.tbBoldal = new System.Windows.Forms.TextBox();
            this.tbColdal = new System.Windows.Forms.TextBox();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHaromszogLista = new System.Windows.Forms.ListBox();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnFajbol = new System.Windows.Forms.Button();
            this.ofdMegnyitas = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "A haromszog oldalai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "c:";
            // 
            // tbAoldal
            // 
            this.tbAoldal.Location = new System.Drawing.Point(42, 49);
            this.tbAoldal.Name = "tbAoldal";
            this.tbAoldal.Size = new System.Drawing.Size(100, 29);
            this.tbAoldal.TabIndex = 4;
            // 
            // tbBoldal
            // 
            this.tbBoldal.Location = new System.Drawing.Point(42, 84);
            this.tbBoldal.Name = "tbBoldal";
            this.tbBoldal.Size = new System.Drawing.Size(100, 29);
            this.tbBoldal.TabIndex = 5;
            // 
            // tbColdal
            // 
            this.tbColdal.Location = new System.Drawing.Point(42, 119);
            this.tbColdal.Name = "tbColdal";
            this.tbColdal.Size = new System.Drawing.Size(100, 29);
            this.tbColdal.TabIndex = 6;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(12, 250);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(86, 30);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(232, 81);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(109, 30);
            this.btnSzamol.TabIndex = 8;
            this.btnSzamol.Text = "Számolás";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSzamol);
            this.panel1.Controls.Add(this.tbColdal);
            this.panel1.Controls.Add(this.tbBoldal);
            this.panel1.Controls.Add(this.tbAoldal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 183);
            this.panel1.TabIndex = 9;
            // 
            // lbHaromszogLista
            // 
            this.lbHaromszogLista.FormattingEnabled = true;
            this.lbHaromszogLista.ItemHeight = 24;
            this.lbHaromszogLista.Location = new System.Drawing.Point(398, 60);
            this.lbHaromszogLista.Name = "lbHaromszogLista";
            this.lbHaromszogLista.Size = new System.Drawing.Size(210, 220);
            this.lbHaromszogLista.TabIndex = 10;
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(461, 18);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(86, 30);
            this.btnTorol.TabIndex = 11;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnFajbol
            // 
            this.btnFajbol.Location = new System.Drawing.Point(12, 214);
            this.btnFajbol.Name = "btnFajbol";
            this.btnFajbol.Size = new System.Drawing.Size(86, 30);
            this.btnFajbol.TabIndex = 12;
            this.btnFajbol.Text = "Fájlból";
            this.btnFajbol.UseVisualStyleBackColor = true;
            this.btnFajbol.Click += new System.EventHandler(this.btnFajbol_Click);
            // 
            // ofdMegnyitas
            // 
            this.ofdMegnyitas.Filter = "Text files| *.txt";
            this.ofdMegnyitas.InitialDirectory = "C:\\Users\\c16PAPPÁ\\source\\repos\\haromszogek\\haromszogek\\bin\\Debug";
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 289);
            this.Controls.Add(this.btnFajbol);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.lbHaromszogLista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKilepes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haromszog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAoldal;
        private System.Windows.Forms.TextBox tbBoldal;
        private System.Windows.Forms.TextBox tbColdal;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbHaromszogLista;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnFajbol;
        private System.Windows.Forms.OpenFileDialog ofdMegnyitas;
    }
}

