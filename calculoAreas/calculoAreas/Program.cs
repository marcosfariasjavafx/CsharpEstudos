/*
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
*/

double a, b, c;

double calcularAreaTriangulo (double altura, double bas)
{
    return (altura * bas)/2;
}

double calculaRaio ( double raio)
{
    return (raio*raio) * 3.14159;
}

double areaTrapezio (double bas, double bas2, double altura)
{
    return (bas + bas2) * altura / 2;
}

double calcularQuadrado(double lado)
{
    return lado * lado;
}
double calcularRetangulo(double lado, double altura)
{
    return lado * altura;
}


Console.WriteLine("Digite o numero A");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero B");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero C");
c = double.Parse(Console.ReadLine());

Console.WriteLine("Triangulo: "+ calcularAreaTriangulo(a, c));
Console.WriteLine("Ciruclo: "+ calculaRaio(c));
Console.WriteLine("Trapezio: "+ areaTrapezio(a, b,c));
Console.WriteLine("Quadrado: "+ calcularQuadrado(b));
Console.WriteLine("Rentangulo: " + calcularRetangulo(a, b));