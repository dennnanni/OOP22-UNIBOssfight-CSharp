using Prete_Giovanni;
using System.Drawing;
using System.Reflection;

public interface IRenderer
{
    void Init();

    IRenderable Render(PointF position, int xDirection, int yDirection, double rotation);
}

