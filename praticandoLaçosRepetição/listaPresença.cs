List<string> alunos = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };
Console.WriteLine("Digite o nome do aluno:");
string nome = Console.ReadLine();
int contador = 0;
bool encontrado = false;

while(contador < alunos.Count)
{
    if (alunos[contador] == nome)
    {
        encontrado = true;
        break;
    }
    contador++;
}

if(encontrado)
{
    Console.WriteLine("Aluno encontrado na posição: " + (contador + 1));
}else
{
    Console.WriteLine("O aluno não está presente");
}