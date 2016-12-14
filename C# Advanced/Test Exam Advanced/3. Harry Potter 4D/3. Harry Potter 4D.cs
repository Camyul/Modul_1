

namespace Harry_Potter_4D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class HarryPotter4D
    {
        public static bool harryVsBasi = false;
        public static bool basiVsHarry = false;
        static void Main()
        {
            //Read Console
            int[] sizeArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[,,,] hipperCube = new string[sizeArray[0], sizeArray[1], sizeArray[2], sizeArray[3]];
            int[] harryCoor = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int countBasilisk = int.Parse(Console.ReadLine());
            string[] basiCoorStr = new string[countBasilisk];
            for (int i = 0; i < countBasilisk; i++)
            {
                basiCoorStr[i] = Console.ReadLine();
            }
            
            List<string> moveUnit = new List<string>();
            while (true)
            {
                string move = Console.ReadLine();
                if (move == "END")
                {
                    break;
                }
                moveUnit.Add(move);
            }
            PasteUnit(hipperCube, basiCoorStr, harryCoor, countBasilisk);
            //Make moves
            MoveUnit(hipperCube, moveUnit);
            //Check colision
            //Print result
           
            Console.WriteLine();
        }

        private static void MoveUnit(string[,,,] hipperCube, List<string> moveUnit)
        {
            string allDimension = "ABCD";
            int harryMovesCount = 0;
            for (int i = 0; i < moveUnit.Count; i++)
            {
                
                string basiName = TransformBasiCoor(moveUnit[i].Substring(0, 1));
                if (basiName == "@")
                {
                    harryMovesCount++;
                }
                moveUnit[i] = moveUnit[i].Remove(0, 2);
                string dimLetter = TransformBasiCoor(moveUnit[i].Substring(0, 1));
                moveUnit[i] = moveUnit[i].Remove(0, 2);
                int dimension = allDimension.IndexOf(dimLetter, 0);
                int step = int.Parse(moveUnit[i]);
                FindUnitCoor(hipperCube, basiName, dimension, step, harryMovesCount);
                
            }
            Console.WriteLine("@: \"I am the chosen one!\" - {0}", harryMovesCount);

        }
        private static void CheckColision(string[,,,] hipperCube, int first, int second, int third, int four, string basiName, int harryMovesCount)
        {
            
            if (hipperCube[first, second, third, four] == "@")
            {
                harryVsBasi = true;
                Console.WriteLine("{0}: \"You thought you could escape, didn't you?\" - {1}",basiName, harryMovesCount);
                Environment.Exit(0);
            }
            else if (basiName == "@" && hipperCube[first, second, third, four] != null)
            {
                basiVsHarry = true;
                Console.WriteLine("{0}: \"Step {1} was the worst you ever made.\"\n{0}: You will regret until the rest of your life... All 3 seconds of it!\"", hipperCube[first, second, third, four], harryMovesCount);
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }
        private static void FindUnitCoor(string[,,,] hipperCube, string basiName, int dimension, int step, int harryMovesCount)
        {
            if (!harryVsBasi && !basiVsHarry)
            {
                for (int firstDim = 0; firstDim < hipperCube.GetLength(0); firstDim++)
                {
                    for (int secondDim = 0; secondDim < hipperCube.GetLength(1); secondDim++)
                    {
                        for (int thirdDim = 0; thirdDim < hipperCube.GetLength(2); thirdDim++)
                        {
                            for (int fourDim = 0; fourDim < hipperCube.GetLength(3); fourDim++)
                            {
                                if (hipperCube[firstDim, secondDim, thirdDim, fourDim] == basiName)
                                {

                                    if (hipperCube[firstDim, secondDim, thirdDim, fourDim].Length <= 1)
                                    {
                                        hipperCube[firstDim, secondDim, thirdDim, fourDim] = null;
                                    }
                                    else
                                    {
                                        int name = hipperCube[firstDim, secondDim, thirdDim, fourDim].IndexOf(basiName, 0);
                                        hipperCube[firstDim, secondDim, thirdDim, fourDim] = hipperCube[firstDim, secondDim, thirdDim, fourDim].Remove(name, 1);

                                    }
                                    if (dimension == 0)
                                    {
                                        if (((firstDim + step) >= 0 && (firstDim + step) < hipperCube.GetLength(0)))
                                        {
                                            CheckColision(hipperCube, firstDim + step, secondDim, thirdDim, fourDim, basiName, harryMovesCount);
                                            hipperCube[firstDim + step, secondDim, thirdDim, fourDim] += basiName;
                                            return;
                                        }
                                        else if ((firstDim + step) < 0)
                                        {
                                            CheckColision(hipperCube, 0, secondDim, thirdDim, fourDim, basiName, harryMovesCount);
                                            hipperCube[0, secondDim, thirdDim, fourDim] += basiName;
                                            return;
                                        }
                                        else
                                        {
                                            CheckColision(hipperCube, hipperCube.GetLength(0) - 1, secondDim, thirdDim, fourDim, basiName, harryMovesCount);
                                            hipperCube[hipperCube.GetLongLength(0) - 1, secondDim, thirdDim, fourDim] += basiName;
                                            return;
                                        }
                                    }

                                    if (dimension == 1)
                                    {
                                        if (((secondDim + step) >= 0 && (secondDim + step) < hipperCube.GetLength(1)))
                                        {
                                            CheckColision(hipperCube, firstDim, secondDim + step, thirdDim, fourDim, basiName, harryMovesCount);
                                            hipperCube[firstDim, secondDim + step, thirdDim, fourDim] += basiName;
                                            return;
                                        }
                                        else if ((secondDim + step) < 0)
                                        {
                                            CheckColision(hipperCube, firstDim, 0, thirdDim, fourDim, basiName, harryMovesCount);
                                            hipperCube[firstDim, 0, thirdDim, fourDim] += basiName;
                                            return;
                                        }
                                        else
                                        {
                                            CheckColision(hipperCube, firstDim, hipperCube.GetLength(1) - 1, thirdDim, fourDim, basiName, harryMovesCount);
                                            hipperCube[firstDim, hipperCube.GetLongLength(1) - 1, thirdDim, fourDim] += basiName;
                                            return;
                                        }
                                    }
                                    if (dimension == 2)
                                    {
                                        if (((thirdDim + step) >= 0 && (thirdDim + step) < hipperCube.GetLength(2)))
                                        {
                                            CheckColision(hipperCube, firstDim, secondDim, thirdDim + step, fourDim, basiName, harryMovesCount);
                                            hipperCube[firstDim, secondDim, thirdDim + step, fourDim] += basiName;
                                            return;
                                        }
                                        else if ((thirdDim + step) < 0)
                                        {
                                            CheckColision(hipperCube, firstDim, secondDim, 0, fourDim, basiName, harryMovesCount);
                                            hipperCube[firstDim, secondDim, 0, fourDim] += basiName;
                                            return;
                                        }
                                        else
                                        {
                                            CheckColision(hipperCube, firstDim, secondDim, hipperCube.GetLength(2) - 1, fourDim, basiName, harryMovesCount);
                                            hipperCube[firstDim, secondDim, hipperCube.GetLongLength(2) - 1, fourDim] += basiName;
                                            return;
                                        }
                                    }

                                    if (dimension == 3)
                                    {
                                        if (((fourDim + step) >= 0 && (fourDim + step) < hipperCube.GetLength(3)))
                                        {
                                            CheckColision(hipperCube, firstDim, secondDim, thirdDim, fourDim + step, basiName, harryMovesCount);
                                            hipperCube[firstDim, secondDim, thirdDim, fourDim + step] += basiName;
                                            return;
                                        }
                                        else if ((fourDim + step) < 0)
                                        {
                                            CheckColision(hipperCube, firstDim, secondDim, thirdDim, 0, basiName, harryMovesCount);
                                            hipperCube[firstDim, secondDim, thirdDim, 0] += basiName;
                                            return;
                                        }
                                        else
                                        {
                                            CheckColision(hipperCube, firstDim, secondDim, thirdDim, hipperCube.GetLength(3) - 1, basiName, harryMovesCount);
                                            hipperCube[firstDim, secondDim, thirdDim, hipperCube.GetLongLength(3) - 1] += basiName;
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void PasteUnit(string[,,,] hipperCube, string[] basiCoorStr, int[] harryCoor, int countBasi)
        {
            
            hipperCube[harryCoor[0], harryCoor[1], harryCoor[2], harryCoor[3]] = "@";
            for (int i = 0; i < countBasi; i++)
            {
                if (!harryVsBasi && !basiVsHarry)
                {
                    string basiName = TransformBasiCoor(basiCoorStr[i]);
                    basiCoorStr[i] = basiCoorStr[i].Remove(0, 2);
                    int[] basiCoor = basiCoorStr[i].Split(' ').Select(int.Parse).ToArray();
                    hipperCube[basiCoor[0], basiCoor[1], basiCoor[2], basiCoor[3]] = basiName;
                }
                else
                {
                    break;
                }
            }

            
        }

        private static string TransformBasiCoor(string basiCoor)
        {
            string basiName = basiCoor.Substring(0, 1);
            return basiName;
        }
    }
}
