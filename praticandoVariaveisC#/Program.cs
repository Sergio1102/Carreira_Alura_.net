//Praticando Variaveis e Tipos em C#

void ExibirMenu()
{
    Console.WriteLine("Bem vindo ao código referente as práticas de variáveis e tipos em C#");
    Console.WriteLine("\nDigite 1 para o código de 'calcular idade'");
    Console.WriteLine("Digite 2 para o código de 'registro de doações'");
    Console.WriteLine("Digite 3 para o código de 'convertendo distâncias'");
    Console.WriteLine("Digite 4 para o código de 'convertendo horas para minutos'");
    Console.WriteLine("Digite 5 para o código de 'calcular a área de um retângulo'");
    Console.WriteLine("Digite 6 para o código de 'calcular a média de notas'");
    Console.WriteLine("Digite 7 para o código de 'convertendo tipos'");
    Console.WriteLine("Digite 8 para o código de 'controle de vidas em um jogo'");
    Console.WriteLine("Digite 9 para o código de 'aumento de salário'");
    Console.WriteLine("Digite 10 para o código de 'calculando a área e o perímetro'");
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
        case 5:
            CalculandoAreaDeUmRetangulo();
            break;
        case 6:
            CalculandoMediaDeNotas();
            break;
        case 7:
            ConvertendoTipos();
            break;
        case 8:
            ControleDeVidas();
            break;
        case 9:
            AumentoDeSalario();
            break;
        case 10:
            CalcularAreaEPerimetro();
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

void CalculandoAreaDeUmRetangulo()
{
    Console.Clear();
    Console.Write("Digite a largura do retângulo: ");
    double largura = double.Parse(Console.ReadLine()!);
    Console.Write("Digite o comprimento do retângulo: ");
    double comprimento = double.Parse(Console.ReadLine()!);
    double area = largura * comprimento;
    Console.WriteLine($"A área do terreno é: {area} m².");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

void CalculandoMediaDeNotas()
{
    Console.Clear();
    Console.Write("Digite a primeira nota: ");
    float notaUm = float.Parse(Console.ReadLine()!);
    Console.Write("Digite a segunda nota: ");
    float notaDois = float.Parse(Console.ReadLine()!);
    Console.Write("Digite a terceira nota: ");
    float notaTres = float.Parse(Console.ReadLine()!);
    float media = (notaUm + notaDois + notaTres) / 3;
    Console.WriteLine($"A média das notas é: {media}");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

void ConvertendoTipos()
{
    Console.Clear();
    Console.Write("Digite o peso total: ");
    double peso = double.Parse(Console.ReadLine()!);
    int quantidadeDeVeiculos = (int)peso;
    Console.WriteLine($"Veículos necessários: {quantidadeDeVeiculos}");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

void ControleDeVidas()
{
    Console.Clear();
    int vidas = 3;
    Console.WriteLine($"O jogo acaba quando você zerar as vidas ou chegar a 5.");
    while (vidas > 0 && vidas < 5)
    {
        Console.Write($"Você tem {vidas}. Você acertou ou errou a questão: ");
        string opcao = Console.ReadLine()!;
        if (opcao == "acertou")
        {
            vidas++;
        }
        else
        {
            vidas--;
        }
        Console.Clear();
    }
    if (vidas == 5)
    {
        Console.Clear();
        Console.WriteLine("Você ganhou");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Você perdeu");
    }
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

void AumentoDeSalario()
{
    Console.Clear();
    Console.Write("Digite o salário atual: ");
    decimal salario = decimal.Parse(Console.ReadLine()!);
    Console.Write("Digite a porcentagem do aumento: ");
    decimal porcentagem = decimal.Parse(Console.ReadLine()!);
    decimal novoSalario = salario + (salario * porcentagem / 100);
    Console.WriteLine($"O novo salário é de R${novoSalario.ToString("F2")}");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

void CalcularAreaEPerimetro()
{
    Console.Clear();
    double pi = 3.14159;
    Console.Write("Digite o valor do raio: ");
    double raio = double.Parse(Console.ReadLine()!);
    double area = pi * (raio * raio);
    double perimetro = 2 * pi * raio;
    Console.WriteLine(@$"
Raio: {raio.ToString("F2")}
Área do círculo: {area.ToString("F2")}
Perímetro do círculo: {perimetro.ToString("F2")}
    ");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();