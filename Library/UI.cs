using System;

namespace MenuComMetodos;

public static class UI
{
    public static void Separador()
    {
        Console.WriteLine("======================");
    }

    public static void LimparTela()
    {
        Console.Clear();
    }

    public static void PularLinha()
    {
        Console.WriteLine();
    }

    public static void Aguardar()
    {
        System.Threading.Thread.Sleep(1250);
    }
    public static void Aguardar(int ms)
    {
        System.Threading.Thread.Sleep(ms);
    }

    public static void Erro(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ResetColor();
        Aguardar(2000);
    }
}