using System;
using System.Collections.Generic;

namespace _01.Point3D
{
    public class Program
    {
        public static void Main()
        {

            List<Point3D> points = new List<Point3D>();

            try
            {
                Console.WriteLine("How much poits you want to have: ");
                int numberOfPoints = int.Parse(Console.ReadLine());

                if (numberOfPoints <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                for (int i = 1; i <= numberOfPoints; i++)
                {
                    Console.WriteLine("Enter the \"x\" cordinate of your [{0}] point", i);
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the \"y\" cordinate of your [{0}] point", i);
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the \"z\" cordinate of your [{0}] point", i);
                    int z = int.Parse(Console.ReadLine());

                    Point3D point = new Point3D(x, y, z);
                    points.Add(point);
                }

                Console.WriteLine();
                Console.WriteLine("You have the fallowing points: ");

                foreach (var point in points)
                {
                    Console.WriteLine(point);
                }

                Console.WriteLine();
                Console.WriteLine("Your starting point is : {0}", Point3D.StartingPoint);

            }

            catch (NullReferenceException)
            {

                Console.WriteLine("Enter a valid number - Positive for number of points \n" +
                                  "and a valid integer number for cordinates of points");
                Main();
            }

            catch (FormatException)
            {
                Console.WriteLine("Enter a valid number - Positive for number of points \n" +
                                  "and a valid integer number for cordinates of points");
                Main();
            }

            catch (OverflowException)
            {
                Console.WriteLine("Enter a valid number - Positive for number of points \n" +
                                  "and a valid integer number for cordinates of points");
                Main();
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Enter a valid number - Positive for number of points \n" +
                                  "and a valid integer number for cordinates of points");
                Main();
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("Thank you to use my programg :)");
            }
        }
    }
}
