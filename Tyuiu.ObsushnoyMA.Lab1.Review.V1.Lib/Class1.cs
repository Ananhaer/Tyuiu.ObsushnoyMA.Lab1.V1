using System;

namespace DataService.ObsushnoyMA.Lab1.Review.V1.Lib
{
    public class DataService_
    {
        public double Calc(double a, double b, double c)
        {
            double z = (b + Math.Sqrt(4 * a * c)) / 2 - Math.Pow(a, 3) * c + Math.Pow(b, -2);
            double z_round = Math.Round(z, 3);
            return z_round;
        }
    }
}