using System;

namespace Cardaccia_Livia
{
    public class BehaviourBuilder : IBehaviourBuilder
    {
        private bool _built;
        private readonly IBehaviour _behaviour = new Behaviour();

        ///
        /// <inheritdoc/>
        ///
        public IBehaviourBuilder AddJumpOnTop()
        {
            _behaviour.JumpingBehaviour = (IEntity e1, IEntity e2) => {
                e1.Transform.SetGroundLevel(e2.Hitbox.GetTopSide());
                if (e1.Transform.IsUnderGroundLevel()) 
                    e1.Transform.MoveOnGroundLevel();
            };
            return this;
        }

        ///
        /// <inheritdoc/>
        ///
        public IBehaviourBuilder AddStopFromBottom()
        {
            _behaviour.BottomStoppingBehaviour = (IEntity e1, IEntity e2) =>
            {
                e1.Transform.MoveTo(e1.Position.X, e1.Position.Y - e1.Height - 1);
                e1.YSpeed = 0;
            };
            return this;
        }

        ///
        /// <inheritdoc/>
        ///
        public IBehaviourBuilder AddStopFromSide()
        {
            _behaviour.SideStoppingBehaviour = (IEntity e1, IEntity e2) => 
                e1.Transform.Move(e1.Hitbox.GetIntersectionOnX(e2), 0);
            return this;
        }

        ///
        /// <inheritdoc/>
        ///
        public IBehaviour Build()
        {
            if (_built) 
                throw new InvalidOperationException();
            
            _built = true;
            return _behaviour;
        }
    }
}
