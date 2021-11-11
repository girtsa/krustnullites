using System;

namespace NoslDar


{
    public class Program


    {
        public static void Main(string[] args)
        {
            string[] gameField = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };



            for (int i = 0; i < 10; i++)
            {
                Board.PrintGameBoard(gameField);
                bool isHorizontalWictory=Check_Win_Horizontal.CheckIfGameIsWinHorizontally(gameField);
                if (isHorizontalWictory)
                {
                    break;
                }
                bool isVerticalWictory=Check_Win_Vertical.CheckIfGameIsWinVertically(gameField);
                if (isVerticalWictory)
                {
                    break;
                }
                bool isDiagonalWictory=Check_Win_Diagonal.CheckIfGameIsWinDiagonally(gameField);
                if (isDiagonalWictory)
                {
                    break;
                }
                
                              
                if (i == 9)
                {
                    Console.WriteLine("It is tie!");
                }


                if (i % 2 == 0)
                {

                    Board.Moves.MakeAMoveX(gameField);
                    

                }
                else
                {
                    Board.Moves.MakeAMoveO(gameField);
                    
                }

                Console.Clear();

            }
        }

    }
}






//pēc noklusējuma spēli pirmais sāk X. 

/* 
Sākumā sistēma uz ekrāna parāda spēles laukumu (ar 1-9 cipariem un arī tekstu, ka pirmais spēlētājs ir X, otrais ir 0 . Un vēl kaut kādus spēles noteikumus, kad ir uzvara utt). 

 * Sistēma iksam piedāvā rakstīt kādu no cipariem 
konsole readline = ikss ieraksta ciparu

Un tad sistēmai jāizdod uz ekrāna, tas ko X jeb Player1 ir ierakstījis.

Tad sistēma parāda Player2, please, choose number un te jau sistēmai būtu jāpiedāvā no atlikušajiem

Un tad sistēmai jāizdod uz ekrāna, tas ko X ir ierakstījis un ko Player2 jeb 0 ir ierakstījis

Tad atkal 










*/


