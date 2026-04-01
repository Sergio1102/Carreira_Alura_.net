Passagem passagem = new Passagem("Lucas Souza", "Paris");
passagem.ExibirDados();

public class Passagem
{
    public string Passageiro{get;}
    public string Destino{get;}
    
    public Passagem(string passageiro, string destino)
    {
        Passageiro = passageiro;
        Destino = destino;
    }

    public void ExibirDados()
    {
        Console.WriteLine("Passageiro: " + Passageiro);
        Console.WriteLine("Destino: " + Destino);
    }
}