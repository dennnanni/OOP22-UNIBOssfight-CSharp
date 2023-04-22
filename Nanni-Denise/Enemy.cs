using System.Drawing;

namespace Nanni_Denise
{
    /// <summary>
    /// This class models the concept of an Enemy.
    /// </summary>
    public abstract class Enemy : IEntity
    {
        ///
        /// <inheritdoc/>
        /// 
        public PointF Position
        {
            get => Transform.Position;
            set => Transform.Position = value;
        }

        ///
        /// <inheritdoc/> 
        ///
        public ITransform Transform { get; private set; }

        ///
        /// <inheritdoc/>
        /// 
        public IHitbox Hitbox { get; set; }

        ///
        /// <inheritdoc/>
        /// 
        public IHealth Health { get; set; }

        /// <summary>
        /// Readonly property to get the collider.
        /// </summary>
        public ICollider Collider { get; private set; }

        ///
        /// <inheritdoc/>
        /// 
        public int Damage { get; set; } = 0;

        /// <summary>
        /// Property to get and set movement speed on y-axis.
        /// </summary>
        public int YSpeed { get; set; }

        /// <summary>
        /// Property to get the max y-speed reachable from the entity.
        /// </summary>
        public int MaxYSpeed { get; private set; }

        ///
        /// <inheritdoc/>
        /// 
        public void Init()
        {

            Collider?.AddBehaviour("Wall.GetType().Name", e =>
            {
                // The wall stops the entity
                // Wall.Stop(this, e);
                if (Hitbox.GetCollisionSideOnY(e.Position.Y) == 0)
                    Jump();
            });

            Collider?.AddBehaviour(typeof(Bullet).Name, e =>
            {
                if (e is Bullet b && !b.Health.IsDead() && b.IsPlayerBullet)
                {
                    Health.Damage(b.Damage);
                    b.Health.Destroy();
                }
            });
        }

        /// <summary>
        /// Checks if the entity is jumping.
        /// </summary>
        /// <returns>true if the y position of the entity is over ground level
        /// false otherwise</returns>
        protected bool IsJumping() => Position.Y > Transform.GroundLevel;

        /// <summary>
        /// Makes the entity jump.
        /// </summary>
        protected void Jump()
        {
            if (!IsJumping())
            {
                YSpeed = MaxYSpeed;
                Transform.Move(0, 1);
            }
        }
    }
}
