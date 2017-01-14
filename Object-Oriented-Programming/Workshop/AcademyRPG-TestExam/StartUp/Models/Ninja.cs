namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Ninja : Character, IFighter, IGatherer
    {
        private int attackPoints;
        private int hitPoints;
        public Ninja(string name, Point position, int owner) : base(name, position, owner)
        {
            this.HitPoints = 1;
            this.AttackPoints = 0;
        }

        public new int HitPoints
        {
            get { return this.hitPoints; }
            private set { 
            //{
            //    if (value <= 0)
            //    {
            //        this.hitPoints = 1;
            //    }
                this.hitPoints = value;
            }
        }
        public int AttackPoints
        {
            get { return this.attackPoints;}
            private set { this.attackPoints = value; }
        }

        public int DefensePoints
        {
            get
            {
                return int.MaxValue; 
            }
        }

        

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target = availableTargets
                 .Where(x => x.Owner != 0 && x.Owner != this.Owner)
                 .OrderByDescending(x => x.HitPoints)
                 .FirstOrDefault();


            return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }
            else if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }

            return false;
        }

        
    }
}
