Random rnd = new Random();
int res = rnd.Next(1, 10);
int num;

Console.WriteLine("Tente adivinhar o número entre 1 e 10: ");
num = int.Parse(Console.ReadLine()!);
while (num != res){
    if (num < res)
    {
        Console.WriteLine("Seu número é menor que o número correto");        
    } else if(num > res){
        Console.WriteLine("Seu número é maior que o número correto");  
    }
    Console.WriteLine("Tente novamente: ");
    num = int.Parse(Console.ReadLine()!);
}
Console.WriteLine("Parabéns, você acertou!");