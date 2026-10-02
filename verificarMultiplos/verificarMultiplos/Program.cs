int calculoMultiplo (int a, int b)
{
    int resultado;
    resultado = a / b;
    return resultado * b;

}

Console.WriteLine("Digite seu numero A");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite seu numero B");
int b = int.Parse(Console.ReadLine());


if (calculoMultiplo(a,b) == a)
{
    Console.WriteLine("SÃO MULTIPLOS");
}
else
{
    Console.WriteLine("NÃO SÃO MULTIPLOS");
}