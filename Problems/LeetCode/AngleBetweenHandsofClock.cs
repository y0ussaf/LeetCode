using System;

namespace Problems.LeetCode
{
    public class AngleBetweenHandsofClock
    {
        public static double Solve(int hour, int minutes)
        {
            
            double a = ((hour%12) * 5) % 60 + (5*((double)minutes/60));
           
            double k = Math.Abs((a * 360 / 60) - ((double)minutes * 360/60)) ;
            return Math.Min(k, 360 - k);
        }
    }
}