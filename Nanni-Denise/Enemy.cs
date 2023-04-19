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
        public Point Position { get; set; }

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

        ///
        /// <inheritdoc/>
        /// 
        public void Init()
        {

            Collider?.AddBehaviour("Wall.GetType().Name", e =>
            {
                // Wall.Stop(this, e);
                if (Hitbox.GetCollisionSideOnY(e.Position.Y) == 0)
                {
                    // Jump();
                }
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
    }
}
