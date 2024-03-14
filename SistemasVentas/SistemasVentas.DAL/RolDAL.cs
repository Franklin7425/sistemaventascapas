using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class RolDAL
    {
        public DataTable ListarRolesDAL()
        {
            string consulta = "select * from rol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
