using System;

namespace NoslDar


{
    public class Program

    {
       public static void Main(string[] args)
        {
            string[] gameField = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };


            
            
            for (int i = 0; i < 9; i++)
            {
                Board.PrintGameBoard(gameField);
                if (i %2 ==1)
                {
                Board.MakeAMoveX(gameField);
                }
                else
                {
                Board.MakeAMoveO(gameField);
                }
                Console.Clear();

            }




            // while   pēc katra gājiena jau pārbauda vai beidzas spēle  (vai ir 3 rindā) 
            //Ja iestājas uzvara, iet ārā no cikla un attēlo, ka beigas.
            // vajag vismaz vienu unit testu. Piem., lietotājs ievada, kaut ko, kas nav 1-9. 



            /*
                        if ((one == "x" && two == "x" && three == "x") || (four == "x" && five == "x" && six == "x") || (seven == "x" && eight == "x" && nine == "x")
                            || (one == "x" && four == "x" && seven == "x") || (two == "x" && five == "x" && eight == "x") || (three == "x" && six == "x" && nine == "x")
                            || (one == "x" && five == "x" && nine == "x") || (three == "x" && five == "x" && seven == "x"))
                        { Console.WriteLine("x = winner! :) "); };

                        if ((one == "o" && two == "o" && three == "o") || (four == "o" && five == "o" && six == "o") || (seven == "o" && eight == "o" && nine == "o")
                            || (one == "o" && four == "o" && seven == "o") || (two == "o" && five == "o" && eight == "o") || (three == "o" && six == "o" && nine == "o")
                            || (one == "o" && five == "o" && nine == "o") || (three == "o" && five == "o" && seven == "o"))
                        { Console.WriteLine("o = winner! :) "); };


                        Console.WriteLine("" +
                            "Thank you for the game, it is tie! :) " +
                            "To play again, press 's' ");
                        //visa spēle ir kā cikls. Spēles beigās būtu jāvar nokļūt uz sākumu, lai spēlētu vēlreiz.

            */




            //Edvarts testē
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


