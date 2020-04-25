using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zahlensysteme_Gruppe_C
{
    class Program
    {
        /// <summary>
        /// Zahlensysteme_Gruppe_C
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           Console.ReadKey();
        }

        /// <summary>
        /// Auswahl zwischen Hex ind Bin
        /// </summary>
        /// <param name="Eingabe">Benuzer Eingabe</param>
        static void Switch(string Eingabe = " ")
        {
            switch (Eingabe)
            {
                case "Hex":
                    //Methode Hex
                    break;

                case "Bin":
                    //Methode Bin
                    break;

                default:
                    Console.WriteLine("Error 2");
                    break;
            }
        }
        void BinToHex(string Zahl)
        {
            string Hex = String.Format("{0:X4}", Convert.ToInt32(Zahl, 2));

            Console.WriteLine("Die Zahl in Hexadecimal ist: " + Hex);
        }
    }
}
