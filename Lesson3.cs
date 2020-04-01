using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Lesson3:myFirstFunction
    {
        
        static void Main(string[] args)
        {
            DividingStudentsToClassesMethod(); // EX 2
            MyPrimeMethod(); // EX 1
            NewMethod();    // Triangle 1st Function
            TriangleFuncUpdate(); // Ex 3
            TriangleOfStarsFunc();

            //    #region Card Game

            //    Console.WriteLine(" Hello dear guest!! \n Welcome to Battle Card Game");
            //    Console.WriteLine(" If you are ready to play please double press \"Enter\"\n");
            //    Console.ReadLine();

            //    int myScore = 0;
            //    int computerScore = 0;

            //    while (myScore < 5 && computerScore < 5)
            //    {
            //        //whos bigger card1>card2?
            //        Console.WriteLine("My Card: ");

            //        //me vrs computer get random card

            //        Random r = new Random();
            //        int card = r.Next(2, 15);


            //        PrintCard(card);


            //        // go to sleep
            //        System.Threading.Thread.Sleep(300);

            //        Console.WriteLine("Computer Card:");
            //        // me vrs computer
            //        // get random card
            //        int card1 = r.Next(2, 15);

            //        // print the card
            //        PrintCard(card1);

            //        // check who won
            //        if (card > card1)
            //        {
            //            // i won
            //            myScore++;
            //            Console.WriteLine("Player won!");
            //        }
            //        else if (card == card1)
            //        {
            //            // tie
            //            Console.WriteLine("Its a tie!!!");
            //        }
            //        else
            //        {
            //            // computer won
            //            computerScore++;
            //            Console.WriteLine("Computer won!");
            //        }
            //        Console.WriteLine($"My score = {myScore}");
            //        Console.WriteLine($"Computer score = {computerScore}");

            //        if (myScore != 5 && computerScore != 5)
            //        {
            //            Console.WriteLine("Ready for another round? press \"Enter\"");
            //            Console.ReadLine();
            //        }

            //    }
            //    Console.WriteLine("--- Game Over ---");

            //}

            //private static void PrintCard(int card)
            //{
            //    switch (card)
            //    {
            //        case 11:
            //            Console.WriteLine("J");
            //            break;
            //        case 12:
            //            Console.WriteLine("Q");
            //            break;
            //        case 13:
            //            Console.WriteLine("K");
            //            break;
            //        case 14:
            //            Console.WriteLine("A");
            //            break;
            //        case 15:
            //            Console.WriteLine("JOKER!!");
            //            break;
            //        default:
            //            Console.WriteLine(card);
            //            break;
            //    }
        }
        //#endregion



    }
}
