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

            Console.WriteLine("  {0}  |  {1}  |  {2}", gameField[0], gameField[1], gameField[2]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", gameField[3], gameField[4], gameField[5]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", gameField[6], gameField[7], gameField[8]);

            Console.WriteLine("     |     |      ");

        }

        public static void MakeAMoveX(string[] gameField)
        {
            string input_x1 = Console.ReadLine();
            int index = int.Parse(input_x1) - 1;
            gameField[index] = "x";
        }

        public static void MakeAMoveO(string[] gameField)
        {
            string input_x1 = Console.ReadLine();
            int index = int.Parse(input_x1) - 1;
            gameField[index] = "o";
            
        }




        public static void CheckIfGameIsWin(string[] gameField)

        {
            for (int i = 0; i < 9; i++)
            {
                if (

                      (  //horizontāli
                          (gameField[0] == gameField[1] && gameField[1] == gameField[2])

                          ||

                          (gameField[3] == gameField[4] && gameField[4] == gameField[5])

                          ||

                          (gameField[6] == gameField[7] && gameField[7] == gameField[8])

                      )

                     ||

                     ( // vertikāli
                         (gameField[0] == gameField[3] && gameField[3] == gameField[6])

                          ||

                          (gameField[1] == gameField[4] && gameField[4] == gameField[7])

                          ||

                          (gameField[2] == gameField[5] && gameField[5] == gameField[8])

                      )

                      ||
                      ( // diagonāli
                          (gameField[0] == gameField[4] && gameField[4] == gameField[8])

                          ||

                          (gameField[2] == gameField[4] && gameField[4] == gameField[6])

                      )
                 )

                    Console.WriteLine("Congratulations! You are the winner!");
                break;
            }
        }
    }
}






//
//trīs metodes
// viena metode

// board klasi uztaisīt ne-statisku. Laukuma printēšanu uztaisīt, pārrakstot uz toString metodi (sk. šodienas lekciju). 
// lai laukuma printēšana notiktu, kad ir toString metode...  Bet ir trikcky, jo ir vairākas līnijas. Artis cer, ka mēs tiksim galā..
// var lietot new line character = /r = ENTER = new line simbols




//if ((one == "x" && two == "x" && three == "x") || (four == "x" && five == "x" && six == "x") || (seven == "x" && eight == "x" && nine == "x")
//    || (one == "x" && four == "x" && seven == "x") || (two == "x" && five == "x" && eight == "x") || (three == "x" && six == "x" && nine == "x")
//    || (one == "x" && five == "x" && nine == "x") || (three == "x" && five == "x" && seven == "x"))
//{ Console.WriteLine("x = winner! :) "); };

//if ((one == "o" && two == "o" && three == "o") || (four == "o" && five == "o" && six == "o") || (seven == "o" && eight == "o" && nine == "o")
//    || (one == "o" && four == "o" && seven == "o") || (two == "o" && five == "o" && eight == "o") || (three == "o" && six == "o" && nine == "o")
//    || (one == "o" && five == "o" && nine == "o") || (three == "o" && five == "o" && seven == "o"))
//{ Console.WriteLine("o = winner! :) "); };


//Console.WriteLine("" +
//    "Thank you for the game, it is tie! :) " +
//    "To play again, press 's' ");
////visa spēle ir kā cikls. Spēles beigās būtu jāvar nokļūt uz sākumu, lai spēlētu vēlreiz.
// crtrl + k + c 



