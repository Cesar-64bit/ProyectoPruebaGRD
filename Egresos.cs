public class Egresos {
    // Atributos
    private string? nss;
    private int cama;
    private DateTime fechaIngreso;
    private int estado;

    // Constructores
    public Egresos() {
        this.nss = "default";
        this.cama = 0;
        this.fechaIngreso = DateTime.Now;
        this.estado = 1;
    }

    public Egresos(string? nss, int cama, DateTime fechaIngreso, int estado) {
        this.nss = nss;
        this.cama = cama;
        this.fechaIngreso = fechaIngreso;
        this.estado = estado;
    }

    // Encapsulamiento
    public string? NSS {
        get {return this.nss;}
        set {this.nss = value;}
    }

    public int Cama {
        get {return this.cama;}
        set {this.cama = value;}
    }

    public DateTime FechaIngreso {
        get {return this.fechaIngreso;}
        set {this.fechaIngreso = value;}
    }

    public int Estado {
        get {return this.estado;}
        set {this.estado = value;}
    }
}