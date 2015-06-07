using System;
using System.Collections.Generic;
using System.Text;
using _01.Point3D;

namespace _03.Paths
{
    public class Path3D
    {
        private List<Point3D> pointList = new List<Point3D>();

        public Path3D(params Point3D[] list)
        {
            this.AddPoints(list);
        }

        public List<Point3D> PointList
        {
            get { return this.pointList; }
        }

        public void AddPoints(params Point3D[] list)
        {
            foreach (var point3D in list)
            {
                this.pointList.Add(point3D);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for(int i = 0; i < pointList.Count; i++)
            {
                result.AppendFormat("x = {0} , y = {1}, z = {2}", this.pointList[i].X, 
                    this.pointList[i].Y, this.pointList[i].Z);
            }

            return result.ToString();
        }
    }
}
