using System;
using System.Drawing;
using Sartini_Matteo;

namespace Prete_Giovanni
{
    /// <summary>
    /// This class models an Entity that can move and performs actions.
    /// </summary>
    internal class ActiveEntity : IEntity
    {
        private int _height;
        private int _width;
        private double _xSpeed;
        private double _ySpeed;
        private double _maxYSpeed;

        public IRenderer Renderer { get; set; }

        public ITransform Transform { get; set; }

        public Nanni_Denise.IHitbox Hitbox { get; set; }

        public Nanni_Denise.IHealth Health { get; set; }

        public ActiveEntity(ITransform transform, int height, int width, IRenderer renderer) 
        {
            Transform = transform;
            _height = height;
            _width = width;
            Renderer = renderer;

            _maxYSpeed = 10;
        }
        
        public void Init()
        {
        }

        public bool IsDisplayed(PointF position)
        {
            return Math.Abs(PointF.Subtract(Transform.Position, new SizeF(position.X, position.Y)).X) - _width / 2.0 < Window.Width / 2
                && Transform.Position.Y < Window.Height
                && Transform.Position.Y >= 0;
        }

        public IRenderable Render(PointF position)
        {
            return Renderer.Render(position, 0);
        }

        public bool IsUpdated(PointF position) { throw new NotImplementedException(); }

        protected bool isJumping()
        {
            return Transform.Position.Y > Transform.GroundLevel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputs"></param>
        /// <exception cref="Exception"></exception>
        public void Update(Inputs inputs)
        {
            switch (inputs)
            {
                case Inputs.LEFT:
                    _xSpeed = -10;
                    break;
                case Inputs.RIGHT:
                    _xSpeed = 10;
                    break;
                case Inputs.SPACE:
                    _ySpeed = 10; 
                    break;
                case Inputs.EMPTY:
                        Transform.Move((float) _xSpeed, (float) _ySpeed);
                        _xSpeed = Acceleration.Accelerate(_xSpeed, 0, 0.5);
                        _ySpeed = this.isJumping()
                                ? Acceleration.Accelerate(_ySpeed, -_maxYSpeed, 1) : 0;
                        Transform.ResetGroundLevel();
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
