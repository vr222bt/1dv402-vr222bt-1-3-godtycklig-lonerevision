using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lonerevision
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                int nSalaries = readInt("Ange antalet löner att mata in:");
                if (nSalaries >= 2)
                {
                    processSalaries(nSalaries);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tryck tangent för att börja om - Esc avslutar");
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste ange minst 2 löner för att kunna göra en beräkning");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Tryck tangent för att börja om - Esc avslutar");
                    Console.ResetColor();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);              

        }

        //Metoden tilldelar lönerna till en array samt räknar ut medelvärde etc
        private static void processSalaries(int count)
        {
            //Deklarerar variablerna som kommer användas
            int[] Salaries = new int[count];
            int[] SortedSalaries = new int[count];
            double average;
            double median;
            int spread;
            


            //Läser in löner och tilldelar dom till en array
            for (int i = 0; i < count; i++)
            {
                Salaries[i] = readInt(String.Format("Ange lön nummer {0}:", i + 1));
            }

            //Kopierar arrayen för att kunna sortera den och ha den osorterade kvar
            Array.Copy(Salaries, SortedSalaries, count);                     
            Array.Sort(SortedSalaries);

            //Räknar ut medelvärdet
            average = Math.Round((double)Salaries.Average());
            

            //Räknar ut lönespridningen
            spread = Salaries.Max() - Salaries.Min();

            //Räknar ut medianen
            if (count % 2 != 0)
            {
                int value1 = count / 2;
                median = (SortedSalaries[value1]); 
            }
            else
            {
                int value2 = count / 2;
                median = Math.Round(((double)SortedSalaries[value2] + SortedSalaries[value2 - 1]) / 2);
                
            }

            //Skriver ut average, median och spread
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Medellön       :{0,15:c0}", average);            
            Console.WriteLine("Medianlön      :{0,15:c0}", median);
            Console.WriteLine("Lönespridning  :{0,15:c0}", spread);
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            //Skriver ut den osorterade arrayen

            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", Salaries[i]);
                
            }
            Console.WriteLine();


               
        }

        //Metoden ska returnera antalet löner som kommer att matas in
        private static int readInt(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    int readInt = int.Parse(Console.ReadLine());
                    return readInt;


                }
                catch (FormatException)
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel format, kan inte tolkas som ett heltal");
                    Console.ResetColor();
                } 
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("För stort antal siffror");
                    Console.ResetColor();
                }
            }


    
        }
    }
}
