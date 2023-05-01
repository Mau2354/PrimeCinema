using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PrimecinemaOG
{
    public partial class butac : Form
    {

        public butac()
        {
            InitializeComponent();

        }
        private bool[,] reservado = new bool[4, 10];
        private void viewreserd()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (reservado[i, j])
                    {
                        sb.Append($"Asiento {i + 1}-{j + 1} está reservado.\n");
                    }
                }
            }
            MessageBox.Show(sb.ToString());
        }
        private void cambiorojo(Button button, int i, int j)
        {
            if (button.BackColor == Color.Red)
            {
                button.BackColor = Color.Lime;
                reservado[i, j] = false;
            }
            else
            {
                button.BackColor = Color.Red;
                reservado[i, j] = true;
            }
        }

        private void butac_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_a1_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a1, 0, 0);
        }

        private void btn_a2_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a2, 0, 1);

        }

        private void btn_a3_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a3, 0, 2);

        }

        private void btn_a4_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a4, 0, 3);
        }

        private void btn_a5_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a5, 0, 4);
        }

        private void btn_a6_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a6, 0, 5);
        }

        private void btn_a7_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a7, 0, 6);
        }

        private void btn_a8_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a8, 0, 7);
        }

        private void btn_a9_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a9, 0, 8);
        }

        private void btn_a10_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_a10, 0, 9);
        }

        private void btn_b1_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b1, 1, 0);
        }

        private void btn_b2_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b2, 1, 1);
        }

        private void btn_b3_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b3, 1, 2);
        }

        private void btn_b4_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b4, 1, 3);
        }

        private void btn_b5_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b5, 1, 4);
        }

        private void btn_b6_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b6, 1, 5);
        }

        private void btn_b7_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b7, 1, 6);
        }

        private void btn_b8_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b8, 1, 7);
        }

        private void btn_b9_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b9, 1, 8);
        }

        private void btn_b10_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_b10, 1, 9);
        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c1, 2, 0);
        }

        private void btn_c2_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c2, 2, 1);
        }

        private void btn_c3_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c3, 2, 2);
        }

        private void btn_c4_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c4, 2, 3);
        }

        private void btn_c5_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c5, 2, 4);
        }

        private void btn_c6_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c6, 2, 5);
        }

        private void btn_c7_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c7, 2, 6);
        }

        private void btn_c8_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c8, 2, 7);
        }

        private void btn_c9_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c9, 2, 8);
        }

        private void btn_c10_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_c10, 2, 9);
        }

        private void btn_d1_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d1, 3, 0);
        }

        private void btn_d2_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d2, 3, 1);
        }

        private void btn_d3_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d3, 3, 2);
        }

        private void btn_d4_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d4, 3, 3);
        }

        private void btn_d5_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d5, 3, 4);
        }

        private void btn_d6_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d6, 3, 5);
        }

        private void btn_d7_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d7, 3, 6);
        }

        private void btn_d8_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d8, 3, 7);
        }

        private void btn_d9_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d9, 3, 8);
        }

        private void btn_d10_Click(object sender, EventArgs e)
        {
            cambiorojo(btn_d10, 3, 9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio_ses frm1 = (inicio_ses)Application.OpenForms["inicio_ses"];
            frm1.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butac_Load_1(object sender, EventArgs e)
        {

        }

        private void butac_Load_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Cartelera forms4 = new Cartelera();
            forms4.Show();
            this.Hide();
        }

        private void Reguistrar_Click(object sender, EventArgs e)
        {
            viewreserd();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
