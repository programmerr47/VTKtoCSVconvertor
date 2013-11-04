using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTKtoCSVconvertor
{
    public partial class coverterProgramm : Form , FormObserver
    {
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
        }
    }
}
