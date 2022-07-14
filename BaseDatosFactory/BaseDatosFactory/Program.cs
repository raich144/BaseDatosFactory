namespace BaseDatosFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConexionDBMySQL conexionDBMySQL = new ConexionDBMySQL();
            ConexionDBOracle conexionDBOracle = new ConexionDBOracle();
            ConexionDBSQLServer conexionDBSQLServer = new ConexionDBSQLServer();

            Console.WriteLine("Creando conexiones");
            List<IDBAdapter> listaAdaptadoresDB = new List<IDBAdapter>();
            listaAdaptadoresDB.Add(conexionDBMySQL.CreateConexion());
            listaAdaptadoresDB.Add(conexionDBOracle.CreateConexion());
            listaAdaptadoresDB.Add(conexionDBSQLServer.CreateConexion());

            foreach (IDBAdapter adaptador in listaAdaptadoresDB) 
            {
                adaptador.getConnection();
            }

            Console.WriteLine("\n***Crear lista Conexion***\n");
            List<Conexion> listaConexion = new List<Conexion>();

            listaConexion.Add(new ConexionDBMySQL());
            listaConexion.Add(new ConexionDBOracle());
            listaConexion.Add(new ConexionDBSQLServer());

            foreach ( Conexion conexion in listaConexion) 
            {
                conexion.someOperacion();
            }
        }
    }
}