using System.Drawing;

namespace Prete_Giovanni
{
    public class Renderer : IRenderer
    {
        private Color _color;
        private int _remainingDamagedFrames;

        /// <summary>
        /// Property to get and set the height.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Property to get and set the width.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Property to get the Remaining Damaged Frames.
        /// </summary>
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

        ///
        /// <inheritdoc/> 
        ///
        public void Init()
        {
        }

        ///
        /// <inheritdoc/> 
        ///
        public IRenderable Render(PointF position, double rotation)
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
