
using System;

namespace Cardaccia_Livia
{
    /// <summary>
    /// This class models a wall, which is an obstacle that stops
    /// the player while running but can be climbed.
    /// </summary>
    public class Wall
    {
        private readonly ITransform _position;
        private readonly int _height;
        private readonly int _width;

        /// <summary>
        /// Creates a new instance of the class Wall.
        /// </summary>
        public Wall(ITransform Position, int Height, int Width)
        {
            _position = Position;
            _height = Height;
            _width = Width;
        }

        /// <summary>
        /// This static method is used to stop the entity colliding with the wall,
        /// by checking on each side of it if there has been an intersection
        /// between the hitboxes.
        /// </summary>
        /// <param name="collidingEntity">the entity colliding</param>
        /// <param name="wall">the wall stopping the entity</param>
        public static void Stop(IEntity collidingEntity,IEntity wall) 
        {
            if (Math.Abs(collidingEntity.Hitbox.GetIntersectionOnX(wall))
                > Math.Abs(collidingEntity.Hitbox.GetIntersectionOnY(wall)))
            {
                if (collidingEntity.Hitbox
                        .GetCollisionSideOnY(wall.Position.Y) < 0)
                {
                    collidingEntity.Behaviour
                        .BottomStoppingBehaviour
                        .Invoke(collidingEntity, wall);
                }
                else
                {
                    collidingEntity.Behaviour
                        .JumpingBehaviour
                        .Invoke(collidingEntity, wall);
                }
            }
            else
            {
                collidingEntity.Behaviour
                        .SideStoppingBehaviour
                        .Invoke(collidingEntity, wall);
            }
        }
    }
}
