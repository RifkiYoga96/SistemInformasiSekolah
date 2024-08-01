namespace SistemInformasiSekolah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Next();
        }

        public void Next()
        {
            int index = tabControl1.SelectedIndex;
            tabControl1.SelectedIndex = index + 1;
        }

        public void Back()
        {
            int index = tabControl1.SelectedIndex;
            tabControl1.SelectedIndex = index - 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
