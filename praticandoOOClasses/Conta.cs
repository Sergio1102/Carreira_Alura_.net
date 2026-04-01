ContaBancaria conta = new ContaBancaria("78901-2", 1000.00);
conta.Depositar(500.00);
conta.ExibirDados();

public class ContaBancaria
{
    public string NumeroConta{get;}
    public double Saldo{get; set;}

    public ContaBancaria(string numConta, double saldo)
    {
        NumeroConta = numConta;
        Saldo = saldo;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void ExibirDados()
    {
        Console.WriteLine("Conta: " + NumeroConta);
        Console.WriteLine("Saldo: R$ " + Saldo.ToString("F2"));
    }
}