﻿using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.BSS
{
    public class TipoProdBss
    {
        TipoProdDAL dal = new TipoProdDAL();
        public DataTable ListarTiposProdBss()
        {
            return dal.ListarTiposProdDAL();
        }

        public void InsertarTiposProdBss(TipoProd tipoprod)
        {
            dal.InsertarTipoProdDAL(tipoprod);
        }
    }
}
