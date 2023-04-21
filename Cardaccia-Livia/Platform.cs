using System;

namespace Cardaccia_Livia
{
    public class Platform
    {
        private readonly ITransform _position;
        private readonly int _height;
        private readonly int _width;

        /// <summary>
        /// Creates a new instance of the class Wall.
        /// </summary>
        public Platform(ITransform Position, int Height, int Width)
        {
            _position = Position;
            _height = Height;
            _width = Width;
        }

        /// <summary>
        /// This method is used to let the entity jump on the platform by
        /// checking the collision on the topside of it and updating the
        /// ground level.
        /// </summary>
        /// <param name="collidingEntity">the entity colliding</param>
        /// <param name="platform">the platform on which the entity is jumping</param>
        public static void Jump(IEntity collidingEntity, IEntity platform)
        {
            if (collidingEntity.Hitbox.GetCollisionSideOnY(platform.Position.Y) > 0
                    && Math.Abs(collidingEntity.Hitbox.GetIntersectionOnX(platform))
                    > Math.Abs(collidingEntity.Hitbox.GetIntersectionOnX(platform)))
            {
                collidingEntity.Behaviour
                               .JumpingBehaviour
                               .Invoke(collidingEntity, platform); 
            }
        }
    }
}
