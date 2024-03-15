using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.BSS
{
    public class UsuarioBss
    {
        UsuarioDAL dal = new UsuarioDAL();
        public DataTable ListarUsuariosBss()
        {
            return dal.ListarUsuariosDAL();
        }

        public void InsertarUsuariosBss(Usuario usuario)
        {
            dal.InsertarUsuarioDAL(usuario);
        }
    }
}
