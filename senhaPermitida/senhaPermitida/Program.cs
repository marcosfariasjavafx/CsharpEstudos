String Senha = "Playboyzinho";
String SenhaTentativa;
while (true)
{
    Console.WriteLine("Digite a senha ?");
    SenhaTentativa = Console.ReadLine();

    if (Senha == SenhaTentativa)
    {
        Console.WriteLine("Senha autorizada");
        break;
    }
    else
    {
        Console.WriteLine("Tente novamente");
    }
}