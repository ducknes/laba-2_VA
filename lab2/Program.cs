using System;

namespace calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double exp = Exp(1);
            Console.WriteLine($"exp: {exp}");
            Console.WriteLine($"exp: {Math.Exp(1)}");
            double ln = Ln(4);
            Console.WriteLine($"ln: {ln}");
            Console.WriteLine($"ln: {Math.Log(4)}");
            double sin = Sin(2);
            Console.WriteLine($"sin: {sin}");
            Console.WriteLine($"sin: {Math.Sin(2)}");
            double cos = Cos(2);
            Console.WriteLine($"cos: {cos}");
            Console.WriteLine($"cos: {Math.Cos(2)}");
            double tg = Sin(3) / Cos(3);
            Console.WriteLine($"tg: {tg}");
            Console.WriteLine($"tg: {Math.Tan(3)}");
            double ctg = Cos(3) / Sin(3);
            Console.WriteLine($"ctg: {ctg}");
            Console.WriteLine($"ctg: {1.0 / Math.Tan(3)}");
            double sqrt = Sqrt(4);
            Console.WriteLine($"sqrt: {sqrt}");
        }

        static double Sqrt(double x) {
            double result = x;
            while (Math.Abs(Math.Pow(result, 2) - x) > 0.000000000000001) {
                result = (result + (x / result)) / 2;
            }
            return result;
        }

        static double Cos(double x)
        {
            double v1 = 1;
            double result = 0;
            double current = v1;
            long k = 1;
            while (Math.Abs(current) > 0)
            {
                result += current;
                current = -( Math.Pow(x, 2) / ( 2 * k * (2 * k - 1) ) ) * current;
                k++;
            }
            return result;
        }

        static double Sin(double x)
        {
            double u1 = x;
            double result = 0;
            double current = u1;
            long k = 1;
            while (Math.Abs(current) > 0)
            {
                result += current;
                current = -( Math.Pow(x, 2) / ( 2 * k * (2 * k + 1) ) ) * current;
                k++;
            }
            return result;
        }

        static double Ln(double z)
        {
            double u0 = (1 - z) / (1 + z);
            double result = 0;
            double current = u0;
            int k = 1;
            while (Math.Abs(current) > 0) 
            {
                result += current;
                current = (1 / (2 * k + 1)) * Math.Pow(u0, 2*k+1);
                k++;
            }
            return -2 * result;
        }

        static double Exp(double x)
        {
            double result = 0;
            long k = 1;
            double current = 1;
            while (Math.Abs(current) > 0)
            {
                result += current;
                current = (x / k) * current;
                k++;
            }
            return result;
        }

        // static long Fact(long k)
        // {
        //     if (k == 0)
        //     {
        //         return 1;
        //     }
        //     return k * Fact(k - 1);
        // }
    }
}