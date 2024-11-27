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
            return conexion.getAllData("spu_semestres_listar");
        }
    }
}
