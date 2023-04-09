using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerencia
{
    public partial class Cartelera : Form
    {
        public string[] Salas = new string[10];

        public Cartelera()
        {
            InitializeComponent();
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("NO SE PUEDE DEJAR EL CAMPO VACIO", "ERROR");
            }
            else
            {
                for (int i = 0; i < Salas.Length; i++)
                {
                    Salas[i] = textBox1.Text;

                    break;
                }
                MessageBox.Show("Datos Registrados Exitosamente");
                Cartelera frmb = new Cartelera();
                frmb.Show();
                this.Hide();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
