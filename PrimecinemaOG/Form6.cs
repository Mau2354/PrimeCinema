using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static PrimecinemaOG.Registro;
using static PrimecinemaOG.inicio_ses;
using static Gerencia.ger1;
using Gerencia;

namespace PrimecinemaOG
{
    public partial class Form6 : Form
    {
        inicio_ses frm1 = (inicio_ses)Application.OpenForms["inicio_ses"];
        Gerencia.ger1 gerencia1 = (Gerencia.ger1)Application.OpenForms["gerencia1"];
        

        public Form6()
        {
            InitializeComponent();
        }


        private void Form6_Load(object sender, EventArgs e)
        {



        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void M_Button_Click(object sender, EventArgs e)
        {
            inicio_ses frm1 = (inicio_ses)Application.OpenForms["inicio_ses"];
            Gerencia.ger1 gerencia1 = (Gerencia.ger1)Application.OpenForms["gerencia1"];
            Grillo.Columns.Add("N_S_Column", "Nombre de Sucursal");
            Grillo.Columns.Add("N_G_Column", "Nombre de Gerente");
            Grillo.Columns.Add("T_S_Column", "Telefono de Sucursal");
            Grillo.Columns.Add("D_S_Column", "Direccion de Sucursal");
            Grillo.Columns.Add("S_Column", "Numero de Salas");

            for (int i = 0; i < gerencia1.S_Nombre.Length; i++)
            {

                Grillo.Rows.Add(gerencia1.S_Nombre[i], gerencia1.N_Gerente[i], gerencia1.S_Sucursal[i], gerencia1.S_Direccion[i], gerencia1.NumeroSalas[i]);
            }

            Grilla.Columns.Add("N_Column", "Nombre");
            Grilla.Columns.Add("M_Column", "Monto");
            Grilla.Columns.Add("DUI_Column", "DUI");
            Grilla.Columns.Add("D_Column", "Direccion");
            Grilla.Columns.Add("T_Column", "Telefono");
            Grilla.Columns.Add("C_Column", "Correo");

            for (int i = 0; i < 50; i++)
            {
                Grilla.Rows.Add(frm1.Nombres[i], frm1.correos[i], frm1.DUIs[i], frm1.Direcciones[i], frm1.Telefonos[i], frm1.correos[i]);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void Grillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            ger1 frm3 = new ger1();
            frm3.Show();
            this.Hide();
        }

        private void Export_Button_Click(object sender, EventArgs e)
        {

            Gerencia.ger1 gerencia1 = (Gerencia.ger1)Application.OpenForms["gerencia1"];
            string datos1 = string.Join("\n", new string[][] { gerencia1.S_Nombre, gerencia1.N_Gerente, gerencia1.S_Sucursal, gerencia1.S_Direccion, gerencia1.NumeroSalas }
            .Select(arr => string.Join(",", arr.Select(x => $"\"{x}\""))));

            File.WriteAllText("datosSucursal.txt", datos1);

            inicio_ses frm1 = (inicio_ses)Application.OpenForms["inicio_ses"];
            string datos2 = string.Join("\n", new string[][] { frm1.Nombres, frm1.correos, frm1.DUIs, frm1.Direcciones, frm1.Telefonos, frm1.correos }
            .Select(arr => string.Join(",", arr.Select(x => $"\"{x}\""))));

            File.WriteAllText("datosSucursal.txt", datos2);


        }
    }
}
