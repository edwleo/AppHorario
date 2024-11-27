using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBAccess
    {
        private MySqlConnection conexion = new MySqlConnection("data source=localhost;user id=root;password=;database=apphorarios");

        public MySqlConnection getConexion() { return this.conexion; }

        public void abrirConexion()
        {
            if (this.conexion.State == System.Data.ConnectionState.Closed)
            {
                this.conexion.Open();
            }
        }

        public void cerrarConexion()
        {
            if (this.conexion.State == System.Data.ConnectionState.Open)
            {
                this.conexion.Close();
            }
        }
    }
}
