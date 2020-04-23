using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Commander stats provider for the popular traiding card game MAGIC THE GATHERING");
            Console.WriteLine("the first goal of this program is to create a probibility generator for an acceptible starting hand.");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("Enter the number of colors in your deck (1-5)");
            string Colors = Console.ReadLine();
            int Color = 0;
            Color = int.Parse(Colors);
            Console.WriteLine("Enter the converted manna cost of your commander");
            string CCMCs = Console.ReadLine();
            int CCMC = 0;
            CCMC = int.Parse(CCMCs);
            Console.WriteLine("Enter the average converted mana cost of your deck");
            string ACMCs = Console.ReadLine();
            int ACMC = 0;
            ACMC = int.Parse(ACMCs);
            Console.WriteLine("Enter the quantity of lands in deck");
            string LandCounts = Console.ReadLine();
            int LandCount = 0;
            LandCount = int.Parse(LandCounts);
            Console.WriteLine("Enter the quantity of Ramp in deck (CMC3and below)");
            string RampCounts = Console.ReadLine();
            int RampCount = 0;
            RampCount = int.Parse(RampCounts);
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("Colors=" + Color);
            Console.WriteLine("your CCMC="+ CCMC);
            Console.WriteLine("your ACMC=" + ACMC);
            Console.WriteLine("LANDS=" + LandCount);
            Console.WriteLine("Ramp=" + RampCount);
            int LandDraw=0;
            int RampDraw=0;

            //auto calculate other missing valuses (needed)
            if (Color>=5) 
            {
                if (ACMC>=5)
                {
                    LandDraw = 3;
                    RampDraw = 1;

                }
                else
                {
                    LandDraw = 2;
                     RampDraw = 2;
                  
                }
                
            }
           
           else if (Color == 4)
            {
                if (ACMC >= 5)
                {
                   LandDraw = 3;
                     RampDraw = 1;

                }
                else
                {
                     LandDraw = 2;
                     RampDraw = 2;
                }
                
            }
           else if (Color == 3)
            {
                if (ACMC >= 4)
                {
                    LandDraw = 3;
                    RampDraw = 1;

                }
                else
                {
                     LandDraw = 2;
                     RampDraw = 1;
                }
                
            }
            else if (Color == 2)
            {
                if (ACMC >= 5)
                {
                     LandDraw = 3;
                     RampDraw = 2;

                }
                else
                {
                     LandDraw = 2;
                     RampDraw = 2;
                }
                
            }
            else if (Color <= 1)
            {
                if (ACMC >= 5)
                {
                     LandDraw = 2;
                     RampDraw = 1;

                }
                else
                {
                     LandDraw = 3;
                     RampDraw = 1;
                }
                

            }
            Console.WriteLine("Desired lands in starting hand"+LandDraw);
            Console.WriteLine("Desired ramp cards in starting hand"+RampDraw);
            //with all veribles defined, Run class for probability
            MTGcommanderStatsClass stats = new MTGcommanderStatsClass();
            decimal probability = stats.calculateprobibilityofacceptiblehand(LandCount, LandDraw, RampCount,RampDraw);

            // end program
            Console.WriteLine("your probability is"+probability+"%");
            Console.WriteLine("NOTE: roman used the wrong formula, and will update when he finds the correct one");


            Console.WriteLine("the end, I hope you found this program useful for all your MTG needs");

        }
    }
}