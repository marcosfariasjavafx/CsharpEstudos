Console.WriteLine("Digite o X");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o Y");
double y = double.Parse(Console.ReadLine());

if (x >= 0.1 && y >=0.1)
{
    Console.WriteLine("Q1");
}
else if (x>= 0.1 && y < 0)
{
    Console.WriteLine("Q4");
}
else if (x < 0 && y >0 )
{
    Console.WriteLine("Q2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}

else
{
    Console.WriteLine("Origem");
}