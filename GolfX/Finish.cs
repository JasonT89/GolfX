using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfX
{
    class Finish
    {
        public static int Räkna = 0;                                    
        public static double UrDis;                                   
        List<double> AllSlags = new List<double>();

        public void Visa()
        {
            Console.WriteLine("\t\t\t\t---------------------------------------------");
            Console.WriteLine("\t\t\t\t Du har: " + Program.Ball + " Meters kvar till målet.");
            Console.WriteLine("\t\t\t\t Du har slagit: " + Räkna + " gånger, max är 10.");
            Console.WriteLine("\t\t\t\t---------------------------------------------");
        }

        public void AddSlags()          
        {
            AllSlags.Add(UrDis);
        }

        public void VisaSlags()
        {
            Console.WriteLine("\nDu vann!");                                       
            Console.WriteLine("\nSå många slag tog du: " + Räkna);               
            Console.WriteLine("\nSå mycket du reste med varje slag:");
            foreach (int item in AllSlags)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void FörMycket()
        {
            if (Räkna >= 11) throw new Exception("Du gick över max.");
        }

        public void Kant()
        {
            if (Program.Ball >= 500 || Program.Ball <= -1500) throw new Exception("Du gick över kanten.");
        }



    }
}
  