using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VTKtoCSVconvertor
{
    class RectangleConverter : Converter
    {
        private static RectangleConverter instance;

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

        public int getSourceFieldSizeX() { return sourceFieldSizeX; }
        public int getSourceFieldSizeY() { return sourceFieldSizeY; }
        public int getSourceFieldSizeZ() { return sourceFieldSizeZ; }
        public int getTargetFieldSizeX() { return targetFieldSizeX; }
        public int getTargetFieldSizeY() { return targetFieldSizeY; }
        public int getTargetFieldSizeZ() { return targetFieldSizeZ; }
        public int getTargetFieldBeginX() { return targetFieldBeginX;}
        public int getTargetFieldBeginY() { return targetFieldBeginY;}
        public int getTargetFieldBeginZ() { return targetFieldBeginZ;}
        public int getTargetFieldOffsetX() { return targetFieldOffsetX; }
        public int getTargetFieldOffsetY() { return targetFieldOffsetY; }
        public int getTargetFieldOffsetZ() { return targetFieldOffsetZ; }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static RectangleConverter getRectInstance()
        {
            if (instance == null)
                instance = new RectangleConverter();

            return instance;
        }

        public override void setSource(string wholePath)
        {
            base.setSource(wholePath);
            getDimensions(wholePath);
            observer.updateDimensionsStatus("максимальные размеры в координатах (" + sourceFieldSizeX + ";" + sourceFieldSizeY + ";" + sourceFieldSizeZ + ") \n" +
                                            "начало координат базового поля (0; 0; 0)");

            path = wholePath.Substring(0, wholePath.LastIndexOf("\\"));
            sourceName = wholePath.Substring(wholePath.LastIndexOf("\\") + 1);
            observer.updateSourceNameLabel();
        }

        public void setTargetFieldOffsetX(int targetFieldOffsetX)
        {
            if (targetFieldOffsetX > 0)
            {
                this.targetFieldOffsetX = targetFieldOffsetX;
            }
            else
            {
                this.targetFieldOffsetX = -1;
            }
            observer.updateFieldInfo();
        }

        public void setTargetFieldOffsetY(int targetFieldOffsetY)
        {
            if (targetFieldOffsetY > 0)
            {
                this.targetFieldOffsetY = targetFieldOffsetY;
            }
            else
            {
                this.targetFieldOffsetY = -1;
            }
            observer.updateFieldInfo();
        }

        public void setTargetFieldOffsetZ(int targetFieldOffsetZ)
        {
            if (targetFieldOffsetZ > 0)
            {
                this.targetFieldOffsetZ = targetFieldOffsetZ;
            }
            else
            {
                this.targetFieldOffsetZ = -1;
            }
            observer.updateFieldInfo();
        }

        private int setTargetFieldOffset(int size, int offset)
        {
            if ((size != -1) && ((size - 1) % offset == 0))
            {
                return offset;
            }
            else
            {
                return -1;
            }
        }

        public void setTargetFieldSizeX(int targetFieldSizeX)
        {
            this.targetFieldSizeX = setTargetField(targetFieldSizeX, targetFieldBeginX, sourceFieldSizeX);
            observer.updateFieldInfo();
        }

        public void setTargetFieldSizeY(int targetFieldSizeY)
        {
            this.targetFieldSizeY = setTargetField(targetFieldSizeY, targetFieldBeginY, sourceFieldSizeY);
            observer.updateFieldInfo();
        }

        public void setTargetFieldSizeZ(int targetFieldSizeZ)
        {
            this.targetFieldSizeZ = setTargetField(targetFieldSizeZ, targetFieldBeginZ, sourceFieldSizeZ);
            observer.updateFieldInfo();
        }

        private int setTargetField(int a, int b, int sourceSize)
        {
            int temp = 0;
            if (b != -1)
            {
                temp = b;
            }

            if (temp + a - sourceSize <= 0)
            {
                return a;
            }
            else
            {
                return -1;
            }
        }

        public void setTargetFieldBeginX(int targetFieldBeginX)
        {
            this.targetFieldBeginX = setTargetField(targetFieldBeginX, targetFieldSizeX, sourceFieldSizeX);
            observer.updateFieldInfo();
        }

        public void setTargetFieldBeginY(int targetFieldBeginY)
        {
            this.targetFieldBeginY = setTargetField(targetFieldBeginY, targetFieldSizeY, sourceFieldSizeY);
            observer.updateFieldInfo();
        }

        public void setTargetFieldBeginZ(int targetFieldBeginZ)
        {
            this.targetFieldBeginZ = setTargetField(targetFieldBeginZ, targetFieldSizeZ, sourceFieldSizeZ);
            observer.updateFieldInfo();
        }

        private void getDimensions(string wholePath)
        {
            StreamReader file = new StreamReader(wholePath);
            string line;
            int minNumber = -1;
            while (!(((line = file.ReadLine()) == null) || line.Contains("DIMENSIONS"))) ;
            if (line != null)
            {
                line = line.Substring(line.IndexOf("DIMENSIONS") + 11);
                string[] strNumbers = line.Split(' ');
                sourceFieldSizeX = Int32.Parse(strNumbers[0]);
                sourceFieldSizeY = Int32.Parse(strNumbers[1]);
                sourceFieldSizeZ = Int32.Parse(strNumbers[2]);
            }
            file.Close();
        }

        public bool isAbleToRectangleConvert()
        {
            bool ableSourceField = (sourceFieldSizeX != -1) && (sourceFieldSizeY != -1) && (sourceFieldSizeZ != -1);
            bool ableTargetFieldSize = (targetFieldSizeX != -1) && (targetFieldSizeY != -1) && (targetFieldSizeZ != -1);
            bool ableTargetFieldBegin = (targetFieldBeginX != -1) && (targetFieldBeginY != -1) && (targetFieldBeginZ != -1);
            bool ableTargetFieldOffset = (targetFieldOffsetX != -1) && (targetFieldOffsetY != -1) && (targetFieldOffsetZ != -1);

            bool ableBaseFileds = ableSourceField && ableTargetFieldBegin && ableTargetFieldOffset && ableTargetFieldSize;
            return ableBaseFileds && !targetName.Equals("-");
        }

        public void rectangleConvertAsync()
        {
            converting = true;
            observer.updateButtonState();
            Thread t1 = new Thread(rectangleConvert);
            t1.Start();
        }

        public void rectangleConvert()
        {
            convertStatus = "Подготовка начальных данных";
            observer.updateProgressStatus();
            progress = 0;
            observer.updateProgress();
            int remainX = (((targetFieldSizeX - 1) % targetFieldOffsetX) == 0) ? 0 : 1;
            int remainY = (((targetFieldSizeY - 1) % targetFieldOffsetY) == 0) ? 0 : 1;
            int remainZ = (((targetFieldSizeZ - 1) % targetFieldOffsetZ) == 0) ? 0 : 1;
            int numberOfXPoints = (((targetFieldSizeX - 1) / targetFieldOffsetX) > 0) ? (((targetFieldSizeX - 1) / targetFieldOffsetX) + 1 + remainX) : 2;
            int numberOfYPoints = (((targetFieldSizeY - 1) / targetFieldOffsetY) > 0) ? (((targetFieldSizeY - 1) / targetFieldOffsetY) + 1 + remainY) : 2;
            int numberOfZPoints = (((targetFieldSizeZ - 1) / targetFieldOffsetZ) > 0) ? (((targetFieldSizeZ - 1) / targetFieldOffsetZ) + 1 + remainZ) : 2;
            int numberOfTargetPoints = numberOfXPoints * numberOfYPoints * numberOfZPoints;
            double progressStep = (100.0) / numberOfTargetPoints;

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
                        if ((((xIndex >= targetFieldBeginX) && (xIndex < (targetFieldSizeX + targetFieldBeginX)) && ((xIndex - targetFieldBeginX) % targetFieldOffsetX == 0)) || (xIndex == (targetFieldSizeX + targetFieldBeginX - 1))) &&
                            (((yIndex >= targetFieldBeginY) && (yIndex < (targetFieldSizeY + targetFieldBeginY)) && ((yIndex - targetFieldBeginY) % targetFieldOffsetY == 0)) || (yIndex == (targetFieldSizeY + targetFieldBeginY - 1))) &&
                            (((zIndex >= targetFieldBeginZ) && (zIndex < (targetFieldSizeZ + targetFieldBeginZ)) && ((zIndex - targetFieldBeginZ) % targetFieldOffsetZ == 0)) || (zIndex == (targetFieldSizeZ + targetFieldBeginZ - 1)))) 
                        {
                            Number number = new Number();
                            number.x = xIndex;
                            number.y = yIndex;
                            number.z = zIndex;

                            outLine = StringsUtils.generateCSVString(number, strNum[i * 3], strNum[i * 3 + 1], strNum[i * 3 + 2]);
                            outFile.WriteLine(outLine);
                            progress += progressStep;
                            observer.updateProgress();
                        }

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
