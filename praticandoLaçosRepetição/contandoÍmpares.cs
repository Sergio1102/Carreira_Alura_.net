int contador = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write("Digite um número: ");
    int num = int.Parse(Console.ReadLine()!);
    if (num % 2 != 0)
    {
        contador++;
    }
}
Console.WriteLine($"Você digitou {contador} números ímpares.");