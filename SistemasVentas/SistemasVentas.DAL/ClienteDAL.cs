using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDAL
    {
        public DataTable ListarClientesDAL()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
