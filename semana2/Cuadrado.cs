// Clase Cuadrado hereda de Figura
public class Cuadrado : Figura
{
    // Atributo que guarda la medida del lado del cuadrado
    public double Lado { get; set; }

    // Constructor que recibe el valor del lado
    public Cuadrado(double lado)
    {
        this.Lado = lado;
    }

    // Área del cuadrado (lado * lado)
    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    // Perímetro del cuadrado (4 * lado)
    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}