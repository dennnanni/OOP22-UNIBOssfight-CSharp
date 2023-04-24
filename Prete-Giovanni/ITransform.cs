using System.Drawing;

namespace Prete_Giovanni
{
    /// <summary>
    /// This class models the component representing the concept 
    /// of the position and the rotation of an entity.
    /// </summary>
    public interface ITransform
    {
        /// <summary>
        /// Property to get the position.
        /// </summary>
        PointF Position { get; set; }

        /// <summary>
        /// Property to get the ground level.
        /// </summary>
        float GroundLevel { set; get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Move(float x, float y);

        /// <summary>
        /// Takes the entity back on the ground level if it is under it.
        /// </summary>
        void MoveOnGroundLevel();

        /// <summary>
        /// This method returns true if the entity is under the ground
        /// level, false otherwise.
        /// </summary>
        /// <returns>true is the entity is under the ground level</returns>
        bool IsUnderGroundLevel();

        /// <summary>
        /// Sets the ground level to the default one, which is the height of the window.
        /// </summary>
        void ResetGroundLevel();

        /// <summary>
        /// Moves the entity to a new position.
        /// </summary>
        /// <param name="x">new position on x-axis</param>
        /// <param name="y">new position on y-axis</param>
        void MoveTo(float x, float y);

        /// <summary>
        /// Creates a copy of the Transform given as input.
        /// </summary>
        /// <returns>a Transform which is the exact copy of the passed one</returns>
        ITransform CopyOf();
    }
}