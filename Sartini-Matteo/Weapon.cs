using System;
using System.Drawing;

namespace Sartini_Matteo
{
    /// <summary>
    ///  This class models the weapon component, which is used by an entity
    ///  to inflict damage towards other entities by firing bullets.
    /// </summary>
    internal class Weapon : IWeapon
    {
        private int PositionOffset { get; set; }

        private double Rotation { get; set; }

        private int YDirection { get; set; }

        private int XDirection { get; set; }

        private Transform UserPosition { get; set; }

        private Transform ShootingPosition { get; set; }

        /// <inheritdoc />
        public Weapon(Transform userPosition, int positionOffset)
        {
            this.UserPosition = userPosition;
            this.ShootingPosition = userPosition;
            this.PositionOffset = positionOffset;

            this.XDirection = 1;
            this.YDirection = 1;
        }

        /// <inheritdoc />
        public Bullet Fire(PointF target)
        {
            return new Bullet(ShootingPosition.Position, 10, 10, 10, target, 10, true);
        }

        /// <inheritdoc />
        public void UpdatePosition(Transform newPosition)
        {
            this.UserPosition = newPosition;
            Transform tempTransform = this.UserPosition;
            tempTransform.Move(0, this.PositionOffset);
            this.ShootingPosition = tempTransform;
        }

        /// <inheritdoc />
        public double UpdateRotation(PointF target)
        {
            double angle = Angle.FindAngle(this.ShootingPosition.Position, target);
            this.Rotation = Angle.ToDegrees(angle);
            return this.Rotation;
        }
    }
}
