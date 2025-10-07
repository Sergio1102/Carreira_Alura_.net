//Praticando Variaveis e Tipos em C#

void ExibirMenu()
{
    Console.WriteLine("Bem vindo ao código referente as práticas de variáveis e tipos em C#");
    Console.WriteLine("\nDigite 1 para o código de 'calcular idade'");
    Console.WriteLine("Digite 2 para o código de 'registro de doações'");
    Console.WriteLine("Digite 3 para o código de 'convertendo distâncias'");
    Console.WriteLine("Digite 4 para o código de 'convertendo horas para minutos'");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite sua opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida) {
        case 1:
            CalculandoIdade();
            break;
        case 2:
            RegistroDeDoacao();
            break;
        case 3:
            ConvertendoDistancias();
            break;
        case 4:
            ConvertendoHorasParaMinutos();
            break;
        case -1:
            Console.WriteLine("Até a próxima ;)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void CalculandoIdade()
{
    Console.Clear();
    int anoAtual = 2025; //Esse código foi desenvolvido em 2025
    Console.Write("Digite o seu ano de nascimento: ");
    int anoNascimento = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Sua idade é: {anoAtual - anoNascimento} anos");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

void RegistroDeDoacao()
{
    Console.Clear();
    Console.Write("Digite o valor da doação: ");
    float doacao = float.Parse(Console.ReadLine()!);
    Console.Write("Ela é anônima(True ou False): ");
    bool anonima = bool.Parse(Console.ReadLine()!);
    Console.Write("Qual o tipo de conta (P ou C): ");
    char tipo = char.Parse(Console.ReadLine()!);
    Console.WriteLine(@$"
Valor recebido: R${doacao}
Doação anônima: {anonima}
Tipo de conta: {tipo}
    ");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

void ConvertendoDistancias()
{
    Console.Clear();
    Console.Write("Digite a distância em milhas: ");
    double milhas = double.Parse(Console.ReadLine()!);
    double distanciaEmKm = milhas * 1.60934;
    Console.WriteLine($"{milhas} milhas equivalem a {distanciaEmKm} quilômetros.");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

void ConvertendoHorasParaMinutos()
{
    Console.Clear();
    Console.Write("Digite o total em minutos: ");
    int minutos = int.Parse(Console.ReadLine()!);
    int horas = minutos / 60;
    int minutosRestantes = minutos % 60;
    Console.WriteLine($"Tempo {horas} horas e {minutosRestantes} minutos");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();