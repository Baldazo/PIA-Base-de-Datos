namespace Proyecto_BD_ElCarmen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label1.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Form formulario = new Form2();
                formulario.ShowDialog();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}