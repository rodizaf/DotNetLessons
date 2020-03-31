using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotNetBasics
{
    class Lesson2
    {
      
        static void Main(string[] args)
        {

            #region Exercise 1 for's
            for (int i = 1; i <= 2000; i++)            //1
            {
                Console.WriteLine(i);
            }
            for (int i = 2; i <= 100; i += 2)        //1.a
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i <= 100; i += 10)       // 1.b
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Exercise 2 for's
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);       //2
            }
            #endregion

            #region Exercise 3 if's
            Console.WriteLine("Please Choose a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 10 && a <= 99)
            {
                Console.WriteLine($"You Choose: {a}");

                int ahadot = a % 10;
                Console.WriteLine($"ahddot is {ahadot}");     //3

                int asarot = a / 10;
                Console.WriteLine($"asarot is {asarot}");

                if (asarot > ahadot)
                {
                    Console.WriteLine("ASAROT!!");
                }
                else
                {
                    Console.WriteLine("AHDAOT!!!!!!");
                }
            }
            #endregion

            #region Exercise 4 PrimeNumbers
            for (int j = 1; j <= 100; j++)
            {
                int m = 2;
                int x = j;

                while (x % m != 0 && m < x)
                {
                    m++;
                }
                if (x == m || x == 1)
                {                                         // 4
                    Console.WriteLine($"Rishoni: {j}");   // getting all prime numbers from 1-100

                }
                else
                {
                    Console.WriteLine($"Lo Rishoni: {j}");
                }
            }
            #endregion

            #region Exercise 5 Dividing money into it's bills value
            Console.WriteLine("Please enter the sum of money: ");
            int money = Convert.ToInt32(Console.ReadLine());
            if (money>=200)
            {
                int shtarotMataim = money / 200;
                money = money - shtarotMataim * 200;
                Console.WriteLine($"200$: {shtarotMataim}");
            } if (money>=100)
            {
                int shtarotMea = money / 100;
                money = money - shtarotMea * 100;
                Console.WriteLine($"100$: {shtarotMea}");
            } 
            if (money>=50)
            {
                int shtarotHamishim = money / 50;
                money = money - shtarotHamishim * 50;
                Console.WriteLine($"50$: {shtarotHamishim}");
            } 
            if (money>=20)
            {
                int shtarotEsrim = money / 20;
                money = money - shtarotEsrim * 20;
                Console.WriteLine($"20$: {shtarotEsrim}");
            } 
            if (money>=10)
            {
                int asiriyot = money / 10;
                money = money - asiriyot * 10;
                Console.WriteLine($"10$: {asiriyot}");
            } 
            if (money>=5)
            {
                int hamishiyot = money / 5;
                money = money - hamishiyot * 5;
                Console.WriteLine($"5$: {hamishiyot}");
            } 
            if (money>=2)
            {
                int shnekelim = money / 2;
                money = money - shnekelim * 2;
                Console.WriteLine($"2$: {shnekelim}");
            }  
            if (money>=1)
            {
                int shkalim = money / 1;
                money = money - shkalim * 1;
                Console.WriteLine($"1$: {shkalim}");
            }
            #endregion

            #region Exercise 6 Printing triangle using nums/*'s
            Console.WriteLine("Please enter a number you like: ");
            int chosenNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:");
            for (int i = 1; i <= chosenNum; i++)
            {
                for (int j = 1; j <= chosenNum; j++)
                {
                    if (j > i)
                    {
                        Console.Write('*');              //version 1
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Result:");
            for (int i2 = 1; i2 <= chosenNum; i2++)
            {
                for (int j = 1; j <= i2; j++)
                {
                    Console.Write(j);
                }
                                                              //version 2 without if
                for (int j = i2 + 1; j <= chosenNum; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            #endregion

        }



    }
    }

