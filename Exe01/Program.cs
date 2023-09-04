using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.Write("Código da peça: ");
var codigoDaPeca = int.Parse(Console.ReadLine()!);
Console.Write("Número de pecas: ");
var numeroDePecas = int.Parse(Console.ReadLine()!);
Console.Write("Valor da peça R$: ");
var valorDaPeca = double.Parse(Console.ReadLine()!, locale);

double totalDaPeca1 = numeroDePecas * valorDaPeca;

Console.Write("Código da peça: ");
codigoDaPeca = int.Parse(Console.ReadLine()!);
Console.Write("Número de pecas: ");
numeroDePecas = int.Parse(Console.ReadLine()!);
Console.Write("Valor da peça R$: ");
valorDaPeca = double.Parse(Console.ReadLine()!, locale);

double totalDaPeca2 = numeroDePecas * valorDaPeca;

double totalAPagar = totalDaPeca1 + totalDaPeca2;

Console.WriteLine($"Valor a pagar R$: {totalAPagar.ToString("F2", locale)}");




