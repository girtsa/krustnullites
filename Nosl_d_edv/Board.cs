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



            Console.WriteLine("                  ");
            Console.WriteLine("    TicTacToe     ");
            Console.WriteLine("                  ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", gameField[0], gameField[1], gameField[2]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", gameField[3], gameField[4], gameField[5]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", gameField[6], gameField[7], gameField[8]);

            Console.WriteLine("     |     |      ");

        }

        public class Moves : Board
        {

            public static void MakeAMoveX(string[] gameField)
            {
                Console.WriteLine("Player X, please, choose and enter one of remaining numbers!");
                               
                int userNumberInput = Board.Moves.GetNumber();
                int index = userNumberInput - 1;
                if (gameField[index] == "x" || gameField[index] == "o")
                {
                    Console.WriteLine("It is already used! Choose another field!");
                    MakeAMoveX(gameField);
                }
                else
                { gameField[index] = "x"; }

            }

            public static void MakeAMoveO(string[] gameField)
            {
                Console.WriteLine("Player O, please, choose and enter one of remaining numbers!");
                int userNumberInput = Board.Moves.GetNumber();

                int index = userNumberInput - 1;
                if (gameField[index] == "x" || gameField[index] == "o")
                {
                    Console.WriteLine("It is already used! Choose another field!");
                    MakeAMoveO(gameField);
                }
                else
                { gameField[index] = "o"; }
                

            }


            private static int GetNumber()
            {


                string userNumberInput = Console.ReadLine();
                int userNumber;

                try
                {
                    userNumber = int.Parse(userNumberInput);

                    if (userNumber > 9 || userNumber < 1)
                    {
                        throw new NumberLargerThanNineException("Aplikācija atbalsta skaitļus tikai no 1 līdz 9.");
                    }





                }
                catch (FormatException)
                {
                    Console.WriteLine($"You entered: { userNumberInput} But only numbers (1-9 and if not already used) can be entered. Try again! :)");
                    userNumber = GetNumber();
                }


                catch (NumberLargerThanNineException exception)
                {
                    Console.WriteLine(exception.Message);
                    userNumber = GetNumber();
                }


                return userNumber;
            }

        
            public string GetNumber(int number)
            {
                string text = "";

                if ( number <= 9)
                {
                    text += "OK";
                }

                if (number >=10)
                {
                    text += "OutOfArray";
                }

                if (string.IsNullOrWhiteSpace(text))
                {
                    return number.ToString();
                }

                return text;
            }
        }
    }
}




