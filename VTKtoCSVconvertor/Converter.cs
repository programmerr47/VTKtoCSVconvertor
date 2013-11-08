using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace VTKtoCSVconvertor
{
    class Converter
    {
        private int maxNumberOfPoints = -1;
        private int numberOfPoints = -1;
        private string sourceName;
        private string targetName;
        private string path;

        private string convertStatus = "";
        private double progress;

        private static Converter instance;
        private FormObserver observer;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Converter getInstance()
        {
            if (instance == null)
                instance = new Converter();

            return instance;
        }

        public void setObserver(FormObserver observer)
        {
            this.observer = observer;
        }

        public void setSource(string wholePath) {
            maxNumberOfPoints = getMaxNumberOfPointsFromFile(wholePath);
            observer.updatePointsNumberMessage();

            path = wholePath.Substring(0, wholePath.LastIndexOf("\\"));
            sourceName = wholePath.Substring(wholePath.LastIndexOf("\\") + 1);
            observer.updateSourceNameLabel();
        }

        private int getMaxNumberOfPointsFromFile(string wholePath)
        {
            StreamReader file = new StreamReader(wholePath);
            string line;
            while (!(((line = file.ReadLine()) == null) || line.Contains("DIMENSIONS"))) ;
            line = line.Substring(line.IndexOf("DIMENSIONS") + 11);
            string[] strNumbers = line.Split(' ');
            int minNumber = Int32.Parse(strNumbers[0]);
            for (int i = 0; i < strNumbers.Length; i++)
            {
                if (minNumber > Int32.Parse(strNumbers[i]))
                    minNumber = Int32.Parse(strNumbers[i]);
            }
            file.Close();

            return minNumber;
        }

        public string getSourceName()
        {
            return sourceName;
        }

        public int getNumberOfPoints()
        {
            return numberOfPoints;
        }

        public int getMaxNumberOfPoints()
        {
            return maxNumberOfPoints;
        }

        public string getTargetName()
        {
            return targetName;
        }

        public void setNumberOfPoints(int numberOfPoints)
        {
            if (maxNumberOfPoints == -1)
            {
                if (numberOfPoints >= 2)
                    this.numberOfPoints = numberOfPoints;
                else
                    this.numberOfPoints = -1;
                observer.updatePointsNumberLabel();
            }
            else
            {
                if ((numberOfPoints >= 2) && (numberOfPoints <= 100))
                    this.numberOfPoints = numberOfPoints;
                else
                    this.numberOfPoints = -1;
                observer.updatePointsNumberLabel();
            }
        }

        public void setTargetName(string targetName)
        {
            if (Regex.IsMatch(targetName, @"^[a-zA-Z]+$"))
                this.targetName = targetName;
            else
                this.targetName = "-";
            observer.updateOutNameStatus();
        }

        public void convertAsync() 
        {
            Thread t1 = new Thread(convert);
            t1.Start();
        }

        public void convert()
        {
            progress = 0;
            observer.updateProgress();
            Number[] numbers = getRandNumbers();
            Array.Sort(numbers, NumberComparator.compareNumber);
            progress = 10;
            double progressStep = (100 - progress) / maxNumberOfPoints;
            observer.updateProgress();

            StreamReader file = new StreamReader(path + "\\" + sourceName);
            StreamWriter outFile = new StreamWriter(path + "\\" + targetName);

            string line;
            string outLine = null;
            int xStep = 1;
            int yStep = 1;
            int zStep = 1;
            int index = 0;
            int numberIndex = 0;
            string[] strNum;

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("SPACING"))
                {
                    line = line.Substring(line.IndexOf("SPACING") + 8);
                    strNum = line.Split(' ');
                    try
                    {
                        xStep = Int32.Parse(strNum[0]);
                        yStep = Int32.Parse(strNum[1]);
                        zStep = Int32.Parse(strNum[2]);
                    }
                    catch (Exception e)
                    {
                    }
                }
                else if (StringsUtils.numberString(line))
                {
                    strNum = line.Split(' ');
                    for (int i = 0; i < strNum.Length / 3; i++)
                    {
                        if (numbers[numberIndex].number == index)
                        {
                            outLine = StringsUtils.generateCSVString(numbers[numberIndex], strNum[i], strNum[i + 1], strNum[i + 2]);
                            outFile.WriteLine(outLine);
                            numberIndex++;
                            progress += progressStep;
                            observer.updateProgress();
                        }
                        index++;
                    }
                }
            }

            file.Close();
            outFile.Close();
            progress = 100;
            observer.updateProgress();
        }

        private Number[] getRandNumbers()
        {
            Number[] result = new Number[numberOfPoints];
            Random random = new Random();
            int randNumber = -1;

            for (int i = 0; i < numberOfPoints; i++)
            {
                result[i] = new Number();
                result[i].x = getOneDimensionRandNumber(random, i, result, Number.X);
                result[i].y = getOneDimensionRandNumber(random, i, result, Number.Y);
                result[i].z = getOneDimensionRandNumber(random, i, result, Number.Z);
                result[i].generateNumber(maxNumberOfPoints);
            }

            return result;
        }

        private int getOneDimensionRandNumber(Random random, int currentIndex, Number[] array, int coord)
        {
            bool notEqual = false;
            int randNumber = -1;
            while (!notEqual)
            {
                randNumber = random.Next(0, maxNumberOfPoints);
                notEqual = true;
                for (int j = 0; j < currentIndex; j++)
                {
                    if (randNumber == array[j].getCoord(coord))
                        notEqual = false;
                }
            }

            return randNumber;
        }

        public double getProgress()
        {
            return progress;
        }
    }
}
