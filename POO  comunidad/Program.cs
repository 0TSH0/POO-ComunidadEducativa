using System;

namespace ComunidadEducativa 
{
    // Clase base de la comunidad 
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }

        public MiembroDeLaComunidad(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
        }
    }

    // Derivadas de miembro de la comunidad 
    public class Empleado : MiembroDeLaComunidad
    {
        public double Salario { get; set; }

        public Empleado(string nombre, double salario) : base(nombre)
        {
            Salario = salario;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Salario: {Salario}");
        }
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public string Matricula { get; set; }

        public Estudiante(string nombre, string matricula) : base(nombre)
        {
            Matricula = matricula;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Matrícula: {Matricula}");
        }
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AnioGraduacion { get; set; }

        public ExAlumno(string nombre, int anioGraduacion) : base(nombre)
        {
            AnioGraduacion = anioGraduacion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Año de Graduación: {AnioGraduacion}");
        }
    }

    // Derivadas de Empleado
    public class Docente : Empleado
    {
        public string Departamento { get; set; }

        public Docente(string nombre, double salario, string departamento) : base(nombre, salario)
        {
            Departamento = departamento;}

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }

    public class Administrativo : Empleado
    {
        public string Puesto { get; set; }

        public Administrativo(string nombre, double salario, string puesto) : base(nombre, salario)
        {
            Puesto = puesto;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Puesto: {Puesto}");}
    }
    // Deribadas de la clase de docente
    public class Administrador : Docente
    {
        public string AreaResponsabilidad { get; set; }

        public Administrador(string nombre, double salario, string departamento, string areaResponsabilidad)
            : base(nombre, salario, departamento)
        {
            AreaResponsabilidad = areaResponsabilidad;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área de Responsabilidad: {AreaResponsabilidad}");
       
        
        }
    }

    public class Maestro : Docente
    {
        public string Asignatura { get; set; }

        public Maestro(string nombre, double salario, string departamento, string asignatura)
            : base(nombre, salario, departamento)
        {
            Asignatura = asignatura;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Asignatura: {Asignatura}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empleado -------------------------------------------");
            Empleado empleado = new Empleado("Juan Perez", 50000);
            empleado.MostrarInformacion();
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Estudiante -------------------------------------------");
            Estudiante estudiante = new Estudiante("Ana Garcia", "2022001");
            estudiante.MostrarInformacion();
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Docente -------------------------------------------");
            Docente docente = new Docente("Carlos López", 60000, "Matemáticas");
            docente.MostrarInformacion();
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Administrador -------------------------------------------");
            Administrador administrador = new Administrador("Laura Gómez", 70000, "Ciencias", "Coordinar laboratorio");
            administrador.MostrarInformacion();
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Maestro -------------------------------------------");
            Maestro maestro = new Maestro("Marta Sánchez", 55000, "Lenguas", "Inglés");
            maestro.MostrarInformacion();
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
