using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTKtoCSVconvertor
{
    class RectangleConverter : Converter
    {
        private int sourceFieldSizeX = -1;
        private int sourceFieldSizeY = -1;
        private int sourceFieldSizeZ = -1;

        private int targetFieldSizeX = -1;
        private int targetFieldSizeY = -1;
        private int targetFieldSizeZ = -1;

        private int targetFieldBeginX = -1;
        private int targetFieldBeginY = -1;
        private int targetFieldBeginZ = -1;

        private int targetFieldOffsetX = -1;
        private int targetFieldOffsetY = -1;
        private int targetFieldOffsetZ = -1;

        public override bool isAbleToConvert()
        {
            bool ableSourceField = (sourceFieldSizeX != -1) && (sourceFieldSizeY != -1) && (sourceFieldSizeZ != -1);
            bool ableTargetFieldSize = (targetFieldSizeX != -1) && (targetFieldSizeY != -1) && (targetFieldSizeZ != -1);
            bool ableTargetFieldBegin = (targetFieldBeginX != -1) && (targetFieldBeginY != -1) && (targetFieldBeginZ != -1);
            bool ableTargetFieldOffset = (targetFieldOffsetX != -1) && (targetFieldOffsetY != -1) && (targetFieldOffsetZ != -1);

            bool ableBaseFileds = ableSourceField && ableTargetFieldBegin && ableTargetFieldOffset && ableTargetFieldSize;
            return ableBaseFileds && !targetName.Equals("-");
        }

        public override void convert()
        {
            convertStatus = "Подготовка начальных данных";
            observer.updateProgressStatus();
            progress = 0;
            observer.updateProgress();
            //Number[] numbers = getRandNumbers();
            //Array.Sort(numbers, NumberComparator.compareNumber);
            int numberOfTargetPoints = (targetFieldSizeX / targetFieldOffsetX) * (targetFieldSizeY / targetFieldOffsetY) * (targetFieldSizeZ / targetFieldOffsetZ);
            double progressStep = (100) / numberOfTargetPoints;

            StreamReader file = new StreamReader(path + "\\" + sourceName);
            StreamWriter outFile = new StreamWriter(path + "\\" + targetName + ".csv");

            string line;
            string outLine = null;
            int xStep = 1;
            int yStep = 1;
            int zStep = 1;
            int commonIndex = 1;
            int xIndex = 0;
            int yIndex = 0;
            int zIndex = 0;
            int numberIndex = 0;
            string[] strNum;

            while (((line = file.ReadLine()) != null) && (isConverting()))
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
                    if (commonIndex % 100 == 0)
                    {
                        convertStatus = "Анализ строки номер " + commonIndex;
                        observer.updateProgressStatus();
                    }
                    strNum = line.Split(new char[] { ' ', '\t' });
                    for (int i = 0; i < strNum.Length / 3; i++)
                    {
                        xIndex++;
                        if (xIndex >= sourceFieldSizeX)
                        {
                            xIndex = 0;
                            yIndex++;
                            if (yIndex >= sourceFieldSizeY)
                            {
                                yIndex = 0;
                                zIndex++;
                            }
                        }

                        if (((xIndex >= targetFieldBeginX) && (xIndex < targetFieldSizeX) && ((xIndex - targetFieldBeginX) % targetFieldOffsetX == 0)) &&
                            ((yIndex >= targetFieldBeginY) && (yIndex < targetFieldSizeY) && ((yIndex - targetFieldBeginY) % targetFieldOffsetY == 0)) &&
                            ((zIndex >= targetFieldBeginZ) && (zIndex < targetFieldSizeZ) && ((zIndex - targetFieldBeginZ) % targetFieldOffsetZ == 0))) 
                        {
                            Number number = new Number();
                            number.x = xIndex;
                            number.y = yIndex;
                            number.z = zIndex;

                            outLine = StringsUtils.generateCSVString(number, strNum[i], strNum[i + 1], strNum[i + 2]);
                            outFile.WriteLine(outLine);
                            progress += progressStep;
                            observer.updateProgress();
                        }
                    }
                }
                commonIndex++;
            }

            convertStatus = "Завершение работы";
            observer.updateProgressStatus();

            file.Close();
            outFile.Close();
            if (isConverting())
            {
                progress = 100;
                observer.updateProgress();

                convertStatus = "Конвертация успешно завершена";
                converting = false;
                observer.updateProgressStatus();
            }
            else
            {
                convertStatus = "Конвертация отменена";
                observer.updateProgressStatus();
            }
            observer.updateButtonState();
        }
    }
}
