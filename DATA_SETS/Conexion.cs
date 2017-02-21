using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_SETS
{
    class Conexion
    {
        SqlConnection conn;

        public SqlConnection Conn
        {
            get{return conn;}
            set{ conn = value;}
        }

        public Conexion()
        {

        }
    }
}
