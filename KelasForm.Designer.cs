namespace SistemInformasiSekolah
{
    partial class KelasForm
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
            flagTxt = new TextBox();
            namaKelasTxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            jurusanCombo = new ComboBox();
            radio12 = new RadioButton();
            radio11 = new RadioButton();
            label4 = new Label();
            radio10 = new RadioButton();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label3 = new Label();
            idKelasTxt = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            label1.Size = new Size(827, 51);
            label1.TabIndex = 1;
            label1.Text = "Kelas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(512, 384);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(flagTxt);
            panel1.Controls.Add(namaKelasTxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(jurusanCombo);
            panel1.Controls.Add(radio12);
            panel1.Controls.Add(radio11);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(radio10);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(idKelasTxt);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(532, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 384);
            panel1.TabIndex = 3;
            // 
            // flagTxt
            // 
            flagTxt.Location = new Point(21, 263);
            flagTxt.Name = "flagTxt";
            flagTxt.Size = new Size(71, 23);
            flagTxt.TabIndex = 23;
            flagTxt.TextChanged += flagTxt_TextChanged;
            // 
            // namaKelasTxt
            // 
            namaKelasTxt.Anchor = AnchorStyles.Top;
            namaKelasTxt.Location = new Point(21, 101);
            namaKelasTxt.Name = "namaKelasTxt";
            namaKelasTxt.ReadOnly = true;
            namaKelasTxt.Size = new Size(225, 23);
            namaKelasTxt.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 78);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 21;
            label6.Text = "Nama Kelas";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 188);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 19;
            label5.Text = "Jurusan";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // jurusanCombo
            // 
            jurusanCombo.FormattingEnabled = true;
            jurusanCombo.Location = new Point(21, 211);
            jurusanCombo.Name = "jurusanCombo";
            jurusanCombo.Size = new Size(225, 23);
            jurusanCombo.TabIndex = 18;
            jurusanCombo.SelectedIndexChanged += jurusanCombo_SelectedIndexChanged;
            // 
            // radio12
            // 
            radio12.AutoSize = true;
            radio12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radio12.Location = new Point(147, 153);
            radio12.Name = "radio12";
            radio12.Size = new Size(38, 21);
            radio12.TabIndex = 17;
            radio12.TabStop = true;
            radio12.Text = "12";
            radio12.UseVisualStyleBackColor = true;
            radio12.CheckedChanged += radio12_CheckedChanged;
            // 
            // radio11
            // 
            radio11.AutoSize = true;
            radio11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radio11.Location = new Point(100, 153);
            radio11.Name = "radio11";
            radio11.Size = new Size(36, 21);
            radio11.TabIndex = 16;
            radio11.TabStop = true;
            radio11.Text = "11";
            radio11.UseVisualStyleBackColor = true;
            radio11.CheckedChanged += radio11_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 130);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 15;
            label4.Text = "Tingkat";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // radio10
            // 
            radio10.AutoSize = true;
            radio10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radio10.Location = new Point(47, 153);
            radio10.Name = "radio10";
            radio10.Size = new Size(38, 21);
            radio10.TabIndex = 14;
            radio10.TabStop = true;
            radio10.Text = "10";
            radio10.UseVisualStyleBackColor = true;
            radio10.CheckedChanged += radio10_CheckedChanged;
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
            btnNew.Location = new Point(10, 340);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 31);
            btnNew.TabIndex = 13;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
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
            btnDelete.Location = new Point(98, 340);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnSave.Location = new Point(186, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 240);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 9;
            label3.Text = "Flag";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // idKelasTxt
            // 
            idKelasTxt.Anchor = AnchorStyles.Top;
            idKelasTxt.Location = new Point(21, 48);
            idKelasTxt.Name = "idKelasTxt";
            idKelasTxt.ReadOnly = true;
            idKelasTxt.Size = new Size(225, 23);
            idKelasTxt.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 25);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "ID Kelas";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // KelasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 461);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "KelasForm";
            Text = "KelasForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private Label label3;
        private TextBox idKelasTxt;
        private Label label2;
        private RadioButton radio12;
        private RadioButton radio11;
        private Label label4;
        private RadioButton radio10;
        private Label label5;
        private ComboBox jurusanCombo;
        private TextBox namaKelasTxt;
        private Label label6;
        private TextBox flagTxt;
    }
}