namespace Defining_Classes___Part_2
{
    using System;
    using Point3D_ClassLibrary;

    class DefiningClassesPart2
    {
        static void Main()
        {
            //Create two 3D Points and Print it
            Point3D firstPoint = new Point3D (1.1, 2.2, 3.3);
            Console.WriteLine(firstPoint.ToString());
            Point3D secondPoint = Point3D.Center; 
            Console.WriteLine(Point3D.Center.ToString());

            //Calculate distance with static class and static method and print it
            Console.WriteLine("Distance: {0}", Distance.Calculate(firstPoint, secondPoint));

            Path rout66 = new Path();
            rout66.AddPoint(firstPoint);
            rout66.AddPoint(secondPoint);
            rout66.ToString();
        }
    }
}
