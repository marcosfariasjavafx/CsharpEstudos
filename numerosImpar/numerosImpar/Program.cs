int numero;

Console.WriteLine("Digite até que numero ");
numero = int.Parse(Console.ReadLine());
Console.WriteLine("=========================");
for(int a =0; a < numero; a++)
{
	if (a%2 ==1)
	{
        Console.WriteLine(a);
	}
}