using System;
using System.Collections.Generic;
using System.Linq;
using _01.Point3D;

namespace _03.Paths
{
    public class Program
    {
        public static void Main()
        {
            const string path = "path.txt";

            Path3D pointList = new Path3D();

            try
            {
                Console.WriteLine("How may points you want to add in your file: ");
                int numberOfPoints = int.Parse(Console.ReadLine());

                if (numberOfPoints < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                for (int i = 1; i <= numberOfPoints; i++)
                {
                    Console.WriteLine("Enter the cordinates of your [{0}] point separated by a space: ", i);
                    int[] pointCordinates = Console.ReadLine().Split(new char[] {' '},
                        StringSplitOptions.RemoveEmptyEntries).Select(k => int.Parse(k)).ToArray();

                    Storage.SavePointCordinatesToFile(path, pointCordinates);
                }

                Console.WriteLine();
                Console.WriteLine("Now I will read the cordinates of your point from the file");

                pointList = Storage.LoadPointCordinatesFromFile(path);

                Console.WriteLine(pointList);
            }

            catch (FormatException)
            {
                Console.Error.WriteLine("You must add a number");
            }

            catch (OverflowException)
            {
                Console.Error.WriteLine("You must add a valid integer number");
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("You must add a number");
            }

            catch (ArgumentException)
            {
                Console.Error.WriteLine("You must add a number");
            }
        }
    }
}
