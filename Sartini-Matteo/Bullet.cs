using System;
using System.Drawing;

namespace Sartini_Matteo
{
    /// <summary>
    ///  This class models the bullet shot by the weapons
    ///  of the game, which can cause damage, has a
    ///  speed and shifts along a vector.
    /// </summary>
    public class Bullet
    {

        /// <summary>
        /// The movement on the X-Axis.
        /// </summary>
        public double XShift
        {
            get; private set;
        }

        /// <summary>
        /// The movement on the Y-Axis.
        /// </summary>
        public double YShift
        {
            get; private set;
        }

        /// <summary>
        /// Identufier of the bullet owner.
        /// </summary>
        public bool IsPlayerBullet { get; private set; }

        /// <summary>
        /// The Bullet's damage value.
        /// </summary>
        public int Damage { get; private set; }

        /// <summary>
        /// The Bullet's position component.
        /// </summary>
        public Transform Transform { get; private set; }

        /// <summary>
        /// Creates a new instance of the class Bullet.
        /// </summary>
        /// <param name="startingPosition">the starting position of the bullet</param>
        /// <param name="height">the height of the bullet</param>
        /// <param name="width">the width of the bullet</param>
        /// <param name="damage">the damage caused by bullet</param>
        /// <param name="target">the spot giving the trajectory</param>
        /// <param name="speed">the speed of the bullet</param>
        /// <param name="isPlayerBullet">identifier of the Bullets from the player Weapon</param>
        public Bullet(PointF startingPosition, int height, int width,
            int damage, PointF target, int speed, bool isPlayerBullet)
        {
            this.Damage = damage;
            this.IsPlayerBullet = isPlayerBullet;

            double angle = Angle.FindAngle(this.Transform.Position, target);
            this.XShift = speed * Math.Cos(angle);
            this.YShift = -speed * Math.Sin(angle);

            this.Transform.Rotation = Angle.ToDegrees(angle);
        }

        /// <summary>
        /// Takes as input an element of Inputs enum and, 
        /// from that, the class will do the update.
        /// </summary>
        public void Update()
        {
            this.Transform.Move((float)this.XShift, (float)this.YShift);
        }
    }
}
