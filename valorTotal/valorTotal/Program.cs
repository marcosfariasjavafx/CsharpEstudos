Console.WriteLine("***** Calculador de mercadoria *****");
Console.WriteLine("Tabela de mercadorias:\nID - MERCADORIA - VALOR\n1 - Arroz - 20R$\n2 - Feijao - 35$\n3 - Batata - 10$");

int [] preco = [0,20,35,10];

Console.WriteLine("Digite o ID da mercadoria que deseja: ");
int id = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade: ");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o ID da mercadoria 2 que deseja: ");
int id2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade: ");
int quantidade2 = int.Parse(Console.ReadLine());

int total = (preco[id] * quantidade) + (preco[id2] * quantidade2);
Console.WriteLine($"O valor da sua compra deu R${total}");

