Console.Write("Digite o código do produto (1 ou 2): ");
int produto = int.Parse(Console.ReadLine()!);

if(produto == 1)
{
    Console.WriteLine("Perecível");
} else if (produto == 2)
{
    Console.WriteLine("Não perecível");    
} else
{
    Console.WriteLine("Código inválido, digite um código existente (1 ou 2)");
}