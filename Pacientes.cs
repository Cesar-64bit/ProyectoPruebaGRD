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
}