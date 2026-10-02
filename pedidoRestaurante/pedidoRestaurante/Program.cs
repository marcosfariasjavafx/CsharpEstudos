Console.WriteLine("Restaurante do MARKIN");

Console.WriteLine("TABELA ITENS\n 1 - Cachorro Quente - R$4.00\n 2 - X-Salada - R$4.50\n 3 - X-Bacon - R$5.00\n 4 - Torrada - R$2.00\n 5 - Refrigerante - R$1.50");

double[] preco = [0, 4.00, 4.50, 5.00, 2.00 , 1.50];

Console.WriteLine("Digite o id do que deseja: ");
int id = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade do item que deseja: ");
double quant = double.Parse(Console.ReadLine());

Console.WriteLine("O total do seu pedido deu: R$"+preco[id]*quant);