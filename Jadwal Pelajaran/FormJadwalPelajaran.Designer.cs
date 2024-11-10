namespace SistemInformasiSekolah
{
    partial class FormJadwalPelajaran
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
            panel6 = new Panel();
            comboJenisJadwal = new ComboBox();
            label4 = new Label();
            comboHari = new ComboBox();
            label1 = new Label();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            panel4 = new Panel();
            guruCombo = new ComboBox();
            mapelCombo = new ComboBox();
            txtKeterangan = new TextBox();
            label2 = new Label();
            jamSelesaiDT = new DateTimePicker();
            jamMulaiDT = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            btnKelas = new Button();
            namaKelasTxt = new TextBox();
            label3 = new Label();
            btn = new Button();
            panel2 = new Panel();
            radioKhusus = new RadioButton();
            label10 = new Label();
            radioUmum = new RadioButton();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btn);
            panel1.Location = new Point(660, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 548);
            panel1.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.BackColor = SystemColors.InactiveCaption;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(comboJenisJadwal);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(comboHari);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(10, 103);
            panel6.Name = "panel6";
            panel6.Size = new Size(325, 134);
            panel6.TabIndex = 10;
            // 
            // comboJenisJadwal
            // 
            comboJenisJadwal.BackColor = Color.Silver;
            comboJenisJadwal.FlatStyle = FlatStyle.Flat;
            comboJenisJadwal.FormattingEnabled = true;
            comboJenisJadwal.Location = new Point(22, 39);
            comboJenisJadwal.Name = "comboJenisJadwal";
            comboJenisJadwal.Size = new Size(262, 23);
            comboJenisJadwal.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 17);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 8;
            label4.Text = "Jenis Jadwal";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // comboHari
            // 
            comboHari.FormattingEnabled = true;
            comboHari.Location = new Point(22, 87);
            comboHari.Name = "comboHari";
            comboHari.Size = new Size(262, 23);
            comboHari.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 66);
            label1.Name = "label1";
            label1.Size = new Size(35, 19);
            label1.TabIndex = 10;
            label1.Text = "Hari";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.AutoEllipsis = true;
            btnNew.BackColor = Color.Green;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(77, 503);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 31);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.AutoEllipsis = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(165, 503);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoEllipsis = true;
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(253, 503);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = SystemColors.InactiveCaption;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(guruCombo);
            panel4.Controls.Add(mapelCombo);
            panel4.Controls.Add(txtKeterangan);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(jamSelesaiDT);
            panel4.Controls.Add(jamMulaiDT);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(10, 244);
            panel4.Name = "panel4";
            panel4.Size = new Size(325, 247);
            panel4.TabIndex = 8;
            // 
            // guruCombo
            // 
            guruCombo.FormattingEnabled = true;
            guruCombo.Location = new Point(22, 135);
            guruCombo.Name = "guruCombo";
            guruCombo.Size = new Size(262, 23);
            guruCombo.TabIndex = 26;
            // 
            // mapelCombo
            // 
            mapelCombo.FormattingEnabled = true;
            mapelCombo.Location = new Point(22, 87);
            mapelCombo.Name = "mapelCombo";
            mapelCombo.Size = new Size(262, 23);
            mapelCombo.TabIndex = 22;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtKeterangan.Location = new Point(22, 185);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(262, 23);
            txtKeterangan.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 164);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 24;
            label2.Text = "Keterangan";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // jamSelesaiDT
            // 
            jamSelesaiDT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            jamSelesaiDT.CustomFormat = " HH:mm";
            jamSelesaiDT.Format = DateTimePickerFormat.Custom;
            jamSelesaiDT.Location = new Point(171, 37);
            jamSelesaiDT.Name = "jamSelesaiDT";
            jamSelesaiDT.ShowUpDown = true;
            jamSelesaiDT.Size = new Size(113, 23);
            jamSelesaiDT.TabIndex = 23;
            // 
            // jamMulaiDT
            // 
            jamMulaiDT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            jamMulaiDT.CalendarMonthBackground = Color.White;
            jamMulaiDT.CustomFormat = " HH:mm";
            jamMulaiDT.Format = DateTimePickerFormat.Custom;
            jamMulaiDT.Location = new Point(22, 37);
            jamMulaiDT.Name = "jamMulaiDT";
            jamMulaiDT.ShowUpDown = true;
            jamMulaiDT.Size = new Size(113, 23);
            jamMulaiDT.TabIndex = 22;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(22, 114);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 18;
            label7.Text = "Guru";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 66);
            label8.Name = "label8";
            label8.Size = new Size(48, 19);
            label8.TabIndex = 16;
            label8.Text = "Mapel";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(171, 16);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 14;
            label5.Text = "Selesai";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 16);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 12;
            label6.Text = "Jam Mulai";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnKelas);
            panel3.Controls.Add(namaKelasTxt);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 86);
            panel3.TabIndex = 7;
            // 
            // btnKelas
            // 
            btnKelas.Location = new Point(242, 36);
            btnKelas.Name = "btnKelas";
            btnKelas.Size = new Size(42, 23);
            btnKelas.TabIndex = 8;
            btnKelas.Text = "...";
            btnKelas.UseVisualStyleBackColor = true;
            // 
            // namaKelasTxt
            // 
            namaKelasTxt.Location = new Point(22, 36);
            namaKelasTxt.Name = "namaKelasTxt";
            namaKelasTxt.PlaceholderText = " Mohon Atur Kelas";
            namaKelasTxt.Size = new Size(214, 23);
            namaKelasTxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 15);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 6;
            label3.Text = "Kelas";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn.AutoEllipsis = true;
            btn.BackColor = Color.Red;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn.ForeColor = Color.White;
            btn.Location = new Point(246, 825);
            btn.Name = "btn";
            btn.Size = new Size(82, 31);
            btn.TabIndex = 5;
            btn.Text = "Delete";
            btn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(radioKhusus);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(radioUmum);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 548);
            panel2.TabIndex = 5;
            // 
            // radioKhusus
            // 
            radioKhusus.AutoSize = true;
            radioKhusus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioKhusus.Location = new Point(224, 11);
            radioKhusus.Name = "radioKhusus";
            radioKhusus.Size = new Size(75, 24);
            radioKhusus.TabIndex = 50;
            radioKhusus.TabStop = true;
            radioKhusus.Text = "Khusus";
            radioKhusus.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 13);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 49;
            label10.Text = "Jenis Jadwal :";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // radioUmum
            // 
            radioUmum.AutoSize = true;
            radioUmum.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioUmum.Location = new Point(136, 11);
            radioUmum.Name = "radioUmum";
            radioUmum.Size = new Size(73, 24);
            radioUmum.TabIndex = 2;
            radioUmum.TabStop = true;
            radioUmum.Text = "Umum";
            radioUmum.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(619, 489);
            dataGridView1.TabIndex = 1;
            // 
            // FormJadwalPelajaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1020, 571);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormJadwalPelajaran";
            Text = "FormJadwalPelajaran";
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel4;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private RadioButton radioUmum;
        private Label label10;
        private RadioButton radioKhusus;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label4;
        private TextBox namaKelasTxt;
        private Label label3;
        private Label label7;
        private Label label8;
        private ComboBox comboHari;
        private ComboBox comboJenisJadwal;
        private DateTimePicker jamSelesaiDT;
        private DateTimePicker jamMulaiDT;
        private Button btnKelas;
        private Panel panel6;
        private TextBox txtKeterangan;
        private Label label2;
        private ComboBox guruCombo;
        private ComboBox mapelCombo;
    }
}