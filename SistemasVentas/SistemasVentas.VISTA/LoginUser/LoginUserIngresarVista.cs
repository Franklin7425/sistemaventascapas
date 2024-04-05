using SistemasVentas.DAL;
using SistemasVentas.VISTA.ClienteVistas;
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
    public partial class LoginUserIngresarVista : Form
    {
        public LoginUserIngresarVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            Conexion conexion = new Conexion();

            string cargo = conexion.AutenticarUsuario(usuario, contraseña);

            if (cargo != null)
            {
                string nombreUsuario = ObtenerNombreUsuario(usuario);

                string mensajeBienvenida = $"¡Bienvenido";

                mensajeBienvenida += $" {nombreUsuario}.";

                MessageBox.Show(mensajeBienvenida);
                if (cargo == "Gerente" || cargo == "Supervisor")
                {
                    WelcomeIngresarVista gerenteForm = new WelcomeIngresarVista();
                    gerenteForm.Show();
                }
                else if (cargo == "Cajero" || cargo == "Vendedor")
                {
                    VendeClienteListarVista cajeroForm = new VendeClienteListarVista();
                    cajeroForm.Show();
                }

                else if (cargo == "Guia" || cargo == "Cliente")
                {
                    CompraProductoVista guiaForm = new CompraProductoVista();
                    guiaForm.Show();
                }
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private string ObtenerNombreUsuario(string nombreUsuario)
        {
            Conexion conexion = new Conexion();
            return nombreUsuario;
        }
    }
}
