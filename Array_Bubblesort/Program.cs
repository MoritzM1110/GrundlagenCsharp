using System;

namespace Array_Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] daten = { 45, 10, 15, 4 };
            int n = daten.Length;


            for (int index = 0; index < n - 1; index++)
            {
                Console.WriteLine(index);

                if (daten[index] > daten[index + 1])
                {
                    double buffer = daten[index + 1];
                    daten[index + 1] = daten[index];
                    daten[index] = buffer;
                }
                else if (daten[index + 1] > daten[index + 2]) 
                {
                    double buffer2 = daten[index + 2];
                    daten[index + 2] = daten[index + 1];
                    daten[index + 1] = buffer2;
                }

                else if (daten[index + 2] > daten[index + 3]) 
                {
                    double buffer3 = daten[index + 3];
                    daten[index + 3] = daten[index + 2];
                    daten[index + 2] = buffer3;
                }
           
            }





        }
    }
}
