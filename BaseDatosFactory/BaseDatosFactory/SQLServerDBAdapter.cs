using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatosFactory
{
    public class SQLServerDBAdapter : IDBAdapter
    {
        public void getConnection()
        {
            Console.WriteLine("Haciendo algo DBSQLServer");
        }
    }
}
