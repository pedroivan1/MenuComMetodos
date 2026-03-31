using System;
using System.Globalization;

namespace MenuComMetodos;

public static class CalculadoraImc
{
    public static void CalcularImc()
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
    public static void CalcularMediaPond()
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
    
}

