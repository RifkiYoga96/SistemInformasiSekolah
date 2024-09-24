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
            pictureBox1 = new PictureBox();
            txtIdGuru = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMapel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            label1.Size = new Size(1000, 51);
            label1.TabIndex = 4;
            label1.Text = "Guru";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(13, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(369, 492);
            dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtIdGuru);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(413, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 549);
            panel1.TabIndex = 6;
            // 
            // tglLahir
            // 
            tglLahir.Location = new Point(15, 149);
            tglLahir.Name = "tglLahir";
            tglLahir.Size = new Size(257, 23);
            tglLahir.TabIndex = 48;
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
            btnNew.Location = new Point(303, 504);
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
            btnDelete.Location = new Point(391, 504);
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
            btnSave.Location = new Point(479, 504);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 45;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // txtKota
            // 
            txtKota.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtKota.Location = new Point(302, 311);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(257, 23);
            txtKota.TabIndex = 44;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(302, 288);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 43;
            label8.Text = "Kota";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtInstansiPendidikan
            // 
            txtInstansiPendidikan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtInstansiPendidikan.Location = new Point(302, 256);
            txtInstansiPendidikan.Name = "txtInstansiPendidikan";
            txtInstansiPendidikan.Size = new Size(257, 23);
            txtInstansiPendidikan.TabIndex = 42;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(302, 233);
            label9.Name = "label9";
            label9.Size = new Size(140, 20);
            label9.TabIndex = 41;
            label9.Text = "Instansi Pendidikan";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // gridMapel
            // 
            gridMapel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridMapel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMapel.Location = new Point(15, 360);
            gridMapel.Name = "gridMapel";
            gridMapel.RowTemplate.Height = 25;
            gridMapel.Size = new Size(544, 127);
            gridMapel.TabIndex = 40;
            // 
            // txtTahunLulus
            // 
            txtTahunLulus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTahunLulus.Location = new Point(15, 311);
            txtTahunLulus.Name = "txtTahunLulus";
            txtTahunLulus.Size = new Size(257, 23);
            txtTahunLulus.TabIndex = 35;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(15, 288);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 34;
            label6.Text = "Tahun Lulus";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtJurusanPendidikan
            // 
            txtJurusanPendidikan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtJurusanPendidikan.Location = new Point(15, 256);
            txtJurusanPendidikan.Name = "txtJurusanPendidikan";
            txtJurusanPendidikan.Size = new Size(257, 23);
            txtJurusanPendidikan.TabIndex = 33;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(15, 233);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 32;
            label7.Text = "Jurusan Pendidikan";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // radioS3
            // 
            radioS3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioS3.AutoSize = true;
            radioS3.Location = new Point(233, 207);
            radioS3.Name = "radioS3";
            radioS3.Size = new Size(37, 19);
            radioS3.TabIndex = 31;
            radioS3.TabStop = true;
            radioS3.Text = "S3";
            radioS3.UseVisualStyleBackColor = true;
            // 
            // radioS2
            // 
            radioS2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioS2.AutoSize = true;
            radioS2.Location = new Point(164, 207);
            radioS2.Name = "radioS2";
            radioS2.Size = new Size(37, 19);
            radioS2.TabIndex = 30;
            radioS2.TabStop = true;
            radioS2.Text = "S2";
            radioS2.UseVisualStyleBackColor = true;
            // 
            // radioS1
            // 
            radioS1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioS1.AutoSize = true;
            radioS1.Location = new Point(93, 207);
            radioS1.Name = "radioS1";
            radioS1.Size = new Size(37, 19);
            radioS1.TabIndex = 29;
            radioS1.TabStop = true;
            radioS1.Text = "S1";
            radioS1.UseVisualStyleBackColor = true;
            // 
            // radioD3
            // 
            radioD3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioD3.AutoSize = true;
            radioD3.Location = new Point(23, 207);
            radioD3.Name = "radioD3";
            radioD3.Size = new Size(39, 19);
            radioD3.TabIndex = 28;
            radioD3.TabStop = true;
            radioD3.Text = "D3";
            radioD3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 182);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 27;
            label5.Text = "Tingkat Pendidikan";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 126);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 25;
            label4.Text = "Tgl Lahir";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNamaGuru
            // 
            txtNamaGuru.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNamaGuru.Location = new Point(15, 95);
            txtNamaGuru.Name = "txtNamaGuru";
            txtNamaGuru.Size = new Size(257, 23);
            txtNamaGuru.TabIndex = 24;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 72);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 23;
            label3.Text = "Nama";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(379, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 212);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // txtIdGuru
            // 
            txtIdGuru.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIdGuru.Location = new Point(15, 41);
            txtIdGuru.Name = "txtIdGuru";
            txtIdGuru.ReadOnly = true;
            txtIdGuru.Size = new Size(257, 23);
            txtIdGuru.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 18);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "ID Guru";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 549);
            panel2.TabIndex = 7;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(13, 15);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 48;
            label10.Text = "Search :";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox7.Location = new Point(82, 15);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(300, 23);
            textBox7.TabIndex = 48;
            // 
            // FormGuru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 623);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormGuru";
            Text = "FormGuru";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridMapel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private TextBox textBox7;
        private DateTimePicker tglLahir;
    }
}