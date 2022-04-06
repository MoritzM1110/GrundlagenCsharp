using System;

namespace Hotel_Methode
{
    class Program
    {
        static void Main()
        {
            do
            {
                int Auswahl;
                short eingabe_short;
                string eingabe_string;
                bool flag = false;

                short[] zimmernummer = { 45, 23, 3, 32 };
                string[] vorname = { "John", "Paul", "George", "Ringo" };
                string[] nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
                short[] übernachtungen = { 1, 4, 12, 3 };
                double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };




                Console.WriteLine("Bitte geben sie ihre Daten ein");
                eingabe_string = Console.ReadLine();
                flag = short.TryParse(eingabe_string, out eingabe_short);




                if (flag == false)
                {
                  var daten = (eingabe_string, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag);
                    
                }
                else
                {
                  var daten = (eingabe_short, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag);

                }




            } while (true);


        }



        static (bool, short, string, string, short, double) 
        

        

       
        













    }
} 
