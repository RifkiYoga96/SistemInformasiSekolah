namespace SistemInformasiSekolah
{
    partial class Dashboard
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
            menuStrip1 = new MenuStrip();
            formToolStripMenuItem = new ToolStripMenuItem();
            dataIndukToolStripMenuItem = new ToolStripMenuItem();
            mapelToolStripMenuItem = new ToolStripMenuItem();
            jurusanToolStripMenuItem = new ToolStripMenuItem();
            kelasToolStripMenuItem = new ToolStripMenuItem();
            guruToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { formToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1014, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            formToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataIndukToolStripMenuItem, mapelToolStripMenuItem, jurusanToolStripMenuItem, kelasToolStripMenuItem, guruToolStripMenuItem });
            formToolStripMenuItem.Name = "formToolStripMenuItem";
            formToolStripMenuItem.Size = new Size(47, 20);
            formToolStripMenuItem.Text = "Form";
            // 
            // dataIndukToolStripMenuItem
            // 
            dataIndukToolStripMenuItem.Name = "dataIndukToolStripMenuItem";
            dataIndukToolStripMenuItem.Size = new Size(180, 22);
            dataIndukToolStripMenuItem.Text = "Data Induk";
            dataIndukToolStripMenuItem.Click += dataIndukToolStripMenuItem_Click;
            // 
            // mapelToolStripMenuItem
            // 
            mapelToolStripMenuItem.Name = "mapelToolStripMenuItem";
            mapelToolStripMenuItem.Size = new Size(180, 22);
            mapelToolStripMenuItem.Text = "Mapel";
            mapelToolStripMenuItem.Click += mapelToolStripMenuItem_Click;
            // 
            // jurusanToolStripMenuItem
            // 
            jurusanToolStripMenuItem.Name = "jurusanToolStripMenuItem";
            jurusanToolStripMenuItem.Size = new Size(180, 22);
            jurusanToolStripMenuItem.Text = "Jurusan";
            jurusanToolStripMenuItem.Click += jurusanToolStripMenuItem_Click;
            // 
            // kelasToolStripMenuItem
            // 
            kelasToolStripMenuItem.Name = "kelasToolStripMenuItem";
            kelasToolStripMenuItem.Size = new Size(180, 22);
            kelasToolStripMenuItem.Text = "Kelas";
            kelasToolStripMenuItem.Click += kelasToolStripMenuItem_Click;
            // 
            // guruToolStripMenuItem
            // 
            guruToolStripMenuItem.Name = "guruToolStripMenuItem";
            guruToolStripMenuItem.Size = new Size(180, 22);
            guruToolStripMenuItem.Text = "Guru";
            guruToolStripMenuItem.Click += guruToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 751);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "Dashboard";
            Text = "Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formToolStripMenuItem;
        private ToolStripMenuItem dataIndukToolStripMenuItem;
        private ToolStripMenuItem mapelToolStripMenuItem;
        private ToolStripMenuItem jurusanToolStripMenuItem;
        private ToolStripMenuItem kelasToolStripMenuItem;
        private ToolStripMenuItem guruToolStripMenuItem;
    }
}