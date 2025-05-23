public class MiembroDeLaComunidad
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
   
    public MiembroDeLaComunidad(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}

public class Empleado : MiembroDeLaComunidad
{
    public string Puesto { get; set; }
    public double Salario { get; set; }
    public Empleado(string nombre, int edad, string puesto, double salario) : base(nombre, edad)
    {
        Puesto = puesto;
        Salario = salario;
    }
    public void MostrarInformacionEmpleado()
    {
        MostrarInformacion();
        Console.WriteLine($"Puesto: {Puesto}, Salario: {Salario}");
    }
}

public class Estudiante : MiembroDeLaComunidad
{
    public string Carrera { get; set; }
    public double Promedio { get; set; }
    public Estudiante(string nombre, int edad, string carrera, double promedio) : base(nombre, edad)
    {
        Carrera = carrera;
        Promedio = promedio;
    }
    public void MostrarInformacionEstudiante()
    {
        MostrarInformacion();
        Console.WriteLine($"Carrera: {Carrera}, Promedio: {Promedio}");
    }
}

public class ExAlumno : Estudiante
{
    public int AnioDeGraduacion { get; set; }
    public ExAlumno(string nombre, int edad, string carrera, double promedio, int anioDeGraduacion) : base(nombre, edad, carrera, promedio)
    {
        AnioDeGraduacion = anioDeGraduacion;
    }
    public void MostrarInformacionExAlumno()
    {
        MostrarInformacionEstudiante();
        Console.WriteLine($"Año de Graduación: {AnioDeGraduacion}");
    }
}

public class Docente : Empleado
{
    public string Materia { get; set; }
    public int AniosDeExperiencia { get; set; }
    public Docente(string nombre, int edad, string puesto, double salario, string materia, int aniosDeExperiencia) : base(nombre, edad, puesto, salario)
    {
        Materia = materia;
        AniosDeExperiencia = aniosDeExperiencia;
    }
    public void MostrarInformacionDocente()
    {
        MostrarInformacionEmpleado();
        Console.WriteLine($"Materia: {Materia}, Años de Experiencia: {AniosDeExperiencia}");
    }
}

public class Administrativo : Empleado
{
    public string Departamento { get; set; }
    public int AniosDeServicio { get; set; }
    public Administrativo(string nombre, int edad, string puesto, double salario, string departamento, int aniosDeServicio) : base(nombre, edad, puesto, salario)
    {
        Departamento = departamento;
        AniosDeServicio = aniosDeServicio;
    }
    public void MostrarInformacionAdministrativo()
    {
        MostrarInformacionEmpleado();
        Console.WriteLine($"Departamento: {Departamento}, Años de Servicio: {AniosDeServicio}");
    }
}

public class Administrador : Docente
{
    public string AreaDeResponsabilidad { get; set; }
    public Administrador(string nombre, int edad, string puesto, double salario, string materia, int aniosDeExperiencia, string areaDeResponsabilidad) : base(nombre, edad, puesto, salario, materia, aniosDeExperiencia)
    {
        AreaDeResponsabilidad = areaDeResponsabilidad;
    }
    public void MostrarInformacionAdministrador()
    {
        MostrarInformacionDocente();
        Console.WriteLine($"Área de Responsabilidad: {AreaDeResponsabilidad}");
    }
}

public class Maestro : Docente
{
    public string Grado { get; set; }
    public Maestro(string nombre, int edad, string puesto, double salario, string materia, int aniosDeExperiencia, string grado) : base(nombre, edad, puesto, salario, materia, aniosDeExperiencia)
    {
        Grado = grado;
    }
    public void MostrarInformacionMaestro()
    {
        MostrarInformacionDocente();
        Console.WriteLine($"Grado: {Grado}");
    }
}
