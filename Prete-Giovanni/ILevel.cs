
using System.Collections.Generic;
using System;
using System.Drawing;

namespace Prete_Giovanni
{
    internal interface ILevel
    {
        void AddEntity(IEntity e);

        void UpdateEntities();

        void UpdatePlayer(Inputs input);

        List<IRenderable> RenderEntities();

        IRenderable RenderPlayer();

        void RotatePlayerWeapon(PointF mousePosition);

        void Init();

        bool IsOver();

        bool IsLevelEnded();
    }
}
