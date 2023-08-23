using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Can be defined in this way.
            /*
            int[] numbers = new int[4];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
            */

            // Can be defined in this way.
            /*
            string[] names = { "Özay", "Melih", "Yıldız" };
            for(int i  = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            // Get value from user
            /*
            int[] number = new int[4];

            for(int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*****************************************");
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadLine();
            */

            // ForEach
            /*
            string[] names = { "Ozay", "Melih", "Yıldız" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            // Example 1
            /*
            int[] numbers = { 1, 2, 5, 8, 100, 50, 789, 159, 753, 555, 666 };

            Console.WriteLine("Please, enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == userNumber)
                {
                    Console.WriteLine("Your number is in the list");
                }else
                {
                    Console.WriteLine("Your number is not in the list");
                }
            }
            Console.ReadLine();
            */

            // Example 2

            int[] numbers = new int[10];
            int numberoffOddNumbers = 0;
            int numberoffEvenNumbers = 0;

            int sumoffOddNumbers = 0;
            int sumoffEvenNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    numberoffOddNumbers++;
                    sumoffOddNumbers += numbers[i];
                }
                else if (numbers[i] % 2 == 0)
                {
                    numberoffEvenNumbers++;
                    sumoffEvenNumbers += numbers[i];
                }
            }
            Console.WriteLine("Number off odd numbers = "+ numberoffOddNumbers);
            Console.WriteLine("Number off even numbers = " + numberoffEvenNumbers);

            Console.WriteLine("Sum off odd numbers = " + sumoffOddNumbers);
            Console.WriteLine("Sum off even numbers = " + sumoffOddNumbers);

            if(sumoffOddNumbers > sumoffEvenNumbers)
            {
                Console.WriteLine("The sum of odd numbers is greater");
            }
            else
            {
                Console.WriteLine("The sum of even numbers is greater");
            }



            Console.ReadLine();

        }
    }
}
