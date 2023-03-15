using src.Model;

namespace GRDSystem {
    class Program {
        static void Main(string[] args) {
            ModeloConexion conexion = new ModeloConexion();

            if(conexion.establecerConexion() == true) {
                Console.WriteLine("Conexion establecida con exito");
            }
            else {
                Console.WriteLine("Fallo");
            }
        }
    }
}