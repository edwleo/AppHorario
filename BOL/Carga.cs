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
    public class Carga
    {
        DBAccess conexion = new DBAccess();

        public DataTable showInstructor(int idsemestre)
        {
            return conexion.searchData("spu_cargas_listar_semestre", "_idsemestre", idsemestre);
        }

        public void add(int idsemestre, string jsonClaves)
        {
            conexion.abrirConexion();
            MySqlCommand comando = new MySqlCommand("spu_cargas_registrar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("_idsemestre", idsemestre);
            comando.Parameters.AddWithValue("_claves", jsonClaves);
            comando.ExecuteNonQuery();

            conexion.cerrarConexion();
        }        

        public void delete(int idcarga)
        {
            conexion.delete("spu_cargas_eliminar", "_idcarga", idcarga);
        }
    }
}
