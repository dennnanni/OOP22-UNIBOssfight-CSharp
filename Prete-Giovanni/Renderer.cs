using System.Drawing;

namespace Prete_Giovanni
{
    public class Renderer : IRenderer
    {
        private Color _color;
        private int _remainingDamagedFrames;

        public int Height { get; set; }
        public int Width { get; set; }
        public int RemainingDamagedFrames { 
            get => --_remainingDamagedFrames;
            private set => _remainingDamagedFrames = value; 
        }

        public Renderer(int height, int width, Color color)
        {
            Height = height;
            Width = width;
            _color = color;
        }

        public void Init()
        {
        }

        public IRenderable Render(PointF position, int xDirection, int yDirection, double rotation)
        {
            Rectangle rect = new Rectangle(
                    new PointF (
                        position.X - Width / 2, 
                        Window.Height - position.Y - Height
                        ),
                    Width,
                    Height
                    );
            rect.Color = _color;
            rect.Rotation = rotation;

            return rect;
        }
    }
}
