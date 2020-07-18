using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string t = Console.ReadLine();
            Console.WriteLine("Hi, " + t + 2);

            int numb = 5;

            Console.WriteLine("Hi, " + (numb + 2));

            if (numb == 5)
            {
                Console.WriteLine("Number is 5");
            }

            else if (numb > 5)
            {
                Console.WriteLine("Number is GT 5");

            }
            else
            {
                Console.WriteLine("Number is NOT 5");
            }
        }
    }
}
