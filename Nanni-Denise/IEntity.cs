using System.Drawing;

namespace Nanni_Denise
{
    /// <summary>
    /// This interface models the concept of an Entity.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Property to get and set the position.
        /// </summary>
        Point Position { get; set; }

        /// <summary>
        /// Property to get and set the hitbox.
        /// </summary>
        IHitbox Hitbox { get; set; }

        /// <summary>
        /// Property to get and set the hitbox.
        /// </summary>
        IHealth Health { get; set; }

        /// <summary>
        /// Property to get and set the damage inflicted by the entity.
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// Initialise the components of the entity.
        /// </summary>
        void Init();
    }
}
