namespace SistemInformasiSekolah
{
    partial class FormGuru
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            tglLahir = new DateTimePicker();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            txtKota = new TextBox();
            label8 = new Label();
            txtInstansiPendidikan = new TextBox();
            label9 = new Label();
            gridMapel = new DataGridView();
            txtTahunLulus = new TextBox();
            label6 = new Label();
            txtJurusanPendidikan = new TextBox();
            label7 = new Label();
            radioS3 = new RadioButton();
            radioS2 = new RadioButton();
            radioS1 = new RadioButton();
            radioD3 = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            txtNamaGuru = new TextBox();
            label3 = new Label();
            txtIdGuru = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            txtFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMapel).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1043, 51);
            label1.TabIndex = 4;
            label1.Text = "Guru";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(10, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(375, 495);
            dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(tglLahir);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtKota);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtInstansiPendidikan);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(gridMapel);
            panel1.Controls.Add(txtTahunLulus);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtJurusanPendidikan);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(radioS3);
            panel1.Controls.Add(radioS2);
            panel1.Controls.Add(radioS1);
            panel1.Controls.Add(radioD3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNamaGuru);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtIdGuru);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(413, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 587);
            panel1.TabIndex = 6;
            // 
            // tglLahir
            // 
            tglLahir.Font = new Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            tglLahir.Location = new Point(36, 159);
            tglLahir.Name = "tglLahir";
            tglLahir.Size = new Size(257, 25);
            tglLahir.TabIndex = 48;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.AutoEllipsis = true;
            btnNew.BackColor = Color.FromArgb(0, 192, 0);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(351, 545);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 31);
            btnNew.TabIndex = 47;
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
            btnDelete.Location = new Point(439, 545);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 46;
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
            btnSave.Location = new Point(527, 545);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 45;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtKota
            // 
            txtKota.Font = new Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            txtKota.Location = new Point(323, 321);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(257, 25);
            txtKota.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.InactiveCaption;
            label8.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(323, 298);
            label8.Name = "label8";
            label8.Size = new Size(38, 19);
            label8.TabIndex = 43;
            label8.Text = "Kota";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtInstansiPendidikan
            // 
            txtInstansiPendidikan.Font = new Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            txtInstansiPendidikan.Location = new Point(323, 266);
            txtInstansiPendidikan.Name = "txtInstansiPendidikan";
            txtInstansiPendidikan.Size = new Size(257, 25);
            txtInstansiPendidikan.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.InactiveCaption;
            label9.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(323, 243);
            label9.Name = "label9";
            label9.Size = new Size(130, 19);
            label9.TabIndex = 41;
            label9.Text = "Instansi Pendidikan";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // gridMapel
            // 
            gridMapel.BackgroundColor = Color.Silver;
            gridMapel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMapel.Location = new Point(36, 371);
            gridMapel.Name = "gridMapel";
            gridMapel.RowTemplate.Height = 25;
            gridMapel.Size = new Size(544, 135);
            gridMapel.TabIndex = 40;
            // 
            // txtTahunLulus
            // 
            txtTahunLulus.Font = new Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            txtTahunLulus.Location = new Point(36, 321);
            txtTahunLulus.Name = "txtTahunLulus";
            txtTahunLulus.Size = new Size(257, 25);
            txtTahunLulus.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.InactiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(36, 298);
            label6.Name = "label6";
            label6.Size = new Size(84, 19);
            label6.TabIndex = 34;
            label6.Text = "Tahun Lulus";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtJurusanPendidikan
            // 
            txtJurusanPendidikan.Font = new Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            txtJurusanPendidikan.Location = new Point(36, 266);
            txtJurusanPendidikan.Name = "txtJurusanPendidikan";
            txtJurusanPendidikan.Size = new Size(257, 25);
            txtJurusanPendidikan.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.InactiveCaption;
            label7.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(36, 243);
            label7.Name = "label7";
            label7.Size = new Size(130, 19);
            label7.TabIndex = 32;
            label7.Text = "Jurusan Pendidikan";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // radioS3
            // 
            radioS3.AutoSize = true;
            radioS3.BackColor = SystemColors.InactiveCaption;
            radioS3.Location = new Point(254, 217);
            radioS3.Name = "radioS3";
            radioS3.Size = new Size(37, 19);
            radioS3.TabIndex = 31;
            radioS3.TabStop = true;
            radioS3.Text = "S3";
            radioS3.UseVisualStyleBackColor = false;
            // 
            // radioS2
            // 
            radioS2.AutoSize = true;
            radioS2.BackColor = SystemColors.InactiveCaption;
            radioS2.Location = new Point(185, 217);
            radioS2.Name = "radioS2";
            radioS2.Size = new Size(37, 19);
            radioS2.TabIndex = 30;
            radioS2.TabStop = true;
            radioS2.Text = "S2";
            radioS2.UseVisualStyleBackColor = false;
            // 
            // radioS1
            // 
            radioS1.AutoSize = true;
            radioS1.BackColor = SystemColors.InactiveCaption;
            radioS1.Location = new Point(114, 217);
            radioS1.Name = "radioS1";
            radioS1.Size = new Size(37, 19);
            radioS1.TabIndex = 29;
            radioS1.TabStop = true;
            radioS1.Text = "S1";
            radioS1.UseVisualStyleBackColor = false;
            // 
            // radioD3
            // 
            radioD3.AutoSize = true;
            radioD3.BackColor = SystemColors.InactiveCaption;
            radioD3.Location = new Point(44, 217);
            radioD3.Name = "radioD3";
            radioD3.Size = new Size(39, 19);
            radioD3.TabIndex = 28;
            radioD3.TabStop = true;
            radioD3.Text = "D3";
            radioD3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.InactiveCaption;
            label5.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(36, 192);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 27;
            label5.Text = "Tingkat Pendidikan";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 136);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 25;
            label4.Text = "Tgl Lahir";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNamaGuru
            // 
            txtNamaGuru.Font = new Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamaGuru.Location = new Point(36, 105);
            txtNamaGuru.Name = "txtNamaGuru";
            txtNamaGuru.Size = new Size(257, 25);
            txtNamaGuru.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 82);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 23;
            label3.Text = "Nama";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtIdGuru
            // 
            txtIdGuru.Font = new Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdGuru.Location = new Point(36, 51);
            txtIdGuru.Name = "txtIdGuru";
            txtIdGuru.ReadOnly = true;
            txtIdGuru.Size = new Size(257, 25);
            txtIdGuru.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 28);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 4;
            label2.Text = "ID Guru";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 516);
            panel3.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(401, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 194);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(12, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 587);
            panel2.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Silver;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(txtFilter);
            panel4.Location = new Point(9, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(376, 61);
            panel4.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(11, 18);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 48;
            label10.Text = "Search :";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(80, 18);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Masukkan Nama Guru";
            txtFilter.Size = new Size(273, 23);
            txtFilter.TabIndex = 48;
            // 
            // FormGuru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1043, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormGuru";
            Text = "FormGuru";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridMapel).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox txtKota;
        private Label label8;
        private TextBox txtInstansiPendidikan;
        private Label label9;
        private DataGridView gridMapel;
        private TextBox txtTahunLulus;
        private Label label6;
        private TextBox txtJurusanPendidikan;
        private Label label7;
        private RadioButton radioS3;
        private RadioButton radioS2;
        private RadioButton radioS1;
        private RadioButton radioD3;
        private Label label5;
        private Label label4;
        private TextBox txtNamaGuru;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtIdGuru;
        private Label label2;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private Panel panel2;
        private Label label10;
        private TextBox txtFilter;
        private DateTimePicker tglLahir;
        private Panel panel3;
        private Panel panel4;
    }
}