using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatosFactory
{
    public class OracleDBAdapter : IDBAdapter
    {
        public void getConnection()
        {
            Console.WriteLine("Haciendo algo DBOracle");
        }
    }
}
