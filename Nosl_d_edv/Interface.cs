using System;
using System.Collections.Generic;
using System.Text;

namespace Nosl_d_edv
{
    class Interface
    {
        private static IWrite consoleWrite;

        public static void Main(string[] args)
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


        }
    }
}
