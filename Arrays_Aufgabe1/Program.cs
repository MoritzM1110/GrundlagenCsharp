using System;

namespace Arrays_Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int arbeiten = 20;
            double summeg = 0;
            double summe = 0;

            int[] note = new int[arbeiten];
          

            for (int index = 0; index < arbeiten; index++ )
            {
                Console.WriteLine("Geben sie die {0} Note ein!", index + 1);
                note[0] = Convert.ToInt32(Console.ReadLine());
                summe = summe + note[0];
                summeg = summe / 20;
                

            }

            Console.WriteLine("Ihr Durschnitt lautet {0}", summeg) ;
            


            

            







        }
    }
}
