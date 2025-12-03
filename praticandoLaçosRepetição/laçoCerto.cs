List<double> notas= new List<double> {8.5, 6.2, 9.1, 5.8, 7.4};

foreach(double i in notas)
{
    if(i >= 7)
    {
        Console.WriteLine($"O aluno com a nota {i} está indo muito bem!");
    } else
    {
        Console.WriteLine($"O aluno com a nota {i} está abaixo da média!");
    }
}