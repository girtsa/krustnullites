
using System;
using System.Threading;

namespace NoslDar
{
    public class Check_Win_Vertical

    {

        public static bool CheckIfGameIsWinVertically(string[] gameField)

        {
            for (int i = 0; i < 9; i++)
            {
                if

                   ( // vertikāli
                             (gameField[0] == gameField[3] && gameField[3] == gameField[6])

                              ||

                              (gameField[1] == gameField[4] && gameField[4] == gameField[7])

                              ||

                              (gameField[2] == gameField[5] && gameField[5] == gameField[8])

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