Console.WriteLine("Digite a idade:");
int idade = int.Parse(Console.ReadLine()!);

if (idade >= 0 && idade <= 12)
{
    Console.WriteLine("Classificação: Infantil");
} else if(idade <= 17)
{
    Console.WriteLine("Classificação: Adolescente");
} else if (idade <= 59)
{
    Console.WriteLine("Classificação: Adulto");
}
else
{
    Console.WriteLine("Classificação: Idoso");
}