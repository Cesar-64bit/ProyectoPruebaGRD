public class Egresos {
    // Atributos
    private string? NSS {get; set;}
    private int Cama {get; set;}
    private DateTime FechaIngreso {get; set;}
    private int Estado {get; set;}

    // Constructores
    public Egresos() {
        this.NSS = "default";
        this.Cama = 0;
        this.FechaIngreso = DateTime.Now;
        this.Estado = 1;
    }

    public Egresos(string? nss, int cama, DateTime fechaIngreso, int estado) {
        this.NSS = nss;
        this.Cama = cama;
        this.FechaIngreso = fechaIngreso;
        this.Estado = estado;
    }
}