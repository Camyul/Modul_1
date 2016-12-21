

namespace Point3D_ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class PathStorage // Task 4
    {
        public static Path LoadFile(string inputFilePath)
        {
            Path pathFromFile = new Path();
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string row = string.Empty;
                while (reader.EndOfStream == false)
                {
                    row = reader.ReadLine();
                    double[] currentPoint = row.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                    pathFromFile.AddPoint(new Point3D(currentPoint[0], currentPoint[1], currentPoint[2]));
                }
            }
            return pathFromFile;
        }
        public static void SaveFile(string outputFilePath, Path points)
        {
            //File.WriteAllText(outputFilePath, points.ToString());
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < points.CountPoints; i++)
                {
                    writer.WriteLine(points[0]);
                }
            }
        }
    }
}
