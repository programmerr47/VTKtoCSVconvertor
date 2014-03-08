using System;
using System.Collections;
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
        private AboutForm af = null;
        private const string OPEN_FILE_FILTER = "ParaView Data(*.vtk)|*.vtk";
        private const string POINT_NUMBER_MESSAGE = "Выберите количество выходных точек от 2 до ";
        private const string DIMENSIONS_MESSAGE = "Укажите размеры прямоугольника, координаты начальной точки и шаг дискретизации";
        private const string STANDART_CONVERT_STATUS = "Конвертация не началась";
        private const int UPDATE_STATUS_TIMER = 5 * 1000;
        private int indexTimer = 0;
        private bool isDoneConvert = true;
        private ArrayList messages;

        private RectangleConverter converter;

        public coverterProgramm()
        {
            InitializeComponent();
            converter = RectangleConverter.getRectInstance();
            converter.setObserver(this);
            checkingDataCorrect.Enabled = true;
            openFileDialog.Filter = OPEN_FILE_FILTER;
        }

        public void updateSourceNameLabel()
        {
            vtkStatusLabel.Text = converter.getSourceName();
        }

        public void updateMessage(string sourceMessage, bool condition)
        {
            if (messages != null)
            {
                bool hasMessage = false;
                foreach (string message in messages)
                {
                    if (message.Equals(sourceMessage))
                    {
                        hasMessage = true;
                    }
                }

                if (condition)
                {
                    if (!hasMessage)
                    {
                        messages.Add(sourceMessage);
                    }
                }
                else
                {
                    if (hasMessage)
                    {
                        messages.Remove(sourceMessage);
                    }
                }
            }
            else
            {
                if (condition)
                {
                    messages = new ArrayList();
                    messages.Add(sourceMessage);
                }
            }
        }

        public void updatePointsNumberLabel()
        {
            updateMessage("- Введено некорректное число точек. Пожалуйста, проверьте, находится ли ваше число в указанном диапазоне и повторите попытку", converter.getNumberOfPoints() == -1);
        }

        public void updateFieldInfo()
        {
            updateMessage("- Введен неправильный размер поля (X - координата). Проверьте, находится ли ваше число в указанном диапазоне", converter.getTargetFieldSizeX() == -1);
            updateMessage("- Введен неправильный размер поля (Y - координата). Проверьте, находится ли ваше число в указанном диапазоне", converter.getTargetFieldSizeY() == -1);
            updateMessage("- Введен неправильный размер поля (Z - координата). Проверьте, находится ли ваше число в указанном диапазоне", converter.getTargetFieldSizeZ() == -1);
            updateMessage("- Введена неправильная начальная точка поля (X - координата). Проверьте, находится ли ваше число в указанном диапазоне (не меньше 0, не больше указанного максимума)", converter.getTargetFieldBeginX() == -1);
            updateMessage("- Введена неправильная начальная точка поля (Y - координата). Проверьте, находится ли ваше число в указанном диапазоне (не меньше 0, не больше указанного максимума)", converter.getTargetFieldBeginY() == -1);
            updateMessage("- Введена неправильная начальная точка поля (Z - координата). Проверьте, находится ли ваше число в указанном диапазоне (не меньше 0, не больше указанного максимума)", converter.getTargetFieldBeginZ() == -1);
            updateMessage("- Введен неправильный шаг дискретезации (X - координата). Проверьте, больше ли он нуля", converter.getTargetFieldOffsetX() == -1);
            updateMessage("- Введен неправильный шаг дискретезации (Y - координата). Проверьте, больше ли он нуля", converter.getTargetFieldOffsetY() == -1);
            updateMessage("- Введен неправильный шаг дискретезации (Z - координата). Проверьте, больше ли он нуля", converter.getTargetFieldOffsetZ() == -1);
        }

        public void updatePointsNumberMessage()
        {
            if (converter.getMaxNumberOfPoints() != -1)
                poinsNumberLabel.Text = POINT_NUMBER_MESSAGE + converter.getMaxNumberOfPoints();
            else
                poinsNumberLabel.Text = POINT_NUMBER_MESSAGE;
        }

        public void updateDimensionsStatus(string status)
        {
            infoLabel.Text = DIMENSIONS_MESSAGE + "\n" + status;
        }

        public void updateOutNameStatus()
        {
            updateMessage("- Введено некорректное имя файла. Название должно содержать только буквы латинского алфавита", converter.getTargetName().Equals("-"));
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
                    beginCancelButton.Text = "Отменить";
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
                    converterProgressBar.Value = 0;
                    progressPercentLabel.Text = "0%";
                    progressStatusLabel.Text = STANDART_CONVERT_STATUS;
                }
            }

            int numberOfPoints;
            try { numberOfPoints = Int32.Parse(pointsNumberTextBox.Text); } 
            catch (Exception ex) { numberOfPoints = -1; }
            converter.setNumberOfPoints(numberOfPoints);

            int rectSizeX;
            try { rectSizeX = Int32.Parse(xRecSize.Text); }
            catch (Exception ex) { rectSizeX = -1; }
            converter.setTargetFieldSizeX(rectSizeX);

            int rectSizeY;
            try { rectSizeY = Int32.Parse(yRecSize.Text); }
            catch (Exception ex) { rectSizeY = -1; }
            converter.setTargetFieldSizeY(rectSizeY);

            int rectSizeZ;
            try { rectSizeZ = Int32.Parse(zRecSize.Text); }
            catch (Exception ex) { rectSizeZ = -1; }
            converter.setTargetFieldSizeZ(rectSizeZ);

            int rectBeginX;
            try { rectBeginX = Int32.Parse(xRecOffset.Text); }
            catch (Exception ex) { rectBeginX = -1; }
            converter.setTargetFieldBeginX(rectBeginX);

            int rectBeginY;
            try { rectBeginY = Int32.Parse(yRecOffset.Text); }
            catch (Exception ex) { rectBeginY = -1; }
            converter.setTargetFieldBeginY(rectBeginY);

            int rectBeginZ;
            try { rectBeginZ = Int32.Parse(zRecOffset.Text); }
            catch (Exception ex) { rectBeginZ = -1; }
            converter.setTargetFieldBeginZ(rectBeginZ);

            int rectStepX;
            try { rectStepX = Int32.Parse(xRecStep.Text); }
            catch (Exception ex) { rectStepX = -1; }
            converter.setTargetFieldOffsetX(rectStepX);

            int rectStepY;
            try { rectStepY = Int32.Parse(yRecStep.Text); }
            catch (Exception ex) { rectStepY = -1; }
            converter.setTargetFieldOffsetY(rectStepY);

            int rectStepZ;
            try { rectStepZ = Int32.Parse(zRecStep.Text); }
            catch (Exception ex) { rectStepZ = -1; }
            converter.setTargetFieldOffsetZ(rectStepZ);

            converter.setTargetName(csvNameTextBox.Text);

            if (messages != null)
            {
                string messagesBoxText = "";
                foreach(string message in messages) 
                {
                    messagesBoxText += message + Environment.NewLine + Environment.NewLine;
                }
                messageBox.Text = messagesBoxText;
            }
        }

        private void beginCancelButton_Click(object sender, EventArgs e)
        {
            if (converter.isConverting())
            {
                converter.cancelConvert();
            }
            else
            {
                if (typeConverter.SelectedIndex == 0)
                {
                    if (converter.isAbleToConvert())
                    {
                        converter.convertAsync();
                    }
                }
                else
                {
                    if (converter.isAbleToRectangleConvert())
                    {
                        converter.rectangleConvertAsync();
                    }
                }
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            if (af != null) af.Close();
            af = new AboutForm();
            af.Activate();
            af.Show();
        }

        private void configurateByExample(int sizeX, int sizeY, int sizeZ, int offsetX, int offsetY, int offsetZ, int discX, int discY, int discZ)
        {
            xRecSize.Text = sizeX.ToString();
            yRecSize.Text = sizeY.ToString();
            zRecSize.Text = sizeZ.ToString();
            xRecOffset.Text = offsetX.ToString();
            yRecOffset.Text = offsetY.ToString();
            zRecOffset.Text = offsetZ.ToString();
            xRecStep.Text = discX.ToString();
            yRecStep.Text = discY.ToString();
            zRecStep.Text = discZ.ToString();
        }

        private void exConfigButton1_Click(object sender, EventArgs e)
        {
            configurateByExample(converter.getSourceFieldSizeX(), converter.getSourceFieldSizeY(), converter.getSourceFieldSizeZ(), 0, 0, 0, 4, 4, 4);
        }

        private void exConfigButton2_Click(object sender, EventArgs e)
        {
            configurateByExample(converter.getSourceFieldSizeX(), converter.getSourceFieldSizeY(), converter.getSourceFieldSizeZ(), 0, 0, 0, 16, 16, 16);
        }

        private void exConfigButton3_Click(object sender, EventArgs e)
        {
            configurateByExample(converter.getSourceFieldSizeX() / 2, converter.getSourceFieldSizeY() / 3, converter.getSourceFieldSizeZ() / 4,
                converter.getSourceFieldSizeX() / 4, converter.getSourceFieldSizeY() / 4, converter.getSourceFieldSizeZ() / 4, 3, 3, 3);
        }

        private void exConfigButton4_Click(object sender, EventArgs e)
        {
            configurateByExample(converter.getSourceFieldSizeX() / 2, converter.getSourceFieldSizeY() / 2, converter.getSourceFieldSizeZ() / 2,
                0, converter.getSourceFieldSizeY() / 4, converter.getSourceFieldSizeZ() / 2, 3, 3, 3);
        }

        private void exConfigButton5_Click(object sender, EventArgs e)
        {
            configurateByExample(converter.getSourceFieldSizeX() / 3, converter.getSourceFieldSizeY() / 3, converter.getSourceFieldSizeZ() / 3,
                0, 0, 0, 6, 6, 6);
        }

        private void exConfigButton6_Click(object sender, EventArgs e)
        {
            configurateByExample(converter.getSourceFieldSizeX() / 3, converter.getSourceFieldSizeY() / 5, converter.getSourceFieldSizeZ() / 2,
                converter.getSourceFieldSizeX() / 2, converter.getSourceFieldSizeX() / 5, converter.getSourceFieldSizeX() / 7, 6, 6, 6);
        }

    }
}
