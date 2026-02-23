using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Conjunto universal de 500 ciudadanos
        HashSet<string> ciudadanos = GenerarCiudadanos(500);

        // Conjuntos vacunados
        HashSet<string> pfizer = GenerarVacunados(ciudadanos, 75, 1);
        HashSet<string> astrazeneca = GenerarVacunados(ciudadanos, 75, 2);

        // Operaciones de conjuntos
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astrazeneca);

        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca);

        HashSet<string> soloAstraZeneca = new HashSet<string>(astrazeneca);
        soloAstraZeneca.ExceptWith(pfizer);

        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astrazeneca);

        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados);

        // Mostrar resultados
        Mostrar("Ciudadanos NO vacunados", noVacunados);
        Mostrar("Ciudadanos con AMBAS dosis", ambasDosis);
        Mostrar("Ciudadanos SOLO Pfizer", soloPfizer);
        Mostrar("Ciudadanos SOLO AstraZeneca", soloAstraZeneca);
    }

    static HashSet<string> GenerarCiudadanos(int cantidad)
    {
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= cantidad; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }
        return ciudadanos;
    }

    static HashSet<string> GenerarVacunados(HashSet<string> ciudadanos, int cantidad, int semilla)
    {
        Random random = new Random(semilla);
        return ciudadanos.OrderBy(x => random.Next()).Take(cantidad).ToHashSet();
    }

    static void Mostrar(string titulo, HashSet<string> conjunto)
    {
        Console.WriteLine($"\n{titulo} ({conjunto.Count}):");
        foreach (var ciudadano in conjunto)
        {
            Console.WriteLine(ciudadano);
        }
    }
}
