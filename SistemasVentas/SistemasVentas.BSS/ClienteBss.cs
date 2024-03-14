using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ClienteBss
    {
        ClienteDAL dal = new ClienteDAL();
        public DataTable ListarClientesBss()
        {
            return dal.ListarClientesDAL();
        }
    }
}
