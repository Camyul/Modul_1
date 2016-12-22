namespace Defining_Classes___Part_2
{
    using System;
    using Point3D_ClassLibrary;
    using Point3D_ClassLibrary.Generic_class;

    class DefiningClassesPart2
    {
        static void Main()
        {
            //Create two 3D Points and Print it - Task 1
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
            Console.WriteLine(rout66.ToString()!= string.Empty ? rout66.ToString() : "rout66 is Empty\n");

            Path routFromFile = PathStorage.LoadFile("../../inputPoints.txt"); // Read points from File - Task 4
            PathStorage.SaveFile("../../outputPoints.txt", routFromFile);      // Write point to File - Task 4

            GenericList<string> holydays = new GenericList<string>(2); // Create Generic List - Task 5
            holydays.AddElement("Koleda");
            holydays.AddElement("NG");
            holydays.AddElement("Ivanov Den");
            holydays.AddElement("Yordanov Den");
            Console.WriteLine(holydays[1]); // Print element by index
            holydays.RemoveAt(1);      // Remove element by index
            Console.WriteLine(holydays.ToString());
            holydays.InsertAt("New Year", 1);   // Insert element by index
            Console.WriteLine(holydays.ToString()); // Print all element from holydeys
            GenericList<int> numbers = new GenericList<int>();// Create another one Generic List 
            for (int i = 0; i < 17; i++) //Add elements
            {
                numbers.AddElement(i);
            }
            Console.WriteLine(numbers.ToString());// Print all element from numbers
            Console.WriteLine("numbers Capacity: {0}", numbers.Capacity); // Print numbers Arr Capacity
            Console.WriteLine("numbers Count: {0}\n", numbers.Count);       // Print numbers Arr Count
            //numbers.ClearAll(); // Delete all elements from numbers and set default size
            Console.WriteLine("IndexOfElement is: {0}\n", holydays.IndexOfElement("Yordanov Den"));//Finding element by its value and print it index - Task 5

            Console.WriteLine("Min Element is: {0}", holydays.MinElement());        //Task 7
            Console.WriteLine("Max Element is: {0}\n", holydays.MaxElement());      //Task 7

            Matrix<int> firstMatrix = new Matrix<int>(6,5);     //Create Matrix<T> - Task 8
            Random rnd = new Random();
            for (int row = 0; row < 6; row++)                   //Add elements in Matrix by index - Task 9
            {
                for (int col = 0; col < 5; col++)
                {
                    firstMatrix[row, col] = rnd.Next(10, 100);
                }
            }
            Console.WriteLine(firstMatrix.ToString());
            firstMatrix[3, 0] = 88;                             //Replace element from Matrix by index - Task9
            Console.WriteLine(firstMatrix.ToString());


        }
    }
}
