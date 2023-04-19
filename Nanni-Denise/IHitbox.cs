namespace Nanni_Denise
{
    /// <summary>
    /// This interface models the concept of an hitbox.
    /// </summary>
    public interface IHitbox
    {
        /// <summary>
        /// This method returns the y-axis side in which the collision occurred.
        /// </summary>
        /// <param name="y">the y coordinate of the collided entity</param>
        /// <returns>1 if it is on the top, -1 if it is on the bottom, 0 otherwise</returns>
        double GetCollisionSideOnY(double y);

    }
}
