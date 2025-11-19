Console.WriteLine("Digite o saldo:");
decimal saldo = decimal.Parse(Console.ReadLine()!);

if (saldo < 0)
{
    Console.WriteLine("O saldo está negativo.");
} else if(saldo == 0)
{
    Console.WriteLine("O saldo está zerado.");
}
else
{
    Console.WriteLine("O saldo está positivo.");
}