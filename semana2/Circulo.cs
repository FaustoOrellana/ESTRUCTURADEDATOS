// Clase Circulo hereda de Figura
public class Circulo : Figura
{
    // Atributo que guarda el radio del círculo
    public double Radio { get; set; }

    // Constructor que recibe el valor del radio
    public Circulo(double radio)
    {
        this.Radio = radio;
    }

    // Calcula el área del círculo (π * radio²)
    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    // Calcula el perímetro del círculo (2πr)
    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}
