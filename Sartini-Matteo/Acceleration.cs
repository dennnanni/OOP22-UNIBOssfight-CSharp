using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sartini_Matteo
{
    static class Acceleration
    {

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
