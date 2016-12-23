

namespace Point3D_ClassLibrary
{
    using System;
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |  AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute      //Task 11 
    {
        
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
        
    }
}
