using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class MarcaDAL
    {
        public DataTable ListarMarcasDAL()
        {
            string consulta = "select * from marca";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
