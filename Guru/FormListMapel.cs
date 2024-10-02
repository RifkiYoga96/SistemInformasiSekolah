using SistemInformasiSekolah.Mapel;
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
    public partial class FormListMapel : Form
    {
        private readonly MapelDal _mapelDal;
        public int MapelId { get; private set; } = 0;
        public string MapelName { get; private set; } = string.Empty;
        public FormListMapel()
        {
            InitializeComponent();
            KeyPreview = true;

            _mapelDal = new MapelDal();
            var listMapel = _mapelDal.ListData()?.ToList() ?? new List<MapelModel>();
            dataGridView1.DataSource = listMapel.Select(x => new
            {
                ID = x.MapelId,
                Mapel = x.NamaMapel
            }).ToList();

            dataGridView1.CellDoubleClick += dataGridView1_DoubleClick;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            this.KeyDown += ThisForm_KeyDown;
        }

        private void ThisForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void dataGridView1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataGridView1.CurrentRow != null)
            {
                e.Handled = true;
                DataGridViewRow row = dataGridView1.CurrentRow;
                MapelId = Convert.ToInt32(row.Cells[0].Value);
                MapelName = row?.Cells[1].Value.ToString() ?? string.Empty;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridView1_DoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            MapelId = Convert.ToInt32(row.Cells[0].Value);
            MapelName = row?.Cells[1].Value.ToString() ?? string.Empty;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
  
    }
}
