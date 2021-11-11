
using System;


namespace NoslDar
{
    public class Check_Win_Horizontal

    {
        public static bool CheckIfGameIsWinHorizontally(string[] gameField)

        {
            for (int i = 0; i < 9; i++)
            {
                if                    

                      (  //horizontāli
                          (gameField[0] == gameField[1] && gameField[1] == gameField[2])

                          || (gameField[3] == gameField[4] && gameField[4] == gameField[5])

                          || (gameField[6] == gameField[7] && gameField[7] == gameField[8])

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