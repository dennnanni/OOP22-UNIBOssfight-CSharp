using System.Drawing;

namespace Nanni_Denise
{
    /// <summary>
    /// This interface models the component representing the concept of
    /// the position of an entity.
    /// </summary>
    public interface ITransform
    {
        /// <summary>
        /// Property to get and set the entity position.
        /// </summary>
        PointF Position { get; set; }

        /// <summary>
        /// Property to get and set the ground level.
        /// </summary>
        int GroundLevel { get; set; }

        /// <summary>
        /// Translates the current position with the vector of components x and y.
        /// </summary>
        /// <param name="x">position on x-axis</param>
        /// <param name="y">position on y-axis</param>
        void Move(float x, float y);
    }
}
