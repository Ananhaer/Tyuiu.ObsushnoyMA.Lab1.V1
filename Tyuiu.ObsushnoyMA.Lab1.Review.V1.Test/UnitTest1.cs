using System;
using DataService.ObsushnoyMA.Lab1.Review.V1.Lib;
using Xunit;

namespace DataService.ObsushnoyMA.Lab1.Review.V1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CheckCalc()
        {
            double a = 0.5;
            double b = 0.2;
            double c = 0.1;

            DataService_ ds = new DataService_();

            double res = ds.Calc(a, b, c);

            double true_value = 25.311;

            Assert.Equal(true_value, res);
        }
    }
}