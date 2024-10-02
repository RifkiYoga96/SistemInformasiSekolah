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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel4 = new Panel();
            jamSelesaiDT = new DateTimePicker();
            jamMulaiDT = new DateTimePicker();
            comboHari = new ComboBox();
            comboJenisJadwal = new ComboBox();
            guruTxt = new TextBox();
            label7 = new Label();
            mapelTxt = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            namaKelasTxt = new TextBox();
            label3 = new Label();
            idMapelTxt = new TextBox();
            label2 = new Label();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            panel2 = new Panel();
            radioButton2 = new RadioButton();
            label10 = new Label();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(660, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 569);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(77, 524);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 11;
            button1.Text = "New";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(165, 524);
            button2.Name = "button2";
            button2.Size = new Size(82, 31);
            button2.TabIndex = 10;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.AutoEllipsis = true;
            button3.BackColor = SystemColors.Highlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(253, 524);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 9;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = SystemColors.InactiveCaption;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(jamSelesaiDT);
            panel4.Controls.Add(jamMulaiDT);
            panel4.Controls.Add(comboHari);
            panel4.Controls.Add(comboJenisJadwal);
            panel4.Controls.Add(guruTxt);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(mapelTxt);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(10, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(325, 365);
            panel4.TabIndex = 8;
            // 
            // jamSelesaiDT
            // 
            jamSelesaiDT.CustomFormat = " HH:mm";
            jamSelesaiDT.Format = DateTimePickerFormat.Custom;
            jamSelesaiDT.Location = new Point(22, 184);
            jamSelesaiDT.Name = "jamSelesaiDT";
            jamSelesaiDT.ShowUpDown = true;
            jamSelesaiDT.Size = new Size(262, 23);
            jamSelesaiDT.TabIndex = 23;
            // 
            // jamMulaiDT
            // 
            jamMulaiDT.CalendarMonthBackground = Color.White;
            jamMulaiDT.CustomFormat = " HH:mm";
            jamMulaiDT.Format = DateTimePickerFormat.Custom;
            jamMulaiDT.Location = new Point(22, 134);
            jamMulaiDT.Name = "jamMulaiDT";
            jamMulaiDT.ShowUpDown = true;
            jamMulaiDT.Size = new Size(262, 23);
            jamMulaiDT.TabIndex = 22;
            // 
            // comboHari
            // 
            comboHari.FormattingEnabled = true;
            comboHari.Location = new Point(22, 85);
            comboHari.Name = "comboHari";
            comboHari.Size = new Size(262, 23);
            comboHari.TabIndex = 21;
            // 
            // comboJenisJadwal
            // 
            comboJenisJadwal.BackColor = Color.Silver;
            comboJenisJadwal.FlatStyle = FlatStyle.Flat;
            comboJenisJadwal.FormattingEnabled = true;
            comboJenisJadwal.Location = new Point(22, 37);
            comboJenisJadwal.Name = "comboJenisJadwal";
            comboJenisJadwal.Size = new Size(262, 23);
            comboJenisJadwal.TabIndex = 20;
            // 
            // guruTxt
            // 
            guruTxt.Location = new Point(22, 319);
            guruTxt.Name = "guruTxt";
            guruTxt.Size = new Size(262, 23);
            guruTxt.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(22, 298);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 18;
            label7.Text = "Guru";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // mapelTxt
            // 
            mapelTxt.Location = new Point(22, 271);
            mapelTxt.Name = "mapelTxt";
            mapelTxt.Size = new Size(262, 23);
            mapelTxt.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 250);
            label8.Name = "label8";
            label8.Size = new Size(48, 19);
            label8.TabIndex = 16;
            label8.Text = "Mapel";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 162);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 14;
            label5.Text = "Selesai";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 113);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 12;
            label6.Text = "Jam Mulai";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 64);
            label1.Name = "label1";
            label1.Size = new Size(35, 19);
            label1.TabIndex = 10;
            label1.Text = "Hari";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 15);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 8;
            label4.Text = "Jenis Jadwal";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(namaKelasTxt);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(idMapelTxt);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 134);
            panel3.TabIndex = 7;
            // 
            // namaKelasTxt
            // 
            namaKelasTxt.Location = new Point(22, 90);
            namaKelasTxt.Name = "namaKelasTxt";
            namaKelasTxt.Size = new Size(262, 23);
            namaKelasTxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 69);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 6;
            label3.Text = "Nama Kelas";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // idMapelTxt
            // 
            idMapelTxt.Location = new Point(22, 37);
            idMapelTxt.Name = "idMapelTxt";
            idMapelTxt.ReadOnly = true;
            idMapelTxt.Size = new Size(262, 23);
            idMapelTxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 16);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 4;
            label2.Text = "ID Kelas";
            label2.TextAlign = ContentAlignment.BottomLeft;
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
            btnNew.Location = new Point(158, 846);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 31);
            btnNew.TabIndex = 6;
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
            btnDelete.Location = new Point(246, 846);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 5;
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
            btnSave.Location = new Point(334, 846);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 569);
            panel2.TabIndex = 5;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(224, 11);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 24);
            radioButton2.TabIndex = 50;
            radioButton2.TabStop = true;
            radioButton2.Text = "Khusus";
            radioButton2.UseVisualStyleBackColor = true;
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(136, 11);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Umum";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(619, 510);
            dataGridView1.TabIndex = 1;
            // 
            // FormJadwalPelajaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1020, 592);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormJadwalPelajaran";
            Text = "FormJadwalPelajaran";
            panel1.ResumeLayout(false);
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
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button2;
        private Button button3;
        private RadioButton radioButton1;
        private Label label10;
        private RadioButton radioButton2;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label4;
        private TextBox namaKelasTxt;
        private Label label3;
        private TextBox idMapelTxt;
        private Label label2;
        private TextBox guruTxt;
        private Label label7;
        private TextBox mapelTxt;
        private Label label8;
        private ComboBox comboHari;
        private ComboBox comboJenisJadwal;
        private DateTimePicker jamSelesaiDT;
        private DateTimePicker jamMulaiDT;
    }
}