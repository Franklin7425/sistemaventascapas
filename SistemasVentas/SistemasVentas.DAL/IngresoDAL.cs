using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class IngresoDAL
    {
        public DataTable ListarIngresosDAL()
        {
            string consulta = "select * from ingreso";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarIngresoDAL(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values(" + ingreso.IdProveedor + " ," +
                                                         "'" + ingreso.FechaIngreso.ToString("yyyy-MM-dd HH:mm:ss") +
                                                         "" + ingreso.Total + " ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
