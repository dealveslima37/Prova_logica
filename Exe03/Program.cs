using System.Globalization;

var locale = CultureInfo.InvariantCulture;

Console.WriteLine("Código Especificação   Preço");
Console.WriteLine("1      Cachorro Quente R$ 4.00");
Console.WriteLine("2      X - Salada      R$ 4.50");
Console.WriteLine("3      X-Bacon         R$ 5.00");
Console.WriteLine("4      Torrada Simples R$ 2.00");
Console.WriteLine("5      Refrigerante    R$ 1.50");

Console.Write("Código: ");
var codigo = int.Parse(Console.ReadLine()!);
Console.Write("Quantidade: ");
var qtd = int.Parse(Console.ReadLine()!);

var valorTotal = 0.0;

switch (codigo)
{
    case 1:
        valorTotal = 4.00 * qtd;
        break;
    case 2:
        valorTotal = 4.50 * qtd;
        break;
    case 3:
        valorTotal = 5.00 * qtd;
        break;
    case 4:
        valorTotal = 2.00 * qtd;
        break;
    case 5:
        valorTotal = 1.50 * qtd;
        break;
    default:
        Console.WriteLine("Valor inválido");
        break;
}

Console.WriteLine($"Valor total R$ {valorTotal.ToString("F2", locale)}");


