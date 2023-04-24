using System;

namespace Cardaccia_Livia
{
    /// <summary>
    /// This class models the component representing the concept
    /// of the position and the rotation of an entity.
    /// </summary>
    public interface ITransform
    {
        /// <summary>
        /// Changes the ground level.
        /// </summary>
        /// <param name="yGround">the new value of the ground</param>
        void SetGroundLevel(double yGround);

        /// <summary>
        /// This method returns true if the entity is under the ground
        /// level, false otherwise.
        /// </summary>
        /// <returns>true is the entity is under the ground level</returns>
        bool IsUnderGroundLevel();

        /// <summary>
        /// Takes the entity back on the ground level if it is under it.
        /// </summary>
        void MoveOnGroundLevel();

        /// <summary>
        /// Translates the current position with the vector of components x and y.
        /// </summary>
        /// <param name="x">position on x-axis</param>
        /// <param name="y">position on y-axis</param>
        void Move(double x, double y);

        /// <summary>
        /// Moves the entity to a new position.
        /// </summary>
        /// <param name="x">new position on x-axis</param>
        /// <param name="y">new position on y-axis</param>
        void MoveTo(double x, double y);
    }
}
