using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ===== EJERCICIO 1 =====
        Console.WriteLine("VERIFICACION DE PARENTESIS BALANCEADOS");
        Console.Write("Ingrese una expresion: ");
        string expresion = Console.ReadLine();

        if (Balanceado(expresion))
            Console.WriteLine("Formula balanceada");
        else
            Console.WriteLine("Formula NO balanceada");

        Console.WriteLine("\n------------------------------\n");

        // ===== EJERCICIO 2 =====
        Console.WriteLine("TORRES DE HANOI");
        Console.Write("Ingrese numero de discos: ");
        int n = int.Parse(Console.ReadLine());

        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Se colocan los discos en la torre origen
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        MoverDiscos(n, origen, auxiliar, destino);
    }

    // ===== EJERCICIO 1 =====
    static bool Balanceado(string texto)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in texto)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                    return false;

                char x = pila.Pop();

                if ((c == ')' && x != '(') ||
                    (c == '}' && x != '{') ||
                    (c == ']' && x != '['))
                {
                    return false;
                }
            }
        }

        return pila.Count == 0;
    }

    // ===== EJERCICIO 2 =====
    static void MoverDiscos(int n, Stack<int> origen, Stack<int> aux, Stack<int> dest)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            dest.Push(disco);
            Console.WriteLine("Mover disco " + disco);
            return;
        }

        MoverDiscos(n - 1, origen, dest, aux);

        int d = origen.Pop();
        dest.Push(d);
        Console.WriteLine("Mover disco " + d);

        MoverDiscos(n - 1, aux, origen, dest);
    }
}

