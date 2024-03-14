using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class TipoProductoBss
    {
        TipoProductoDAL dal = new TipoProductoDAL();
        public DataTable ListarTiposProductoBss()
        {
            return dal.ListarTiposProductoDAL();
        }
    }
}
