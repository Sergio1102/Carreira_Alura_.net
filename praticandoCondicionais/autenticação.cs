string cadastrados = "Admin";
Console.WriteLine(@"
Sistema de Autenticação
-----------------------
Digite seu nome de usuário: ");
string nome = Console.ReadLine()!;

if(nome == cadastrados)
{
    Console.WriteLine($"Bem-vindo, {nome}");
}
else
{
    Console.WriteLine(@"
Usuário não cadastrado.
Opções disponíveis:
[1] Cadastrar novo usuário
[2] Acessar como convidado
[3] Sair");
    int opc = int.Parse(Console.ReadLine()!);

    switch (opc)
    {
        case 1:
            Console.WriteLine($"Novo usuário '{nome}' cadastrado com sucesso!");
            break;
        case 2:
            Console.WriteLine("Acesso concedido como convidado.");
            break;
        case 3:
            Console.WriteLine("Saindo do sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida. O sistema será encerrado.");
            break;
    }
}