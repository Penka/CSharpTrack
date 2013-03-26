using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    class Rock : StaticObject, IResource
    {
        ResourceType type;
        public Rock(int hitPoints, Point position)
            : base(position, 0)
        {
            this.HitPoints = hitPoints;
            this.type = ResourceType.Stone;
            this.Quantity = this.HitPoints / 2;
        }
        public int Quantity { get; set; }

        public ResourceType Type
        {
            get { return this.type; }
        }
    }
}
