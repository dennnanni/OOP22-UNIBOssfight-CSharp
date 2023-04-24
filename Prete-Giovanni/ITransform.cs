using System.Drawing;

namespace Prete_Giovanni
{

    public interface ITransform
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Move(float x, float y);

        void MoveOnGroundLevel();

        bool IsUnderGroundLevel();
        void ResetGroundLevel();

        void MoveTo(float x, float y);

        ITransform CopyOf();
    }
}