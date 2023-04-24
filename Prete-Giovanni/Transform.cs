using System.Drawing;

namespace Prete_Giovanni
{
    public class Transform : ITransform
    {

        public PointF Position { get; set; }

        public double Rotation { get; set; }

        public float GroundLevel { set; get; }

        public Transform(PointF position, double rotation)
        {
            Position = position;
            Rotation = rotation;
            GroundLevel = Window.Height;
        }

        public ITransform CopyOf()
        {
            return new Transform(Position, Rotation);
        }

        public bool IsUnderGroundLevel()
        {
            return Position.Y < GroundLevel;
        }

        public void Move(float x, float y)
        {
            Position += new SizeF(x, y);
        }

        public void MoveOnGroundLevel()
        {
            if (this.IsUnderGroundLevel())
            {
                Position = new PointF(Position.X, GroundLevel);
            }
        }

        public void MoveTo(float x, float y)
        {
            Position = new PointF(x, y);
        }

        public void ResetGroundLevel()
        {
            GroundLevel = 0;
        }
    }
}