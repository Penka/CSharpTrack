using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    class Giant : Character, IFighter, IGatherer
    {
        private bool firtsGather;
        public Giant(string name, Point position) : base(name, position, 0)
        {
            this.AttackPoints = 150;
            this.DefensePoints = 80;
            this.HitPoints = 200;
            this.firtsGather = false;
        }
        public int AttackPoints { get; set; }
        public int DefensePoints { get; set; }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!firtsGather)
                {
                    this.firtsGather = true;
                    this.AttackPoints = this.AttackPoints + 100;
                }
                return true;
            }

            return false;
        }

        private double Distance(int x1, int x2, int y1, int y2)
        {
            double dist = Math.Sqrt((x1-x2) * (x1-x2) + (y1-y2) * (y1-y2));
            return dist;
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int minIndex = -1;
            double minDistance = double.MaxValue;
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    double currentDdistance = Distance(this.Position.X, availableTargets[i].Position.X,
                        this.Position.Y, availableTargets[i].Position.Y);
                    if (currentDdistance < minDistance)
                    {
                        minDistance = currentDdistance;
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }
    }
}
