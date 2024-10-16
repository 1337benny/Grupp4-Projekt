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
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 29F);
            lblRubrik.Location = new Point(870, 9);
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
            lblMeny.Location = new Point(2007, 74);
            lblMeny.Name = "lblMeny";
            lblMeny.Size = new Size(80, 36);
            lblMeny.TabIndex = 1;
            lblMeny.Text = "Meny";
            // 
            // btnLaggTillNyPodd
            // 
            btnLaggTillNyPodd.Location = new Point(1942, 129);
            btnLaggTillNyPodd.Name = "btnLaggTillNyPodd";
            btnLaggTillNyPodd.Size = new Size(140, 23);
            btnLaggTillNyPodd.TabIndex = 2;
            btnLaggTillNyPodd.Text = "Lägg till ny podd";
            btnLaggTillNyPodd.UseVisualStyleBackColor = true;
            btnLaggTillNyPodd.Click += this.btnLaggTillNyPodd_Click;
            // 
            // btnHanteraMinaPoddar
            // 
            btnHanteraMinaPoddar.Location = new Point(1942, 174);
            btnHanteraMinaPoddar.Name = "btnHanteraMinaPoddar";
            btnHanteraMinaPoddar.Size = new Size(140, 23);
            btnHanteraMinaPoddar.TabIndex = 3;
            btnHanteraMinaPoddar.Text = "Hantera mina poddar";
            btnHanteraMinaPoddar.UseVisualStyleBackColor = true;
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.Location = new Point(1942, 218);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(140, 23);
            btnHanteraKategorier.TabIndex = 4;
            btnHanteraKategorier.Text = "Hantera kategorier";
            btnHanteraKategorier.UseVisualStyleBackColor = true;
            // 
            // StartsidaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2099, 949);
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
    }
}