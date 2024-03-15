using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class ProveedorDAL
    {
        public DataTable ListarProveedoresDAL()
        {
            string consulta = "select * from proveedor";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProveedorDAL(Proveedor proveedor)
        {
            string consulta = "insert into proveedor values('" + proveedor.Nombre + "' ," +
                                                         "'" + proveedor.Telefono + "' ," +
                                                         "'" + proveedor.Direccion + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
