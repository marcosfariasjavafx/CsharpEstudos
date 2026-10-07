int a;
int[] numerosIn;

Console.WriteLine("Digite seu numero:");
a = int.Parse(Console.ReadLine());

numerosIn = new int[a];

for (int i = 0; i < a; i++)
{
    Console.WriteLine("Digite o numero para saber se está dentro ou fora:");
    int temp = int.Parse(Console.ReadLine());

     numerosIn[i] = temp;
   
}
foreach (int b in numerosIn)
{
    if (b <= a)
    {
        Console.WriteLine(b + "In");
    }
    else
    {
        Console.WriteLine(b+"Out");
    }
}

