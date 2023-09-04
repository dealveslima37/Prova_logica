using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.Write("Valor do raio: ");
var raio = double.Parse(Console.ReadLine()!, locale);

double area = Math.PI * Math.Pow(raio, 2.0);

Console.WriteLine($"A = {area.ToString("F2", locale)}");
