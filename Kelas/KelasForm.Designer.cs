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
            panel3 = new Panel();
            flagTxt = new TextBox();
            jurusanCombo = new ComboBox();
            namaKelasTxt = new TextBox();
            label2 = new Label();
            label6 = new Label();
            idKelasTxt = new TextBox();
            label5 = new Label();
            label3 = new Label();
            radio10 = new RadioButton();
            radio12 = new RadioButton();
            label4 = new Label();
            radio11 = new RadioButton();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            label1.Size = new Size(788, 51);
            label1.TabIndex = 1;
            label1.Text = "Kelas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(13, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(420, 375);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(463, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 399);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(flagTxt);
            panel3.Controls.Add(jurusanCombo);
            panel3.Controls.Add(namaKelasTxt);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(idKelasTxt);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(radio10);
            panel3.Controls.Add(radio12);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(radio11);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 319);
            panel3.TabIndex = 5;
            // 
            // flagTxt
            // 
            flagTxt.Location = new Point(18, 255);
            flagTxt.Name = "flagTxt";
            flagTxt.Size = new Size(71, 23);
            flagTxt.TabIndex = 23;
            flagTxt.TextChanged += flagTxt_TextChanged;
            // 
            // jurusanCombo
            // 
            jurusanCombo.FormattingEnabled = true;
            jurusanCombo.Location = new Point(18, 203);
            jurusanCombo.Name = "jurusanCombo";
            jurusanCombo.Size = new Size(244, 23);
            jurusanCombo.TabIndex = 18;
            jurusanCombo.SelectedIndexChanged += jurusanCombo_SelectedIndexChanged;
            // 
            // namaKelasTxt
            // 
            namaKelasTxt.Location = new Point(18, 93);
            namaKelasTxt.Name = "namaKelasTxt";
            namaKelasTxt.ReadOnly = true;
            namaKelasTxt.Size = new Size(244, 23);
            namaKelasTxt.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 17);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "ID Kelas";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 70);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 21;
            label6.Text = "Nama Kelas";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // idKelasTxt
            // 
            idKelasTxt.Location = new Point(18, 40);
            idKelasTxt.Name = "idKelasTxt";
            idKelasTxt.ReadOnly = true;
            idKelasTxt.Size = new Size(244, 23);
            idKelasTxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 180);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 19;
            label5.Text = "Jurusan";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 232);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 9;
            label3.Text = "Flag";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // radio10
            // 
            radio10.AutoSize = true;
            radio10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radio10.Location = new Point(44, 145);
            radio10.Name = "radio10";
            radio10.Size = new Size(38, 21);
            radio10.TabIndex = 14;
            radio10.TabStop = true;
            radio10.Text = "10";
            radio10.UseVisualStyleBackColor = true;
            radio10.CheckedChanged += radio10_CheckedChanged;
            // 
            // radio12
            // 
            radio12.AutoSize = true;
            radio12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radio12.Location = new Point(148, 146);
            radio12.Name = "radio12";
            radio12.Size = new Size(38, 21);
            radio12.TabIndex = 17;
            radio12.TabStop = true;
            radio12.Text = "12";
            radio12.UseVisualStyleBackColor = true;
            radio12.CheckedChanged += radio12_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 122);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 15;
            label4.Text = "Tingkat";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // radio11
            // 
            radio11.AutoSize = true;
            radio11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radio11.Location = new Point(97, 145);
            radio11.Name = "radio11";
            radio11.Size = new Size(36, 21);
            radio11.TabIndex = 16;
            radio11.TabStop = true;
            radio11.Text = "11";
            radio11.UseVisualStyleBackColor = true;
            radio11.CheckedChanged += radio11_CheckedChanged;
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
            btnNew.Location = new Point(43, 357);
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
            btnDelete.Location = new Point(131, 357);
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
            btnSave.Location = new Point(219, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 399);
            panel2.TabIndex = 4;
            // 
            // KelasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(788, 476);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "KelasForm";
            Text = "KelasForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel2;
        private Panel panel3;
    }
}