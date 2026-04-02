using System;

namespace MenuComMetodos;

class Program {
    static void Main(string[] args) {
        bool mostrarMenu = true;

        do {
            Console.Clear();
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("|        PROJETO TED N1       |");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("1 - Calculadora Média Ponderada");
            Console.WriteLine("2 - Calculadora de IMC");
            Console.WriteLine("3 - Calculadora Simples");
            Console.WriteLine("4 - Gerador de Tabuada");
            Console.WriteLine("5 - Soma com Condição");
            Console.WriteLine("6 - Validação de Senha");
            Console.WriteLine("7 - Conversor de Temperaturas");
            Console.WriteLine("8 - Caixa Eletrônico");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção -> ");

            string opcao = Console.ReadKey(true).KeyChar.ToString();
            
            switch (opcao)
            {
                case "1":
                    CalculadoraMediaPond.CalcularMedia();
                    break;
                case "2":
                    CalculadoraImc.CalcularIMC();
                    break;
                case "3":
                    CalculadoraSimples.CalcularNumeros();
                    break;
                case "4":
                    GeradorDeTabuada.GerarTabuada();
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "0":
                    Console.WriteLine("Até a próxima.");
                    mostrarMenu = false;
                    UI.Aguardar();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Write("Opção inválida! Pressione qualquer tecla para continuar. ");
                    Console.ReadKey();
                    Console.ResetColor();
                    break;
            }
        } while (mostrarMenu);
    }
}