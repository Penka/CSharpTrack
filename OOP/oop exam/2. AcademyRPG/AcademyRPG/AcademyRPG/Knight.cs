using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    class Knight : Character, IFighter
    {
        public Knight(string name, Point position, int owner) : base(name, position, owner)
        {
            this.AttackPoints = 100;
            this.DefensePoints = 100;
            this.HitPoints = 100;
        }
        public int AttackPoints { get; set; }
        public int DefensePoints { get; set; }

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
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
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
