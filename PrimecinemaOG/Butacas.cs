using System.Data;
using WinFormsApp2.Dato;
using WinFormsApp2.Modelo;

namespace WinFormsApp2
{
    public partial class Asiento : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();
        public Asiento()
        {
            InitializeComponent();
            Iniciar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Asiento_Load(object sender, EventArgs e)
        {

        }

        private void btnReguistrar_Click(object sender, EventArgs e)
        {
            Reguistrar();
            Iniciar();
            Cancelar();
            Consultar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Columna");
            tabla.Columns.Add("Fila");
            grilla.DataSource = tabla;
        }
        private void Reguistrar()
        {
            UsuarioModel modelo = new UsuarioModel()
            {
                fila = textfila.Text,
                columna = int.Parse(textcolumna.Text)
            };
            dato.Guardar(modelo);

        }
        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Fila"] = item.fila;
                fila["Columna"] = item.columna;
                tabla.Rows.Add(fila);
            }
        }
        private void Cancelar()
        {
            textfila.Text = "";
            textcolumna.Text = "";
        }
    }
}