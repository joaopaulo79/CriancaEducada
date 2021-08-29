using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            string Texto;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Diga algo: ");
            Console.ResetColor();
            Texto = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Eu sou uma criança educada. No seu lugar eu diria: ");
            Console.ResetColor();
            Console.WriteLine(Texto
                            .Replace("chato","#@$%*!&")
                            .Replace("chata","#@$%*!&")
                            .Replace("bobo","#@$%*!&")
                            .Replace("boba","#@$%*!&")
                            .Replace("feio","#@$%*!&")
                            .Replace("feia","#@$%*!&")
                            .Replace("boboca","#@$%*!&")
                            .Replace("bocó","#@$%*!&")
                            .Replace("tonto","#@$%*!&")
                            .Replace("tonta","#@$%*!&")
                            .Replace("palerma","#@$%*!&")
                            .Replace("paspalho","#@$%*!&")
                            .Replace("paspalha","#@$%*!&")
                            .Replace("tantã","#@$%*!&")
                            .Replace("panaca","#@$%*!&")
                            .Replace("pentelho","#@$%*!&")
                            .Replace("pentelha","#@$%*!&")
                            .Replace("burro","#@$%*!&")
                            .Replace("burra","#@$%*!&")
                            .Replace("besta","#@$%*!&"));
            Console.WriteLine();  //.Replace("I","#@$%*!&")
        }
    }
}
