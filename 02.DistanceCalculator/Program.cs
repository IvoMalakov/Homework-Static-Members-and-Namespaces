using System;
using System.Linq;
using System.Linq.Expressions;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the cordinates of your fist point separated by a space: ");
            int[] firstPointCordinates =
                Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).
                    Select(i => int.Parse(i)).ToArray();

            Console.WriteLine("Enter the cordinates of your second point separated by a space: ");
            int[] secondPointCordinates =
                Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                    Select(i => int.Parse(i)).ToArray();

            Point3D point1 = new Point3D(firstPointCordinates[0], firstPointCordinates[1], firstPointCordinates[2]);
            Point3D point2 = new Point3D(secondPointCordinates[0], secondPointCordinates[1], secondPointCordinates[2]);

            Console.WriteLine("The distance between your points is {0}", DistanceCalculator.CalculateTheDistanceBetweenTwoPoints
                (point1, point2));
        }
    }
}
