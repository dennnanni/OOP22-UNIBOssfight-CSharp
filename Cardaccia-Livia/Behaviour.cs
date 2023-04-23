using System;

namespace Cardaccia_Livia
{
    public class Behaviour : IBehaviour
    {
        public Action<IEntity, IEntity> JumpingBehaviour { get; set; }
        public Action<IEntity, IEntity> BottomStoppingBehaviour { get; set; }
        public Action<IEntity, IEntity> SideStoppingBehaviour { get; set; }
    }
}
