Console.WriteLine("Escolha um número para a tabela de multiplicação: ");
int num = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= 10; i++)
{
    int multiplicacao = num * i;
    Console.WriteLine($"{num} x {i} = {multiplicacao}");
}