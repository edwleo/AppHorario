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
    public class Semestre
    {
        DBAccess conexion = new DBAccess();

        public DataTable getAll()
        {
            DataTable dt = new DataTable();

            conexion.abrirConexion();
            MySqlCommand comando = new MySqlCommand("spu_semestres_listar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            dt.Load(comando.ExecuteReader());
            conexion.cerrarConexion();

            return dt;
        }
    }
}
