// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

while (true)
{
    Console.WriteLine("\n--- MENÚ DE EJERCICIOS ---");
    Console.WriteLine("1. Mostrar asignaturas");
    Console.WriteLine("2. Yo estudio asignaturas");
    Console.WriteLine("3. Notas por asignatura");
    Console.WriteLine("4. Lotería ordenada");
    Console.WriteLine("5. Números del 1 al 10 en orden inverso");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Ejercicio1();
            break;
        case 2:
            Ejercicio2();
            break;
        case 3:
            Ejercicio3();
            break;
        case 4:
            Ejercicio4();
            break;
        case 5:
            Ejercicio5();
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Opción inválida");
            break;
    }
}

static void Ejercicio1()
{
    List<string> subjects = new()
    { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

    Console.WriteLine("\nAsignaturas:");
    foreach (var subject in subjects)
        Console.WriteLine(subject);
}

static void Ejercicio2()
{
    List<string> subjects = new()
    { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

    Console.WriteLine();
    foreach (var subject in subjects)
        Console.WriteLine("Yo estudio " + subject);
}

static void Ejercicio3()
{
    List<string> subjects = new()
    { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

    List<double> scores = new();

    foreach (var subject in subjects)
    {
        Console.Write("¿Qué nota sacaste en " + subject + "? ");
        scores.Add(double.Parse(Console.ReadLine()));
    }

    Console.WriteLine();
    for (int i = 0; i < subjects.Count; i++)
        Console.WriteLine($"En {subjects[i]} has sacado {scores[i]}");
}

static void Ejercicio4()
{
    List<int> awarded = new();

    for (int i = 0; i < 6; i++)
    {
        Console.Write("Introduce un número ganador: ");
        awarded.Add(int.Parse(Console.ReadLine()));
    }

    awarded.Sort();

    Console.WriteLine("Números ganadores ordenados:");
    Console.WriteLine(string.Join(", ", awarded));
}

static void Ejercicio5()
{
    List<int> numbers = new()
    { 1,2,3,4,5,6,7,8,9,10 };

    numbers.Reverse();
    Console.WriteLine(string.Join(", ", numbers));
}

