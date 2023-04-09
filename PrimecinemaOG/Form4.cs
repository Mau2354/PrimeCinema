using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrimecinemaOG
{
    public partial class Cartelera : Form
    {
        public string[] sucursales = { "Galerias", "La Gran via", "Multiplaza", "MetroCentro", "Plaza Mundo", "Plaza Merliot", "Plaza Futura", "Antiguo Cuscatlan", "Soyapango", "Cabañas" };
        public string[] sucursalSeleccionada = new string[10];
        public string sucursal;
        public Cartelera()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (Font font = new Font("Arial", 22.0f))
            {
                lbl_sucursal.Font = font;
                lbl_pelis.Font = font;
            }

            foreach (string sucursal in sucursales)
            {
                cb_sucurales.Items.Add(sucursal);
            }
        }

        private void cb_sucurales_SelectedIndexChanged(object sender, EventArgs e)
        {
            sucursal = cb_sucurales.SelectedItem.ToString();
            for (int f = 0; f < sucursales.Length; f++)
            {
                sucursalSeleccionada[f] = sucursal;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio_ses frm1 = (inicio_ses)Application.OpenForms["inicio_ses"];
            frm1.Show();
            this.Close();

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            Compra_bolet frm5 = new Compra_bolet();
            frm5.Show();
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            inicio_ses frm1 = (inicio_ses)Application.OpenForms["inicio_ses"];
            frm1.Close();
        }
    }
}
