using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfX
{
    class Shot
    {
        double Vinkel;
        double UtHast;

        Finish cup = new Finish();

        
        public void Hit()
        {
            
            Console.WriteLine("Vid vilken vinkel vill du slå? ");
            

            double UtVinkel;
            bool Vad = false;

            while (Vad == false)
            {
                string InVinkel = Console.ReadLine();
                if (double.TryParse(InVinkel, out UtVinkel) && UtVinkel != 0)
                {
                    Vinkel = (Math.PI / 180) * UtVinkel;
                    Console.WriteLine("Din radianer är: " + Vinkel);
                    Vad = true;
                }
                else if (!double.TryParse(InVinkel, out UtVinkel))
                {
                    Console.WriteLine("Det är inte ett tal, försök igen.");
                }
                else if (UtVinkel == 0)
                {
                    Console.WriteLine("Vinkeln kan inte vara 0, försök igen.");
                }

            }
        }

        public void Kraft()
        {
            Console.WriteLine("\nHur mycket hastighet vill du ha?");

            bool Vad = false;

            while (Vad == false)
            {
                string InHast = Console.ReadLine();
                if (double.TryParse(InHast, out UtHast) && UtHast != 0)
                {
                    Console.WriteLine("\nDin hastighet är: " + UtHast);
                    Vad = true;
                }
                else if (!double.TryParse(InHast, out UtHast))
                {
                    Console.WriteLine("\nDet är inte ett tal, försök igen.");
                }
                else if (UtHast == 0)
                {
                    Console.WriteLine("\nHastigheten kan inte vara 0, försök igen.");
                }
            }
        }

        public void Dist()
        {
            double Distans = Math.Pow(UtHast, 2) / 9.8 * Math.Sin(2 * Vinkel);
            Finish.UrDis = Math.Round(Distans);
                                                                                                         
            if (Program.Ball < Program.Mål)
            {
                Program.Ball = Program.Ball + Finish.UrDis;
                Console.WriteLine("Din boll flög: " + Finish.UrDis + " Meters.");
                Console.WriteLine("Du har: " + Program.Ball + " meters till målet.");
                Finish.Räkna = Finish.Räkna + 1;
                Console.ReadKey();
            }
            else if (Program.Ball > Program.Mål)
            {
                Program.Ball = Program.Ball - Finish.UrDis;
                Console.WriteLine("Din boll flög: " + Finish.UrDis  + " Meters.");
                Console.WriteLine("Du har: " + Program.Ball + " meters till målet.");
                Finish.Räkna = Finish.Räkna + 1;
                Console.ReadKey();
            }

        }
    }
}
