Console.WriteLine(@"
Qual momento do dia é agora?
1 - Manhã
2 - Tarde
3 - Noite
");
int opc = int.Parse(Console.ReadLine()!);

Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine()!;

switch (opc)
{
    case 1:
        Console.WriteLine($"Bom dia, {nome}.");
        break;
    case 2:
        Console.WriteLine($"Boa tarde, {nome}.");
        break;
    case 3:
        Console.WriteLine($"Boa noite, {nome}.");
        break;
    default:
        Console.WriteLine("Entrada Inválida");
        break;
}