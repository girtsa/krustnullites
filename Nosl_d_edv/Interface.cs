using System;
using System.Collections.Generic;
using System.Text;

namespace Nosl_d_edv
{
    public class Interface
    {
        private static IWriter consoleWriter;

        public static void First(string[] args)
        {
            Value O = Value.O;

            int ONumber = (int)Value.O;

            Console.WriteLine($"O enum text value: {O}");
            Console.WriteLine($"O numeber value: {ONumber}");


            var Symbol = new Symbol
            {
                Player = "One",
                Value = Value.O
            };

            Console.WriteLine($"Hello my player is {Symbol.O} and I am { Symbol.Value}");
            Console.WriteLine(value: $"Hello my player is {Symbol.O} and I am {Symbol.Value}");

            //
           // iWriter consolewriter = new consoleWriter();
           // FileWriter fileWriter1 = new FileWriter();
           // iWriter fileWriter = (iWriter)fileWriter1;






        }
    }
}
