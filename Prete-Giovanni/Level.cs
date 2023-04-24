using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace Prete_Giovanni
{
    /// <summary>
    /// This class models the concept of a Level.
    /// </summary>
    internal class Level : ILevel
    {
        /// <summary>
        /// Standard player width anc height.
        /// </summary>
        private const int PlayerWidth = 250;
        /// <summary>
        /// Standard end position.
        /// </summary>
        private const int EndPosition = 10_000;

        /// <summary>
        /// List of entities.
        /// </summary>
        private List<IEntity> _entities;

        /// <summary>
        /// End position
        /// </summary>
        private int _endPosition;

        /// <summary>
        /// Number of defeated enemies
        /// </summary>
        private int _defeatedEnemyCount;

        ///
        /// <inheritdoc/> 
        ///
        public List<IEntity> Entities { 
            get => _entities; 
            set => _entities = value;
        }

        ///
        /// <inheritdoc/> 
        ///
        public Player Player { get; set; }

        ///
        /// <inheritdoc/> 
        ///
        public int DefeatedEnemyCount
        {
            get => _defeatedEnemyCount;
        }

        public Level()
        {
            _endPosition = EndPosition;
            _entities = new List<IEntity>();
            Player = new Player(
                    new Transform(new PointF(0, 0), 0),
                    PlayerWidth, 
                    PlayerWidth, 
                    new Renderer(PlayerWidth, PlayerWidth, Color.Red)
            );
        }

        ///
        /// <inheritdoc/> 
        ///
        public void AddEntity(IEntity e) => this.Entities.Add(e);

        ///
        /// <inheritdoc/> 
        ///
        public void Init()
        {
            Player.Init();
            _entities.ForEach(e => e.Init());
        }

        ///
        /// <inheritdoc/> 
        ///
        public bool IsLevelEnded() => Player.Transform.Position.X >= this._endPosition;

        ///
        /// <inheritdoc/> 
        ///
        public bool IsOver() => Player.Health.IsDead();

        ///
        /// <inheritdoc/> 
        ///
        public List<IRenderable> RenderEntities()
        {
            return _entities
                .Where(e => e.IsDisplayed(Player.Transform.Position))
                .Select(e => e.Render(Player.Transform.Position))
                .ToList();
        }

        ///
        /// <inheritdoc/> 
        ///
        public IRenderable RenderPlayer() => Player.Render(Player.Transform.Position);

        ///
        /// <inheritdoc/> 
        ///
        public void RotatePlayerWeapon(PointF mousePosition) => this.Player.RotateWeapon(mousePosition);

        ///
        /// <inheritdoc/> 
        ///
        public void UpdateEntities()
        {
            _entities
                .Where(e => e is ActiveEntity)
                .Select(e => (ActiveEntity)e)
                .Where(e => e.IsUpdated(Player.Transform.Position))
                .ToList()
                .ForEach(e => e.Update(Inputs.EMPTY));

            _defeatedEnemyCount += _entities
                .Where(e => e is Enemy)
                .Count();

            _entities.RemoveAll(e => e.Health.IsDead());
        }

        ///
        /// <inheritdoc/> 
        ///
        public void UpdatePlayer(Inputs input) => Player.Update(input);
    }
}
