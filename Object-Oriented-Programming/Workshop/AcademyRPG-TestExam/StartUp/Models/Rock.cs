namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Rock : StaticObject, IResource
    {

        public Rock(int size, Point position) : base(position)
        {
            this.HitPoints = size;
        }

        public int Quantity
        {
            get
            {
                return this.HitPoints / 2;
            }
        }

        public ResourceType Type
        {
            get
            {
                return ResourceType.Stone;
            }
        }

       


    }
}
