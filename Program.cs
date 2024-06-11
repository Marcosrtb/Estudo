using System.Runtime.CompilerServices;

namespace Calculadora;

class Program
{
    static void Main(string[] args){
        Console.WriteLine("## Calculadora Simples ##");
        Console.WriteLine("\nOpções");


        int opcao = 0;

        do{
        Console.WriteLine("1. Somar");
        Console.WriteLine("2. Subtrair");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("0. Sair");
        Console.WriteLine("\nEscolha uma opção: ");
        opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 0)
        break;
        
        Console.WriteLine("\nPrimeiro Valor: ");
        Double valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Segundo Valor: ");
        Double valor2 = Convert.ToDouble(Console.ReadLine());

        Double resposta = 0;

        switch(opcao){
            case 1:
            resposta = valor1  + valor2;
            break;

            case 2:
            resposta = valor1 - valor2;
            break;

            case 3:
            resposta = valor1 * valor2;
            break;

            case 4:
            resposta = valor1 / valor2;
            break;

        }

        Console.WriteLine("Resultado: " + resposta);

        }
        while(opcao != 0);

    }
}
