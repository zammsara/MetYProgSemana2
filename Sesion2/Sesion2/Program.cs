using Sesion2.clases;

namespace Sesion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leer los datos de una persona y determinar si es mayor o menor de edad
            string nombre;
            DateTime fechaNac;
            Persona persona = new Persona();

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("En que fecha naciste? ");
            fechaNac = DateTime.Parse(Console.ReadLine());

            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;

            Console.WriteLine(persona.EvaluarEdad());
        }
    }
}
