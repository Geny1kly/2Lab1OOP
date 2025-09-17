using System.Windows.Media.Animation;

namespace _2Lab1OOP;

public static class Calculations
{
    public static double E1(double e, double x, double a, double b)
    {
        return Math.Pow(e, (a * x)) - Math.Pow(e, (b * x)) / (2 * b);
    }

    public static double E2(double e, double x, double a, double b)
    {
        return Math.Pow(e, (a * x)) + Math.Pow(e, (b * x)) / (2 * a);
    }
    
    public static double E3(double e, double x, double a, double b)
    {
        return Math.Pow(e, (a * x * b)) + Math.Pow(e, ((a * x) / b)) / 2;
    }

    public static double F(double e, double x, double a, double b)
    {
        var rE1 = E1(e, x, a, b);
        var rE2 = E2(e, x, a, b);
        var rE3 = E3(e, x, a, b);
        
        return (
            ((rE1 * rE1) + Math.Abs(rE2) + rE3)
            /
            (Math.Sqrt(Math.Abs(rE1 * rE3)))
            -
            (1d / 3)
        );

    } 
}