using System.Drawing;

public interface ITransform
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    void move(float x, float y);

    void moveOnGroundLevel();

    bool isUnderGroundLevel();
    void resetGroundLevel();

    void moveTo(float x, float y);

    ITransform copyOf();
}