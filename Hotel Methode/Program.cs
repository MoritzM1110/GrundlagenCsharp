using System;

namespace Hotel_Methode
{
    class Program
    {
        static void Main()
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

            do 
            { 


                Console.WriteLine("Bitte geben sie ihre Daten ein");
                eingabe_string = Console.ReadLine();
                flag = short.TryParse(eingabe_string, out eingabe_short);





                if (flag == true)
                {

                   Console.WriteLine(GetData(eingabe_short, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag)); 

                }
                else
                {

                   Console.WriteLine(GetData(eingabe_string, zimmernummer, vorname, nachname, übernachtungen, rechnungsbetrag));

                }




            } while (true);


        }
        //Methode für short
        static (bool, short, string, string, short, double) GetData(short diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {

            short zimNum = zn[diff];
            string vorNum = vn[diff];
            string nacNum = nn[diff];
            short ueNum = ue[diff];
            double reNum = rb[diff];

            bool ei = false;
            int index = 0;

            for (int i = 0; i < zn.Length, i++)
            {
                if (diff == zn[i])
                {
                    ei = true;
                    index = i;
                }
            }

            //zn = { 45, 23, 3, 32 };

            return (ei, zn[index], vn[index], nacNum,ueNum ,reNum);

        }

        static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {

            
            return (true, , "", "", 1, 2.3);

        }




    }
} 
