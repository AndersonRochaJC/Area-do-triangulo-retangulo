using System;

namespace Area_do_triangulo_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {           
           double b, h, area;
           Console.BackgroundColor = ConsoleColor.Green;
           Console.WriteLine("Calcule a area...");
            Console.BackgroundColor = ConsoleColor.Red;
           Console.Write("Base...: ");
           b = Convert.ToDouble(Console.ReadLine());
           Console.BackgroundColor = ConsoleColor.Red;
           Console.Write("Altura...: ");
           h = Convert.ToDouble(Console.ReadLine());
           Console.BackgroundColor = ConsoleColor.Green;
           area = (b * h) / 2;
           Console.WriteLine($"Area...: {area:N3} ");
           Console.ResetColor();
        }
        
    }
}