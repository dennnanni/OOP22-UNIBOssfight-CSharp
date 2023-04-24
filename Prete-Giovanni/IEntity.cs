using System.Drawing;
using Nanni_Denise;

namespace Prete_Giovanni
{
    enum Inputs
    {
        /// <summary>
        /// Left input
        /// </summary>
        LEFT,
        /**
         * Right input.
         */
        RIGHT,
        /**
         * Space input.
         */
        SPACE,
        /**
         * Empty input.
         */
        EMPTY
    }

    /// <summary>
    /// This interface models the concept of an Entity.
    /// </summary>
    public interface IEntity
    {

        IRenderer Renderer { get; set; }
        ITransform Transform { get; set; }
        IHitbox Hitbox { get; set; }
        IHealth Health { get; set; }

        bool IsDisplayed(PointF position);

        IRenderable Render(PointF position);

        void Init();
    }
}
