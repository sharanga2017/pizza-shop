using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisi une valeur :");
            string val = Console.ReadLine();

            int number;
            bool success = int.TryParse(val, out number);
            if(success == true)
            {
                Console.WriteLine("Vous avez saisi "+ number);
            }
            else
            {

                Console.WriteLine("Vous avez saisi "+ val);
            }

            Console.ReadKey();
        }
    }
}
