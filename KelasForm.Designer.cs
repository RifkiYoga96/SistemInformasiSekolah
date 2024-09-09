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
            label5 = new Label();
            jurusanCombo = new ComboBox();
            radio12 = new RadioButton();
            radio11 = new RadioButton();
            label4 = new Label();
            radio10 = new RadioButton();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            namaKelasTxt = new TextBox();
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
            label1.Size = new Size(800, 51);
            label1.TabIndex = 1;
            label1.Text = "Kelas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(512, 384);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(jurusanCombo);
            panel1.Controls.Add(radio12);
            panel1.Controls.Add(radio11);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(radio10);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(namaKelasTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(idKelasTxt);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(518, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 384);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 202);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 19;
            label5.Text = "Jurusan";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // jurusanCombo
            // 
            jurusanCombo.FormattingEnabled = true;
            jurusanCombo.Location = new Point(22, 225);
            jurusanCombo.Name = "jurusanCombo";
            jurusanCombo.Size = new Size(225, 23);
            jurusanCombo.TabIndex = 18;
            // 
            // radio12
            // 
            radio12.AutoSize = true;
            radio12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radio12.Location = new Point(146, 167);
            radio12.Name = "radio12";
            radio12.Size = new Size(38, 21);
            radio12.TabIndex = 17;
            radio12.TabStop = true;
            radio12.Text = "12";
            radio12.UseVisualStyleBackColor = true;
            // 
            // radio11
            // 
            radio11.AutoSize = true;
            radio11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radio11.Location = new Point(99, 167);
            radio11.Name = "radio11";
            radio11.Size = new Size(36, 21);
            radio11.TabIndex = 16;
            radio11.TabStop = true;
            radio11.Text = "11";
            radio11.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 144);
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
            radio10.Location = new Point(46, 167);
            radio10.Name = "radio10";
            radio10.Size = new Size(38, 21);
            radio10.TabIndex = 14;
            radio10.TabStop = true;
            radio10.Text = "10";
            radio10.UseVisualStyleBackColor = true;
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
            btnNew.Location = new Point(12, 342);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 31);
            btnNew.TabIndex = 13;
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
            btnDelete.Location = new Point(100, 342);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 12;
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
            btnSave.Location = new Point(188, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // namaKelasTxt
            // 
            namaKelasTxt.Anchor = AnchorStyles.Top;
            namaKelasTxt.Location = new Point(22, 114);
            namaKelasTxt.Name = "namaKelasTxt";
            namaKelasTxt.Size = new Size(225, 23);
            namaKelasTxt.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 91);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 9;
            label3.Text = "Nama Kelas";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // idKelasTxt
            // 
            idKelasTxt.Anchor = AnchorStyles.Top;
            idKelasTxt.Location = new Point(22, 61);
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
            label2.Location = new Point(22, 38);
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
            ClientSize = new Size(800, 450);
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
        private TextBox namaKelasTxt;
        private Label label3;
        private TextBox idKelasTxt;
        private Label label2;
        private RadioButton radio12;
        private RadioButton radio11;
        private Label label4;
        private RadioButton radio10;
        private Label label5;
        private ComboBox jurusanCombo;
    }
}