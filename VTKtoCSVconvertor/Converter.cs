using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
            path = wholePath.Substring(0, wholePath.LastIndexOf("\\"));
            sourceName = wholePath.Substring(wholePath.LastIndexOf("\\") + 1);
            observer.updateSourceNameLabel();
        }

        public string getSourceName()
        {
            return sourceName;
        }

        public int getNumberOfPoints()
        {
            return numberOfPoints;
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
        }
    }
}
