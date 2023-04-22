namespace Cardaccia_Livia
{
    /// <summary>
    /// A Builder of the Behaviour component,
    /// with methods used to add behaviours
    /// and a method build() to be called just once.
    /// </summary>
    public interface IBehaviourBuilder
    {
        /// <returns>this, and add a behaviour to jump
        /// on platforms and walls</returns>
        IBehaviourBuilder AddJumpOnTop();

        /// <returns>this, and add a behaviour to stop when colliding
        /// with the bottom of a wall<\returns>
        IBehaviourBuilder AddStopFromBottom();

        /// <returns>this, and add a behaviour to stop when colliding
        /// with the side of a wall</returns>
        IBehaviourBuilder AddStopFromSide();

        /// <returns>the Behaviour built with all of the above</returns>
        IBehaviour Build();
    }
}
