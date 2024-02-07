namespace WFA240207
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            újToolStripMenuItem = new ToolStripMenuItem();
            keresésToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            dgvDijazottak = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDijazottak).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightCoral;
            menuStrip1.Items.AddRange(new ToolStripItem[] { újToolStripMenuItem, keresésToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(434, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // újToolStripMenuItem
            // 
            újToolStripMenuItem.Name = "újToolStripMenuItem";
            újToolStripMenuItem.Size = new Size(30, 20);
            újToolStripMenuItem.Text = "Új";
            // 
            // keresésToolStripMenuItem
            // 
            keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            keresésToolStripMenuItem.Size = new Size(58, 20);
            keresésToolStripMenuItem.Text = "Keresés";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            // 
            // dgvDijazottak
            // 
            dgvDijazottak.AllowUserToAddRows = false;
            dgvDijazottak.AllowUserToDeleteRows = false;
            dgvDijazottak.AllowUserToResizeColumns = false;
            dgvDijazottak.AllowUserToResizeRows = false;
            dgvDijazottak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDijazottak.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDijazottak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDijazottak.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvDijazottak.Location = new Point(12, 42);
            dgvDijazottak.Name = "dgvDijazottak";
            dgvDijazottak.RowHeadersVisible = false;
            dgvDijazottak.Size = new Size(410, 307);
            dgvDijazottak.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.FillWeight = 2F;
            Column1.HeaderText = "év";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 8F;
            Column2.HeaderText = "személy";
            Column2.Name = "Column2";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(434, 361);
            Controls.Add(dgvDijazottak);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 6, 4, 6);
            Name = "FrmMain";
            Text = "A József Attila Díj birtokosai";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDijazottak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem újToolStripMenuItem;
        private ToolStripMenuItem keresésToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private DataGridView dgvDijazottak;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
