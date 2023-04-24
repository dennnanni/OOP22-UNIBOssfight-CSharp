using Prete_Giovanni;
using System.Drawing;

/// <summary>
/// This class models the component used to render the entities of the game.
/// </summary>
public interface IRenderer
{
    /// <summary>
    /// Initialize the Renderer.
    /// </summary>
    void Init();

    /// <summary>
    /// The method used to render the entity.
    /// </summary>
    /// <param name="position">the position of the entity</param>
    /// <param name="rotation">the rotation of the entity</param>
    /// <returns>a Renderable that will be given as input to the Scene</returns>
    IRenderable Render(PointF position, double rotation);
}

