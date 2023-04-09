using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Modelo;

namespace WinFormsApp2.Dato
{
    public class Usuario
    {
        List<UsuarioModel> list = new List<UsuarioModel>();
        /// <summary>
        /// Guardar los asientos
        /// </summary>
        /// <param name="modelo">datos del asiento</param>
        public void Guardar(UsuarioModel modelo)
        {
            list.Add(modelo);
        }
/// <summary>
/// Consulta los asientos
/// </summary>
/// <returns>datos del asiento</returns>
        public List<UsuarioModel>Consultar()
        {
            return list;
        }
    }
}
