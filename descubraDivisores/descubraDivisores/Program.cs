int a = 0;

Console.WriteLine("Digite o numero para descobrir os divisores");
a = int.Parse(Console.ReadLine());

for (int i = 0; i <= a; i++)
{

	if (i %2 ==0)
	{
        Console.WriteLine(i);
	}

}