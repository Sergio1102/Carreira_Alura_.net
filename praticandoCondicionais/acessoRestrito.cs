Console.WriteLine("Digite a senha:");
int senha = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o nível de acesso:");
int nivel = int.Parse(Console.ReadLine()!);

if (senha == 42 && nivel >= 5)
{
    Console.WriteLine("Acesso liberado");
} else
{
    Console.WriteLine("Acesso negado");
}