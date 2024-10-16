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
            lblFlodetsNamn = new Label();
            tbFlodetsNamn = new TextBox();
            tbAntalAvsnitt = new TextBox();
            label1 = new Label();
            lblAllaAvsnitt = new Label();
            lbxAllaAvsnitt = new ListBox();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI", 29F);
            lblRubrik.Location = new Point(818, 9);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(357, 52);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Lägg till ny podcast";
            // 
            // btnTillbaka
            // 
            btnTillbaka.Location = new Point(1977, 30);
            btnTillbaka.Name = "btnTillbaka";
            btnTillbaka.Size = new Size(75, 23);
            btnTillbaka.TabIndex = 1;
            btnTillbaka.Text = "Tillbaka";
            btnTillbaka.UseVisualStyleBackColor = true;
            btnTillbaka.Click += btnTillbaka_Click;
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(818, 171);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(357, 23);
            tbUrl.TabIndex = 2;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(929, 144);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(118, 15);
            lblUrl.TabIndex = 3;
            lblUrl.Text = "Klistra in flödets URL:";
            // 
            // btnHamtaUrl
            // 
            btnHamtaUrl.Location = new Point(1181, 171);
            btnHamtaUrl.Name = "btnHamtaUrl";
            btnHamtaUrl.Size = new Size(75, 23);
            btnHamtaUrl.TabIndex = 4;
            btnHamtaUrl.Text = "Hämta URL";
            btnHamtaUrl.UseVisualStyleBackColor = true;
            btnHamtaUrl.Click += btnHamtaUrl_Click;
            // 
            // lblFlodetsNamn
            // 
            lblFlodetsNamn.AutoSize = true;
            lblFlodetsNamn.Location = new Point(804, 376);
            lblFlodetsNamn.Name = "lblFlodetsNamn";
            lblFlodetsNamn.Size = new Size(79, 15);
            lblFlodetsNamn.TabIndex = 5;
            lblFlodetsNamn.Text = "Flödets namn";
            // 
            // tbFlodetsNamn
            // 
            tbFlodetsNamn.Location = new Point(804, 403);
            tbFlodetsNamn.Name = "tbFlodetsNamn";
            tbFlodetsNamn.Size = new Size(367, 23);
            tbFlodetsNamn.TabIndex = 6;
            // 
            // tbAntalAvsnitt
            // 
            tbAntalAvsnitt.Location = new Point(804, 470);
            tbAntalAvsnitt.Name = "tbAntalAvsnitt";
            tbAntalAvsnitt.Size = new Size(188, 23);
            tbAntalAvsnitt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(804, 443);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 7;
            label1.Text = "Antal avsnitt";
            // 
            // lblAllaAvsnitt
            // 
            lblAllaAvsnitt.AutoSize = true;
            lblAllaAvsnitt.Location = new Point(807, 512);
            lblAllaAvsnitt.Name = "lblAllaAvsnitt";
            lblAllaAvsnitt.Size = new Size(65, 15);
            lblAllaAvsnitt.TabIndex = 9;
            lblAllaAvsnitt.Text = "Alla avsnitt";
            // 
            // lbxAllaAvsnitt
            // 
            lbxAllaAvsnitt.FormattingEnabled = true;
            lbxAllaAvsnitt.ItemHeight = 15;
            lbxAllaAvsnitt.Location = new Point(809, 541);
            lbxAllaAvsnitt.Name = "lbxAllaAvsnitt";
            lbxAllaAvsnitt.Size = new Size(362, 259);
            lbxAllaAvsnitt.TabIndex = 10;
            // 
            // LaggTillPoddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2098, 949);
            Controls.Add(lbxAllaAvsnitt);
            Controls.Add(lblAllaAvsnitt);
            Controls.Add(tbAntalAvsnitt);
            Controls.Add(label1);
            Controls.Add(tbFlodetsNamn);
            Controls.Add(lblFlodetsNamn);
            Controls.Add(btnHamtaUrl);
            Controls.Add(lblUrl);
            Controls.Add(tbUrl);
            Controls.Add(btnTillbaka);
            Controls.Add(lblRubrik);
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
        private Label lblFlodetsNamn;
        private TextBox tbFlodetsNamn;
        private TextBox tbAntalAvsnitt;
        private Label label1;
        private Label lblAllaAvsnitt;
        private ListBox lbxAllaAvsnitt;
    }
}