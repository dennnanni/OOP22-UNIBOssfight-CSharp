using System.Drawing;

namespace Cardaccia_Livia
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
        /// Property to get and set the behaviour.
        /// </summary>
        IBehaviour Behaviour { get; set; }

        /// <summary>
        /// Property to get and set the Transform.
        /// </summary>
        ITransform Transform { get; set; }

        /// <summary>
        /// Property to get and set the height.
        /// </summary>
        int Height { get; set; }

        /// <summary>
        /// Property to set the speed on the y-axis.
        /// </summary>
        double YSpeed { set; }
    }
}
