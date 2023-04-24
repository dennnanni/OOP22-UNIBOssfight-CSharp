using Sartini_Matteo;
using System.Drawing;


namespace Prete_Giovanni
{
    internal class Player : ActiveEntity
    {
        

        public IWeapon Weapon { get; }

        public void RotateWeapon(PointF mousePosition)
        {
            Weapon.UpdateRotation(mousePosition);
        }

        public Player(ITransform transform, int height, int width, IRenderer renderer) : base(transform, height, width, renderer)
        {
        }
    }
}
