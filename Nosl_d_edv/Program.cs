using System;

namespace NoslDar


{
    public class Program

    {
        static void Main(string[] args)
        {

            string one = "1";
            string two = "2";
            string three = "3";
            string four = "4";
            string five = "5";
            string six = "6";
            string seven = "7";
            string eight = "8";
            string nine = "9";
           

            Console.WriteLine("Noteikumi u.c.");
            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);



            string input_x1 = Console.ReadLine();
            Console.Clear();
            if (input_x1 == one)
            { one = "x"; };
            if (input_x1 == two)
            { two = "x"; };
            if (input_x1 == three)
            { three = "x"; };
            if (input_x1 == four)
            { four = "x"; };
            if (input_x1 == five)
            { five = "x"; };
            if (input_x1 == six)
            { six = "x"; };
            if (input_x1 == seven)
            { seven = "x"; };
            if (input_x1 == eight)
            { eight = "x"; };
            if (input_x1 == nine)
            { nine = "x"; };



            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);

            string input_o1 = Console.ReadLine();
            Console.Clear();

            if (input_o1 == one)
            { one = "o"; };
            if (input_o1 == two)
            { two = "o"; };
            if (input_o1 == three)
            { three = "o"; };
            if (input_o1 == four)
            { four = "o"; };
            if (input_o1 == five)
            { five = "o"; };
            if (input_o1 == six)
            { six = "o"; };
            if (input_o1 == seven)
            { seven = "o"; };
            if (input_o1 == eight)
            { eight = "o"; };
            if (input_o1 == nine)
            { nine = "o"; };

            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);


            //string[] Laukums = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            //while 
            // if ()


            string input_x2 = Console.ReadLine();
            Console.Clear();

            if (input_x2 == one)
            { one = "x"; };
            if (input_x2 == two)
            { two = "x"; };
            if (input_x2 == three)
            { three = "x"; };
            if (input_x2 == four)
            { four = "x"; };
            if (input_x2 == five)
            { five = "x"; };
            if (input_x2 == six)
            { six = "x"; };
            if (input_x2 == seven)
            { seven = "x"; };
            if (input_x2 == eight)
            { eight = "x"; };
            if (input_x2 == nine)
            { nine = "x"; };

            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);


            // while   pēc katra gājiena jau pārbauda vai beidzas spēle  (vai ir 3 rindā) 
            //Ja iestājas uzvara, iet ārā no cikla un attēlo, ka beigas.
            // vajag vismaz vienu unit testu. Piem., lietotājs ievada, kaut ko, kas nav 1-9. 

            string input_o2 = Console.ReadLine();
            Console.Clear();

            if (input_o2 == one)
            { one = "o"; };
            if (input_o2 == two)
            { two = "o"; };
            if (input_o2 == three)
            { three = "o"; };
            if (input_o2 == four)
            { four = "o"; };
            if (input_o2 == five)
            { five = "o"; };
            if (input_o2 == six)
            { six = "o"; };
            if (input_o2 == seven)
            { seven = "o"; };
            if (input_o2 == eight)
            { eight = "o"; };
            if (input_o2 == nine)
            { nine = "o"; };



            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);



            string input_x3 = Console.ReadLine();
            Console.Clear();

            if (input_x3 == one)
            { one = "x"; };
            if (input_x3 == two)
            { two = "x"; };
            if (input_x3 == three)
            { three = "x"; };
            if (input_x3 == four)
            { four = "x"; };
            if (input_x3 == five)
            { five = "x"; };
            if (input_x3 == six)
            { six = "x"; };
            if (input_x3 == seven)
            { seven = "x"; };
            if (input_x3 == eight)
            { eight = "x"; };
            if (input_x3 == nine)
            { nine = "x"; };


            if ((one == "x" && two == "x" && three == "x") || (four == "x" && five == "x" && six == "x") || (seven == "x" && eight == "x" && nine == "x")
                || (one == "x" && four == "x" && seven == "x") || (two == "x" && five == "x" && eight == "x") || (three == "x" && six == "x" && nine == "x")
                || (one == "x" && five == "x" && nine == "x") || (three == "x" && five == "x" && seven == "x"))
            { Console.WriteLine("x = winner! :) "); };

            if ((one == "o" && two == "o" && three == "o") || (four == "o" && five == "o" && six == "o") || (seven == "o" && eight == "o" && nine == "o")
                || (one == "o" && four == "o" && seven == "o") || (two == "o" && five == "o" && eight == "o") || (three == "o" && six == "o" && nine == "o")
                || (one == "o" && five == "o" && nine == "o") || (three == "o" && five == "o" && seven == "o"))
            { Console.WriteLine("o = winner! :) "); };


            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);


            string input_o3 = Console.ReadLine();
            Console.Clear();

            if (input_o3 == one)
            { one = "o"; };
            if (input_o3 == two)
            { two = "o"; };
            if (input_o3 == three)
            { three = "o"; };
            if (input_o3 == four)
            { four = "o"; };
            if (input_o3 == five)
            { five = "o"; };
            if (input_o3 == six)
            { six = "o"; };
            if (input_o3 == seven)
            { seven = "o"; };
            if (input_o3 == eight)
            { eight = "o"; };
            if (input_o3 == nine)
            { nine = "o"; };

            if ((one == "x" && two == "x" && three == "x") || (four == "x" && five == "x" && six == "x") || (seven == "x" && eight == "x" && nine == "x")
                            || (one == "x" && four == "x" && seven == "x") || (two == "x" && five == "x" && eight == "x") || (three == "x" && six == "x" && nine == "x")
                            || (one == "x" && five == "x" && nine == "x") || (three == "x" && five == "x" && seven == "x"))
            { Console.WriteLine("x = winner! :) "); };

            if ((one == "o" && two == "o" && three == "o") || (four == "o" && five == "o" && six == "o") || (seven == "o" && eight == "o" && nine == "o")
                || (one == "o" && four == "o" && seven == "o") || (two == "o" && five == "o" && eight == "o") || (three == "o" && six == "o" && nine == "o")
                || (one == "o" && five == "o" && nine == "o") || (three == "o" && five == "o" && seven == "o"))
            { Console.WriteLine("o = winner! :) "); };


            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);


            string input_x4 = Console.ReadLine();
            Console.Clear();

            if (input_x4 == one)
            { one = "x"; };
            if (input_x4 == two)
            { two = "x"; };
            if (input_x4 == three)
            { three = "x"; };
            if (input_x4 == four)
            { four = "x"; };
            if (input_x4 == five)
            { five = "x"; };
            if (input_x4 == six)
            { six = "x"; };
            if (input_x4 == seven)
            { seven = "x"; };
            if (input_x4 == eight)
            { eight = "x"; };
            if (input_x4 == nine)
            { nine = "x"; };

            if ((one == "x" && two == "x" && three == "x") || (four == "x" && five == "x" && six == "x") || (seven == "x" && eight == "x" && nine == "x")
                            || (one == "x" && four == "x" && seven == "x") || (two == "x" && five == "x" && eight == "x") || (three == "x" && six == "x" && nine == "x")
                            || (one == "x" && five == "x" && nine == "x") || (three == "x" && five == "x" && seven == "x"))
            { Console.WriteLine("x = winner! :) "); };

            if ((one == "o" && two == "o" && three == "o") || (four == "o" && five == "o" && six == "o") || (seven == "o" && eight == "o" && nine == "o")
                || (one == "o" && four == "o" && seven == "o") || (two == "o" && five == "o" && eight == "o") || (three == "o" && six == "o" && nine == "o")
                || (one == "o" && five == "o" && nine == "o") || (three == "o" && five == "o" && seven == "o"))
            { Console.WriteLine("o = winner! :) "); };


            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);




            string input_o4 = Console.ReadLine();
            Console.Clear();

            if (input_o4 == one)
            { one = "o"; };
            if (input_o4 == two)
            { two = "o"; };
            if (input_o4 == three)
            { three = "o"; };
            if (input_o4 == four)
            { four = "o"; };
            if (input_o4 == five)
            { five = "o"; };
            if (input_o4 == six)
            { six = "o"; };
            if (input_o4 == seven)
            { seven = "o"; };
            if (input_o4 == eight)
            { eight = "o"; };
            if (input_o4 == nine)
            { nine = "o"; };


            if ((one == "x" && two == "x" && three == "x") || (four == "x" && five == "x" && six == "x") || (seven == "x" && eight == "x" && nine == "x")
                            || (one == "x" && four == "x" && seven == "x") || (two == "x" && five == "x" && eight == "x") || (three == "x" && six == "x" && nine == "x")
                            || (one == "x" && five == "x" && nine == "x") || (three == "x" && five == "x" && seven == "x"))
            { Console.WriteLine("x = winner! :) "); };

            if ((one == "o" && two == "o" && three == "o") || (four == "o" && five == "o" && six == "o") || (seven == "o" && eight == "o" && nine == "o")
                || (one == "o" && four == "o" && seven == "o") || (two == "o" && five == "o" && eight == "o") || (three == "o" && six == "o" && nine == "o")
                || (one == "o" && five == "o" && nine == "o") || (three == "o" && five == "o" && seven == "o"))
            { Console.WriteLine("o = winner! :) "); };


            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);

            string input_x5 = Console.ReadLine();
            Console.Clear();

            if (input_x5 == one)
            { one = "x"; };
            if (input_x5 == two)
            { two = "x"; };
            if (input_x5 == three)
            { three = "x"; };
            if (input_x5 == four)
            { four = "x"; };
            if (input_x5 == five)
            { five = "x"; };
            if (input_x5 == six)
            { six = "x"; };
            if (input_x5 == seven)
            { seven = "x"; };
            if (input_x5 == eight)
            { eight = "x"; };
            if (input_x5 == nine)
            { nine = "x"; };


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


