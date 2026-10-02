using System.Runtime.Serialization;

namespace CalcularDiferenca;

public class Program
{
    public static void Main(string[] args)
    {
        int A,B,C,D,DIFERENCA;

        Console.WriteLine("Digite o primeiro valor:");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        B = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor:");
        C = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o quarto valor:");
        D = int.Parse(Console.ReadLine());

        DIFERENCA = (A * B) - (C * D);
        Console.WriteLine($"DIFERENCA = {DIFERENCA}";
        
    }
}
