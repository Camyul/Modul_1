namespace Defining_Classes___Part_2
{
    using System;
    using Point3D_ClassLibrary;

    class DefiningClassesPart2
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D (1.1, 2.2, 3.3);
            Console.WriteLine(firstPoint.ToString());
            Console.WriteLine(Point3D.O.ToString());
        }
    }
}
