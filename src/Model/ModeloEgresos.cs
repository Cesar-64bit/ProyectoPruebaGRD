namespace src.Model {
    public class ModeloEgresos {
        // Atributos
        private string? NSS {get; set;}
        private int Cama {get; set;}
        private DateTime FechaIngreso {get; set;}
        private int Estado {get; set;}

        // Constructores
        public ModeloEgresos() {
            this.NSS = "default";
            this.Cama = 0;
            this.FechaIngreso = DateTime.Now;
            this.Estado = 1;
        }

        public ModeloEgresos(string? nss, int cama, DateTime fechaIngreso, int estado) {
            this.NSS = nss;
            this.Cama = cama;
            this.FechaIngreso = fechaIngreso;
            this.Estado = estado;
        }
    }
}