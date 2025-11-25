int senha = 0, chamada = 0, escolha;

while (true)
{
    Console.WriteLine(@"
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: ");
    escolha = int.Parse(Console.ReadLine()!);
    if(escolha == 1)
    {
        senha++;
        Console.WriteLine("Senha gerada: " + senha.ToString("D3"));
    } else if(escolha == 2){
        chamada++;
        Console.WriteLine("Senha chamada: " + chamada.ToString("D3"));
    } else if(escolha == 3)
    {
        Console.WriteLine("Encerrando sistema.");
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}