using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTKtoCSVconvertor
{
    public partial class coverterProgramm : Form , FormObserver
    {
        private const string POINT_NUMBER_MESSAGE = "Выберите количество выходных точек от 2 до ";
        private const string STANDART_CONVERT_STATUS = "Конвертация не началась";
        private const int UPDATE_STATUS_TIMER = 5 * 1000;
        private int indexTimer = 0;
        private bool isDoneConvert = true;

        private Converter converter;

        public coverterProgramm()
        {
            InitializeComponent();
            converter = Converter.getInstance();
            converter.setObserver(this);
            checkingDataCorrect.Enabled = true;
        }

        public void updateSourceNameLabel()
        {
            vtkStatusLabel.Text = converter.getSourceName();
        }

        public void updatePointsNumberLabel()
        {
            if (converter.getNumberOfPoints() == -1)
                pointsNumberStatusLabel.Text = "Введены некорректные данные.\nПожалуйста, повторите попытку";
            else
                pointsNumberStatusLabel.Text = "";
        }

        public void updatePointsNumberMessage()
        {
            if (converter.getMaxNumberOfPoints() != -1)
                poinsNumberLabel.Text = POINT_NUMBER_MESSAGE + converter.getMaxNumberOfPoints();
            else
                poinsNumberLabel.Text = POINT_NUMBER_MESSAGE;
        }

        public void updateOutNameStatus()
        {
            if (converter.getTargetName().Equals("-"))
                csvNameStatusLabel.Text = "Введено некорректное имя файла.\nНазвание должно содержать только\nбуквы латинского алфавита";
            else
                csvNameStatusLabel.Text = "";
        }

        public void updateProgress()
        {
            this.Invoke(new ThreadStart(delegate
            {
                if (converter.getProgress() > 100)
                {
                    converterProgressBar.Value = 100;
                    progressPercentLabel.Text = "100%";
                }
                else
                {
                    converterProgressBar.Value = (int)converter.getProgress();
                    progressPercentLabel.Text = (int)converter.getProgress() + "%";
                }
            }));
        }

        public void updateButtonState()
        {
            this.Invoke(new ThreadStart(delegate
            {
                if (converter.isConverting())
                {
                    beginCancelButton.Text = "Отмена";
                    isDoneConvert = false;
                }
                else
                {
                    beginCancelButton.Text = "Конвертировать";
                }
            }));
        }

        public void updateProgressStatus()
        {
            this.Invoke(new ThreadStart(delegate
            {
                progressStatusLabel.Text = converter.getProgressStatus();
                if (!converter.isConverting())
                {
                    indexTimer = 0;
                    isDoneConvert = true;
                }
            }));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vtkOpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                converter.setSource(openFileDialog.FileName);
            }
        }

        private void checkingDataCorrect_Tick(object sender, EventArgs e)
        {
            if (isDoneConvert)
            {
                indexTimer++;
                if (indexTimer * checkingDataCorrect.Interval >= UPDATE_STATUS_TIMER)
                {
                    indexTimer = 0;
                    progressStatusLabel.Text = STANDART_CONVERT_STATUS;
                }
            }

            int numberOfPoints;
            try
            {
                numberOfPoints = Int32.Parse(pointsNumberTextBox.Text);
            }
            catch (Exception ex)
            {
                numberOfPoints = -1;
            }
            converter.setNumberOfPoints(numberOfPoints);

            converter.setTargetName(csvNameTextBox.Text);
        }

        private void beginCancelButton_Click(object sender, EventArgs e)
        {
            if (converter.isConverting())
            {
                converter.cancelConvert();
            }
            else
            {
                if ((converter.getMaxNumberOfPoints() != -1) && (csvNameStatusLabel.Text.Equals("")) && (pointsNumberStatusLabel.Text.Equals("")))
                {
                    converter.convertAsync();
                }
            }
        }
    }
}
