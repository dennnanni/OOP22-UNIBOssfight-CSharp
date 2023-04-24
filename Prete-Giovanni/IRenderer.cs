using Prete_Giovanni;
using System.Drawing;

public interface IRenderer
{
    void Init();

    IRenderable Render(PointF position, double rotation);
}

