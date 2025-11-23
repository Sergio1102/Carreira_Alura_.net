Console.WriteLine("Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL):");
string cupom = Console.ReadLine()!;

string msg = cupom switch
{
    "DOBRAR" => "Você ganhou 2x EXP por 1 hora!",
    "CURAR" => "Poção de cura adquirida!",
    "OURO" => "1000 moedas de ouro!",
    "ESPECIAL" => "Item lendário desbloqueado!",
    _ => "Recompensa Indisponível."
};

Console.WriteLine(msg);