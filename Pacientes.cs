public class Paciente {
    // Atributos
    private string? NSS;
    private string? apellidoPaterno;
    private string? apellidoMaterno;
    private string? enfermedad;
    private int medico;
    private string? genero;
    private int cama;
    private DateTime fechaIngreso;
    private DateTime fechaNacimiento;
    private int estado;

    // Constructores
    public Paciente() {
        this.NSS = "default";
        this.apellidoPaterno = "default";
        this.apellidoMaterno = "default";
        this.enfermedad = "defaul";
        this.medico = 0;
        this.genero = "default";
        this.cama = 0;
        this.fechaIngreso = DateTime.Now;
        this.fechaNacimiento = DateTime.Now;
        this.estado = 1;
    }

    public Paciente(string? nss, string? apellidoPaterno, string? apellidoMaterno,
                    string? enfermedad, int medico, string? genero, int cama,
                    DateTime fechaIngreso, DateTime fechaNacimiento, int estado) {
        this.NSS = nss;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.enfermedad = enfermedad;
        this.medico = medico;
        this.genero = genero;
        this.cama = cama;
        this.fechaIngreso = fechaIngreso;
        this.fechaNacimiento = fechaNacimiento;
        this.estado = estado;
    }

    // Encapsulación
    public string? Nss {
        get {return this.NSS;}
        set {this.NSS = value;}
    }

    public string? ApellidoPaterno {
        get {return this.apellidoPaterno;}
        set {this.apellidoPaterno = value;}
    }

     public string? ApellidoMaterno {
        get {return this.apellidoMaterno;}
        set {this.apellidoMaterno = value;}
    }

    public string? Enfermedad {
        get {return this.enfermedad;}
        set {this.enfermedad = value;}
    }

    public int Medico {
        get {return this.medico;}
        set {this.medico = value;}
    }

    public string? Genero {
        get {return this.genero;}
        set {this.genero = value;}
    }

    public int Cama {
        get {return this.cama;}
        set {this.cama = value;}
    }

    public DateTime FechaIngreso {
        get {return this.fechaIngreso;}
        set {this.fechaIngreso = value;}
    }

    public DateTime FechaNacimiento {
        get {return this.fechaNacimiento;}
        set {this.fechaNacimiento = value;}
    }

    public int Estado {
        get {return this.estado;}
        set {this.estado = value;}
    }
}