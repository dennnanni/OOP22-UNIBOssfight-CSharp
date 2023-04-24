using System.Drawing;

namespace Prete_Giovanni
{
    public class Transform : ITransform
    {
        ///
        /// <inheritdoc/> 
        ///
        public PointF Position { get; set; }

        ///
        /// <inheritdoc/> 
        ///
        public double Rotation { get; set; }

        ///
        /// <inheritdoc/> 
        ///
        public float GroundLevel { get; set; }

        public Transform(PointF position, double rotation)
        {
            Position = position;
            Rotation = rotation;
            GroundLevel = Window.Height;
        }

        ///
        /// <inheritdoc/> 
        ///
        public ITransform CopyOf() => new Transform(Position, Rotation);

        ///
        /// <inheritdoc/> 
        ///
        public bool IsUnderGroundLevel() => Position.Y < GroundLevel;

        ///
        /// <inheritdoc/> 
        ///
        public void Move(float x, float y) => Position += new SizeF(x, y);

        ///
        /// <inheritdoc/> 
        ///
        public void MoveOnGroundLevel()
        {
            if (IsUnderGroundLevel()) 
                Position = new PointF(Position.X, GroundLevel);
        }

        ///
        /// <inheritdoc/> 
        ///
        public void MoveTo(float x, float y) => Position = new PointF(x, y);

        ///
        /// <inheritdoc/> 
        ///
        public void ResetGroundLevel() => GroundLevel = 0;
    }
}