// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Reflection;
using Tarea3Vehiculo;
class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Automovil y solicitar los datos al usuario
        Automovil automovil = new Automovil();
        Console.WriteLine("Ingrese los datos del automóvil:");
        Console.Write("Marca: ");
        automovil.Marca = Console.ReadLine();
        Console.Write("Modelo: ");
        automovil.Modelo = Console.ReadLine();
        Console.Write("Año: ");
        automovil.Anio = int.Parse(Console.ReadLine());
        Console.Write("Cantidad de puertas: ");
        automovil.Puertas = int.Parse(Console.ReadLine());

        // Crear una instancia de Camioneta y solicitar los datos al usuario
        Camioneta camioneta = new Camioneta();
        Console.WriteLine("\nIngrese los datos de la camioneta:");
        Console.Write("Marca: ");
        camioneta.Marca = Console.ReadLine();
        Console.Write("Modelo: ");
        camioneta.Modelo = Console.ReadLine();
        Console.Write("Año: ");
        camioneta.Anio = int.Parse(Console.ReadLine());
        Console.Write("Capacidad de carga (en kg): ");
        camioneta.CapacidadCarga = double.Parse(Console.ReadLine());

        // Obtener y mostrar la información de los vehículos
        Console.WriteLine("\nInformación del Automóvil:");
        Console.WriteLine(automovil.GetInformation());

        Console.WriteLine("\nInformación de la Camioneta:");
        Console.WriteLine(camioneta.GetInformation());


        // Realizar acciones específicas de cada tipo de vehículo
        Console.WriteLine("\nAcciones del Automóvil:");
        Console.WriteLine(automovil.RunAction()); // Acción específica del automóvil

        Console.WriteLine("\nAcciones de la Camioneta:");
        Console.WriteLine(camioneta.RunAction()); // Acción específica de la camioneta
        Console.ReadLine();
    }
}



