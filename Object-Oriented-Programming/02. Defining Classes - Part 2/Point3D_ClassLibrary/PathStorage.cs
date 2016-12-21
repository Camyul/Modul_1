

namespace Point3D_ClassLibrary
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading;
    public static class PathStorage // Task 4
    {
        public static Path LoadFile(string inputFilePath) //Read point form File
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
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
        public static void SaveFile(string outputFilePath, Path points)  //Write point To File
        {
            //File.WriteAllText(outputFilePath, points.ToString());
            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < points.CountPoints; i++)
                {
                    writer.WriteLine(points[i]);
                }
            }
        }
    }
}
