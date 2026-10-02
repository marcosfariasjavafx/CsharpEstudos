namespace CalculaRaio
{
    internal class Program
    {
        public static double CalculaRaio(double pi, double raio)
        {
            double resultado = pi * (raio * raio);
            return resultado;
        }
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.WriteLine("Digite o raio do círculo em metros:");

            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"Área do círculo: {CalculaRaio(pi, raio)}");
            
        }
    }
}