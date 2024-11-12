using SistemInformasiSekolah.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemInformasiSekolah
{
    public partial class MapelForm : Form
    {
        private readonly MapelDal mapelDal;
        public MapelForm()
        {
            InitializeComponent();
            mapelDal = new MapelDal();
            LoadData();
            InitGrid();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = mapelDal.ListData();
        }

        private void InitGrid()
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.ColumnHeadersHeight = 33;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Nama Mapel";
        }

        private void SaveData()
        {
            string mapelId = idMapelTxt.Text;
            string namaMapel = namaMapelTxt.Text;
            if (namaMapel == string.Empty)
            {
                MessageBox.Show("Nama Mapel Wajib Diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mapelId == string.Empty)
            {
                if (MessageBox.Show("Save Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mapelDal.Insert(namaMapel);
                    LoadData();
                }
            }
            else
            {
                if (MessageBox.Show("Update Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mapelDal.Update(Convert.ToInt32(mapelId), namaMapel);
                    LoadData();
                }
            }
        }

        private void ClearInput()
        {
            idMapelTxt.Clear();
            namaMapelTxt.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idMapelTxt.Text == string.Empty)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mapelDal.Delete(int.Parse(idMapelTxt.Text));
                LoadData();
                ClearInput();
                
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            var idMapel = row.Cells["MapelId"].Value?.ToString()?? string.Empty;
            var NamaJurusan = row.Cells["NamaMapel"].Value?.ToString()?? string.Empty;

            idMapelTxt.Text = idMapel;
            namaMapelTxt.Text = NamaJurusan;
        }
    }
}
