namespace Nanni_Denise
{
    /// <summary>
    /// This class models the health component which determines if
    /// an entity is dead or not.
    /// </summary>
    public interface IHealth
    {
        /// <summary>
        /// Property to get and set the health value.
        /// </summary>
        int Value { get; set; }

        /// <summary>
        /// Property to get the max health value.
        /// </summary>
        int MaxValue { get; }

        /// <summary>
        /// Subtracts the specified damage from the health.
        /// </summary>
        /// <param name="damage">the damage received</param>
        void Damage(int damage);

        /// <summary>
        /// Determines if the entity is dead.
        /// </summary>
        /// <returns>if the entity is dead or not</returns>
        bool IsDead();

        /// <summary>
        /// Sets the health to zero, killing the entity.
        /// </summary>
        void Destroy();
    }
}
