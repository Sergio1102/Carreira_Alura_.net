int opc = 1, quant = 0;

Console.WriteLine(@"
Deseja adicionar um produto ao estoque?
1 - Sim | 0 - Não");
opc = int.Parse(Console.ReadLine()!);

while (opc == 1)
{
    Console.WriteLine("Quantidade: ");
    quant += int.Parse(Console.ReadLine()!);
    Console.WriteLine("Estoque atual: " + quant);

    Console.WriteLine(@"
Deseja continuar?
1 - Sim | 0 - Não");
    opc = int.Parse(Console.ReadLine()!);
}
Console.WriteLine("Obrigado por usar nosso sistema de estoque!");