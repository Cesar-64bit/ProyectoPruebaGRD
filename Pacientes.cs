public class Paciente {
    // Atributos
    private string? NSS {get; set;} 
    private string? ApellidoPaterno {get; set;}
    private string? ApellidoMaterno {get; set;}
    private string? Enfermedad {get; set;}
    private int Medico {get; set;}
    private string? Genero {get; set;}
    private int Cama {get; set;}
    private DateTime FechaIngreso {get; set;}
    private DateTime FechaNacimiento {get; set;}
    private int Estado {get; set;}

    // Constructores
    public Paciente() {
        this.NSS = "default";
        this.ApellidoPaterno = "default";
        this.ApellidoMaterno = "default";
        this.Enfermedad = "defaul";
        this.Medico = 0;
        this.Genero = "default";
        this.Cama = 0;
        this.FechaIngreso = DateTime.Now;
        this.FechaNacimiento = DateTime.Now;
        this.Estado = 1;
    }

    public Paciente(string? nss, string? apellidoPaterno, string? apellidoMaterno,
                    string? enfermedad, int medico, string? genero, int cama,
                    DateTime fechaIngreso, DateTime fechaNacimiento, int estado) {
        this.NSS = nss;
        this.ApellidoPaterno = apellidoPaterno;
        this.ApellidoMaterno = apellidoMaterno;
        this.Enfermedad = enfermedad;
        this.Medico = medico;
        this.Genero = genero;
        this.Cama = cama;
        this.FechaIngreso = fechaIngreso;
        this.FechaNacimiento = fechaNacimiento;
        this.Estado = estado;
    }
}