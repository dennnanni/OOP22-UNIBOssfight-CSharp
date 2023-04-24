using System.Drawing;

namespace Nanni_Denise
{
    /// <summary>
    /// This class implements a Bullet.
    /// </summary>
    public class Bullet : IEntity
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

        ///
        /// <inheritdoc/>
        /// 
        public int Damage { get; set; } = 0;

        /// <summary>
        /// This method returns the Bullet property identifier.
        /// </summary>
        public bool IsPlayerBullet { get; private set; }


        /// <summary>
        /// Creates a new instance of a bullet given its identifier.
        /// </summary>
        /// <param name="isPlayerBullet">if it is the bullet of the player</param>
        public Bullet(bool isPlayerBullet)
        {
            IsPlayerBullet = true;
        }

        ///
        /// <inheritdoc/>
        /// 
        public void Init()
        {

        }
    }
}
