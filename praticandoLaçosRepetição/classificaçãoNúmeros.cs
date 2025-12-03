List <int> notas = new List<int> { 4, 7, 5, 9, 6 };

foreach (int i in notas)
{
    if (i < 6)
    {
        Console.WriteLine($"Nota {i}: Reprovado");
    }else
    {
        Console.WriteLine($"Nota {i}: Aprovado");
    }
}