using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatosFactory
{
    public class ConexionDBSQLServer : Conexion
    {
        public override IDBAdapter CreateConexion()
        {
            Console.WriteLine("Conexion con DBSQLServer");
            return new SQLServerDBAdapter();
        }
    }
}
