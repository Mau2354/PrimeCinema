using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
namespace Gerencia
{
    public partial class ger1 : Form
    {

        public ger1()
        {
            InitializeComponent();
        }
        public string[] sucursales = { "Galerias", "La Gran via", "Multiplaza", "MetroCentro", "Plaza Mundo", "Plaza Merliot", "Plaza Futura", "Antiguo Cuscatlan", "Soyapango", "Cabañas" };
        public string[] sucursalSeleccionada = new string[10];
        public string sucursal;
        public string[] S_Nombre = new string[10];
        public string[] N_Gerente = new string[10];
        public string[] S_Sucursal = new string[10];
        public string[] S_Direccion = new string[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.MaxLength = 8;
            foreach (string sucursal in sucursales)
            {
                comboBox1.Items.Add(sucursal);
            }
        }

        private void Title1_Click(object sender, EventArgs e)
        {

        }

        private void Title2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("NO SE PUEDE DEJAR EL CAMPO VACIO", "ERROR");
            }
            else
            {
                for (int i = 0; i < S_Nombre.Length; i++)
                {
                    N_Gerente[i] = textBox2.Text;
                    S_Sucursal[i] = textBox3.Text;
                    S_Direccion[i] = textBox4.Text;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sucursal = comboBox1.SelectedItem.ToString();
            for (int f = 0; f < sucursales.Length; f++)
            {
                sucursalSeleccionada[f] = sucursal;
            }
        }
    }
}