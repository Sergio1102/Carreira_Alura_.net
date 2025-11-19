Console.WriteLine("Informe a nota final do aluno:");
int nota = int.Parse(Console.ReadLine()!);

if (nota >= 9)
{
    Console.WriteLine("O aluno tirou a nota A");
} else if(nota >= 7)
{
    Console.WriteLine("O aluno tirou a nota B");
} else if (nota >= 5)
{
    Console.WriteLine("O aluno tirou a nota C");
}
else
{
    Console.WriteLine("O aluno tirou a nota D");
}