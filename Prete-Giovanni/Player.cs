using Sartini_Matteo;
using System.Drawing;


namespace Prete_Giovanni
{
    /// <summary>
    /// This class models the concept of a Player.
    /// </summary>
    internal class Player : ActiveEntity
    {

        /// <summary>
        /// Property to get the Weapon.
        /// </summary>
        public IWeapon Weapon { get; }

        /// <summary>
        /// Rotates the weapon according to the mouse coordinates.
        /// </summary>
        /// <param name="mousePosition">the mouse position</param>
        public void RotateWeapon(PointF mousePosition)
        {
            Weapon.UpdateRotation(mousePosition);
        }

        public Player(ITransform transform, int height, int width, IRenderer renderer) : base(transform, height, width, renderer)
        {
        }
    }
}
