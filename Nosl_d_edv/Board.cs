using System;
using System.Collections.Generic;
using System.Text;

namespace NoslDar
{
    //public class Board : Program  //kā te šajā klasē var ielikt atsauci uz Program klasi? 
    // Tobiš kā panākt, ka te tas "one" ir no tās Program klases?


    public class Board
    {
        public static void PrintGameBoard(string[] gameField)
        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", gameField[1], gameField[2], gameField[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", gameField[4], gameField[5], gameField[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", gameField[7], gameField[8], gameField[9]);

            Console.WriteLine("     |     |      ");

        }

        public static void MakeAMoveX(string[] gameField)
        {
            string input_x1 = Console.ReadLine();
            int index = int.Parse(input_x1) -1 ;
            Console.Clear();
            gameField[index] = "x";
        }

        public static void MakeAMoveO(string[] gameField)
        {
            string input_x1 = Console.ReadLine();
            int index = int.Parse(input_x1) - 1;
            Console.Clear();
            gameField[index] = "o";
        }

    }
}


