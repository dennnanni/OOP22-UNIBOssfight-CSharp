using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace Prete_Giovanni
{
    internal class Level : ILevel
    {
        private const int PlayerWidth = 250;
        private const int EndPosition = 10_000;

        private List<IEntity> _entities;
        private int _endPosition;
        private int _defeatedEnemyCount;

        public List<IEntity> Entities { 
            get => _entities; 
            private set => _entities = value;
        }

        public Player Player { get; set; }

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

        public void AddEntity(IEntity e)
        {
            this.Entities.Add(e);
        }

        public void Init()
        {
            Player.Init();
            _entities.ForEach(e => e.Init());
        }

        public bool IsLevelEnded()
        {
            return Player.Transform.Position.X >= this._endPosition;
        }

        public bool IsOver()
        {
            return Player.Health.IsDead();
        }

        public List<IRenderable> RenderEntities()
        {
            return _entities
                .Where(e => e.IsDisplayed(Player.Transform.Position))
                .Select(e => e.Render(Player.Transform.Position))
                .ToList();
        }

        public IRenderable RenderPlayer()
        {
            return Player.Render(Player.Transform.Position);
        }

        public void RotatePlayerWeapon(PointF mousePosition)
        {
            this.Player.RotateWeapon(mousePosition);
        }

        public void UpdateEntities()
        {
            _entities
                .Where(e => e.GetType() is ActiveEntity)
                .Select(e => (ActiveEntity)e)
                .Where(e => e.IsUpdated(Player.Transform.Position))
                .ToList()
                .ForEach(e => e.Update(Inputs.EMPTY));

            _defeatedEnemyCount += _entities
                .Where(e => e.GetType() is Enemy)
                .Count();

            _entities.RemoveAll(e => e.Health.IsDead());
        }

        public void UpdatePlayer(Inputs input)
        {
            Player.Update(input);
        }
    }
}
