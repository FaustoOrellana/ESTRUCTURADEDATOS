using System;
using System.Collections.Generic;
using System.Text;

class TraductorBasico
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"time", "tiempo"},
        {"person", "persona"},
        {"year", "año"},
        {"way", "camino"},
        {"day", "día"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"hand", "mano"},
        {"eye", "ojo"},
        {"woman", "mujer"},
        {"work", "trabajo"},
        {"place", "lugar"},
        {"week", "semana"}
    };

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;

                case 2:
                    AgregarPalabra();
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese una frase: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ');
        StringBuilder traduccion = new StringBuilder();

        foreach (string palabra in palabras)
        {
            string limpia = LimpiarPalabra(palabra.ToLower());
            string signos = ObtenerSignos(palabra);

            if (diccionario.ContainsKey(limpia))
            {
                traduccion.Append(diccionario[limpia] + signos + " ");
            }
            else
            {
                traduccion.Append(palabra + " ");
            }
        }

        Console.WriteLine("\nTraducción:");
        Console.WriteLine(traduccion.ToString());
    }

    static void AgregarPalabra()
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        Console.Write("Ingrese la traducción en español: ");
        string español = Console.ReadLine().ToLower();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, español);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }

    static string LimpiarPalabra(string palabra)
    {
        return palabra.Trim('.', ',', ';', ':', '!', '?');
    }

    static string ObtenerSignos(string palabra)
    {
        string signos = "";
        foreach (char c in palabra)
        {
            if (!char.IsLetter(c))
            {
                signos += c;
            }
        }
        return signos;
    }
}
