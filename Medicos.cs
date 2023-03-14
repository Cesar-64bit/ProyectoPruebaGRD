public class Medicos {
    // Atributos
    private int id;
    private string? nombre;
    private string? apellidoPaterno;
    private string? apellidoMaterno;
    private int edad;
    private string? especialidad;
    private int estado;

    // Constructores
    public Medicos() {
        this.id = 0;
        this.nombre = "default";
        this.apellidoPaterno = "default";
        this.apellidoMaterno = "default";
        this.edad = 0;
        this.especialidad = "default";
        this.estado = 1;
    }

    public Medicos(int id, string? nombre, string? apellidoPaterno, string? apellidoMaterno,
                    int edad, string? especialidad, int estado) {
        this.id = id;
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.edad = edad;
        this.especialidad = especialidad;
        this.estado = estado;
    }

    // Encapsulamiento
    public int ID {
        get {return this.id;}
        set {this.id = value;}
    }

    public string? Nombre {
        get {return this.nombre;}
        set {this.nombre = value;}
    }

    public string? ApellidoPaterno {
        get {return this.apellidoPaterno;}
        set {this.apellidoPaterno = value;}
    }

    public string? ApellidoMaterno {
        get {return this.apellidoMaterno;}
        set {this.apellidoMaterno = value;}
    }

    public int Edad {
        get {return this.edad;}
        set {this.edad = value;}
    }

    public string? Especialidad {
        get {return this.especialidad;}
        set {this.especialidad = value;}
    }

    public int Estado {
        get {return this.estado;}
        set {this.estado = value;}
    }
}