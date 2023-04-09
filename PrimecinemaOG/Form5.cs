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
using WinFormsApp2;
using static System.Windows.Forms.DataFormats;

namespace PrimecinemaOG
{
    public partial class Compra_bolet : Form
    {
        private string[] formatos = { "Tradicional", "3D" };
        private string formatoSeleccionado;
        private double precioBoleto;
        private double totalVenta;
        private int cantidadBoletos;
        public double precioBarbi1 = 0;
        public double precioBarbi2 = 0;
        public double precioBarbi3 = 0;
        public double precioIT = 0;
        public double precioSaw = 0;
        public double precioRPF = 0;

        public Compra_bolet()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Cartelera frm4 = (Cartelera)Application.OpenForms["Cartelera"];
            frm4.Show();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            inicio_ses frm1 = (inicio_ses)Application.OpenForms["inicio_ses"];
            frm1.Close();
        }

        private void pb_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titulo: barbie el secreto de las hadas" + "\nGéneros: Animación, Familia, Fantasía" + "\nClasificación: Todo público" + "\nFormato: Tradicional y 3D" + "\nDuración: 72 minutos", "Barbie el secreto de las hadas");
        }

        private void pb_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titulo: Barbie en una aventura de sirenas" + "\nGéneros: Animación, infantil" + "\nClasificación: Todo público" + "\nFormato: Tradicional y 3D" + "\nDuración: 75 minutos", "Barbie en una aventura de sirenas");
        }

        private void pb_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titulo: Barbie: Fairytopia" + "\nGéneros: Animación" + "\nClasificación: Todo público" + "\nFormato: Tradicional y 3D" + "\nDuración: 89 minutos", "Barbie: Fairytopia");
        }

        private void pb_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titulo: IT" + "\nGéneros: Terror" + "\nClasificación: +18​" + "\nFormato: Tradicional y 3D" + "\nDuración: 135 minutos", "IT");
        }

        private void pb_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titulo: SAW" + "\nGéneros: Terror, Gore, Policíaco, Suspenso, Thriller psicológico, Aventura" + "\nClasificación: +18​" + "\nFormato: Tradicional y 3D" + "\nDuración: 103 minutos", "SAW");
        }

        private void pb_6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titulo: Rápido y furioso: reto Tokio" + "\nGéneros: Acción, Aventura, Suspenso" + "\nClasificación: PG-13" + "\nFormato: Tradicional y 3D" + "\nDuración: 104 minutos", "Rápido y furioso: reto Tokio");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_formato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void Compra_bolet_Load(object sender, EventArgs e)
        {
            using (Font font = new Font("Arial", 22.0f))
            {
                label1.Font = font;
                label2.Font = font;
            }

            foreach (string formato in formatos)
            {
                cb_formato.Items.Add(formato);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            cantidadBoletos = (int)numericUpDown1.Value;
            formatoSeleccionado = cb_formato.SelectedItem.ToString();

            switch (formatoSeleccionado)
            {
                case "Tradicional":
                    if (cantidadBoletos >= 1 && cantidadBoletos <= 40)
                    {
                        precioBoleto = cb_edad.Checked ? 3.90 : 5.00;
                        totalVenta = cantidadBoletos * precioBoleto;

                    }
                    else
                    {

                        numericUpDown1.Value = 1;
                    }
                    break;

                case "3D":
                    if (cantidadBoletos >= 1 && cantidadBoletos <= 40)
                    {
                        precioBoleto = cb_edad.Checked ? 5.60 : 6.55;
                        totalVenta = cantidadBoletos * precioBoleto;

                    }
                    else
                    {

                        numericUpDown1.Value = 1;
                    }
                    break;

                default:
                    MessageBox.Show("Debe seleccionar un formato");
                    break;
            }

            if (chk_barbi1.Checked)
            {
                precioBarbi1 = totalVenta;
            }
            else
            {
                precioBarbi1 = 0;
            }

            if (chk_barbi2.Checked)
            {
                precioBarbi2 = totalVenta;
            }
            else
            {
                precioBarbi2 = 0;
            }

            if (chk_barbi3.Checked)
            {
                precioBarbi3 = totalVenta;
            }
            else
            {
                precioBarbi3 = 0;
            }

            if (chk_it.Checked)
            {
                precioIT = totalVenta;
            }
            else
            {
                precioIT = 0;
            }

            if (chk_saw.Checked)
            {
                precioSaw = totalVenta;
            }
            else
            {
                precioSaw = 0;
            }

            if (chk_rpf.Checked)
            {
                precioRPF = totalVenta;
            }
            else
            {
                precioRPF = 0;
            }
            this.Hide();
            butac asiento = new butac();
            asiento.Show();
        }
    
    
        

        private void chk_barbi1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_barbi2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_barbi3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_it_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_saw_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_rpf_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
