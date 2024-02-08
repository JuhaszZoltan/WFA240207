namespace WFA240207
{
    partial class FrmReszletek
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
            lblNev = new Label();
            lblUI01 = new Label();
            lblFoglalkozasok = new Label();
            lblUI02 = new Label();
            lblEvek = new Label();
            SuspendLayout();
            // 
            // lblNev
            // 
            lblNev.BackColor = Color.LightCoral;
            lblNev.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNev.Location = new Point(12, 9);
            lblNev.Name = "lblNev";
            lblNev.Size = new Size(360, 66);
            lblNev.TabIndex = 0;
            lblNev.Text = "###díjazott neve###";
            lblNev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUI01
            // 
            lblUI01.BackColor = Color.IndianRed;
            lblUI01.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUI01.Location = new Point(12, 75);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(360, 30);
            lblUI01.TabIndex = 1;
            lblUI01.Text = "Fő foglalkozásai:";
            lblUI01.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFoglalkozasok
            // 
            lblFoglalkozasok.BackColor = Color.IndianRed;
            lblFoglalkozasok.Font = new Font("Segoe UI", 12F);
            lblFoglalkozasok.Location = new Point(12, 117);
            lblFoglalkozasok.Name = "lblFoglalkozasok";
            lblFoglalkozasok.Size = new Size(360, 180);
            lblFoglalkozasok.TabIndex = 1;
            lblFoglalkozasok.Text = "[*] foglalkozas 01\r\n[*] foglalkozás 02\r\n[*] foglalkozas 03";
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUI02.Location = new Point(12, 317);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(131, 21);
            lblUI02.TabIndex = 2;
            lblUI02.Text = "A díjat elnyerte:";
            // 
            // lblEvek
            // 
            lblEvek.AutoSize = true;
            lblEvek.Location = new Point(149, 317);
            lblEvek.Name = "lblEvek";
            lblEvek.Size = new Size(135, 21);
            lblEvek.TabIndex = 3;
            lblEvek.Text = "év01, év02, év03...";
            // 
            // FrmReszletek
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(384, 361);
            Controls.Add(lblEvek);
            Controls.Add(lblUI02);
            Controls.Add(lblFoglalkozasok);
            Controls.Add(lblUI01);
            Controls.Add(lblNev);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmReszletek";
            Text = "Részletek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNev;
        private Label lblUI01;
        private Label lblFoglalkozasok;
        private Label lblUI02;
        private Label lblEvek;
    }
}