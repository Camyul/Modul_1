namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Giant : Character, IFighter, IGatherer
    {
        private bool increaseAttack;

        public Giant(string name, Point position) : base(name, position, 0)
        {
            this.HitPoints = 200;
            this.increaseAttack = false;
        }

        public bool IncreaseAttack
        {
            get { return this.increaseAttack; }
            private set
            {
                if (value == true)
                {
                    this.increaseAttack = value;
                }
            }
        }
        public int AttackPoints
        {
            get
            {
                if (increaseAttack)
                {
                    return 250;
                }
                return 150;
            }
        }

        public int DefensePoints
        {
            get
            {
                return 80;
            }
        }

        

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
              
                this.IncreaseAttack = true;
                
                return true;
            }

            return false;
        }
    }
}
