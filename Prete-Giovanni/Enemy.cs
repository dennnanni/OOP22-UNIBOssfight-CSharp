namespace Prete_Giovanni
{
    internal class Enemy : ActiveEntity
    {
        public Enemy(ITransform transform, int height, int width, IRenderer renderer) : base(transform, height, width, renderer)
        {
        }
    }
}
