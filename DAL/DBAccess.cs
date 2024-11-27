using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBAccess
    {
        private MySqlConnection conexion = new MySqlConnection("server=localhost;uid=root;pwd=;database=apphorarios;SslMode=none");

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

        public DataTable getAllData(string storeProcedure)
        {
            DataTable dt = new DataTable();

            this.abrirConexion();
            MySqlCommand comando = new MySqlCommand(storeProcedure, this.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            dt.Load(comando.ExecuteReader());
            this.cerrarConexion();

            return dt;
        }

        public DataTable searchData(string storeProcedure, string key, object value)
        {
            DataTable dt = new DataTable();

            this.abrirConexion();
            MySqlCommand comando = new MySqlCommand(storeProcedure, this.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue(key, value);
            dt.Load(comando.ExecuteReader());
            this.cerrarConexion();

            return dt;
        }

        public void delete(string storeProcedure, string key, object value)
        {
            this.abrirConexion();
            MySqlCommand comando = new MySqlCommand(storeProcedure, this.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue(key, value);
            comando.ExecuteNonQuery();
            this.cerrarConexion();
        }
    }
}
