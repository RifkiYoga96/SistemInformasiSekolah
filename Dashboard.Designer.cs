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
            kelasSiswaToolStripMenuItem = new ToolStripMenuItem();
            pengajaranToolStripMenuItem = new ToolStripMenuItem();
            mapelToolStripMenuItem1 = new ToolStripMenuItem();
            jurusanToolStripMenuItem1 = new ToolStripMenuItem();
            kelasToolStripMenuItem1 = new ToolStripMenuItem();
            guruToolStripMenuItem1 = new ToolStripMenuItem();
            jadwalPelajaranToolStripMenuItem1 = new ToolStripMenuItem();
            persensiToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { formToolStripMenuItem, pengajaranToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 53);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            formToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataIndukToolStripMenuItem, kelasSiswaToolStripMenuItem });
            formToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            formToolStripMenuItem.Image = Properties.Resources.profile__2__1__1_;
            formToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            formToolStripMenuItem.Name = "formToolStripMenuItem";
            formToolStripMenuItem.Size = new Size(127, 49);
            formToolStripMenuItem.Text = "Kesiswaan";
            formToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataIndukToolStripMenuItem
            // 
            dataIndukToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataIndukToolStripMenuItem.Image = Properties.Resources.refresh_data__1_;
            dataIndukToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            dataIndukToolStripMenuItem.Name = "dataIndukToolStripMenuItem";
            dataIndukToolStripMenuItem.Size = new Size(169, 38);
            dataIndukToolStripMenuItem.Text = "Data Induk";
            dataIndukToolStripMenuItem.Click += dataIndukToolStripMenuItem_Click;
            // 
            // kelasSiswaToolStripMenuItem
            // 
            kelasSiswaToolStripMenuItem.Image = Properties.Resources.lecture_room;
            kelasSiswaToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            kelasSiswaToolStripMenuItem.Name = "kelasSiswaToolStripMenuItem";
            kelasSiswaToolStripMenuItem.Size = new Size(169, 38);
            kelasSiswaToolStripMenuItem.Text = "Kelas - Siswa";
            kelasSiswaToolStripMenuItem.Click += kelasSiswaToolStripMenuItem_Click;
            // 
            // pengajaranToolStripMenuItem
            // 
            pengajaranToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mapelToolStripMenuItem1, jurusanToolStripMenuItem1, kelasToolStripMenuItem1, guruToolStripMenuItem1, jadwalPelajaranToolStripMenuItem1, persensiToolStripMenuItem1 });
            pengajaranToolStripMenuItem.Image = Properties.Resources.teaching__1__1;
            pengajaranToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            pengajaranToolStripMenuItem.Name = "pengajaranToolStripMenuItem";
            pengajaranToolStripMenuItem.Size = new Size(123, 49);
            pengajaranToolStripMenuItem.Text = "Pengajaran";
            // 
            // mapelToolStripMenuItem1
            // 
            mapelToolStripMenuItem1.Image = Properties.Resources.maths__1_;
            mapelToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            mapelToolStripMenuItem1.Name = "mapelToolStripMenuItem1";
            mapelToolStripMenuItem1.Size = new Size(196, 38);
            mapelToolStripMenuItem1.Text = "Mapel";
            mapelToolStripMenuItem1.Click += mapelToolStripMenuItem1_Click;
            // 
            // jurusanToolStripMenuItem1
            // 
            jurusanToolStripMenuItem1.Image = Properties.Resources.specification__1_;
            jurusanToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            jurusanToolStripMenuItem1.Name = "jurusanToolStripMenuItem1";
            jurusanToolStripMenuItem1.Size = new Size(196, 38);
            jurusanToolStripMenuItem1.Text = "Jurusan";
            jurusanToolStripMenuItem1.Click += jurusanToolStripMenuItem1_Click;
            // 
            // kelasToolStripMenuItem1
            // 
            kelasToolStripMenuItem1.Image = Properties.Resources._class;
            kelasToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            kelasToolStripMenuItem1.Name = "kelasToolStripMenuItem1";
            kelasToolStripMenuItem1.Size = new Size(196, 38);
            kelasToolStripMenuItem1.Text = "Kelas";
            kelasToolStripMenuItem1.Click += kelasToolStripMenuItem1_Click;
            // 
            // guruToolStripMenuItem1
            // 
            guruToolStripMenuItem1.Image = Properties.Resources.teacher__1_;
            guruToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            guruToolStripMenuItem1.Name = "guruToolStripMenuItem1";
            guruToolStripMenuItem1.Size = new Size(196, 38);
            guruToolStripMenuItem1.Text = "Guru";
            guruToolStripMenuItem1.Click += guruToolStripMenuItem1_Click;
            // 
            // jadwalPelajaranToolStripMenuItem1
            // 
            jadwalPelajaranToolStripMenuItem1.Image = Properties.Resources.calendar;
            jadwalPelajaranToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            jadwalPelajaranToolStripMenuItem1.Name = "jadwalPelajaranToolStripMenuItem1";
            jadwalPelajaranToolStripMenuItem1.Size = new Size(196, 38);
            jadwalPelajaranToolStripMenuItem1.Text = "Jadwal Pelajaran";
            jadwalPelajaranToolStripMenuItem1.Click += jadwalPelajaranToolStripMenuItem1_Click;
            // 
            // persensiToolStripMenuItem1
            // 
            persensiToolStripMenuItem1.Image = Properties.Resources.raise_hand;
            persensiToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            persensiToolStripMenuItem1.Name = "persensiToolStripMenuItem1";
            persensiToolStripMenuItem1.Size = new Size(196, 38);
            persensiToolStripMenuItem1.Text = "Persensi";
            persensiToolStripMenuItem1.Click += persensiToolStripMenuItem1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 726);
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
        private ToolStripMenuItem kelasSiswaToolStripMenuItem;
        private ToolStripMenuItem pengajaranToolStripMenuItem;
        private ToolStripMenuItem mapelToolStripMenuItem1;
        private ToolStripMenuItem jurusanToolStripMenuItem1;
        private ToolStripMenuItem kelasToolStripMenuItem1;
        private ToolStripMenuItem guruToolStripMenuItem1;
        private ToolStripMenuItem jadwalPelajaranToolStripMenuItem1;
        private ToolStripMenuItem persensiToolStripMenuItem1;
    }
}