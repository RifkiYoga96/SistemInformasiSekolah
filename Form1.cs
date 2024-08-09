using System.Web;

namespace SistemInformasiSekolah
{
    public partial class Form1 : Form
    {
        private DbDal db;

        public Form1()
        {
            db = new DbDal();
            InitializeComponent();
            ListAgama();
            Yatim();
            loadSiswa();
        }

        public void loadSiswa()
        {
            dataGridView1.DataSource = db.ListSiswa();
        }

        public void ListAgama()
        {
            List<string> Agama = new List<string>() { "Islam", "Kristen", "Katolik", "Hindu", "Budha", "Konghucu" };

            comboAgamaAyah.DataSource = new List<string>(Agama);
            comboAgamaIbu.DataSource = new List<string>(Agama);
            comboAgamaWali.DataSource = new List<string>(Agama);
            comboAgamaSiswa.DataSource = new List<string>(Agama);
        }

        public void Goldar()
        {
            List<string> golongan = new List<string>() { "AB", "A", "B", "O" };
            comboGolDar.DataSource = golongan;
        }
        public void Yatim()
        {
            List<string> Ytm = new List<string>() { "Lengkap", "Yatim", "Piatu", "Yatim Piatu" };

            comboYatim.DataSource = new List<string>(Ytm);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Validasi();
        }
        public void Validasi()
        {
            string a, b, c, d, e, f, g, h, i, j, k;

            a = txtNamaLengkap.Text;
            b = (!radioLaki.Checked && !radioPerempuan.Checked) ? "" : "a";
            c = txtTempatLahir.Text;
            d = tglLahirSiswa.Text;
            e = txtKewarganegara.Text;
            f = txtAnakKe.Text;
            g = txtJumSauKan.Text;
            h = txtJumSauTi.Text;
            i = txtJumSauAng.Text;
            j = txtBahasa.Text;
            k = txtNIKSiswa.Text;

            string[] arrvalid = { a, b, c, d, e, f, g, h, i, j, k };
            bool cek = Array.Exists(arrvalid, string.IsNullOrEmpty);

            if (cek)
            {
                txtNamaLengkap.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Horeee");
            }

        }

        private void radioTidak_CheckedChanged(object sender, EventArgs e)
        {
            txtJikaYa.ReadOnly = true;
        }

        private void radioYa_CheckedChanged(object sender, EventArgs e)
        {
            txtJikaYa.ReadOnly = false;
        }
        private void radioHidupAyah_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHidupAyah.Checked)
            {
                txtTahunMatiAyah.ReadOnly = true;
            }
            else
            {
                txtTahunMatiAyah.ReadOnly = false;
            }
        }

        private void radioHidupIbu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHidupIbu.Checked)
            {
                txtTahunMatiIbu.ReadOnly = true;
            }
            else
            {
                txtTahunMatiIbu.ReadOnly = false;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (txtNoHPWali.Text == "")
            {
                MessageBox.Show("ppp");
            }
            else
            {
                MessageBox.Show("aaa");
            }
        }
        private void txtNamaLengkap_Click(object sender, EventArgs e)
        {
            txtNamaLengkap.BackColor = Color.White;
        }

      
    }
}
