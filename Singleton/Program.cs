using System.Data;
using System.Data.SqlClient;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseConnection.Instance.ExecuteCommand("INSERT INTO Platos (ID, Nombre, Descripcion, Valor)" +
                "VALUES" +
                "(1, 'Bandeja Paisa', 'Plato típico colombiano con carne molida, chorizo, chicharrón, arepa, huevo frito, aguacate y frijoles.', 25000)," +
                "(2, 'Ajiaco Santafereño', 'Sopa colombiana con pollo, papa criolla, mazorca, alcaparras y aguacate.', 20000)," +
                "(3, 'Lechona Tolimense', 'Plato típico del Tolima con carne de cerdo, arroz, garbanzos, arveja y plátano maduro.', 22000)," +
                "(4, 'Mojarra frita', 'Pescado frito con arroz con coco, ensalada y patacones.', 18000)," +
                "(5, 'Empanadas', 'Empanadas de carne, pollo o queso con ají.', 12000)," +
                "(6, 'Arepas', 'Arepas de maíz blanco o amarillo con queso, mantequilla o carne.', 8000)," +
                "(7, 'Posta negra', 'Carne de res a la parrilla con papas a la francesa y ensalada.', 28000)," +
                "(8, 'Cazuela de mariscos', 'Cazuela con camarones, langosta, calamares y mejillones en salsa de tomate.', 30000)," +
                "(9, 'Lomo de cerdo al horno', 'Lomo de cerdo al horno con salsa de ciruelas y puré de papa.', 25000)," +
                "(10, 'Ensalada de frutas', 'Ensalada de frutas tropicales con yogur y granola.', 10000);");

        }
    }

    public sealed class DatabaseConnection
    {
        private readonly string _connectionString;

        private static readonly Lazy<DatabaseConnection> _instance = 
            new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        //constructor privado para que no s epueda instanciar directamente
        private DatabaseConnection()
        {
            _connectionString = "Server=MELISSA;Database=RestaurantDB;Trusted_Connection=True;";
        }

        //propiedad publica para acceder a la unica instancia de de la clase
        public static DatabaseConnection Instance
        {
            get { return _instance.Value; }
        }

        //metodo para conectarse a la BD
        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public void ExecuteCommand (string commandText) 
        {
            using (IDbConnection connection = GetConnection())
            {
                connection.Open();
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = commandText;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
