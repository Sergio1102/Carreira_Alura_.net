int opc;
double celsius, fahrenheit;
do
{
    Console.WriteLine(@"
1 - Celsius para Fahrenheit
2 - Fahrenheit para Celsius
3 - Sair
Escolha uma opção: ");
    opc = int.Parse(Console.ReadLine()!);

    switch(opc)
    {
        case 1:
            Console.WriteLine("Digite a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine()!);
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}ºC equivalem {fahrenheit}ºF");
            break;
        case 2:
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine()!);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}ºF equivalem {celsius}ºC");
            break;
        case 3:
            Console.WriteLine("Saindo...");
            break;
        case 4:
            Console.WriteLine("Operação inválida");
            break;

    }
} while(opc != 3);