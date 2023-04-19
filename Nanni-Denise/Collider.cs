using System;
using System.Collections.Generic;
     
namespace Nanni_Denise
{
    ///
    /// <inheritdoc/>
    /// 
    public class Collider : ICollider
    {
        private Dictionary<string, Action<IEntity>> _behaviours;

        /// <summary>
        /// Creates a new instance of the collider.
        /// </summary>
        public Collider() 
        { 
            _behaviours = new Dictionary<string, Action<IEntity>>();
        }

        ///
        /// <inheritdoc/>
        /// 
        public void AddBehaviour(string key, Action<IEntity> action)
        {
            _behaviours.Add(key, action);
        }

        ///
        /// <inheritdoc/>
        /// 
        public void AddBehaviours(IList<string> keys, Action<IEntity> action)
        {
            foreach (string key in keys)
            {
                AddBehaviour(key, action);
            }
        }

        ///
        /// <inheritdoc/>
        /// 
        public void ManageCollision(IEntity e)
        {
            if (_behaviours.ContainsKey(e.GetType().Name))
            {
                _behaviours[e.GetType().Name].Invoke(e);
            }
        }
    }
}
