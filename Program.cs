using System;

class Estudiante
{
    // Atributos del estudiante
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos; // Array para 3 números de teléfono

    // Método para registrar los datos del estudiante
    public void RegistrarDatos()
    {
        Console.Write("Ingrese ID: ");
        Id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nombres: ");
        Nombres = Console.ReadLine();

        Console.Write("Ingrese apellidos: ");
        Apellidos = Console.ReadLine();

        Console.Write("Ingrese dirección: ");
        Direccion = Console.ReadLine();

        Telefonos = new string[3];

        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.Write("Ingrese teléfono " + (i + 1) + ": ");
            Telefonos[i] = Console.ReadLine();
        }
    }

    // Método para mostrar los datos del estudiante
    public void MostrarDatos()
    {
        Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);

        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine("- " + Telefonos[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();

        estudiante.RegistrarDatos();
        estudiante.MostrarDatos();

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
