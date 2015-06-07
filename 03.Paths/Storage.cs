using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using _01.Point3D;

namespace _03.Paths
{
    public static class Storage
    {
        public static void SavePointCordinatesToFile(string path, int[] cordinates)
        {
            using (var fileDestination = new StreamWriter(path))
            {
               fileDestination.WriteLine(String.Join(" ", cordinates));
            }
        }

        public static Path3D LoadPointCordinatesFromFile(string path)
        {
            Path3D points = new Path3D();
         
            using (var fileSource = new StreamReader(path, Encoding.UTF8))
            {
                string line = fileSource.ReadLine();

                while (line != null)
                {
                    int[] pointCordinates = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).
                        Select(i => int.Parse(i)).ToArray();

                    if (pointCordinates.Length != 3)
                    {
                        throw new ArgumentException();
                    }

                    Point3D point = new Point3D(pointCordinates[0], pointCordinates[1], pointCordinates[2]);
                    points.AddPoints(point);

                    line = Console.ReadLine();
                }
            }

            return points;
        }
    }
}