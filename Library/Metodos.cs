using System;
using System.ComponentModel;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

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

public static class ValidadorDeSenhas
{
    public static void Validar()
    {
        UI.LimparTela();
        string senha = "Csharp123";
        int tentativas = 3;

        do
        {
            Console.Write("Digite uma senha: ");
            string input = Console.ReadLine();
            if (input == senha)
            {
                Console.WriteLine("Acesso permitido.");
                UI.Aguardar(3000);
                return;
            }
            else
            {
                tentativas--;
                UI.Erro($"Acesso negado. Você tem {tentativas} tentativas restante(s).");
            }
        }
        while (tentativas > 0);
    }
}

public static class ConversorDeTemperaturas
{
    public static void Converter()
    {
        UI.LimparTela();
        Console.Write("Digite a temperatura: ");
        string inputTemperatura = Console.ReadLine();
        if (double.TryParse(inputTemperatura, CultureInfo.InvariantCulture, out double temperatura))
        {
            Console.WriteLine("[1] - Converter Celsius > Fahrenheit");
            Console.WriteLine("[2] - Converter Fahrenheit > Celsius");
            Console.Write("Escolha uma opção: ");
            string inputConversao = Console.ReadLine();
            if (int.TryParse(inputConversao, CultureInfo.InvariantCulture, out int opcao))
            {
                switch (opcao)
                {
                    case 1:
                        double conversaoFahrenheit = temperatura * 1.8 + 32;
                        Console.WriteLine($"{temperatura}°C é equivalente a {conversaoFahrenheit}ºF");
                        UI.Aguardar(3000);
                        break;
                    case 2:
                        double conversaoCelsius = 5.0/9.0 * (temperatura - 32);
                        Console.WriteLine($"{temperatura}°F é equivalente a {conversaoCelsius:F2}ºC");
                        UI.Aguardar(3000);
                        break;
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
            UI.Erro("Parâmetro inválido.");
        }
        
    }
}

public class SimuladorATM
{
    public decimal saldoConta = 1000;
    public void Sacar(decimal valor)
    {
        if (saldoConta < valor)
        {
            UI.Erro("Saldo insuficiente.", 1000);
        }
        else
        {
            saldoConta -= valor;
        }
    }
    public void Depositar(decimal valor)
    {
        saldoConta += valor;
    }

    public void VerSaldo()
    {
        Console.WriteLine($"Seu saldo é {saldoConta:C}");
    }

    public void Simular()
    {
        while (true)
        {
            UI.LimparTela();
            UI.Separador();
            Console.WriteLine("  Simulador de Caixa");
            UI.Separador();
            Console.WriteLine("[1] - Sacar");
            Console.WriteLine("[2] - Depositar");
            Console.WriteLine("[3] - Ver Saldo");
            Console.WriteLine("[4] - Sair");
            Console.Write("Escolha uma opção: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, CultureInfo.InvariantCulture, out int opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Quanto você deseja sacar? ");
                        string inputSaque = Console.ReadLine();
                        if (decimal.TryParse(inputSaque, CultureInfo.InvariantCulture, out decimal valorSaque))
                        {
                            Sacar(valorSaque);
                        }
                        else
                        {
                            UI.Erro("Valor inválido");
                        }
                        break;
                    case 2:
                        Console.Write("Quanto você deseja depositar? ");
                        string inputDeposito = Console.ReadLine();
                        if (decimal.TryParse(inputDeposito, CultureInfo.InvariantCulture, out decimal valorDeposito))
                        {
                            Depositar(valorDeposito);
                        }
                        else
                        {
                            UI.Erro("Valor inválido");
                        }
                        break;
                    case 3:
                        VerSaldo();
                        UI.Aguardar();
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
            else
            {
                UI.Erro("Opção inválida");
            }
        }
    }
}