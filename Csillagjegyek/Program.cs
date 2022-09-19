using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csillagjegyek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bekér egy dátumot és kiírja, melyik csillagjegybe esik.
            Console.WriteLine("Adj meg egy dátumot hónap-nap formátumban (pl.: 5-28): ");  
            int[] datum = HelyesFormatum();
            string csillagjegy = MelyikCsillagjegy(datum[0], datum[1]);

            Console.WriteLine(csillagjegy);

            Console.ReadKey();
        }

        private static string MelyikCsillagjegy(int honap, int nap)
        {
            if ((honap == 3 && nap >= 21 && nap <= 31) || honap == 4 && nap >= 1 && nap <= 20)
            {
                return "Kos";
            }
            else if ((honap == 4 && nap >= 21 && nap <= 30) || honap == 5 && nap >= 1 && nap <= 21)
            {
                return "Bika";
            }
            else if ((honap == 5 && nap >= 22 && nap <= 31) || honap == 6 && nap >= 1 && nap <= 21)
            {
                return "Ikrek";
            }
            else if ((honap == 6 && nap >= 22 && nap <= 30) || honap == 7 && nap >= 1 && nap <= 22)
            {
                return "Rák";
            }
            else if ((honap == 7 && nap >= 23 && nap <= 31) || honap == 8 && nap >= 1 && nap <= 23)
            {
                return "Oroszlán";
            }
            else if ((honap == 8 && nap >= 24 && nap <= 31) || honap == 9 && nap >= 1 && nap <= 22)
            {
                return "Szűz";
            }
            else if ((honap == 9 && nap >= 23 && nap <= 30) || honap == 10 && nap >= 1 && nap <= 23)
            {
                return "Mérleg";
            }
            else if ((honap == 10 && nap >= 24 && nap <= 31) || honap == 11 && nap >= 1 && nap <= 22)
            {
                return "Skorpió";
            }
            else if ((honap == 11 && nap >= 23 && nap <= 30) || honap == 12 && nap >= 1 && nap <= 21)
            {
                return "Nyilas";
            }
            else if ((honap == 12 && nap >= 22 && nap <= 31) || honap == 1 && nap >= 1 && nap <= 22)
            {
                return "Bak";
            }
            else if ((honap == 1 && nap >= 21 && nap <= 31) || honap == 2 && nap >= 1 && nap <= 19)
            {
                return "Vízöntő";
            }
            else if ((honap == 2 && nap >= 20 && nap <= 29) || honap == 3 && nap >= 1 && nap <= 20)
            {
                return "Halak";
            }
            else
            {
                return "Nem létező dátum.";
            }

        }

        private static int[] HelyesFormatum()
        {
            bool helyesE = true;
            int[] datum = new int[2];
            do
            {
                helyesE = true;
                try
                {
                    string felhasznalotolKapottErtek = Console.ReadLine();
                    string[] darabolt = felhasznalotolKapottErtek.Split('-');
                    int honap = int.Parse(darabolt[0]);
                    int nap = int.Parse(darabolt[1]);
                    if (honap <= 0 || honap > 12 || nap <= 0 || nap > 31)
                    {
                        helyesE = HibaUzenetHelytelen();
                    }
                    datum[0] = honap;
                    datum[1] = nap;

                }
                catch
                {
                    helyesE = HibaUzenetHelytelen();
                }

            } while (!helyesE);

            return datum;
        }

        private static bool HibaUzenetHelytelen()
        {
            Console.WriteLine("Hibás érték! Adj meg újat!");
            return false;
        }

    }
}
