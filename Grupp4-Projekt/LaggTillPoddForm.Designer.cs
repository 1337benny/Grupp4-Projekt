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
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 29F);
            lblRubrik.Location = new Point(184, 9);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(451, 66);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Lägg till ny podcast";
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(760, 65);
            btnTillbaka.Margin = new Padding(3, 4, 3, 4);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(86, 31);
            btnTillbaka.TabIndex = 1;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(184, 137);
            tbUrl.Margin = new Padding(3, 4, 3, 4);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(407, 27);
            tbUrl.TabIndex = 2;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(311, 101);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(149, 20);
            lblUrl.TabIndex = 3;
            lblUrl.Text = "Klistra in flödets URL:";
            // 
            // btnHamtaUrl
            // 
            btnHamtaUrl.Location = new Point(599, 137);
            btnHamtaUrl.Margin = new Padding(3, 4, 3, 4);
            btnHamtaUrl.Name = "btnHamtaUrl";
            btnHamtaUrl.Size = new Size(86, 31);
            btnHamtaUrl.TabIndex = 4;
            btnHamtaUrl.Text = "Hämta URL";
            btnHamtaUrl.UseVisualStyleBackColor = true;
            btnHamtaUrl.Click += btnHamtaUrl_Click;
            // 
            // tbNamn
            // 
            tbNamn.Enabled = false;
            tbNamn.Location = new Point(50, 226);
            tbNamn.Margin = new Padding(3, 4, 3, 4);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(407, 27);
            tbNamn.TabIndex = 5;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(50, 202);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(49, 20);
            lblNamn.TabIndex = 6;
            lblNamn.Text = "Namn";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(760, 198);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(91, 20);
            lblAvsnitt.TabIndex = 8;
            lblAvsnitt.Text = "Antal avsnitt";
            // 
            // tbAntalAvsnitt
            // 
            tbAntalAvsnitt.Enabled = false;
            tbAntalAvsnitt.Location = new Point(762, 227);
            tbAntalAvsnitt.Margin = new Padding(3, 4, 3, 4);
            tbAntalAvsnitt.Name = "tbAntalAvsnitt";
            tbAntalAvsnitt.Size = new Size(83, 27);
            tbAntalAvsnitt.TabIndex = 7;
            // 
            // lbAllaAvsnitt
            // 
            lbAllaAvsnitt.FormattingEnabled = true;
            lbAllaAvsnitt.Location = new Point(50, 261);
            lbAllaAvsnitt.Margin = new Padding(3, 4, 3, 4);
            lbAllaAvsnitt.Name = "lbAllaAvsnitt";
            lbAllaAvsnitt.Size = new Size(405, 384);
            lbAllaAvsnitt.TabIndex = 9;
            lbAllaAvsnitt.Click += lbAllaAvsnitt_Click;
            // 
            // rtbAvsnittInfo
            // 
            rtbAvsnittInfo.Location = new Point(475, 261);
            rtbAvsnittInfo.Margin = new Padding(3, 4, 3, 4);
            rtbAvsnittInfo.Name = "rtbAvsnittInfo";
            rtbAvsnittInfo.Size = new Size(370, 265);
            rtbAvsnittInfo.TabIndex = 10;
            rtbAvsnittInfo.Text = "";
            // 
            // btnPrenumerera
            // 
            btnPrenumerera.Font = new Font("Segoe UI", 19F);
            btnPrenumerera.Location = new Point(475, 534);
            btnPrenumerera.Margin = new Padding(3, 4, 3, 4);
            btnPrenumerera.Name = "btnPrenumerera";
            btnPrenumerera.Size = new Size(370, 113);
            btnPrenumerera.TabIndex = 11;
            btnPrenumerera.Text = "Prenumerera";
            btnPrenumerera.UseVisualStyleBackColor = true;
            btnPrenumerera.Click += btnPrenumerera_Click;
            // 
            // cbValjKategori
            // 
            cbValjKategori.FormattingEnabled = true;
            cbValjKategori.Items.AddRange(new object[] { "Humor", "Nöje", "Sport", "Dokumentär" });
            cbValjKategori.Location = new Point(477, 226);
            cbValjKategori.Margin = new Padding(3, 4, 3, 4);
            cbValjKategori.Name = "cbValjKategori";
            cbValjKategori.Size = new Size(241, 28);
            cbValjKategori.TabIndex = 12;
            // 
            // lblValjKategori
            // 
            lblValjKategori.AutoSize = true;
            lblValjKategori.Location = new Point(477, 202);
            lblValjKategori.Name = "lblValjKategori";
            lblValjKategori.Size = new Size(66, 20);
            lblValjKategori.TabIndex = 13;
            lblValjKategori.Text = "Kategori";
            // 
            // LaggTillPoddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 717);
            Controls.Add(lblValjKategori);
            Controls.Add(cbValjKategori);
            Controls.Add(btnPrenumerera);
            Controls.Add(rtbAvsnittInfo);
            Controls.Add(lbAllaAvsnitt);
            Controls.Add(lblAvsnitt);
            Controls.Add(tbAntalAvsnitt);
            Controls.Add(lblNamn);
            Controls.Add(tbNamn);
            Controls.Add(btnHamtaUrl);
            Controls.Add(lblUrl);
            Controls.Add(tbUrl);
            Controls.Add(btnTillbaka);
            Controls.Add(lblRubrik);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LaggTillPoddForm";
            Text = "Form2";
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
    }
}