Console.WriteLine("Digite o código do livro: ");
int codigo = int.Parse(Console.ReadLine()!);

string msg = (codigo/100) switch
{
    1 => "Ficção Científica",
    2 => "Literatura Clássica",
    3 => "Fantasia",
    4 => "Romance",
    5 => "Suspense/Mistério",
    6 => "Não Ficção",
    7 => "Biografias/Memórias",
    8 => "Distopia",
    9 => "Infantojuvenil",
    _ => "Código inexistente"
};

Console.WriteLine(msg);