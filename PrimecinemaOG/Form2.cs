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
using static PrimecinemaOG.Registro;

namespace PrimecinemaOG
{
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            using (Font font = new Font("Arial", 22.0f))
            {
                lbl_registro.Font = font;
            }
            txtb_contra.MaxLength = 14;
            txtb_contra.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtb_contra.UseSystemPasswordChar = !checkBox1.Checked;
        }

        public void btn_registro_Click(object sender, EventArgs e)
        {

            inicio_ses frm1 = (inicio_ses)Application.OpenForms["inicio_ses"];
            if (string.IsNullOrEmpty(txtb_contra.Text) || string.IsNullOrEmpty(txtb_correo.Text) || string.IsNullOrEmpty(txtb_direccion.Text) || string.IsNullOrEmpty(txtb_dui.Text) || string.IsNullOrEmpty(txtb_name.Text) || string.IsNullOrEmpty(txtb_tel.Text))
            {
                MessageBox.Show("NO SE PUEDE DEJAR EL CAMPO VACIO", "ERROR");
            }
            else
            {
                bool duiRepetido = false;
                bool correoRepetido = false;
                for (int f = 0; f < frm1.Contraseñas.Length; f++)
                {
                    if (frm1.DUIs[f] == txtb_dui.Text)
                    {
                        duiRepetido = true;
                        break;
                    }
                    if (frm1.correos[f] == txtb_correo.Text)
                    {
                        correoRepetido = true;
                        break;
                    }
                }

                if (duiRepetido)
                {
                    MessageBox.Show("El DUI ingresado ya existe, por favor ingrese uno diferente.", "ERROR");
                }
                else if (correoRepetido)
                {
                    MessageBox.Show("El correo electrónico ingresado ya existe, por favor ingrese uno diferente.", "ERROR");
                }
                else
                {
                    for (int f = 0; f < frm1.Contraseñas.Length; f++)
                    {
                        if (frm1.Contraseñas[f] == null)
                        {
                            frm1.Contraseñas[f] = txtb_contra.Text;
                            frm1.correos[f] = txtb_correo.Text;
                            frm1.Nombres[f] = txtb_name.Text;
                            frm1.Direcciones[f] = txtb_direccion.Text;
                            frm1.DUIs[f] = txtb_dui.Text;
                            frm1.Telefonos[f] = txtb_tel.Text;
                            break;
                        }
                    }
                    this.Close();
                }
            }
        }

    }
}
