using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class UsuarioRolBss
    {
        UsuarioRolDAL dal = new UsuarioRolDAL();
        public DataTable ListarUsuariosRolBss()
        {
            return dal.ListarUsuariosRolDAL();
        }
    }
}
