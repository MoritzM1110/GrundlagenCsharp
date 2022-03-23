using System;

namespace Methoden_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {


            bool richtig = true;
            do
            {
                richtig = true;
                Console.WriteLine("Geben sie die Anzahl der durchläufe ein?");
                int durchlauf = Convert.ToInt32(Console.ReadLine());

                if (durchlauf < 0 & durchlauf > 1000)
                {
                    richtig = false;
                    Console.WriteLine("Bitte geben sie eine Richtige Zahl ein!");
                    Console.ReadLine();
                    Console.Clear();


                } while (richtig == false) ;

                bool richtig2 = true;
                do
                {
                    richtig2 = true;
                    Console.WriteLine("Gebn sie bitte ihre Buchstaben ein");
                    string text = Console.ReadLine();

                    if (durchlauf < 1 | durchlauf > 1000)
                    {
                        richtig2 = false;
                        Console.WriteLine("Bitte geben sie eine Gültige eingabe ein!");
                        Console.ReadKey();
                        Console.Clear();
                    }




                } while (richtig2 == false);

                int anzahl = 0;



                int anzahl_zeichen = 0;


                anzahl_zeichen = ausgabeTextMalX(durchlauf, text);
                Console.Write("\nAnzahl der Buchstaben: {0}", anzahl_zeichen);
            }

        static int ausgabeTextMalX(int durchlauf, string text)
            {
                for (int i = 0; i < durchlauf; i++)
                {
                    Console.WriteLine(text);


                }

                return text.Length * durchlauf;


        }


    }
}



