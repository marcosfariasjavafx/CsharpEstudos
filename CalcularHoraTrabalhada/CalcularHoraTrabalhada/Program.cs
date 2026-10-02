float caluclarHoraTrabalhada(float a, float b)
{
    return a * b;
}


Console.WriteLine("Bem vindo ao calculadora de salário");


Console.WriteLine("Digite seu nome: ");
String? nome = Console.ReadLine();

Console.WriteLine("Digite a quantidade de hora trabalhada: ");
float horaTrabalhada = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o quanto você ganha por hora");
float valorHora = float.Parse(Console.ReadLine());

Console.WriteLine($"{nome} você trabalhou {horaTrabalhada}h o total a receber é = "+ caluclarHoraTrabalhada(horaTrabalhada, valorHora)+"$");