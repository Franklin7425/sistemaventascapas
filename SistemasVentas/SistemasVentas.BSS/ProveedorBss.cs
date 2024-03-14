using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ProveedorBss
    {
        ProveedorDAL dal = new ProveedorDAL();
        public DataTable ListarProveedoresBss()
        {
            return dal.ListarProveedoresDAL();
        }
    }
}
