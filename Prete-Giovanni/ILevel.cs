using System.Collections.Generic;
using System;
using System.Drawing;

namespace Prete_Giovanni
{
    /// <summary>
    /// This interface models the concept of the game level.
    /// </summary>
    internal interface ILevel
    {
        /// <summary>
        /// Property to get and set the entities.
        /// </summary>
        List<IEntity> Entities { get; set; }

        /// <summary>
        /// Property to get and set the player.
        /// </summary>
        Player Player { get; set; }

        /// <summary>
        /// Property to get the number of defeated enemies.
        /// </summary>
        int DefeatedEnemyCount
        {
            get;
        }

        /// <summary>
        /// Adds an entity to the level.
        /// </summary>
        /// <param name="e">the new entity</param>
        void AddEntity(IEntity e);

        /// <summary>
        /// Calls the update method on all entities.
        /// </summary>
        void UpdateEntities();

        /// <summary>
        /// Updates the player.
        /// </summary>
        /// <param name="input">the action the player should perform</param>
        void UpdatePlayer(Inputs input);

        /// <summary>
        /// Calls the render method on all entities.
        /// </summary>
        /// <returns>the list of nodes of the entities</returns>
        List<IRenderable> RenderEntities();


        /// <summary>
        /// Renders the player of the level.
        /// </summary>
        /// <returns>the node of the player</returns>
        IRenderable RenderPlayer();

        /// <summary>
        /// Performs a rotation on the player weapon given the position of the mouse.
        /// </summary>
        /// <param name="mousePosition">the position of the mouse</param>
        void RotatePlayerWeapon(PointF mousePosition);

        /// <summary>
        /// Calls the init method on all entities.
        /// </summary>
        void Init();

        /// <summary>
        /// Checks if the game is over.
        /// </summary>
        /// <returns>true if the player is dead and so the game is over, 
        /// false otherwise</returns>
        bool IsOver();

        /// <summary>
        /// Checks if the player reaches the end of the level.
        /// </summary>
        /// <returns>true if the player reaches the end of the level, 
        /// false otherwise</returns>
        bool IsLevelEnded();
    }
}
