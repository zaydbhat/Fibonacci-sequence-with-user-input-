using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_term = 0;
            Console.WriteLine(first_term);

            int second_term = 1;
            Console.WriteLine(second_term);

            int next_term = 0;

            Console.WriteLine("Enter the number of cycles");
            int y = int.Parse(Console.ReadLine());

            int x = 1;

            while ( x <= y)
            {

                next_term = first_term + second_term;
                Console.WriteLine(next_term);
               
                first_term = second_term;
                second_term = next_term;
                x++;
            }
        }
    }
}
