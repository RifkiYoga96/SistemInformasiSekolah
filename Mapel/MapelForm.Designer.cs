namespace SistemInformasiSekolah
{
    partial class MapelForm
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
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            namaMapelTxt = new TextBox();
            label3 = new Label();
            idMapelTxt = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            label1.Size = new Size(920, 51);
            label1.TabIndex = 0;
            label1.Text = "Mapel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.DimGray;
            dataGridView1.Location = new Point(9, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(561, 415);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(namaMapelTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(idMapelTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(597, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 433);
            panel1.TabIndex = 2;
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
            btnNew.Location = new Point(40, 389);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 31);
            btnNew.TabIndex = 6;
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
            btnDelete.Location = new Point(128, 389);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 31);
            btnDelete.TabIndex = 5;
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
            btnSave.Location = new Point(216, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // namaMapelTxt
            // 
            namaMapelTxt.Anchor = AnchorStyles.Top;
            namaMapelTxt.Font = new Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            namaMapelTxt.Location = new Point(36, 120);
            namaMapelTxt.Name = "namaMapelTxt";
            namaMapelTxt.Size = new Size(236, 25);
            namaMapelTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.InactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 97);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 2;
            label3.Text = "Nama Mapel";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // idMapelTxt
            // 
            idMapelTxt.Anchor = AnchorStyles.Top;
            idMapelTxt.Font = new Font("Segoe UI", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            idMapelTxt.Location = new Point(36, 64);
            idMapelTxt.Name = "idMapelTxt";
            idMapelTxt.ReadOnly = true;
            idMapelTxt.Size = new Size(236, 25);
            idMapelTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 41);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 0;
            label2.Text = "ID Mapel";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(9, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 365);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 433);
            panel2.TabIndex = 3;
            // 
            // MapelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(920, 509);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "MapelForm";
            Text = "MapelForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox idMapelTxt;
        private Label label2;
        private TextBox namaMapelTxt;
        private Label label3;
        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private Panel panel2;
        private Panel panel3;
    }
}