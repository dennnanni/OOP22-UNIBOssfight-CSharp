using System;
using System.Drawing;

namespace Sartini_Matteo
{
    /// <summary>
    /// This class models the weapon component, which is used by an entity
    /// to inflict damage towards other entities by firing bullets.
    /// </summary>
    public interface IWeapon
    {

        /// <summary>
        /// Used to create new bullets shot by the weapon towards a certain target.
        /// </summary>
        /// <param name="target">the target at which the weapon is pointing</param>
        /// <returns>the bullet fired</returns>
        Bullet Fire(PointF target);

        /// <summary>
        /// Updates the position of the weapon with the given one.
        /// </summary>
        /// <param name="newPosition">the new position of the weapon</param>
        void UpdatePosition(Transform newPosition);

        /// <summary>
        /// Update the weapon rotation.
        /// </summary>
        /// <param name="target">the target to point with the weapon</param>
        /// <returns>the new angle between the weapon and the target</returns>
        double UpdateRotation(PointF target);
    }
}