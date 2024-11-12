namespace SistemInformasiSekolah
{
    partial class FormPersensi
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
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnSave = new Button();
            label7 = new Label();
            txtA = new TextBox();
            txtI = new TextBox();
            txtS = new TextBox();
            txtHadir = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnListSiswa = new Button();
            btnNew = new Button();
            panel4 = new Panel();
            label6 = new Label();
            guruCombo = new ComboBox();
            label5 = new Label();
            mapelCombo = new ComboBox();
            label3 = new Label();
            kelasCombo = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label4 = new Label();
            txtJam = new TextBox();
            tglDT = new DateTimePicker();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtA);
            panel1.Controls.Add(txtI);
            panel1.Controls.Add(txtS);
            panel1.Controls.Add(txtHadir);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 456);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(439, 380);
            label11.Name = "label11";
            label11.Size = new Size(17, 17);
            label11.TabIndex = 18;
            label11.Text = "A";
            label11.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(395, 380);
            label10.Name = "label10";
            label10.Size = new Size(12, 17);
            label10.TabIndex = 17;
            label10.Text = "I";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(347, 380);
            label9.Name = "label9";
            label9.Size = new Size(15, 17);
            label9.TabIndex = 16;
            label9.Text = "S";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(280, 379);
            label8.Name = "label8";
            label8.Size = new Size(41, 17);
            label8.TabIndex = 15;
            label8.Text = "Hadir";
            label8.TextAlign = ContentAlignment.BottomLeft;
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
            btnSave.Location = new Point(620, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(218, 400);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 11;
            label7.Text = "Total : ";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtA
            // 
            txtA.Anchor = AnchorStyles.Bottom;
            txtA.Location = new Point(426, 399);
            txtA.Name = "txtA";
            txtA.Size = new Size(40, 23);
            txtA.TabIndex = 4;
            // 
            // txtI
            // 
            txtI.Anchor = AnchorStyles.Bottom;
            txtI.Location = new Point(380, 399);
            txtI.Name = "txtI";
            txtI.Size = new Size(40, 23);
            txtI.TabIndex = 3;
            // 
            // txtS
            // 
            txtS.Anchor = AnchorStyles.Bottom;
            txtS.Location = new Point(334, 399);
            txtS.Name = "txtS";
            txtS.Size = new Size(40, 23);
            txtS.TabIndex = 2;
            // 
            // txtHadir
            // 
            txtHadir.Anchor = AnchorStyles.Bottom;
            txtHadir.Location = new Point(273, 399);
            txtHadir.Name = "txtHadir";
            txtHadir.Size = new Size(55, 23);
            txtHadir.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(697, 354);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(btnListSiswa);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(734, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 456);
            panel2.TabIndex = 1;
            // 
            // btnListSiswa
            // 
            btnListSiswa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnListSiswa.AutoEllipsis = true;
            btnListSiswa.BackColor = SystemColors.ControlDarkDark;
            btnListSiswa.FlatAppearance.BorderSize = 0;
            btnListSiswa.FlatStyle = FlatStyle.Flat;
            btnListSiswa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListSiswa.ForeColor = Color.White;
            btnListSiswa.Location = new Point(12, 411);
            btnListSiswa.Name = "btnListSiswa";
            btnListSiswa.Size = new Size(95, 31);
            btnListSiswa.TabIndex = 13;
            btnListSiswa.Text = "List Siswa";
            btnListSiswa.UseVisualStyleBackColor = false;
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
            btnNew.Location = new Point(246, 411);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 31);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = SystemColors.InactiveCaption;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(guruCombo);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(mapelCombo);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(kelasCombo);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(9, 117);
            panel4.Name = "panel4";
            panel4.Size = new Size(320, 279);
            panel4.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 144);
            label6.Name = "label6";
            label6.Size = new Size(40, 19);
            label6.TabIndex = 15;
            label6.Text = "Guru";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // guruCombo
            // 
            guruCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            guruCombo.FormattingEnabled = true;
            guruCombo.Location = new Point(27, 166);
            guruCombo.Name = "guruCombo";
            guruCombo.Size = new Size(258, 23);
            guruCombo.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 82);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 13;
            label5.Text = "Mata Pelajaran";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // mapelCombo
            // 
            mapelCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            mapelCombo.FormattingEnabled = true;
            mapelCombo.Location = new Point(27, 104);
            mapelCombo.Name = "mapelCombo";
            mapelCombo.Size = new Size(258, 23);
            mapelCombo.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 19);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 11;
            label3.Text = "Kelas";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // kelasCombo
            // 
            kelasCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            kelasCombo.FormattingEnabled = true;
            kelasCombo.Location = new Point(27, 41);
            kelasCombo.Name = "kelasCombo";
            kelasCombo.Size = new Size(258, 23);
            kelasCombo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 49);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtJam);
            panel3.Controls.Add(tglDT);
            panel3.Location = new Point(9, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 100);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(170, 24);
            label2.Name = "label2";
            label2.Size = new Size(34, 19);
            label2.TabIndex = 10;
            label2.Text = "Jam";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 24);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 9;
            label4.Text = "Tanggal";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtJam
            // 
            txtJam.Location = new Point(170, 46);
            txtJam.Name = "txtJam";
            txtJam.Size = new Size(115, 23);
            txtJam.TabIndex = 1;
            // 
            // tglDT
            // 
            tglDT.Format = DateTimePickerFormat.Short;
            tglDT.Location = new Point(27, 46);
            tglDT.Name = "tglDT";
            tglDT.Size = new Size(115, 23);
            tglDT.TabIndex = 0;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.Highlight;
            label12.Dock = DockStyle.Top;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(1085, 51);
            label12.TabIndex = 5;
            label12.Text = "Persensi";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPersensi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 532);
            Controls.Add(label12);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormPersensi";
            Text = "FormPersensi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DateTimePicker tglDT;
        private TextBox txtJam;
        private Label label1;
        private Label label6;
        private ComboBox guruCombo;
        private Label label5;
        private ComboBox mapelCombo;
        private Label label3;
        private ComboBox kelasCombo;
        private Label label2;
        private Label label4;
        private Button btnListSiswa;
        private Button btnNew;
        private Button btnSave;
        private Label label7;
        private TextBox txtA;
        private TextBox txtI;
        private TextBox txtS;
        private TextBox txtHadir;
        private DataGridView dataGridView1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label12;
    }
}