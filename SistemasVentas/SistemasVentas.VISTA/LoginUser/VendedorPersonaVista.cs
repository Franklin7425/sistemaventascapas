using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.LoginUser
{
    public partial class VendedorPersonaVista : Form
    {
        public VendedorPersonaVista()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!button5.Visible)
                button5.Visible = true;
            else
                button5.Visible = false;
        }
    }
}
