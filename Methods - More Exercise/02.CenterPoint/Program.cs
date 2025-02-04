﻿using System;

namespace _02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            ClosestToCenterPoint(x1, y1, x2, y2);
        }

        private static void ClosestToCenterPoint(double x1, double y1, double x2, double y2)
        {
            double sum1 = FirstPoint(x1, y1);
            double sum2 = SecondPoint(x2, y2);

            if (sum1<=sum2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double SecondPoint(double x2, double y2)
        {
            return Math.Abs(x2) + Math.Abs(y2);
        }

        private static double FirstPoint(double x1, double y1)
        {
            return Math.Abs(x1) + Math.Abs(y1);
        }
    }
}
