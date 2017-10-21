using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace clase77
{
    public class conexion
    {
        public SqlConnection cadena = new SqlConnection("Data Source=.;Initial Catalog=neptuno;Integrated Security=True");
        public void conectar() {
            cadena.Open();
        }
        public void cerrar() {
            cadena.Close();
        }
    }
}