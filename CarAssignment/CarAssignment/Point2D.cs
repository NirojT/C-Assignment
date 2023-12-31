﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssignment
{
    public class Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        // Constructor
        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        public class DistanceCalculator
        {
            public static float CalculateDistance(Point2D point1, Point2D point2)
            {
                float deltaX = point2.X - point1.X;
                float deltaY = point2.Y - point1.Y;

                return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        }

    }
}
