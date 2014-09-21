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
            int nSalaries = readInt("Ange antalet löner att mata in:");

            Console.WriteLine(nSalaries);
        }
        //Metoden tilldelar lönerna till en array samt räknar ut medelvärde etc
        private static void processSalaries(int count)
        {
            throw new NotImplementedException();
    
        
        }

        //Metoden ska returnera antalet löner som kommer att matas in
        private static int readInt(string prompt)
        {
            Console.Write(prompt);
            int nSalaries = int.Parse(Console.ReadLine());
            return nSalaries;
            
    
        }
    }
}
