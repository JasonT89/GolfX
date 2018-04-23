using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfX
{
    class Program
    {
        public static double Ball = -1000  ;
        public static int Mål = 0;

        static void Main(string[] args)
        {
            Shot slag = new Shot();
            Finish cup = new Finish();

            while (Ball != Mål)                                        
            {
                Console.Clear();
                cup.FörMycket();
                cup.Kant();                                              
                cup.Visa();                                             
                slag.Hit();                                           
                slag.Kraft();
                slag.Dist();                                           
                cup.AddSlags();                                         
            }                                                           
            Console.Clear();
            cup.VisaSlags();
        }
    }
}
