Livro meuLivro = new Livro();
meuLivro.Titulo = "Dom Casmurro";
meuLivro.Autor = "Machado de Assis";
meuLivro.ExibirDados();

public class Livro
{
    public string Titulo {get; set;}
    public string Autor {get;set;}
    
    public void ExibirDados()
    {
        Console.WriteLine("Livro: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
    }
}