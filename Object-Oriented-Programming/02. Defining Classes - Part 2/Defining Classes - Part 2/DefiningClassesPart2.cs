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
            Console.WriteLine(Point3D.Center.ToString()); // Print static field - Task 2

            //Calculate distance with static class and static method and print it - Task 3
            Console.WriteLine("Distance: {0}\n", Distance.Calculate(firstPoint, secondPoint));

            Path rout66 = new Path(); // Create class Path to Hold points in List - Task 4
            rout66.AddPoint(firstPoint);
            rout66.AddPoint(secondPoint);
            rout66.AddPoint(new Point3D(5, 8, 3));
            rout66.AddPoint(new Point3D(6, 6, 6));
            rout66.AddPoint(new Point3D(3.3, 3.3, 3.3));
            rout66.RemovePoint(new Point3D (5, 8, 3));
            Console.WriteLine("Point with index[2] is:\n{0}\n", rout66[2]);         // Print by index
            Console.WriteLine("All points coordinate: \n{0}", rout66.ToString());   //Print All Points
            Console.WriteLine("All points count: {0}", rout66.CountPoints);         //Print Points Count
            rout66.ClearPoint();
            Console.WriteLine(rout66.ToString()!= string.Empty ? rout66.ToString() : "rout66 is Empty");

            Path routFromFile = PathStorage.LoadFile("../../inputPoints.txt"); // Read points from File - Task 4
            PathStorage.SaveFile("../../outputPoints.txt", routFromFile);      // Write point to File - Task 4


        }
    }
}
