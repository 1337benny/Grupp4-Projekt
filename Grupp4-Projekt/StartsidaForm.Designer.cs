namespace Grupp4_Projekt
{
    partial class StartsidaForm
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
            lblMeny = new Label();
            btnLaggTillNyPodd = new Button();
            btnHanteraMinaPoddar = new Button();
            btnHanteraKategorier = new Button();
            lvMinaPoddar = new ListView();
            Namn = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnAvsluta = new Button();
            panel1 = new Panel();
            cbFiltreraPaKategori = new ComboBox();
            label3 = new Label();
            rtbBeskrivning = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            lbAvsnitt = new ListBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnAterstall = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 29F);
            lblRubrik.Location = new Point(14, 132);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(271, 52);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Mina Podcasts";
            // 
            // lblMeny
            // 
            lblMeny.AutoSize = true;
            lblMeny.FlatStyle = FlatStyle.Flat;
            lblMeny.Font = new Font("Segoe UI", 18F);
            lblMeny.Location = new Point(10, 9);
            lblMeny.Name = "lblMeny";
            lblMeny.Size = new Size(75, 32);
            lblMeny.TabIndex = 1;
            lblMeny.Text = "Meny";
            // 
            // btnLaggTillNyPodd
            // 
            btnLaggTillNyPodd.Location = new Point(3, 44);
            btnLaggTillNyPodd.Name = "btnLaggTillNyPodd";
            btnLaggTillNyPodd.Size = new Size(140, 23);
            btnLaggTillNyPodd.TabIndex = 2;
            btnLaggTillNyPodd.Text = "Lägg till ny podd";
            btnLaggTillNyPodd.UseVisualStyleBackColor = true;
            btnLaggTillNyPodd.Click += btnLaggTillNyPodd_Click;
            // 
            // btnHanteraMinaPoddar
            // 
            btnHanteraMinaPoddar.Location = new Point(149, 44);
            btnHanteraMinaPoddar.Name = "btnHanteraMinaPoddar";
            btnHanteraMinaPoddar.Size = new Size(140, 23);
            btnHanteraMinaPoddar.TabIndex = 3;
            btnHanteraMinaPoddar.Text = "Hantera mina poddar";
            btnHanteraMinaPoddar.UseVisualStyleBackColor = true;
            btnHanteraMinaPoddar.Click += btnHanteraMinaPoddar_Click;
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.Location = new Point(295, 44);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(140, 23);
            btnHanteraKategorier.TabIndex = 4;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.UseVisualStyleBackColor = true;
            btnHanteraKategorier.Click += btnHanteraKategorier_Click;
            // 
            // lvMinaPoddar
            // 
            lvMinaPoddar.Columns.AddRange(new ColumnHeader[] { Namn, columnHeader1, columnHeader2, columnHeader3 });
            lvMinaPoddar.FullRowSelect = true;
            lvMinaPoddar.GridLines = true;
            lvMinaPoddar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvMinaPoddar.Location = new Point(14, 187);
            lvMinaPoddar.MultiSelect = false;
            lvMinaPoddar.Name = "lvMinaPoddar";
            lvMinaPoddar.Size = new Size(584, 290);
            lvMinaPoddar.TabIndex = 7;
            lvMinaPoddar.UseCompatibleStateImageBehavior = false;
            lvMinaPoddar.View = View.Details;
            lvMinaPoddar.Click += lvMinaPoddar_Click;
            // 
            // Namn
            // 
            Namn.Text = "Namn";
            Namn.Width = 160;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Titel";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kategori";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Antal avsnitt";
            columnHeader3.Width = 100;
            // 
            // btnAvsluta
            // 
            btnAvsluta.Location = new Point(13, 12);
            btnAvsluta.Name = "btnAvsluta";
            btnAvsluta.Size = new Size(75, 23);
            btnAvsluta.TabIndex = 8;
            btnAvsluta.Text = "Avsluta";
            btnAvsluta.UseVisualStyleBackColor = true;
            btnAvsluta.Click += btnAvsluta_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(btnAterstall);
            panel1.Controls.Add(cbFiltreraPaKategori);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rtbBeskrivning);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbAvsnitt);
            panel1.Controls.Add(btnAvsluta);
            panel1.Controls.Add(lblRubrik);
            panel1.Controls.Add(lvMinaPoddar);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 543);
            panel1.TabIndex = 9;
            // 
            // cbFiltreraPaKategori
            // 
            cbFiltreraPaKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltreraPaKategori.FormattingEnabled = true;
            cbFiltreraPaKategori.Location = new Point(333, 153);
            cbFiltreraPaKategori.Name = "cbFiltreraPaKategori";
            cbFiltreraPaKategori.Size = new Size(166, 23);
            cbFiltreraPaKategori.TabIndex = 16;
            cbFiltreraPaKategori.SelectedValueChanged += cbFiltreraPaKategori_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(333, 132);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 15;
            label3.Text = "Filtrera på kategori";
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(616, 329);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(329, 148);
            rtbBeskrivning.TabIndex = 14;
            rtbBeskrivning.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(616, 305);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 13;
            label2.Text = "Avsnittsbeskrivning";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(616, 124);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 11;
            label1.Text = "Avsnitt";
            // 
            // lbAvsnitt
            // 
            lbAvsnitt.FormattingEnabled = true;
            lbAvsnitt.ItemHeight = 15;
            lbAvsnitt.Location = new Point(616, 148);
            lbAvsnitt.Name = "lbAvsnitt";
            lbAvsnitt.Size = new Size(332, 154);
            lbAvsnitt.TabIndex = 10;
            lbAvsnitt.Click += lbAvsnitt_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(498, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 103);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(lblMeny);
            panel3.Controls.Add(btnLaggTillNyPodd);
            panel3.Controls.Add(btnHanteraMinaPoddar);
            panel3.Controls.Add(btnHanteraKategorier);
            panel3.Location = new Point(15, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 79);
            panel3.TabIndex = 2;
            // 
            // btnAterstall
            // 
            btnAterstall.Location = new Point(505, 152);
            btnAterstall.Name = "btnAterstall";
            btnAterstall.Size = new Size(93, 23);
            btnAterstall.TabIndex = 17;
            btnAterstall.Text = "Återställ";
            btnAterstall.UseVisualStyleBackColor = true;
            btnAterstall.Click += btnAterstall_Click;
            // 
            // StartsidaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 537);
            Controls.Add(panel1);
            Name = "StartsidaForm";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblRubrik;
        private Label lblMeny;
        private Button btnLaggTillNyPodd;
        private Button btnHanteraMinaPoddar;
        private Button btnHanteraKategorier;
        private ListView lvMinaPoddar;
        private ColumnHeader Namn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnAvsluta;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ListBox lbAvsnitt;
        private Panel panel3;
        private Label label2;
        private RichTextBox rtbBeskrivning;
        private ComboBox cbFiltreraPaKategori;
        private Label label3;
        private Button btnAterstall;
    }
}