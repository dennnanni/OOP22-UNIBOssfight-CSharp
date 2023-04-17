using System.Reflection;
using System;
using System.Drawing;

namespace Sartini_Matteo
{
    public static class Angle
    {
        public const int RIGHT_ANGLE = 90;

        public static double FindAngle(Point point1, Point point2)
        {
            double dx = point2.X - point1.X;
            double dy = point2.Y - point1.Y;
            return -Math.Atan2(dy, dx);
        }
    }
}
