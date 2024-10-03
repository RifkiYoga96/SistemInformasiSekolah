using Dapper;
using SistemInformasiSekolah.Dal;
using SistemInformasiSekolah.Model;
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
    public partial class FormGuru : Form
    {
        private readonly GuruDal _guruDal;
        private readonly GuruMapelDal _guruMapelDal;
        private readonly MapelDal _mapelDal;

        private readonly BindingSource _listMapelBinding;
        private readonly BindingList<MapelDto> _listMapel;
        public FormGuru()
        {
            InitializeComponent();
            _guruDal = new GuruDal();
            _guruMapelDal = new GuruMapelDal();
            _mapelDal = new MapelDal();
            _listMapel = new BindingList<MapelDto>();
            _listMapelBinding = new BindingSource()
            {
                DataSource = _listMapel
            };
            RegisterControlEvent();
            RefreshData();
            InitGrid();
        }
        private void RegisterControlEvent()
        {
            btnNew.Click += btnNew_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += BtnDelete_Click;

            dataGridView1.RowEnter += dataGridView1_RowEnter;
            gridMapel.KeyDown += gridMapel_KeyDown;
            gridMapel.CellValidated += gridMapel_CellValidated;

            txtFilter.TextChanged += txtFilter_TextChanged;
        }

        private void txtFilter_TextChanged(object? sender, EventArgs e)
        {
            RefreshData();

        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            klikDelete();
        }
        private void klikDelete()
        {
            var delete = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            if(MessageBox.Show("Apakah ingin menghapus data tersebut","Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                _guruDal.Delete(delete);
                RefreshData();
            }
        }
        private void gridMapel_CellValidated(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var dataGrid = (DataGridView)sender;
            var getIdMapel = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            switch (dataGrid.CurrentCell.OwningColumn.Name)
            {
                case "Id":
                    var mapel = _mapelDal.GetData(Convert.ToInt32(getIdMapel));
                    if (mapel == null)
                    {
                        _listMapel[e.RowIndex].Mapel = " ";
                        return;
                    }

                    _listMapel[e.RowIndex].Id = mapel.MapelId;
                    _listMapel[e.RowIndex].Mapel= mapel.NamaMapel;

                    break;
            }
        }

        private void InitGrid()
        {
            gridMapel.DataSource = _listMapelBinding;
            gridMapel.Columns["Id"].Width = 30;
            gridMapel.Columns["Mapel"].Width = 200;
        }

        private void gridMapel_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                DataGridViewRow currentRow = gridMapel.CurrentRow;

                using var formMapel = new FormListMapel();
                if (formMapel.ShowDialog() == DialogResult.OK)
                {
                    var mapelId = formMapel.MapelId;
                    var mapelName = formMapel.MapelName;

                    gridMapel.BeginEdit(true);

                    currentRow.Cells[0].Value = mapelId;
                    currentRow.Cells[1].Value = mapelName;

                    gridMapel.EndEdit(DataGridViewDataErrorContexts.Commit);

                    _listMapelBinding.ResetBindings(false);
                    gridMapel.CurrentCell = gridMapel.Rows[gridMapel.Rows.Count - 1].Cells[0];
                }
            }
        }

        private void dataGridView1_RowEnter(object? sender, DataGridViewCellEventArgs e)
        {
            var guruId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LoadData(Convert.ToInt32(guruId));
        }

        private void btnNew_Click(object? sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            SaveGuru();
            RefreshData();
            ClearInput();
        }

        private void ClearInput()
        {
            txtIdGuru.Clear();
            txtNamaGuru.Clear();
            tglLahir.Value = DateTime.Now;
            radioD3.Checked = false;
            radioS1.Checked = false;
            radioS2.Checked = false;
            radioS3.Checked = false;
            txtJurusanPendidikan.Clear();
            txtTahunLulus.Clear();
            txtInstansiPendidikan.Clear();
            txtKota.Clear();
            _listMapel.Clear();
        }
        private int SaveGuru()
        {
            int guruId = txtIdGuru.Text == string.Empty ? 0 : int.Parse(txtIdGuru.Text);

            var guru = new GuruModel
            {
                GuruId = guruId,
                GuruName = txtNamaGuru.Text,
                TglLahir = tglLahir.Value,
                TingkatPendidikan = radioD3.Checked ? "D3" : radioS1.Checked ? "S1" : radioS2.Checked ? "S2" : radioS3.Checked ? "S3" : string.Empty,
                JurusanPendidikan = txtJurusanPendidikan.Text,
                TahunLulus = txtTahunLulus.Text,
                InstansiPendidikan = txtInstansiPendidikan.Text,
                KotaPendidikan = txtKota.Text,

                ListMapel = _listMapel.Select(x => new GuruMapelModel
                {
                    GuruId = guruId,
                    MapelId = x.Id
                }).ToList()
            };
 
            if (guruId == 0)
                guru.GuruId = _guruDal.Insert(guru);
            else
                _guruDal.Update(guru);
            MessageBox.Show(guru.GuruId.ToString());
            _guruMapelDal.Delete(guru.GuruId);
            _guruMapelDal.Insert(guru.ListMapel, guru.GuruId);
            return guruId;
        }

        private void LoadData(int guruId)
        {
            var guru = _guruDal.GetData(guruId);
            if (guru is null)
            {
                return;
            };
            txtIdGuru.Text = guru.GuruId.ToString();
            txtNamaGuru.Text = guru.GuruName;
            tglLahir.Value = guru.TglLahir;
            if (guru.TingkatPendidikan == "D3") radioD3.Checked = true;
            if (guru.TingkatPendidikan == "S1") radioS1.Checked = true;
            if (guru.TingkatPendidikan == "S2") radioS2.Checked = true;
            if (guru.TingkatPendidikan == "S3") radioS3.Checked = true;
            txtJurusanPendidikan.Text = guru.JurusanPendidikan;
            txtInstansiPendidikan.Text = guru.InstansiPendidikan;
            txtTahunLulus.Text = guru.TahunLulus;
            txtKota.Text = guru.KotaPendidikan;

            var listMapel = _guruMapelDal.ListData(guruId)?.ToList() ?? new List<GuruMapelModel>();
            _listMapel.Clear();
            listMapel.ForEach(x => _listMapel.Add(new MapelDto
            {
                Id = x.MapelId,
                Mapel = x.MapelName
            }));
        }
        private void RefreshData()
        {
            string sqlc = Filter(txtFilter.Text);
            var dp = new DynamicParameters();
            if (sqlc != "") dp.Add("@GuruName",txtFilter.Text);
            var listData = _guruDal.ListData(sqlc,dp) ?? new List<GuruModel>();
            var dataSource = listData.Select(x => new GuruDto
            {
                Id = x.GuruId,
                Name = x.GuruName,
                Pendidikan = $"{x.TingkatPendidikan} - {x.JurusanPendidikan}"
            }).ToList();
            dataGridView1.DataSource = dataSource;
            dataGridView1.Refresh();
        }

        private string Filter(string namaGuru)
        {
            string sql = string.Empty;
            if (namaGuru != "")
                return sql += @" WHERE GuruName LIKE '%'+@GuruName+'%'";
            else
                return sql;
        }

    }
}

public class GuruDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Pendidikan { get; set; }
}

public class MapelDto
{
    public int Id { get; set; }
    public string Mapel { get; set; }
}
