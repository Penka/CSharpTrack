using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    class Ninja : Character, IFighter, IGatherer
    {
        public int HitPoints
        {
            get
            {
                return 1;
            }
            set
            {
            }
        }
        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            base.HitPoints = 1;
            this.AttackPoints = 0;
            this.DefensePoints = int.MaxValue;
        }
        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }


        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints = this.AttackPoints + resource.Quantity;
                return true;
            }
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints = this.AttackPoints + resource.Quantity * 2;
                return true;
            }

            return false;
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int result = -1;
            int maxPoints = int.MinValue;
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    if (availableTargets[i].HitPoints > maxPoints)
                    {
                        maxPoints = availableTargets[i].HitPoints;
                        result = i;
                    }
                }
            }

            return result;
        }
    }
}
