Console.Write("Digite um valor inteiro: ");
var n = int.Parse(Console.ReadLine()!);

var vector = new int[n];

for (var i = 0; i < n; i++)
{
    Console.Write("Digite um valor: ");
    vector[i] = int.Parse(Console.ReadLine()!);
}

var numbersIn = vector.Where(x => x >= 10 && x <= 20).Count();
var numbersOut = vector.Length - numbersIn;

Console.WriteLine($"{numbersIn} dentro do intervalo de [10,20]");
Console.WriteLine($"{numbersOut} forta do intervalo de [10,20]");



