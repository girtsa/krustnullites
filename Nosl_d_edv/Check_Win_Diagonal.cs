
using System;


namespace NoslDar
{
    public class Check_Win_Diagonal

    {

        public static bool CheckIfGameIsWinDiagonally(string[] gameField)

        {
            for (int i = 0; i < 9; i++)
            {
                if

                    ( // diagonāli
                              (gameField[0] == gameField[4] && gameField[4] == gameField[8])

                              ||

                              (gameField[2] == gameField[4] && gameField[4] == gameField[6])

                          )

                {
                    Console.WriteLine("Congratulations! You are the winner!");
                    return true;
                }
                
            }
            return false;
        }

    }
}