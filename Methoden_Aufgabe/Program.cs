using System;

namespace Methoden_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {


            string durchlauf;
            string text;
            int num;


            bool richtig = true;
            do
            {
                richtig = true;
                Console.WriteLine("Geben sie bitte die Anzahl der Durchläufe ein:");
                durchlauf = Console.ReadLine();
                if (!Int32.TryParse(durchlauf, out num))
                {
                    richtig = false;
                    Console.WriteLine("Bitte geben sie eine gültige Eingabe ein. Bitte drücken sie eine beliebige Taste um es erneut zu versuchen:");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (richtig == false);





            Console.WriteLine("Geben sie bitte ihren Text ein:");
            text = Console.ReadLine();




            int anzahl = 0;
            anzahl = ausgabeTextMalX(num, text);

            Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);

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
