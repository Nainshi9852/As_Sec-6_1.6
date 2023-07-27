using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }
        static void doApp()
        { 
            // IF-ELSE statement
            int x = 10;
            if (x > 5)
            {
                Console.WriteLine("x is greater than 5.");
            }
            else
            {
                Console.WriteLine("x is less than or equal to 5.");
            }

           // WHILE loop
           int i = 1;
           while (i <= 5)
           {
             Console.WriteLine("WHILE loop iteration: " + i);
             i++;
           }

         // FOR loop
         for (int j = 1; j <= 5; j++)
         {
            Console.WriteLine("FOR loop iteration: " + j);
         }

         // DO-WHILE loop
         int k = 1;
         do
         {
            Console.WriteLine("DO-WHILE loop iteration: " + k);
            k++;
         } while (k <= 5);

         // SWITCH statement
         char grade = 'B';
         switch (grade)
         {
         case 'A':
          Console.WriteLine("Excellent!");
          break;
         case 'B':
           Console.WriteLine("Well done!");
           break;
          case 'C':
            Console.WriteLine("Good effort!");
            break;
           default:
             Console.WriteLine("You can do better.");
              break;
            }
            string[] numbers = { "One", "Two", "Three", "Four", "Five" };
            foreach (string s in numbers)
            {
                Console.WriteLine("Foreach loop to iterate through an array :" + s);
            }
        }

    }
}

