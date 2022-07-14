using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatosFactory
{
    public abstract class Conexion
    {
        public abstract IDBAdapter CreateConexion();

        public void someOperacion()
        {
            Console.WriteLine("Haciendo algo en Conexion");
            IDBAdapter a = CreateConexion();
            a.getConnection();
        }
    }
}
