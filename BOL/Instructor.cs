using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using DAL;
using System.Data;
using MySql.Data.MySqlClient;

namespace BOL
{
    public class Instructor
    {
        DBAccess acceso = new DBAccess();

        public DataTable getAll()
        {
            DataTable dt = new DataTable();

            acceso.abrirConexion();
            MySqlCommand comando = new MySqlCommand("spu_instructores_listar", acceso.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            dt.Load(comando.ExecuteReader());
            acceso.cerrarConexion();

            return dt;
        }
    }
}
