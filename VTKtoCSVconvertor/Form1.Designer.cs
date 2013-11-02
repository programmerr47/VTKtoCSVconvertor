namespace VTKtoCSVconvertor
{
    partial class coverterProgramm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.csvNameTextBox = new System.Windows.Forms.TextBox();
            this.progressNameLabel = new System.Windows.Forms.Label();
            this.progressStatusLabel = new System.Windows.Forms.Label();
            this.progressPercentLabel = new System.Windows.Forms.Label();
            this.vtkOpenButton = new System.Windows.Forms.Button();
            this.vtkStatusLabel = new System.Windows.Forms.Label();
            this.beginCancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.csvNameLabel = new System.Windows.Forms.Label();
            this.pointsNumberTextBox = new System.Windows.Forms.TextBox();
            this.poinsNumberLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(567, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // csvNameTextBox
            // 
            this.csvNameTextBox.Location = new System.Drawing.Point(446, 27);
            this.csvNameTextBox.Name = "csvNameTextBox";
            this.csvNameTextBox.Size = new System.Drawing.Size(133, 20);
            this.csvNameTextBox.TabIndex = 1;
            this.csvNameTextBox.Text = "simpleName";
            // 
            // progressNameLabel
            // 
            this.progressNameLabel.AutoSize = true;
            this.progressNameLabel.Location = new System.Drawing.Point(12, 80);
            this.progressNameLabel.Name = "progressNameLabel";
            this.progressNameLabel.Size = new System.Drawing.Size(62, 13);
            this.progressNameLabel.TabIndex = 2;
            this.progressNameLabel.Text = "Прогресс :";
            // 
            // progressStatusLabel
            // 
            this.progressStatusLabel.AutoSize = true;
            this.progressStatusLabel.Location = new System.Drawing.Point(74, 80);
            this.progressStatusLabel.Name = "progressStatusLabel";
            this.progressStatusLabel.Size = new System.Drawing.Size(138, 13);
            this.progressStatusLabel.TabIndex = 3;
            this.progressStatusLabel.Text = "Конвертация не началась";
            // 
            // progressPercentLabel
            // 
            this.progressPercentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressPercentLabel.AutoSize = true;
            this.progressPercentLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.progressPercentLabel.Location = new System.Drawing.Point(546, 80);
            this.progressPercentLabel.Name = "progressPercentLabel";
            this.progressPercentLabel.Size = new System.Drawing.Size(21, 13);
            this.progressPercentLabel.TabIndex = 4;
            this.progressPercentLabel.Text = "0%";
            this.progressPercentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vtkOpenButton
            // 
            this.vtkOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vtkOpenButton.Location = new System.Drawing.Point(12, 9);
            this.vtkOpenButton.Name = "vtkOpenButton";
            this.vtkOpenButton.Size = new System.Drawing.Size(133, 38);
            this.vtkOpenButton.TabIndex = 5;
            this.vtkOpenButton.Text = "Открыть vtk";
            this.vtkOpenButton.UseVisualStyleBackColor = true;
            // 
            // vtkStatusLabel
            // 
            this.vtkStatusLabel.AutoSize = true;
            this.vtkStatusLabel.Location = new System.Drawing.Point(12, 50);
            this.vtkStatusLabel.Name = "vtkStatusLabel";
            this.vtkStatusLabel.Size = new System.Drawing.Size(109, 13);
            this.vtkStatusLabel.TabIndex = 6;
            this.vtkStatusLabel.Text = "Не выбран vtk файл";
            // 
            // beginCancelButton
            // 
            this.beginCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.beginCancelButton.Location = new System.Drawing.Point(12, 125);
            this.beginCancelButton.Name = "beginCancelButton";
            this.beginCancelButton.Size = new System.Drawing.Size(133, 38);
            this.beginCancelButton.TabIndex = 7;
            this.beginCancelButton.Text = "Конвертировать";
            this.beginCancelButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.exitButton.Location = new System.Drawing.Point(446, 125);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 38);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // csvNameLabel
            // 
            this.csvNameLabel.AutoSize = true;
            this.csvNameLabel.Location = new System.Drawing.Point(443, 11);
            this.csvNameLabel.Name = "csvNameLabel";
            this.csvNameLabel.Size = new System.Drawing.Size(127, 13);
            this.csvNameLabel.TabIndex = 9;
            this.csvNameLabel.Text = "Введите имя csv файла";
            // 
            // pointsNumberTextBox
            // 
            this.pointsNumberTextBox.Location = new System.Drawing.Point(151, 27);
            this.pointsNumberTextBox.Name = "pointsNumberTextBox";
            this.pointsNumberTextBox.Size = new System.Drawing.Size(57, 20);
            this.pointsNumberTextBox.TabIndex = 10;
            this.pointsNumberTextBox.Text = "2";
            // 
            // poinsNumberLabel
            // 
            this.poinsNumberLabel.AutoSize = true;
            this.poinsNumberLabel.Location = new System.Drawing.Point(148, 9);
            this.poinsNumberLabel.Name = "poinsNumberLabel";
            this.poinsNumberLabel.Size = new System.Drawing.Size(243, 13);
            this.poinsNumberLabel.TabIndex = 11;
            this.poinsNumberLabel.Text = "Выберите количество выходных точек от 2 до ";
            // 
            // aboutButton
            // 
            this.aboutButton.Enabled = false;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.aboutButton.Location = new System.Drawing.Point(220, 125);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(133, 38);
            this.aboutButton.TabIndex = 12;
            this.aboutButton.Text = "О программе";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // coverterProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 171);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.poinsNumberLabel);
            this.Controls.Add(this.pointsNumberTextBox);
            this.Controls.Add(this.csvNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.beginCancelButton);
            this.Controls.Add(this.vtkStatusLabel);
            this.Controls.Add(this.vtkOpenButton);
            this.Controls.Add(this.progressPercentLabel);
            this.Controls.Add(this.progressStatusLabel);
            this.Controls.Add(this.progressNameLabel);
            this.Controls.Add(this.csvNameTextBox);
            this.Controls.Add(this.progressBar1);
            this.Name = "coverterProgramm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox csvNameTextBox;
        private System.Windows.Forms.Label progressNameLabel;
        private System.Windows.Forms.Label progressStatusLabel;
        private System.Windows.Forms.Label progressPercentLabel;
        private System.Windows.Forms.Button vtkOpenButton;
        private System.Windows.Forms.Label vtkStatusLabel;
        private System.Windows.Forms.Button beginCancelButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label csvNameLabel;
        private System.Windows.Forms.TextBox pointsNumberTextBox;
        private System.Windows.Forms.Label poinsNumberLabel;
        private System.Windows.Forms.Button aboutButton;
    }
}

