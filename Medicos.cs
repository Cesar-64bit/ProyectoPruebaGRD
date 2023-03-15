public class Medicos {
    // Atributos
    private int ID {get; set;}
    private string? Nombre {get; set;}
    private string? ApellidoPaterno {get; set;}
    private string? ApellidoMaterno {get; set;}
    private int Edad {get; set;}
    private string? Especialidad {get; set;}
    private int Estado {get; set;}

    // Constructores
    public Medicos() {
        this.ID = 0;
        this.Nombre = "default";
        this.ApellidoPaterno = "default";
        this.ApellidoMaterno = "default";
        this.Edad = 0;
        this.Especialidad = "default";
        this.Estado = 1;
    }

    public Medicos(int id, string? nombre, string? apellidoPaterno, string? apellidoMaterno,
                    int edad, string? especialidad, int estado) {
        this.ID = id;
        this.Nombre = nombre;
        this.ApellidoPaterno = apellidoPaterno;
        this.ApellidoMaterno = apellidoMaterno;
        this.Edad = edad;
        this.Especialidad = especialidad;
        this.Estado = estado;
    }
}