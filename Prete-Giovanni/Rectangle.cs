using System.Drawing;

namespace Prete_Giovanni
{
    internal class Rectangle : IRenderable
    {
        public PointF Position { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Color Color { get; set; }
        public double Rotation { get; set; }

        public Rectangle(PointF position, float width, float height)
        {
            Position = position;
            Width = width;
            Height = height;
        }
    }
}
