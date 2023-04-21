namespace Cardaccia_Livia
{
    /// <summary>
    /// This class models the hitbox component,
    /// which represents the rectangular area
    /// occupied by the entity and is used to detect
    /// the collisions between entities.
    /// </summary>
    internal interface IHitbox
    {
        /// <summary>
        /// This method returns the top side of the hitbox.
        /// </summary>
        /// <returns>the top side of the hitbox</returns>
        double GetTopSide();

        /// <summary>
        /// This method returns the intersection on the x-axis
        /// between the two hitboxes colliding.
        /// </summary>
        /// <param name="e">the colliding entity</param>
        /// <returns>the overlapping between the two hitboxes if any</returns>
        double GetIntersectionOnX(IEntity e);

        /// <summary>
        /// This method returns the intersection on the y-axis
        /// between the two hitboxes colliding.
        /// </summary>
        /// <param name="e">the colliding entity</param>
        /// <returns>the overlapping between the two hitboxes if any</returns>
        double GetIntersectionOnY(IEntity e);

        /// <summary>
        /// This method returns the x-axis side in which the collision occurred.
        /// </summary>
        /// <param name="x">the y coordinate of the collided entity</param>
        /// <returns>1 if it is on the top, -1 if it is on the bottom, 0 otherwise</returns>
        double GetCollisionSideOnX(double x);

        /// <summary>
        /// This method returns the y-axis side in which the collision occurred.
        /// </summary>
        /// <param name="y">the y coordinate of the collided entity</param>
        /// <returns>1 if it is on the top, -1 if it is on the bottom, 0 otherwise</returns>
        double GetCollisionSideOnY(double y);
    }
}
