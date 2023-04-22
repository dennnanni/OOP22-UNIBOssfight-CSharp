using System;

namespace Sartini_Matteo
{
    /// <summary>
    /// This utility class models the concept of acceleration.
    /// </summary>
    static class Acceleration
    {

        /// <summary>
        /// This method is used to increase the speed of the entities.
        /// </summary>
        /// <param name="currentVelocity">the current velocity of the entity</param>
        /// <param name="targetVelocity">the target velocity</param>
        /// <param name="timeDelta">the time delta</param>
        /// <returns>the updated velocity of the Entity</returns>
        public static double Accelerate(double currentVelocity, double targetVelocity, double timeDelta)
        {
            if (currentVelocity == targetVelocity)
            {
                return targetVelocity;
            }

            double velocityDelta = targetVelocity - currentVelocity;

            if (velocityDelta > timeDelta)
            {
                return currentVelocity + timeDelta;
            }

            if (velocityDelta < timeDelta)
            {
                return currentVelocity - timeDelta;
            }

            return targetVelocity;
        }

    }
}
