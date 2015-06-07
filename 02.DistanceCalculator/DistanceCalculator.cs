using System;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateTheDistanceBetweenTwoPoints(Point3D point1, Point3D point2)
        {
            int xd = point2.X - point1.X;
            int yd = point2.Y - point1.Y;
            int zd = point2.Z - point1.Z;

            double distance = Math.Sqrt(Math.Pow(xd, 2) + Math.Pow(yd, 2) + Math.Pow(zd, 2));

            return double.Parse(String.Format("{0:F4}", distance));
        }
    }
}
