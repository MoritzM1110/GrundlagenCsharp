using System;

namespace Methoden_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie ihre gewünschte Anzahl ein");
            int durchlauf = Convert.ToInt32(Console.ReadLine());
            int anzahl_zeichen = 0;
            Console.WriteLine("Geben sie ihren gewünschten Text ein");
            string text = Console.ReadLine();
            anzahl_zeichen = ausgabeTextMalX(durchlauf,text);
            Console.Write("\nAnzahl der Buchstaben: {0}", anzahl_zeichen);
        }

         static int ausgabeTextMalX(int durchlauf, string text)
         {
             for(int i = 0; i<durchlauf ; i++)
            {
                Console.WriteLine(text);

                
            }

            return text.Length * durchlauf;


        }


    }


}
