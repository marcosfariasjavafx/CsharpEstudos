namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int na1, na2, resultado;
            Console.WriteLine("Digite o primeiro número:");
            na1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            na2 = int.Parse(Console.ReadLine());

            resultado = na1 + na2;

            Console.WriteLine("A soma é: " + resultado);
        }
    }
} 