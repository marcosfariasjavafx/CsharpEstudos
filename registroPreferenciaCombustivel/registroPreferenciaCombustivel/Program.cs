int alcool=0;
int gasolina= 0;
int disel =0;
int contador=0;

Console.WriteLine("Inicio do contador\n1.Álcool 2.Gasolina 3.Diesel 4.Fim");
while (true)
{
    Console.WriteLine("Digite:");
    contador = int.Parse(Console.ReadLine());

    if (contador == 1)
    {
        alcool++;
    }
    else if (contador ==2)
    {
        gasolina++;
    }
    else if (contador==3)
    {
        disel++;
    }
    else if (contador == 4)
    {
        Console.WriteLine($"Resultados:\nAlcool = {alcool}\nGasolina = {gasolina}\nDiesel = {disel}");
        break;
    }

}