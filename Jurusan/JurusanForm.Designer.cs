namespace SistemInformasiSekolah
{
    partial class JurusanForm
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            codeTxt = new TextBox();
            label4 = new Label();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            namaJurusanTxt = new TextBox();
            label3 = new Label();
            idJurusanTxt = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(487, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(836, 51);
            label1.TabIndex = 1;
            label1.Text = "Jurusan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(codeTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(namaJurusanTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(idJurusanTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(533, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 384);
            panel1.TabIndex = 2;
            // 
            // codeTxt
            // 
            codeTxt.Anchor = AnchorStyles.Top;
            codeTxt.Location = new Point(25, 171);
            codeTxt.Name = "codeTxt";
            codeTxt.Size = new Size(72, 23);
            codeTxt.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.InactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 148);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 14;
            label4.Text = "Code";
            label4.TextAlign = ContentAlignment.BottomLeft;
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
            btnNew.Location = new Point(19, 340);
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
            btnDelete.Location = new Point(107, 340);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
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
            btnSave.Location = new Point(195, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // namaJurusanTxt
            // 
            namaJurusanTxt.Anchor = AnchorStyles.Top;
            namaJurusanTxt.Location = new Point(25, 119);
            namaJurusanTxt.Name = "namaJurusanTxt";
            namaJurusanTxt.Size = new Size(225, 23);
            namaJurusanTxt.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 96);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 9;
            label3.Text = "Nama Jurusan";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // idJurusanTxt
            // 
            idJurusanTxt.Anchor = AnchorStyles.Top;
            idJurusanTxt.Location = new Point(25, 66);
            idJurusanTxt.Name = "idJurusanTxt";
            idJurusanTxt.ReadOnly = true;
            idJurusanTxt.Size = new Size(225, 23);
            idJurusanTxt.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 43);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 7;
            label2.Text = "ID Jurusan";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 384);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Location = new Point(12, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 312);
            panel3.TabIndex = 16;
            // 
            // JurusanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(836, 461);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "JurusanForm";
            Text = "JurusanForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
        private TextBox namaJurusanTxt;
        private Label label3;
        private TextBox idJurusanTxt;
        private Label label2;
        private TextBox codeTxt;
        private Label label4;
        private Panel panel3;
        private Panel panel2;
    }
}