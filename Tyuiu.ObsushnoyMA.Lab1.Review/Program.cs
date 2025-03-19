using System;
using DataService.ObsushnoyMA.Lab1.Review.V1.Lib;

namespace DataService.ObsushnoyMA.Lab1.Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService_ ds = new DataService_();

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(ds.Calc(a, b, c));
            Console.ReadKey();
        }
    }
}