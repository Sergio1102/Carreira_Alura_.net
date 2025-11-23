Console.WriteLine("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a operação (+, -, *, /): ");
string operacao = Console.ReadLine()!;

switch (operacao)
{
    case "+":
        Console.WriteLine("O resultado da operação é: " + (num1 + num2));
        break;
    case "-":
        Console.WriteLine("O resultado da operação é: " + (num1 - num2));
        break;
    case "*":
        Console.WriteLine("O resultado da operação é: " + (num1 * num2));
        break;
    case "/":
        Console.WriteLine("O resultado da operação é: " + (num1 / num2));
        break;
    default:
        Console.WriteLine("Operação Inválida");
        break;
}