using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class PersonaDAL
    {
        public DataTable ListarPersonasDAL()
        {
            string consulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        
        public void InsertarPersonaDAL(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "' ," +
                                                         "'" + persona.Apellido + "' ," +
                                                         "'" + persona.Telefono + "' ," +
                                                         "'" + persona.CI + "' ," +
                                                         "'" + persona.Correo + "' ," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
