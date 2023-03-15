using MySql.Data.MySqlClient;

namespace src.Model {
    public class ModeloConexion {
        private readonly string? connectionString = "server=127.0.0.1;database=hospital;user=root;password=";
        public Boolean establecerConexion() {
            try {
                using(MySqlConnection connection = new MySqlConnection(connectionString)) {
                    connection.Open();
                    return true;
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}