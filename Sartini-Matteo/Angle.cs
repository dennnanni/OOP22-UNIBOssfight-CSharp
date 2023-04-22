using System.Reflection;
using System;
using System.Drawing;

namespace Sartini_Matteo
{

    /// <summary>
    /// Util class to manage angles needed in the application.
    /// </summary>
    public static class Angle
    {
        /// <summary>
        /// Right angle value.
        /// </summary>
        public const int RIGHT_ANGLE = 90;

        /// <summary>
        /// This method finds the angle in gradients between
        /// two given points in the game's reference system.
        /// </summary>
        /// <param name="point1">starting point of the vector</param>
        /// <param name="point2">finish point of the vector</param>
        /// <returns>the angle in gradients</returns>
        public static double FindAngle(PointF point1, PointF point2)
        {
            double dx = point2.X - point1.X;
            double dy = point2.Y - point1.Y;
            return -Math.Atan2(dy, dx);
        }

        /// <summary>
        /// Convert an angle from radians to degrees.
        /// </summary>
        /// <param name="angle">angle in radians</param>
        /// <returns>the angle in degrees</returns>
        public static double ToDegrees(double angle)
        {
            return angle * (180 / Math.PI);
        }
    }
}
