using System;

namespace Cardaccia_Livia
{
    /// <summary>
    /// This class implements the Behaviour, which is built using a Builder.
    /// The methods of this class are used to set new entities' behaviours.
    /// </summary>
    public class Behaviour : IBehaviour
    {
        /// 
        /// <inheritdoc/>
        /// 
        public Action<IEntity, IEntity> JumpingBehaviour { get; set; }

        /// 
        /// <inheritdoc/>
        /// 
        public Action<IEntity, IEntity> BottomStoppingBehaviour { get; set; }

        /// 
        /// <inheritdoc/>
        /// 
        public Action<IEntity, IEntity> SideStoppingBehaviour { get; set; }
    }
}
