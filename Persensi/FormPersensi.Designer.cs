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
            btnSave = new Button();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 509);
            panel1.TabIndex = 0;
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
            btnSave.Location = new Point(620, 446);
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
            label7.Location = new Point(227, 453);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 11;
            label7.Text = "Total";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom;
            textBox4.Location = new Point(426, 452);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(40, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom;
            textBox3.Location = new Point(380, 452);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(40, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom;
            textBox2.Location = new Point(334, 452);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(40, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Location = new Point(273, 452);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(690, 407);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnListSiswa);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(734, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 509);
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
            btnListSiswa.Location = new Point(12, 464);
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
            btnNew.Location = new Point(246, 464);
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
            panel4.Controls.Add(label6);
            panel4.Controls.Add(guruCombo);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(mapelCombo);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(kelasCombo);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(11, 119);
            panel4.Name = "panel4";
            panel4.Size = new Size(316, 332);
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
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtJam);
            panel3.Controls.Add(tglDT);
            panel3.Location = new Point(11, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 100);
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
            // FormPersensi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1085, 532);
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}