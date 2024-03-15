using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

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

        public void InsertarUsuarioRolDAL(UsuarioRol usuariorol)
        {
            string consulta = "insert into usuariorol values(" + usuariorol.IdUsuario + " ," +
                                                         "" + usuariorol.IdRol + " ," +
                                                         "'" + usuariorol.FechaAsigna.ToString("yyyy-MM-dd HH:mm:ss") + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
