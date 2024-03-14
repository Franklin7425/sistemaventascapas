using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProductoDAL
    {
        public DataTable ListarTiposProductoDAL()
        {
            string consulta = "select * from tipoproducto";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
