Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");
funcionario.ExibirDados();
funcionario.Promover("Assistente Administrativo");
funcionario.Promover("Analista de Projetos");

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
 
    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public void Promover(string novoCargo)
    {
        if(novoCargo != Cargo)
        {
            Cargo = novoCargo;
            Console.WriteLine(@$"
Promoção do Funcionário {Nome} realizada com sucesso!
Cargo Atual: {Cargo}");
        }
        else
        {
            Console.WriteLine("Erro: O novo cargo deve ser diferente do cargo atual.");
        }
    }

    public void ExibirDados()
    {
        Console.WriteLine("Funcionário: " + Nome);
        Console.WriteLine("Cargo Atual: " + Cargo);
    }
}