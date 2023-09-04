using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.WriteLine("Digite o valor de A, B e C");
var a = double.Parse(Console.ReadLine()!, locale);
var b = double.Parse(Console.ReadLine()!, locale);
var c = double.Parse(Console.ReadLine()!, locale);

var delta = Math.Pow(b, 2.0) - (4 * a * c);

var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
var x2 = (-b - Math.Sqrt(delta)) / (2 * a);

if (a == 0 || delta < 0)
{
    Console.WriteLine("Impossível Calcular");
}
else
{

    Console.WriteLine($"X1 = {x1.ToString("F5", locale)}");
    Console.WriteLine($"X2 = {x2.ToString("F5", locale)}");
}



