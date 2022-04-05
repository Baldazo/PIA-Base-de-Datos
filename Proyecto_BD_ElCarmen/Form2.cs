using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD_ElCarmen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }
    }
}
