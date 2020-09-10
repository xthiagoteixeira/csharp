using System;
using System.Collections.Generic;

namespace CursoP2
{

    class Program
    {
        static void Main(string[] args)
        {
        
            var book = new Book("Thiago Teixeira");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

             var stats = book.GetStatistics();
             Console.WriteLine($"Nota mínima é: {stats.Low:N2}");
             Console.WriteLine($"Nota máxima é: {stats.High:N2}");
             Console.WriteLine($"Nota media é: {stats.Average}");
                          
        }
    }
}
