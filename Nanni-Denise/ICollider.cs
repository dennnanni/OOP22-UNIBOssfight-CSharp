using System;
using System.Collections.Generic;

namespace Nanni_Denise
{
    /// <summary>
    /// This class models the collider component 
    /// which manages the behaviours of the entities
    /// on collisions.
    /// </summary>
    public interface ICollider
    {
        /// <summary>
        /// Manages the collision executing the procedure associated 
        /// to the colliding entityy.
        /// </summary>
        /// <param name="e">Entity with which the caller collides</param>
        void ManageCollision(IEntity e);

        /// <summary>
        /// Associates a behaviour to a specific entity.
        /// </summary>
        /// <param name="key">string value of the entity</param>
        /// <param name="action">behaviour</param>
        void AddBehaviour(string key, Action<IEntity> action);

        /// <summary>
        /// Associates a behaviour to a list of entities.
        /// </summary>
        /// <param name="keys">a list of the string values of the entities</param>
        /// <param name="action">behaviour</param>
        void AddBehaviours(IList<string> keys, Action<IEntity> action);
    }
}
