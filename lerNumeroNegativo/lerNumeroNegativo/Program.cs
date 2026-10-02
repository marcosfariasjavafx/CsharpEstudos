int a;

static void verificarNumeroPositvo(int a)
{
    if (a < 0)
    {
        Console.WriteLine("Seu numero é NEGATIVO");
    }
    else
    {
        Console.WriteLine("Seu numero é POSITIVO");
    }
}

Console.WriteLine("Digite o seu nuemro: ");
a = int.Parse(Console.ReadLine());

verificarNumeroPositvo(a);