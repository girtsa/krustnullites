
using System;


namespace NoslDar
{
    public class Check_Tie

    {

        public static bool CheckIfGameIsTie(string[] gameField)

        {
            for (int i = 0; i < 9; i++)
            {
                if  //vai ir neizšķirts?

                    (
                        gameField[0] != "1" && gameField[1] != "2" && gameField[2] != "3"
                     && gameField[3] != "4" && gameField[4] != "5" && gameField[5] != "6"
                     && gameField[6] != "7" && gameField[7] != "8" && gameField[8] != "9"
                    )

                {
                    Console.WriteLine("It is tie!");   //jāpamēģina šo ielikt pie iepriekšējās metodes zem else if!!
                    return true;
                }

            }
            return false;
        }
    }
}
