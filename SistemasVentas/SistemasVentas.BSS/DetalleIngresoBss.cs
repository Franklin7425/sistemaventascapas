using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class DetalleIngresoBss
    {
        DetalleIngresoDAL dal = new DetalleIngresoDAL();
        public DataTable ListarDetallesIngresoBss()
        {
            return dal.ListarDetallesIngresoDAL();
        }
    }
}
