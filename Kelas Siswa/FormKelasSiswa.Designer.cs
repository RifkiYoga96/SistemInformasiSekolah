namespace SistemInformasiSekolah
{
    partial class FormKelasSiswa
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
            textBox1 = new TextBox();
            gridKelasSiswa = new DataGridView();
            gridSiswa = new DataGridView();
            panel2 = new Panel();
            btnSave = new Button();
            panel3 = new Panel();
            txtTahunAjaran = new TextBox();
            label6 = new Label();
            waliKelasCombo = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            kelasCombo = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridKelasSiswa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSiswa).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(gridKelasSiswa);
            panel1.Controls.Add(gridSiswa);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 479);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Masukkan Kata Kunci Pencarian";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 2;
            // 
            // gridKelasSiswa
            // 
            gridKelasSiswa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gridKelasSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridKelasSiswa.Location = new Point(308, 41);
            gridKelasSiswa.Name = "gridKelasSiswa";
            gridKelasSiswa.RowTemplate.Height = 25;
            gridKelasSiswa.Size = new Size(295, 425);
            gridKelasSiswa.TabIndex = 1;
            // 
            // gridSiswa
            // 
            gridSiswa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gridSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSiswa.Location = new Point(13, 41);
            gridSiswa.Name = "gridSiswa";
            gridSiswa.RowTemplate.Height = 25;
            gridSiswa.Size = new Size(289, 425);
            gridSiswa.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(634, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 479);
            panel2.TabIndex = 1;
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
            btnSave.Location = new Point(245, 431);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtTahunAjaran);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(waliKelasCombo);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(kelasCombo);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(315, 406);
            panel3.TabIndex = 0;
            // 
            // txtTahunAjaran
            // 
            txtTahunAjaran.Location = new Point(29, 111);
            txtTahunAjaran.Name = "txtTahunAjaran";
            txtTahunAjaran.Size = new Size(258, 23);
            txtTahunAjaran.TabIndex = 23;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(25, 151);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 22;
            label6.Text = "Wali Kelas";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // waliKelasCombo
            // 
            waliKelasCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            waliKelasCombo.FormattingEnabled = true;
            waliKelasCombo.Location = new Point(25, 173);
            waliKelasCombo.Name = "waliKelasCombo";
            waliKelasCombo.Size = new Size(258, 23);
            waliKelasCombo.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 89);
            label5.Name = "label5";
            label5.Size = new Size(91, 19);
            label5.TabIndex = 20;
            label5.Text = "Tahun Ajaran";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 26);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 18;
            label3.Text = "Kelas";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // kelasCombo
            // 
            kelasCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kelasCombo.FormattingEnabled = true;
            kelasCombo.Location = new Point(25, 48);
            kelasCombo.Name = "kelasCombo";
            kelasCombo.Size = new Size(258, 23);
            kelasCombo.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(57, 56);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 16;
            // 
            // FormKelasSiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(987, 503);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormKelasSiswa";
            Text = "KelasSiswa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridKelasSiswa).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSiswa).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private ComboBox waliKelasCombo;
        private Label label5;
        private Label label3;
        private ComboBox kelasCombo;
        private Label label1;
        private DataGridView gridSiswa;
        private Button btnSave;
        private TextBox txtTahunAjaran;
        private TextBox textBox1;
        private DataGridView gridKelasSiswa;
    }
}