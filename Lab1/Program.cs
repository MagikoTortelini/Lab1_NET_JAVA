using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Test"),InternalsVisibleTo("GUI")]
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe przedmiotw");
            int number_of_items = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj seed");
            int seed = int.Parse(Console.ReadLine());
            Problem solution = new Problem(number_of_items, seed);
            for (int i = 0; i < number_of_items; i++)
            {
                Console.WriteLine(solution.print_numbers(i));
            }
           
            Console.WriteLine(" ");
            Console.WriteLine("Podaj pojemnosc");
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine(solution.Solve(capacity));
        }
    }
        
    

    

}
