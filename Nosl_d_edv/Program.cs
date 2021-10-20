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
            string player1 = "X";
            string player2 = "0";


            Console.WriteLine("Noteikumi u.c.");
            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);
            


            string input1 = Console.ReadLine();
            Console.Clear();
            if (input1 ==  one)
            { one = "x"; };
            if (input1 == two)
            { two = "x"; };
            if (input1 == three)
            { three = "x"; };
            if (input1 == four)
            { four = "x"; };
            if (input1 == five)
            { five = "x"; };
            if (input1 == six)
            { six = "x"; };
            if (input1 == seven)
            { seven = "x"; };
            if (input1 == eight)
            { eight = "x"; };
            if (input1 == nine)
            { nine = "x"; };



            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);
            
           string input2 = Console.ReadLine();
            Console.Clear();

            if (input2 == one)
            { one = "0"; };
            if (input2 == two)
            { two = "0"; };
            if (input2 == three)
            { three = "0"; };
            if (input2 == four)
            { four = "0"; };
            if (input2 == five)
            { five = "0"; };
            if (input2 == six)
            { six = "0"; };
            if (input2 == seven)
            { seven = "0"; };
            if (input2 == eight)
            { eight = "0"; };
            if (input2 == nine)
            { nine = "0"; };


            // while   pēc katra gājiena jau pārbauda vai beidzas spēle  (vai ir 3 rindā) 
            //Ja iestājas uzvara, iet ārā no cikla un attēlo, ka beigas.
            // vajag vismaz vienu unit testu. Piem., lietotājs ievada, kaut ko, kas nav 1-9. 


            Console.WriteLine(one + "  | " + two + "   | " + three);
            Console.WriteLine("  --------------");
            Console.WriteLine(four + "  | " + five + "   | " + six);
            Console.WriteLine("  --------------");
            Console.WriteLine(seven + "  | " + eight + "   | " + nine);








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


