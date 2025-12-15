Console.WriteLine("ESTRUCTURA DE DATOS - UEA");
Console.WriteLine();

// Crear un círculo con radio 4
Circulo circulo = new Circulo(4);

// Crear un cuadrado con lado 6
Cuadrado cuadrado = new Cuadrado(6);

// ===== TABLA CÍRCULO =====

Console.WriteLine("Círculo          | Valor");
Console.WriteLine("-----------------|-----------");
Console.WriteLine("Radio            | " + circulo.Radio);
Console.WriteLine("Área             | " + circulo.CalcularArea());
Console.WriteLine("Perímetro        | " + circulo.CalcularPerimetro());
Console.WriteLine();

// ===== TABLA CUADRADO =====

Console.WriteLine("Cuadrado         | Valor");
Console.WriteLine("-----------------|-----------");
Console.WriteLine("Lado             | " + cuadrado.Lado);
Console.WriteLine("Área             | " + cuadrado.CalcularArea());
Console.WriteLine("Perímetro        | " + cuadrado.CalcularPerimetro());

Console.WriteLine();