using System;
using System.Globalization;

namespace MenuComMetodos;

public static class CalculadoraImc
{
    public static void CalcularIMC()
    {   
        UI.LimparTela();
        Console.Write("Digite sua altura: ");
        string inputHeight = Console.ReadLine();
        Console.Write("Digite seu peso: ");
        string inputWeight = Console.ReadLine();

        if (double.TryParse(inputHeight, CultureInfo.InvariantCulture, out double height) && double.TryParse(inputWeight, CultureInfo.InvariantCulture, out double weight))
        {
            double imc = weight / (height*height);
            if (imc < 18.5)
            {
                Console.WriteLine($"Seu IMC é {imc:F2} e sua classificação é Abaixo do peso.");
                UI.Aguardar(2500);
            }
            else if (imc < 24.9)
            {
                Console.WriteLine($"Seu IMC é {imc:F2} e sua classificação é Peso Normal.");
                UI.Aguardar(2500);
            }
            else if (imc < 29.9)
            {
                Console.WriteLine($"Seu IMC é {imc:F2} e sua classificação é Sobrepeso.");
                UI.Aguardar(2500);
            }
            else if (imc < 39.9)
            {
                Console.WriteLine($"Seu IMC é {imc:F2} e sua classificação é Obesidade.");
                UI.Aguardar(2500);
            }
            else
            {
                Console.WriteLine($"Seu IMC é {imc:F2} e sua classificação é Obesidade Grave.");
                UI.Aguardar(2500);
            }
        }
        else
        {
            UI.Erro("Medida(s) inválidas.");
        }
    }
}

public static class CalculadoraMediaPond
{
    public static void CalcularMedia()
    {
        UI.LimparTela();
        Console.Write("Qual o nome do aluno? ");
        string aluno = Console.ReadLine();
        Console.Write("Qual a primeira nota? ");
        string inputNota1 = Console.ReadLine();
        Console.Write("Qual a segunda nota? ");
        string inputNota2 = Console.ReadLine();
        Console.Write("Qual a terceira nota? ");
        string inputNota3 = Console.ReadLine();

        if (double.TryParse(inputNota1, CultureInfo.InvariantCulture, out double nota1) && 
        double.TryParse(inputNota2, CultureInfo.InvariantCulture, out double nota2) &&
        double.TryParse(inputNota3, CultureInfo.InvariantCulture, out double nota3))
        {
            double media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;
            Console.WriteLine($"A média do aluno {aluno} é {media:F2}");
            UI.Aguardar(2500);
        }
        else
        {
            UI.Erro("Nota(s) inválidas.");
        }
    }
}

public static class CalculadoraSimples
{
    public static void CalcularNumeros()
    {
        UI.LimparTela();
        Console.Write("Digite um número: ");
        string firstInput = Console.ReadLine();
        Console.Write("Digite outro número: ");
        string secondInput = Console.ReadLine();
        if (int.TryParse(firstInput, CultureInfo.InvariantCulture, out int firstNum) && 
        int.TryParse(secondInput, CultureInfo.InvariantCulture, out int secondNum))
        {
            Console.WriteLine("[1] - Somar");
            Console.WriteLine("[2] - Subtrair");
            Console.WriteLine("[3] - Multiplicar");
            Console.WriteLine("[4] - Dividir");
            Console.Write("Escolha uma opção: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, CultureInfo.InvariantCulture, out int opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"A Soma entre {firstNum} e {secondNum} é {firstNum + secondNum}");
                        UI.Aguardar(2000);
                        break;
                    case 2:
                        Console.WriteLine($"A Subtração entre {firstNum} e {secondNum} é {firstNum - secondNum}");
                        UI.Aguardar(2000);
                        break;
                    case 3:
                        Console.WriteLine($"A Multiplicação entre {firstNum} e {secondNum} é {firstNum * secondNum}");
                        UI.Aguardar(2000);
                        break;
                    case 4:
                        if (secondNum == 0)
                        {
                            UI.Erro("Não é possível dividir por 0.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"A Divisão entre {firstNum} e {secondNum} é {(firstNum / secondNum):F2}");
                            UI.Aguardar(2000);
                            break;
                        }
                    default:
                        UI.Erro("Opção inválida.");
                        break;
                }
            }
            else
            {
                UI.Erro("Opção inválida.");
            }
        }
        else
        {
            UI.Erro("Parâmetro(s) inválidos.");
        }
    }
}

public static class GeradorDeTabuada
{
    public static void GerarTabuada()
    {
        UI.LimparTela();
        Console.Write("Qual número você deseja gerar uma tabuda? ");
        string input = Console.ReadLine();
        if (int.TryParse(input, CultureInfo.InvariantCulture, out int numero))
        {
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine($"{numero} X {contador} = {numero*contador}");
                contador++;
            }
            Console.WriteLine($"Tabuada do {numero} gerada!");
            UI.Aguardar(3500);
        }
        else
        {
            UI.Erro("Apenas números inteiros.");
        }
    }    
} 

public static class SomadorComCondicao
{
    public static void Somador()
    {
        UI.LimparTela();
        int soma = 0;
        
        while (true)
        {
            Console.Write("Digite um número: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, CultureInfo.InvariantCulture, out int numero))
            {
                if (numero >= 0)
                {
                    soma += numero;
                }
                else
                {
                    Console.WriteLine($"Soma total: {soma}");
                    UI.Aguardar(4000);
                    return;
                }
            }
            else
            {
                UI.Erro("Apenas números inteiros.", 500);
            }
        }
    }
}

