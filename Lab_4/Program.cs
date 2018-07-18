using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Learn your squares and cubes!");
            bool again = true;
            string answer = "y";

            while (again == true)
            {
                Console.WriteLine("Enter an integer:");
                int x = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("{0,-10} {1,-10} {2,-10}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", "======", "=======", "=====");
                for (int i = 1; i <= x; ++i)
                {
                    int square = (i * i);
                    int cube = (i * i * i);
                    Console.WriteLine("{0,-10} {1,-10} {2,-10}", i, square, cube);
                }
                Console.WriteLine("Continue? (y/n)");
                answer = Convert.ToString(Console.ReadLine());
                answer = answer.ToLower();
                
                if (answer == "y")
                {
                    again = true;
                }
                else if (answer == "n")
                {
                    again = false;
                }

            }
            Console.WriteLine("Thank you for learning and having fun!");
            Console.ReadKey();
        }
    }
}
