namespace Grupp4_Projekt
{
    partial class LaggTillPoddForm
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
            lblRubrik = new Label();
            btnTillbaka = new Button();
            tbUrl = new TextBox();
            lblUrl = new Label();
            btnHamtaUrl = new Button();
            tbNamn = new TextBox();
            lblNamn = new Label();
            lblAvsnitt = new Label();
            tbAntalAvsnitt = new TextBox();
            lbAllaAvsnitt = new ListBox();
            rtbAvsnittInfo = new RichTextBox();
            btnPrenumerera = new Button();
            cbValjKategori = new ComboBox();
            lblValjKategori = new Label();
            lbEgetNamn = new Label();
            tbEgetNamn = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 29F);
            lblRubrik.Location = new Point(228, 10);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(357, 52);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Lägg till ny podcast";
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(852, 22);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(106, 40);
            btnTillbaka.TabIndex = 1;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(161, 103);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(357, 23);
            tbUrl.TabIndex = 2;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Font = new Font("Segoe UI", 13F);
            lblUrl.Location = new Point(258, 76);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(178, 25);
            lblUrl.TabIndex = 3;
            lblUrl.Text = "Klistra in flödets URL:";
            // 
            // btnHamtaUrl
            // 
            btnHamtaUrl.Location = new Point(525, 104);
            btnHamtaUrl.Name = "btnHamtaUrl";
            btnHamtaUrl.Size = new Size(75, 23);
            btnHamtaUrl.TabIndex = 4;
            btnHamtaUrl.Text = "Hämta URL";
            btnHamtaUrl.UseVisualStyleBackColor = true;
            btnHamtaUrl.Click += btnHamtaUrl_Click;
            // 
            // tbNamn
            // 
            tbNamn.Enabled = false;
            tbNamn.Location = new Point(44, 170);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(355, 23);
            tbNamn.TabIndex = 5;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(45, 153);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(29, 15);
            lblNamn.TabIndex = 6;
            lblNamn.Text = "Titel";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(689, 153);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(73, 15);
            lblAvsnitt.TabIndex = 8;
            lblAvsnitt.Text = "Antal avsnitt";
            // 
            // tbAntalAvsnitt
            // 
            tbAntalAvsnitt.Enabled = false;
            tbAntalAvsnitt.Location = new Point(689, 171);
            tbAntalAvsnitt.Name = "tbAntalAvsnitt";
            tbAntalAvsnitt.Size = new Size(73, 23);
            tbAntalAvsnitt.TabIndex = 7;
            // 
            // lbAllaAvsnitt
            // 
            lbAllaAvsnitt.FormattingEnabled = true;
            lbAllaAvsnitt.ItemHeight = 15;
            lbAllaAvsnitt.Location = new Point(45, 259);
            lbAllaAvsnitt.Name = "lbAllaAvsnitt";
            lbAllaAvsnitt.Size = new Size(355, 259);
            lbAllaAvsnitt.TabIndex = 9;
            lbAllaAvsnitt.Click += lbAllaAvsnitt_Click;
            // 
            // rtbAvsnittInfo
            // 
            rtbAvsnittInfo.Location = new Point(438, 227);
            rtbAvsnittInfo.Name = "rtbAvsnittInfo";
            rtbAvsnittInfo.Size = new Size(324, 200);
            rtbAvsnittInfo.TabIndex = 10;
            rtbAvsnittInfo.Text = "";
            // 
            // btnPrenumerera
            // 
            btnPrenumerera.Font = new Font("Segoe UI", 19F);
            btnPrenumerera.Location = new Point(438, 433);
            btnPrenumerera.Name = "btnPrenumerera";
            btnPrenumerera.Size = new Size(324, 85);
            btnPrenumerera.TabIndex = 11;
            btnPrenumerera.Text = "Prenumerera";
            btnPrenumerera.UseVisualStyleBackColor = true;
            btnPrenumerera.Click += btnPrenumerera_Click;
            // 
            // cbValjKategori
            // 
            cbValjKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbValjKategori.FormattingEnabled = true;
            cbValjKategori.Location = new Point(438, 171);
            cbValjKategori.Name = "cbValjKategori";
            cbValjKategori.Size = new Size(211, 23);
            cbValjKategori.TabIndex = 12;
            // 
            // lblValjKategori
            // 
            lblValjKategori.AutoSize = true;
            lblValjKategori.Location = new Point(438, 153);
            lblValjKategori.Name = "lblValjKategori";
            lblValjKategori.Size = new Size(51, 15);
            lblValjKategori.TabIndex = 13;
            lblValjKategori.Text = "Kategori";
            // 
            // lbEgetNamn
            // 
            lbEgetNamn.AutoSize = true;
            lbEgetNamn.Location = new Point(45, 197);
            lbEgetNamn.Name = "lbEgetNamn";
            lbEgetNamn.Size = new Size(64, 15);
            lbEgetNamn.TabIndex = 14;
            lbEgetNamn.Text = "Eget namn";
            // 
            // tbEgetNamn
            // 
            tbEgetNamn.Location = new Point(45, 215);
            tbEgetNamn.Name = "tbEgetNamn";
            tbEgetNamn.Size = new Size(355, 23);
            tbEgetNamn.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(cbValjKategori);
            panel1.Controls.Add(tbEgetNamn);
            panel1.Controls.Add(tbAntalAvsnitt);
            panel1.Controls.Add(lbAllaAvsnitt);
            panel1.Controls.Add(lblRubrik);
            panel1.Controls.Add(lbEgetNamn);
            panel1.Controls.Add(rtbAvsnittInfo);
            panel1.Controls.Add(btnPrenumerera);
            panel1.Controls.Add(lblUrl);
            panel1.Controls.Add(lblValjKategori);
            panel1.Controls.Add(lblNamn);
            panel1.Controls.Add(lblAvsnitt);
            panel1.Controls.Add(btnTillbaka);
            panel1.Controls.Add(btnHamtaUrl);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 542);
            panel1.TabIndex = 16;
            // 
            // LaggTillPoddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 537);
            Controls.Add(tbNamn);
            Controls.Add(tbUrl);
            Controls.Add(panel1);
            Name = "LaggTillPoddForm";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRubrik;
        private Button btnTillbaka;
        private TextBox tbUrl;
        private Label lblUrl;
        private Button btnHamtaUrl;
        private TextBox tbNamn;
        private Label lblNamn;
        private Label lblAvsnitt;
        private TextBox tbAntalAvsnitt;
        private ListBox lbAllaAvsnitt;
        private RichTextBox rtbAvsnittInfo;
        private Button btnPrenumerera;
        private ComboBox cbValjKategori;
        private Label lblValjKategori;
        private Label lbEgetNamn;
        private TextBox tbEgetNamn;
        private Panel panel1;
    }
}