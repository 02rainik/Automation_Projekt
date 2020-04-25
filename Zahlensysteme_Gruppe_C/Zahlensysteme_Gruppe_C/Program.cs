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
        /// 0 = Nix / 1 = Hex / 2 = Dec
        /// </summary>
        static int HexorDec = 4;
        /// <summary>
        /// Auswahl zwischen Hex ind Bin
        /// </summary>
        /// <param name="Eingabe">Benuzer Eingabe</param>
        static void Switch(string Auswahl, string BinZahl)
        {
            bool BoolHexorDec = false;
            for (int i = 0; i < BinZahl.Length; i++)
			{
                if (Convert.ToInt32(BinZahl.Substring(i, 1)) == 0 || Convert.ToInt32(BinZahl.Substring(i, 1)) == 1)
                {
                    BoolHexorDec = true;
                }
                else
                {
                    BoolHexorDec = false;
                }
			}
            if (BoolHexorDec)
            {
                switch (Auswahl)
                {
                    case "Hex":
                        HexorDec = 1;
                        break;

                    case "Dec":
                        HexorDec = 2;
                        break;

                    default:
                        HexorDec = 0;
                        Console.WriteLine("Fehlerhafte Eingabe");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Eingabe ist keine Binärzahl");
            }
            

            
        }
    }
}

