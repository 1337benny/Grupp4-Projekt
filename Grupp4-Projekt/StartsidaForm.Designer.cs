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
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 29F);
            lblRubrik.Location = new Point(179, 7);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(271, 52);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Mina Podcasts";
            // 
            // lblMeny
            // 
            lblMeny.AutoSize = true;
            lblMeny.FlatStyle = FlatStyle.Flat;
            lblMeny.Font = new Font("Segoe UI", 19F);
            lblMeny.Location = new Point(833, 30);
            lblMeny.Name = "lblMeny";
            lblMeny.Size = new Size(80, 36);
            lblMeny.TabIndex = 1;
            lblMeny.Text = "Meny";
            // 
            // btnLaggTillNyPodd
            // 
            btnLaggTillNyPodd.Location = new Point(780, 82);
            btnLaggTillNyPodd.Name = "btnLaggTillNyPodd";
            btnLaggTillNyPodd.Size = new Size(140, 23);
            btnLaggTillNyPodd.TabIndex = 2;
            btnLaggTillNyPodd.Text = "Lägg till ny podd";
            btnLaggTillNyPodd.UseVisualStyleBackColor = true;
            btnLaggTillNyPodd.Click += btnLaggTillNyPodd_Click;
            // 
            // btnHanteraMinaPoddar
            // 
            btnHanteraMinaPoddar.Location = new Point(780, 127);
            btnHanteraMinaPoddar.Name = "btnHanteraMinaPoddar";
            btnHanteraMinaPoddar.Size = new Size(140, 23);
            btnHanteraMinaPoddar.TabIndex = 3;
            btnHanteraMinaPoddar.Text = "Hantera mina poddar";
            btnHanteraMinaPoddar.UseVisualStyleBackColor = true;
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.Location = new Point(780, 171);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(140, 23);
            btnHanteraKategorier.TabIndex = 4;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.UseVisualStyleBackColor = true;
            // 
            // lvMinaPoddar
            // 
            lvMinaPoddar.Columns.AddRange(new ColumnHeader[] { Namn, columnHeader1, columnHeader2, columnHeader3 });
            lvMinaPoddar.FullRowSelect = true;
            lvMinaPoddar.GridLines = true;
            lvMinaPoddar.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvMinaPoddar.Location = new Point(12, 82);
            lvMinaPoddar.MultiSelect = false;
            lvMinaPoddar.Name = "lvMinaPoddar";
            lvMinaPoddar.Size = new Size(584, 290);
            lvMinaPoddar.TabIndex = 7;
            lvMinaPoddar.UseCompatibleStateImageBehavior = false;
            lvMinaPoddar.View = View.Details;
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
            // StartsidaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 485);
            Controls.Add(lvMinaPoddar);
            Controls.Add(btnHanteraKategorier);
            Controls.Add(btnHanteraMinaPoddar);
            Controls.Add(btnLaggTillNyPodd);
            Controls.Add(lblMeny);
            Controls.Add(lblRubrik);
            Name = "StartsidaForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
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
    }
}