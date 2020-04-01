using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
   public class myFirstFunction
    {
        #region 1stFunction making Triangle from numbers
        public static void NewMethod()
        {
            Console.WriteLine("doing work...");
            Console.WriteLine("Enter number for triangle:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
        #endregion

        #region Hw Exercise 1
        public static void MyPrimeMethod()
        {
            Console.WriteLine("PrimeMethod working...");
            Console.WriteLine("Please enter a number of your choice: ");
            int m = 0;
            int x = 0;
            while (x == m)
            {

                m = 2;
                x = Convert.ToInt32(Console.ReadLine());


                while (x % m != 0 && m < x)
                {
                    m++;
                }
                if (x > m)
                {
                    Console.WriteLine($"Lo Rishoni: {x}");
                }
                else
                {
                    Console.WriteLine($"Rishoni: {x}");

                }
            }

        }
#endregion

        #region Hw Exercise 2
        public static void DividingStudentsToClassesMethod()
        {
            Console.WriteLine("Please enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            
            if (numberOfStudents>=100)
            {
                int kitotShelMea = numberOfStudents / 100;
                numberOfStudents = numberOfStudents - kitotShelMea * 100;
                Console.WriteLine($"{kitotShelMea} Classes of 100 students");
            }   
            if (numberOfStudents>=30&&numberOfStudents<100)
            {
                int kitotShelShloshim = numberOfStudents / 30;
                numberOfStudents = numberOfStudents - kitotShelShloshim * 30;
                Console.WriteLine($"{kitotShelShloshim} Classes of 30 students");
            }  
            if (numberOfStudents>=10&&numberOfStudents<30)
            {
                int kitotShelEser = numberOfStudents / 10;
                numberOfStudents = numberOfStudents - kitotShelEser * 10;
                Console.WriteLine($"{kitotShelEser} Classes of 10 students");
            }
            if (numberOfStudents>=1&&numberOfStudents<10)
            {
                int talmidimBodedim = numberOfStudents / 1;
                numberOfStudents = numberOfStudents - talmidimBodedim * 1;
                Console.WriteLine($"{talmidimBodedim} students went home");
            }
        }
        #endregion
        #region Hw Exercise 3
        public static void TriangleFuncUpdate()
        {
            Console.WriteLine("Please choose number for the triangle: ");
            int rows = Convert.ToInt32(Console.ReadLine()); // read a number
            // run from 1 -> rows
            for (int i = 1; i <= rows; i++)
            {

                // print all numbers from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); // print j do not line feed
                }

                Console.WriteLine(); // line feed
            }
            for (int i = rows - 1; i >= 1; i--)
            {

                // print all numbers from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); // print j do not line feed
                }

                Console.WriteLine(); // line feed
            }
        }
        #endregion 

        public static void TriangleOfStarsFunc()
        {
            int stars = Convert.ToInt32(Console.ReadLine()); // read a number

            int i = 1; // number of starts i am drawing in the current row

            int spaces = stars / 2; // number of spaces in each row

            while (i <= stars)
            {
                // draw the spaces
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(' ');
                }

                // draw the stars
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();

                // add 2 to i
                i = i + 2;

                // decrease 1 to spaces
                spaces = spaces - 1;
            }
        }

    }


}

