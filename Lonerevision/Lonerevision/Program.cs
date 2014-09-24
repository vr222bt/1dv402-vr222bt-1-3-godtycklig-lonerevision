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
                int nSalaries = ReadInt("Ange antalet löner att mata in: ");
                if (nSalaries >= 2)
                {
                    ProcessSalaries(nSalaries);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du måste ange minst 2 löner för att kunna göra en beräkning");
                    Console.ResetColor();
                }
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("");
                Console.WriteLine("Tryck tangent för att börja om - Esc avslutar");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);              

        }

        //Metoden tilldelar lönerna till en array samt räknar ut medelvärde etc
        private static void ProcessSalaries(int count)
        {
            //Deklarerar variablerna som kommer användas
            int[] salaries = new int[count];
            int[] sortedSalaries = new int[count];
            double average;
            double median;
            int spread;
            
            //Läser in löner och tilldelar dom till en array
            for (int i = 0; i < count; i++)
            {
                salaries[i] = ReadInt(String.Format("Ange lön nummer {0}: ", i + 1));
            }

            //Kopierar arrayen för att kunna sortera den och ha den osorterade kvar
            Array.Copy(salaries, sortedSalaries, count);                     
            Array.Sort(sortedSalaries);

            //Räknar ut medelvärdet
            average = Math.Round((double)salaries.Average());
            

            //Räknar ut lönespridningen
            spread = salaries.Max() - salaries.Min();

            //Räknar ut medianen
            int index = count / 2;
            if (count % 2 != 0)
            {
                median = (sortedSalaries[index]); 
            }
            else
            {
                median = Math.Round((sortedSalaries[index] + sortedSalaries[index- 1]) / 2.0);
                
            }

            //Skriver ut average, median och spread
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Medellön       :{0,15:c0}", salaries.Average());            
            Console.WriteLine("Medianlön      :{0,15:c0}", median);
            Console.WriteLine("Lönespridning  :{0,15:c0}", spread);
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            //Skriver ut den osorterade arrayen

            for (int i = 0; i < count; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write("{0,9} ", salaries[i]);
                
            }
            Console.WriteLine();
               
        }

        //Metoden ska returnera antalet löner som kommer att matas in
        private static int ReadInt(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    return int.Parse(Console.ReadLine());
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
