using System;

namespace _01.Point3D
{
    public class Point3D
    {
        private int x;
        private int y;
        private int z;

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString()
        {
            return String.Format("Your point have the fallowing cordinates x = {0}, y = {1} and z = {2}",
                this.X, this.Y, this.Z);
        }
    }
}
