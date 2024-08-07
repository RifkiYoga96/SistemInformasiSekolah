using System.Web;

namespace SistemInformasiSekolah
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ListAgama();
        }

        public void ListAgama()
        {
            List<string> Agama = new List<string>() { "Islam", "Kristen", "Katolik", "Hindu", "Budha", "Konghucu" };

            comboAgamaAyah.DataSource = new List<string>(Agama);
            comboAgamaIbu.DataSource = new List<string>(Agama);
            comboAgamaWali.DataSource = new List<string>(Agama);
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioTidak_CheckedChanged(object sender, EventArgs e)
        {
            txtJikaYa.ReadOnly = true;
        }

        private void radioYa_CheckedChanged(object sender, EventArgs e)
        {
            txtJikaYa.ReadOnly = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

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

        private void txtNoHPWali_TextChanged(object sender, EventArgs e)
        {

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

        private void txtNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamaLengkap_Click(object sender, EventArgs e)
        {
            txtNamaLengkap.BackColor = Color.White;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
