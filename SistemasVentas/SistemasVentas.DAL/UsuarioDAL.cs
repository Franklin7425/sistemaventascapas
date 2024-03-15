using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class UsuarioDAL
    {
        public DataTable ListarUsuariosDAL()
        {
            string consulta = "select * from usuario";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarUsuarioDAL(Usuario usuario)
        {
            string consulta = "insert into usuario values(" + usuario.IdPersona + " ," +
                                                         "'" + usuario.NombreUser + "'," +
                                                         "'" + usuario.Contraseña + "'," +
                                                         "'" + usuario.FechaReg.ToString("yyyy-MM-dd HH:mm:ss") + "' )";
            
            conexion.Ejecutar(consulta);
        }
    }
}
