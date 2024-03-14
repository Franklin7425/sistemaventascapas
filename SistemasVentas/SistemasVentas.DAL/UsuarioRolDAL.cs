using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDAL
    {
        public DataTable ListarUsuariosRolDAL()
        {
            string consulta = "select * from UsuarioRol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
