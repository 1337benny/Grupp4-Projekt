namespace Grupp4_Projekt
{
    partial class HanteraKategorierForm
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
            label1 = new Label();
            lblMinaKategorier = new Label();
            lvMinaKategorier = new ListView();
            namn = new ColumnHeader();
            antalPoddar = new ColumnHeader();
            lbPoddarIKategorin = new ListBox();
            label2 = new Label();
            btnRaderaKategori = new Button();
            btnBytNamn = new Button();
            tbUppdateraNamn = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btnSparaNyKategori = new Button();
            tbNyKategoriNamn = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnTillbaka = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(395, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 36);
            label1.TabIndex = 0;
            label1.Text = "Kategorier";
            // 
            // lblMinaKategorier
            // 
            lblMinaKategorier.AutoSize = true;
            lblMinaKategorier.Font = new Font("Segoe UI", 11F);
            lblMinaKategorier.Location = new Point(11, 12);
            lblMinaKategorier.Name = "lblMinaKategorier";
            lblMinaKategorier.Size = new Size(114, 20);
            lblMinaKategorier.TabIndex = 2;
            lblMinaKategorier.Text = "Mina kategorier";
            // 
            // lvMinaKategorier
            // 
            lvMinaKategorier.Columns.AddRange(new ColumnHeader[] { namn, antalPoddar });
            lvMinaKategorier.FullRowSelect = true;
            lvMinaKategorier.GridLines = true;
            lvMinaKategorier.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvMinaKategorier.Location = new Point(55, 107);
            lvMinaKategorier.MultiSelect = false;
            lvMinaKategorier.Name = "lvMinaKategorier";
            lvMinaKategorier.Size = new Size(224, 312);
            lvMinaKategorier.TabIndex = 4;
            lvMinaKategorier.UseCompatibleStateImageBehavior = false;
            lvMinaKategorier.View = View.Details;
            lvMinaKategorier.Click += lvMinaKategorier_Click;
            // 
            // namn
            // 
            namn.Text = "Namn";
            namn.Width = 130;
            // 
            // antalPoddar
            // 
            antalPoddar.Text = "Antal poddar";
            antalPoddar.Width = 90;
            // 
            // lbPoddarIKategorin
            // 
            lbPoddarIKategorin.FormattingEnabled = true;
            lbPoddarIKategorin.ItemHeight = 15;
            lbPoddarIKategorin.Location = new Point(296, 107);
            lbPoddarIKategorin.Name = "lbPoddarIKategorin";
            lbPoddarIKategorin.Size = new Size(263, 139);
            lbPoddarIKategorin.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(252, 12);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 6;
            label2.Text = "Poddar i kategorin";
            // 
            // btnRaderaKategori
            // 
            btnRaderaKategori.Location = new Point(296, 396);
            btnRaderaKategori.Name = "btnRaderaKategori";
            btnRaderaKategori.Size = new Size(263, 23);
            btnRaderaKategori.TabIndex = 7;
            btnRaderaKategori.Text = "Radera vald kategori";
            btnRaderaKategori.UseVisualStyleBackColor = true;
            btnRaderaKategori.Click += btnRaderaKategori_Click;
            // 
            // btnBytNamn
            // 
            btnBytNamn.Location = new Point(296, 318);
            btnBytNamn.Name = "btnBytNamn";
            btnBytNamn.Size = new Size(263, 23);
            btnBytNamn.TabIndex = 8;
            btnBytNamn.Text = "Byt namn för vald kategori";
            btnBytNamn.UseVisualStyleBackColor = true;
            btnBytNamn.Click += btnBytNamn_Click;
            // 
            // tbUppdateraNamn
            // 
            tbUppdateraNamn.Location = new Point(296, 289);
            tbUppdateraNamn.Name = "tbUppdateraNamn";
            tbUppdateraNamn.Size = new Size(263, 23);
            tbUppdateraNamn.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 199);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 10;
            label3.Text = "Nytt namn";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btnSparaNyKategori);
            panel1.Controls.Add(tbNyKategoriNamn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(632, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 312);
            panel1.TabIndex = 11;
            // 
            // btnSparaNyKategori
            // 
            btnSparaNyKategori.Location = new Point(14, 172);
            btnSparaNyKategori.Name = "btnSparaNyKategori";
            btnSparaNyKategori.Size = new Size(101, 40);
            btnSparaNyKategori.TabIndex = 3;
            btnSparaNyKategori.Text = "Spara";
            btnSparaNyKategori.UseVisualStyleBackColor = true;
            btnSparaNyKategori.Click += btnSparaNyKategori_Click;
            // 
            // tbNyKategoriNamn
            // 
            tbNyKategoriNamn.Location = new Point(14, 103);
            tbNyKategoriNamn.Name = "tbNyKategoriNamn";
            tbNyKategoriNamn.Size = new Size(284, 23);
            tbNyKategoriNamn.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 85);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 1;
            label5.Text = "Namn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(169, 28);
            label4.TabIndex = 0;
            label4.Text = "Skapa ny kategori";
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(871, 12);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(75, 23);
            btnTillbaka.TabIndex = 12;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(lblMinaKategorier);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(44, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 380);
            panel2.TabIndex = 13;
            // 
            // HanteraKategorierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 537);
            Controls.Add(btnTillbaka);
            Controls.Add(tbUppdateraNamn);
            Controls.Add(btnBytNamn);
            Controls.Add(btnRaderaKategori);
            Controls.Add(lbPoddarIKategorin);
            Controls.Add(lvMinaKategorier);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "HanteraKategorierForm";
            Text = "HanteraKategorierForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMinaKategorier;
        private ListView lvMinaKategorier;
        private ListBox lbPoddarIKategorin;
        private Label label2;
        private Button btnRaderaKategori;
        private Button btnBytNamn;
        private TextBox tbUppdateraNamn;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private TextBox tbNyKategoriNamn;
        private Label label5;
        private Button btnSparaNyKategori;
        private Button btnTillbaka;
        private Panel panel2;
        private ColumnHeader namn;
        private ColumnHeader antalPoddar;
    }
}