using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    class Lesson1
    {
        static void Main(string[] args)
        {
            #region Lesson 1 youtube
            Console.WriteLine("Please Enter Your Name : ");
            string input = Console.ReadLine();
            Console.WriteLine($"Hello {input}");
            Console.WriteLine("Please Choose Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"Num {a} is even");
            }
            else
            {
                Console.WriteLine($"Num {a} is odd");
            }
            Console.WriteLine($"You Have Chosen : {a}");
            int t = 1;
            while (t <= a)
            {
                Console.WriteLine(t);
                t++;
            }
            #endregion

            #region  1st exercise
            Console.WriteLine("Enter the first number");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            if (f % b == 0)
            {
                Console.WriteLine($"Number : {f} is divided by {b} without the remainder");
            }
            else
            {
                Console.WriteLine($"Number : {f} can't be divide by {b} without the remainder");
            }
            #endregion

            #region  2nd exercise
            Console.WriteLine("Enter the first number");
            int aa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int bb = Convert.ToInt32(Console.ReadLine());
            int result = aa + bb;
            float avg = result / 2;
            Console.WriteLine($"Result of {aa} + {bb} is {result} \n\nThe average of {aa} and {bb} is {avg}");
            #endregion

            #region 3rd exercise
            int sum = 0;
            Console.WriteLine("Please enter a number: ");
            int i = Convert.ToInt32(Console.ReadLine());         //3
            while (i >= 0)
            {
                Console.WriteLine($"You chose {i} which is positive number");
                sum = sum + i;    //adds i to the sum each time
                Console.WriteLine($"Now the sum is : {sum}");
                Console.WriteLine("Choose another number: ");

                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The sum is : {sum}");
                if (i < 0)
                {
                    Console.WriteLine($"{i} is Negative");
                }
            }
            #endregion

            #region 4th exercise
            Console.WriteLine("Please Enter a number:  ");
            int d = Convert.ToInt32(Console.ReadLine());
            int m = 2;
            while (d % m != 0 && m < d)
            {
                m++;
            }
            if (m < d)
            {
                Console.WriteLine("Lo rishoni!!");

            }
            else
            {
                Console.WriteLine("Rishoni");
            }

            #endregion

            #region 5th exercise
            Console.WriteLine("Please enter your secret number: ");

            int secret = Convert.ToInt32(Console.ReadLine());
            // int secret = (new Random()).Next(1, 100);
            Console.WriteLine("Please enter guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            while (secret != guess)
            {
                if (guess < secret)
                {
                    Console.WriteLine("Too small");
                }
                else
                {
                    Console.WriteLine("Too big");
                }
                Console.WriteLine("Please enter another guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Bingo!");
            #endregion

            #region 6th exercise
            Console.WriteLine("Please enter a number: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int i2 = 2;
            int atz = 1;
            while (i2 <= a2)                             // איך עושים עצרת באנגלית : factorial
            {
                atz = atz * i2;
                i2++;
            }
            Console.WriteLine(atz);
            #endregion

            #region 7th exercise
            Console.WriteLine("Please enter a:");
            int a3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter b:");
            int b3 = Convert.ToInt32(Console.ReadLine());
            int i3 = 1;
            int sum3 = 0;
            while (i3 <= a3)                  // איך לעשות כפל בלי להשתמש בכפל
            {
                sum = sum + b3;
                i3++;
            }
            Console.WriteLine($"the Sum of a & b is: {sum3}");
            #endregion

        }
    }
}
