using Gerencia;
using Microsoft.Win32;
using static PrimecinemaOG.Registro;

namespace PrimecinemaOG
{
    public partial class inicio_ses : Form
    {


        string CorreoGerente = "gerente001@primecinema.com.sv";
        string ContraGerente = "Cuak123";
        public string[] correos = new string[10];
        public string[] Contraseñas = new string[10];
        public string[] Nombres = new string[10];
        public string[] DUIs = new string[10];
        public string[] Direcciones = new string[10];
        public string[] Telefonos = new string[10];
        public inicio_ses()
        {
            InitializeComponent();
        }

        private void inicio_ses_Load_1(object sender, EventArgs e)
        {
            using (Font font = new Font("Arial", 22.0f))
            {
                lbl_inicio.Font = font;
            }
            txtb_contra.UseSystemPasswordChar = !chk_mostrar_contra.Checked;
            txtb_contra.MaxLength = 14;

        }

        private void btn_iniciar_ses_Click(object sender, EventArgs e)
        {
            bool credencialesValidas = false;

            if (txtb_correo1.Text == CorreoGerente && txtb_contra.Text == ContraGerente)
            {
                ger1 frm3 = new ger1();
                frm3.Show();
                this.Hide();
            }
            else if (string.IsNullOrEmpty(txtb_correo1.Text) || string.IsNullOrEmpty(txtb_contra.Text))
            {
                MessageBox.Show("NO SE PUEDE DEJAR EL CAMPO VACIO", "ERROR");
            }
            else
            {
                for (int i = 0; i < Contraseñas.Length; i++)
                {
                    if (Contraseñas[i] == txtb_contra.Text && correos[i] == txtb_correo1.Text)
                    {
                        Cartelera frm4 = new Cartelera();
                        frm4.Show();
                        this.Hide();
                        credencialesValidas = true;
                        break;
                    }
                }

                if (!credencialesValidas)
                {
                    MessageBox.Show("CORREO O CONTRASEÑA INCORRECTA", "ERROR");
                }
            }

        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            Registro frm2 = new Registro();
            frm2.Show();
        }

        private void chk_mostrar_contra_CheckedChanged(object sender, EventArgs e)
        {
            txtb_contra.UseSystemPasswordChar = !chk_mostrar_contra.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_inicio_Click(object sender, EventArgs e)
        {

        }
    }

}

