using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDAL
    {
        public DataTable ListarProductosDAL()
        {
            string consulta = "select * from producto";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
