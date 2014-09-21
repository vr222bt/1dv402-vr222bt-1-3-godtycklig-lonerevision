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
            Console.WriteLine("Test");
    
        
        }

        //Metoden ska returnera antalet löner som kommer att matas in
        private static int readInt(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    int nSalaries = int.Parse(Console.ReadLine());
                    return nSalaries;


                }
                catch (FormatException)
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel format, var god använd siffror");
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
