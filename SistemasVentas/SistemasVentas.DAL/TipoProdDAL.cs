using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class TipoProdDAL
    {
        public DataTable ListarTiposProdDAL()
        {
            string consulta = "select * from tipoprod";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarTipoProdDAL(TipoProd tipoprod)
        {
            string consulta = "insert into tipoprod values('" + tipoprod.Nombre + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
