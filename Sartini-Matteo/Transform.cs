using System;
using System.Drawing;

namespace Sartini_Matteo
{
    /// <summary>
    /// This class models the component representing the concept
    /// of the position and the rotation of an entity.
    /// </summary>
    public class Transform
    {

        /// <summary>
        /// The position of the Entity in the level.
        /// </summary>
        public PointF Position { get; set; }
       
        /// <summary>
        /// The rotation of the Entity in relation to the X-axis.
        /// </summary>
        public double Rotation { get; set; }

        /// <summary>
        /// Creates a new instance of the class Transform.
        /// </summary>
        /// <param name="position">the starting position of the entity</param>
        /// <param name="rotation">the rotation of the entity</param>
        public Transform(PointF position, double rotation) 
        {
            this.Position = position;
            this.Rotation = rotation;
        }

        /// <summary>
        /// Translates the current position with the vector of components x and y.
        /// </summary>
        /// <param name="x">position on x-axis</param>
        /// <param name="y">position on y-axis</param>
        public void Move(float x, float y)
        {
            this.Position += new SizeF(x, y);
        }

    }
}
