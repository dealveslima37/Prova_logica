var password = "2002";

while (true)
{
    Console.Write("Digite a senha: ");
    var senha = Console.ReadLine();
    if (senha == password)
    {
        Console.WriteLine("Acesso permitido");
        break;
    }
    else
    {
        Console.WriteLine("Senha inválida");
    }
}
