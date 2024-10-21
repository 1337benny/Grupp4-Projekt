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
            lbMinaPoddar = new ListBox();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 29F);
            lblRubrik.Location = new Point(205, 9);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(340, 66);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Mina Podcasts";
            // 
            // lblMeny
            // 
            lblMeny.AutoSize = true;
            lblMeny.FlatStyle = FlatStyle.Flat;
            lblMeny.Font = new Font("Segoe UI", 19F);
            lblMeny.Location = new Point(952, 40);
            lblMeny.Name = "lblMeny";
            lblMeny.Size = new Size(99, 45);
            lblMeny.TabIndex = 1;
            lblMeny.Text = "Meny";
            // 
            // btnLaggTillNyPodd
            // 
            btnLaggTillNyPodd.Location = new Point(891, 109);
            btnLaggTillNyPodd.Margin = new Padding(3, 4, 3, 4);
            btnLaggTillNyPodd.Name = "btnLaggTillNyPodd";
            btnLaggTillNyPodd.Size = new Size(160, 31);
            btnLaggTillNyPodd.TabIndex = 2;
            btnLaggTillNyPodd.Text = "Lägg till ny podd";
            btnLaggTillNyPodd.UseVisualStyleBackColor = true;
            btnLaggTillNyPodd.Click += btnLaggTillNyPodd_Click;
            // 
            // btnHanteraMinaPoddar
            // 
            btnHanteraMinaPoddar.Location = new Point(891, 169);
            btnHanteraMinaPoddar.Margin = new Padding(3, 4, 3, 4);
            btnHanteraMinaPoddar.Name = "btnHanteraMinaPoddar";
            btnHanteraMinaPoddar.Size = new Size(160, 31);
            btnHanteraMinaPoddar.TabIndex = 3;
            btnHanteraMinaPoddar.Text = "Hantera mina poddar";
            btnHanteraMinaPoddar.UseVisualStyleBackColor = true;
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.Location = new Point(891, 228);
            btnHanteraKategorier.Margin = new Padding(3, 4, 3, 4);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(160, 31);
            btnHanteraKategorier.TabIndex = 4;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.UseVisualStyleBackColor = true;
            // 
            // lbMinaPoddar
            // 
            lbMinaPoddar.FormattingEnabled = true;
            lbMinaPoddar.Location = new Point(33, 109);
            lbMinaPoddar.Margin = new Padding(3, 4, 3, 4);
            lbMinaPoddar.Name = "lbMinaPoddar";
            lbMinaPoddar.Size = new Size(693, 504);
            lbMinaPoddar.TabIndex = 5;
            // 
            // StartsidaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 647);
            Controls.Add(lbMinaPoddar);
            Controls.Add(btnHanteraKategorier);
            Controls.Add(btnHanteraMinaPoddar);
            Controls.Add(btnLaggTillNyPodd);
            Controls.Add(lblMeny);
            Controls.Add(lblRubrik);
            Margin = new Padding(3, 4, 3, 4);
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
        private ListBox lbMinaPoddar;
    }
}