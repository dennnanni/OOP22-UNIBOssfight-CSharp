using System.Drawing;

namespace Prete_Giovanni
{
    public class Transform : ITransform
    {

        public PointF Position { get; set; }

        public double Rotation { get; set; }

        public double GroundLevel { set; get; }

        public Transform(PointF position, double rotation)
        {
            Position = position;
            Rotation = rotation;
            GroundLevel = Window.Height;
        }

        public ITransform copyOf()
        {
            return new Transform(Position, Rotation);
        }

        public double getGroundLevel()
        {
            throw new System.NotImplementedException();
        }

        public Point getPosition()
        {
            throw new System.NotImplementedException();
        }

        public double getRotation()
        {
            throw new System.NotImplementedException();
        }

        public bool isUnderGroundLevel()
        {
            throw new System.NotImplementedException();
        }

        public void move(float x, float y)
        {
            Position += new SizeF(x, y);
        }

        public void moveOnGroundLevel()
        {
        }

        public void moveTo(float x, float y)
        {
            Position = new PointF(x, y);
        }

        public void resetGroundLevel()
        {
            GroundLevel = 0;
        }
    }
}