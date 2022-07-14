﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatosFactory
{
    public class ConexionDBMySQL : Conexion
    {
        public override IDBAdapter CreateConexion()
        {
            Console.WriteLine("Conexion con DBMySQL");
            return new MySQLDBAdapter();
        }
    }
}
