Console.WriteLine("Digite seu salário");
double salario = double.Parse(Console.ReadLine());


if (salario <= 2000)
{
    Console.WriteLine("Isento");
}
else if (salario >2000 && salario <=3000)
{
    Console.WriteLine("R$"+salario*0.08);
}

else if (salario > 3000 && salario <= 4500)
{
    Console.WriteLine("R$"+salario*0.18);
}

else
{
    Console.WriteLine("R$"+salario* 0.28);
}