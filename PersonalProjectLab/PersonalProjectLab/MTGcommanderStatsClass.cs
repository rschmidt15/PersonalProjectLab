using System;
namespace PersonalProjectLab
{
    public class MTGcommanderStatsClass
    {
        public MTGcommanderStatsClass()
        {
        }
        //method1
        public decimal calculateprobibilityofacceptiblehand(int LandCount, int LandDraw, int RampCount, decimal RampDraw)
        {
            //a.	((Landcount!/(Landcount-DrawnLands)!)*((RampCount!/(Rampcount-DrawnRamp)!))// (99! / (92! * 7!)
            decimal Probability = 0.00m;
            //Probability = ((LandCount!) / ((decimal)(LandCount - LandDraw)!) * (RampCount!) / ((RampCount - RampDraw)!) / ((decimal)99! / (decimal)(92!*7!)));
            Probability = LandCount + LandDraw + RampCount + RampDraw;
            return Probability;
        }
        
    }
}
