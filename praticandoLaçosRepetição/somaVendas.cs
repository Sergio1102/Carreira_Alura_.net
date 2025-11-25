decimal valor, total = 0;

do
{
    Console.WriteLine("Digite o valor da venda (ou 0 para encerrar): ");
    valor = decimal.Parse(Console.ReadLine()!);
    total += valor;

} while (valor != 0);

Console.WriteLine("Total de vendas do dia: R$" + total);