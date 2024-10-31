namespace Grupp4_Projekt
{
    partial class HanteraPodcastForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            lbPodcastTitel = new Label();
            btnSparaAndringar = new Button();
            cbValjKategori = new ComboBox();
            label3 = new Label();
            tbNyttNamn = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnRaderaPodcast = new Button();
            lvMinaPoddar = new ListView();
            Namn = new ColumnHeader();
            Titel = new ColumnHeader();
            Kategori = new ColumnHeader();
            Url = new ColumnHeader();
            lblRubrik = new Label();
            btnTillbaka = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnRaderaPodcast);
            panel1.Controls.Add(lvMinaPoddar);
            panel1.Controls.Add(lblRubrik);
            panel1.Controls.Add(btnTillbaka);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 543);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(lbPodcastTitel);
            panel2.Controls.Add(btnSparaAndringar);
            panel2.Controls.Add(cbValjKategori);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tbNyttNamn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(603, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 204);
            panel2.TabIndex = 5;
            // 
            // lbPodcastTitel
            // 
            lbPodcastTitel.AutoSize = true;
            lbPodcastTitel.Font = new Font("Segoe UI", 14F);
            lbPodcastTitel.Location = new Point(125, 9);
            lbPodcastTitel.Name = "lbPodcastTitel";
            lbPodcastTitel.Size = new Size(0, 25);
            lbPodcastTitel.TabIndex = 9;
            // 
            // btnSparaAndringar
            // 
            btnSparaAndringar.Location = new Point(215, 156);
            btnSparaAndringar.Name = "btnSparaAndringar";
            btnSparaAndringar.Size = new Size(99, 34);
            btnSparaAndringar.TabIndex = 8;
            btnSparaAndringar.Text = "Spara ändringar";
            btnSparaAndringar.UseVisualStyleBackColor = true;
            btnSparaAndringar.Click += btnSparaAndringar_Click;
            // 
            // cbValjKategori
            // 
            cbValjKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbValjKategori.FormattingEnabled = true;
            cbValjKategori.Location = new Point(18, 114);
            cbValjKategori.Name = "cbValjKategori";
            cbValjKategori.Size = new Size(172, 23);
            cbValjKategori.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 96);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Kategori";
            // 
            // tbNyttNamn
            // 
            tbNyttNamn.Location = new Point(18, 60);
            tbNyttNamn.Name = "tbNyttNamn";
            tbNyttNamn.Size = new Size(296, 23);
            tbNyttNamn.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 9);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 0;
            label2.Text = "Ändra info för: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 43);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Namn";
            // 
            // btnRaderaPodcast
            // 
            btnRaderaPodcast.Location = new Point(603, 393);
            btnRaderaPodcast.Name = "btnRaderaPodcast";
            btnRaderaPodcast.Size = new Size(213, 43);
            btnRaderaPodcast.TabIndex = 3;
            btnRaderaPodcast.Text = "Radera vald podcast";
            btnRaderaPodcast.UseVisualStyleBackColor = true;
            btnRaderaPodcast.Click += btnRaderaPodcast_Click;
            // 
            // lvMinaPoddar
            // 
            lvMinaPoddar.Columns.AddRange(new ColumnHeader[] { Namn, Titel, Kategori, Url });
            lvMinaPoddar.FullRowSelect = true;
            lvMinaPoddar.GridLines = true;
            lvMinaPoddar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvMinaPoddar.Location = new Point(48, 85);
            lvMinaPoddar.MultiSelect = false;
            lvMinaPoddar.Name = "lvMinaPoddar";
            lvMinaPoddar.Size = new Size(524, 351);
            lvMinaPoddar.TabIndex = 2;
            lvMinaPoddar.UseCompatibleStateImageBehavior = false;
            lvMinaPoddar.View = View.Details;
            lvMinaPoddar.Click += lvMinaPoddar_Click;
            // 
            // Namn
            // 
            Namn.Text = "Namn";
            Namn.Width = 150;
            // 
            // Titel
            // 
            Titel.Text = "Titel";
            Titel.Width = 150;
            // 
            // Kategori
            // 
            Kategori.Text = "Kategori";
            Kategori.Width = 110;
            // 
            // Url
            // 
            Url.Text = "Url";
            Url.Width = 110;
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 19F);
            lblRubrik.Location = new Point(324, 10);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(277, 36);
            lblRubrik.TabIndex = 1;
            lblRubrik.Text = "Hantera mina podcasts";
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(866, 13);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(91, 33);
            btnTillbaka.TabIndex = 0;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // HanteraPodcastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 537);
            Controls.Add(panel1);
            Name = "HanteraPodcastForm";
            Text = "HanteraPodcastForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTillbaka;
        private ListView lvMinaPoddar;
        private ColumnHeader Namn;
        private ColumnHeader Titel;
        private ColumnHeader Kategori;
        private Label lblRubrik;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Button btnRaderaPodcast;
        private Label lbPodcastTitel;
        private Button btnSparaAndringar;
        private ComboBox cbValjKategori;
        private Label label3;
        private TextBox tbNyttNamn;
        private ColumnHeader Url;
    }
}