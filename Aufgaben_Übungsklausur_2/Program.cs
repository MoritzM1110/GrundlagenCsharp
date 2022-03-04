using System;

namespace MeinErstesVSPMoritz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Aufgabe 4");

            Console.WriteLine("Bitte geben sie ihr Alter ein:");

            int alter = Convert.ToInt32(Console.ReadLine());


            while (alter <= 0 || alter >= 120)
            {
                Console.WriteLine("Ihr Alter passt nicht!\nBitte geben sie erneut ihr Alter ein!");
                alter = Convert.ToInt32(Console.ReadLine());
            }

            if (alter < 18)
            {
                Console.WriteLine("Der Download wird verweigert!");
            }
            else
            {
                Console.WriteLine("Der Download wird bestätigt!");
            }

            Console.WriteLine("Aufgabe 5");
            Console.WriteLine("Geben sie ihre Firmenzugehörigkeit in Jahren ein!");
            int zugehörigkeit = Convert.ToInt32(Console.ReadLine());

            if (zugehörigkeit >= 20)
            {
                Console.WriteLine("Herzlischen Glückwunsch zum 20-jährigen Dienstjubiläum.");
            }
            else if (zugehörigkeit >= 40)
            {
                Console.WriteLine("HerzlichenDankfür40JahreEnergie,EinsatzundTeamgeist.");
            }



        }
    }
}