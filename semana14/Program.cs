using System;

class Nodo
{
    public int Valor;
    public Nodo Izquierdo, Derecho;

    public Nodo(int valor)
    {
        Valor = valor;
        Izquierdo = Derecho = null;
    }
}

class ArbolBST
{
    public Nodo Raiz;

    // INSERTAR
    public Nodo Insertar(Nodo raiz, int valor)
    {
        if (raiz == null) return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = Insertar(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = Insertar(raiz.Derecho, valor);

        return raiz;
    }

    // BUSCAR
    public bool Buscar(Nodo raiz, int valor)
    {
        if (raiz == null) return false;
        if (valor == raiz.Valor) return true;

        return valor < raiz.Valor
            ? Buscar(raiz.Izquierdo, valor)
            : Buscar(raiz.Derecho, valor);
    }

    // ELIMINAR
    public Nodo Eliminar(Nodo raiz, int valor)
    {
        if (raiz == null) return raiz;

        if (valor < raiz.Valor)
            raiz.Izquierdo = Eliminar(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = Eliminar(raiz.Derecho, valor);
        else
        {
            if (raiz.Izquierdo == null) return raiz.Derecho;
            if (raiz.Derecho == null) return raiz.Izquierdo;

            Nodo sucesor = MinimoNodo(raiz.Derecho);
            raiz.Valor = sucesor.Valor;
            raiz.Derecho = Eliminar(raiz.Derecho, sucesor.Valor);
        }

        return raiz;
    }

    // RECORRIDOS
    public void InOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            InOrden(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            InOrden(raiz.Derecho);
        }
    }

    public void PreOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            PreOrden(raiz.Izquierdo);
            PreOrden(raiz.Derecho);
        }
    }

    public void PostOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            PostOrden(raiz.Izquierdo);
            PostOrden(raiz.Derecho);
            Console.Write(raiz.Valor + " ");
        }
    }

    // MINIMO Y MAXIMO
    public Nodo MinimoNodo(Nodo nodo)
    {
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;
        return nodo;
    }

    public int Minimo()
    {
        return Raiz == null ? -1 : MinimoNodo(Raiz).Valor;
    }

    public int Maximo()
    {
        Nodo actual = Raiz;
        while (actual != null && actual.Derecho != null)
            actual = actual.Derecho;
        return actual == null ? -1 : actual.Valor;
    }

    // ALTURA
    public int Altura(Nodo nodo)
    {
        if (nodo == null) return -1;
        return Math.Max(Altura(nodo.Izquierdo), Altura(nodo.Derecho)) + 1;
    }

    // LIMPIAR
    public void Limpiar()
    {
        Raiz = null;
    }
}

class Program
{
    static void Main()
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENU BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Inorden");
            Console.WriteLine("5. Preorden");
            Console.WriteLine("6. Postorden");
            Console.WriteLine("7. Minimo");
            Console.WriteLine("8. Maximo");
            Console.WriteLine("9. Altura");
            Console.WriteLine("10. Limpiar");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Insertar(arbol.Raiz, valor);
                    break;

                case 2:
                    Console.Write("Valor: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(arbol.Raiz, valor) ? "Existe" : "No existe");
                    break;

                case 3:
                    Console.Write("Valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Eliminar(arbol.Raiz, valor);
                    break;

                case 4:
                    arbol.InOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    arbol.PreOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 6:
                    arbol.PostOrden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine("Minimo: " + arbol.Minimo());
                    break;

                case 8:
                    Console.WriteLine("Maximo: " + arbol.Maximo());
                    break;

                case 9:
                    Console.WriteLine("Altura: " + arbol.Altura(arbol.Raiz));
                    break;

                case 10:
                    arbol.Limpiar();
                    Console.WriteLine("Arbol limpiado");
                    break;
            }

        } while (opcion != 0);
    }
}
