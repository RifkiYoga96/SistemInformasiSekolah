namespace SistemInformasiSekolah
{
    partial class KelasSiswa
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
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            waliKelasCombo = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            kelasCombo = new ComboBox();
            label1 = new Label();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            txtTahunAjaran = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 479);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(550, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 479);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(txtTahunAjaran);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(waliKelasCombo);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(kelasCombo);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 408);
            panel3.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 151);
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
            waliKelasCombo.Location = new Point(29, 173);
            waliKelasCombo.Name = "waliKelasCombo";
            waliKelasCombo.Size = new Size(258, 23);
            waliKelasCombo.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 89);
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
            label3.Location = new Point(29, 26);
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
            kelasCombo.Location = new Point(29, 48);
            kelasCombo.Name = "kelasCombo";
            kelasCombo.Size = new Size(258, 23);
            kelasCombo.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(61, 56);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 16;
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
            btnNew.Location = new Point(71, 433);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 31);
            btnNew.TabIndex = 50;
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
            btnDelete.Location = new Point(159, 433);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 49;
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
            btnSave.Location = new Point(247, 433);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(505, 454);
            dataGridView1.TabIndex = 0;
            // 
            // txtTahunAjaran
            // 
            txtTahunAjaran.Location = new Point(29, 111);
            txtTahunAjaran.Name = "txtTahunAjaran";
            txtTahunAjaran.Size = new Size(258, 23);
            txtTahunAjaran.TabIndex = 23;
            // 
            // KelasSiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(903, 503);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "KelasSiswa";
            Text = "KelasSiswa";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtTahunAjaran;
    }
}