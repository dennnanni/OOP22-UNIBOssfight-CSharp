using System;

namespace Cardaccia_Livia
{
    /// <summary>
    /// This class models the Behaviour component
    /// which determines the actions of the entities.
    /// </summary>
    public interface IBehaviour
    {
        /// <summary>
        /// Property to get and set the jumping behaviour.
        /// </summary>
        /// <returns></returns>
        Action<IEntity, IEntity> JumpingBehaviour { get; set; }

        /// <summary>
        /// Property to get and set the bottom stopping behaviour.
        /// </summary>
        Action<IEntity, IEntity> BottomStoppingBehaviour { get; set; }

        /// <summary>
        /// Property to get and set the stopping behaviour.
        /// </summary>
        Action<IEntity, IEntity> SideStoppingBehaviour { get; set; }
    }
}
