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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coverterProgramm));
            this.converterProgressBar = new System.Windows.Forms.ProgressBar();
            this.csvNameTextBox = new System.Windows.Forms.TextBox();
            this.progressNameLabel = new System.Windows.Forms.Label();
            this.progressStatusLabel = new System.Windows.Forms.Label();
            this.progressPercentLabel = new System.Windows.Forms.Label();
            this.vtkStatusLabel = new System.Windows.Forms.Label();
            this.beginCancelButton = new System.Windows.Forms.Button();
            this.csvNameLabel = new System.Windows.Forms.Label();
            this.pointsNumberTextBox = new System.Windows.Forms.TextBox();
            this.poinsNumberLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkingDataCorrect = new System.Windows.Forms.Timer(this.components);
            this.pointsNumberStatusLabel = new System.Windows.Forms.Label();
            this.csvNameStatusLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vtkOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.typeConverter = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exConfigButton6 = new System.Windows.Forms.Button();
            this.exConfigButton4 = new System.Windows.Forms.Button();
            this.exConfigButton2 = new System.Windows.Forms.Button();
            this.exConfigButton5 = new System.Windows.Forms.Button();
            this.exConfigButton3 = new System.Windows.Forms.Button();
            this.exConfigButton1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.zRecStep = new System.Windows.Forms.TextBox();
            this.yRecStep = new System.Windows.Forms.TextBox();
            this.xRecStep = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.zRecOffset = new System.Windows.Forms.TextBox();
            this.yRecOffset = new System.Windows.Forms.TextBox();
            this.xRecOffset = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zRecSize = new System.Windows.Forms.TextBox();
            this.yRecSize = new System.Windows.Forms.TextBox();
            this.xRecSize = new System.Windows.Forms.TextBox();
            this.dimensionLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.typeConverter.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // converterProgressBar
            // 
            this.converterProgressBar.Location = new System.Drawing.Point(8, 423);
            this.converterProgressBar.Name = "converterProgressBar";
            this.converterProgressBar.Size = new System.Drawing.Size(708, 23);
            this.converterProgressBar.TabIndex = 0;
            // 
            // csvNameTextBox
            // 
            this.csvNameTextBox.Location = new System.Drawing.Point(497, 325);
            this.csvNameTextBox.Name = "csvNameTextBox";
            this.csvNameTextBox.Size = new System.Drawing.Size(219, 20);
            this.csvNameTextBox.TabIndex = 1;
            this.csvNameTextBox.Text = "simpleName";
            // 
            // progressNameLabel
            // 
            this.progressNameLabel.AutoSize = true;
            this.progressNameLabel.Location = new System.Drawing.Point(8, 407);
            this.progressNameLabel.Name = "progressNameLabel";
            this.progressNameLabel.Size = new System.Drawing.Size(62, 13);
            this.progressNameLabel.TabIndex = 2;
            this.progressNameLabel.Text = "Прогресс :";
            // 
            // progressStatusLabel
            // 
            this.progressStatusLabel.AutoSize = true;
            this.progressStatusLabel.Location = new System.Drawing.Point(70, 407);
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
            this.progressPercentLabel.Location = new System.Drawing.Point(694, 407);
            this.progressPercentLabel.Name = "progressPercentLabel";
            this.progressPercentLabel.Size = new System.Drawing.Size(21, 13);
            this.progressPercentLabel.TabIndex = 4;
            this.progressPercentLabel.Text = "0%";
            this.progressPercentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vtkStatusLabel
            // 
            this.vtkStatusLabel.AutoSize = true;
            this.vtkStatusLabel.Location = new System.Drawing.Point(494, 29);
            this.vtkStatusLabel.Name = "vtkStatusLabel";
            this.vtkStatusLabel.Size = new System.Drawing.Size(109, 13);
            this.vtkStatusLabel.TabIndex = 6;
            this.vtkStatusLabel.Text = "Не выбран vtk файл";
            // 
            // beginCancelButton
            // 
            this.beginCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.beginCancelButton.Location = new System.Drawing.Point(8, 351);
            this.beginCancelButton.Name = "beginCancelButton";
            this.beginCancelButton.Size = new System.Drawing.Size(133, 38);
            this.beginCancelButton.TabIndex = 7;
            this.beginCancelButton.Text = "Конвертировать";
            this.beginCancelButton.UseVisualStyleBackColor = true;
            this.beginCancelButton.Click += new System.EventHandler(this.beginCancelButton_Click);
            // 
            // csvNameLabel
            // 
            this.csvNameLabel.AutoSize = true;
            this.csvNameLabel.Location = new System.Drawing.Point(494, 309);
            this.csvNameLabel.Name = "csvNameLabel";
            this.csvNameLabel.Size = new System.Drawing.Size(127, 13);
            this.csvNameLabel.TabIndex = 9;
            this.csvNameLabel.Text = "Введите имя csv файла";
            // 
            // pointsNumberTextBox
            // 
            this.pointsNumberTextBox.Location = new System.Drawing.Point(9, 103);
            this.pointsNumberTextBox.Name = "pointsNumberTextBox";
            this.pointsNumberTextBox.Size = new System.Drawing.Size(57, 20);
            this.pointsNumberTextBox.TabIndex = 10;
            this.pointsNumberTextBox.Text = "2";
            // 
            // poinsNumberLabel
            // 
            this.poinsNumberLabel.AutoSize = true;
            this.poinsNumberLabel.Location = new System.Drawing.Point(6, 87);
            this.poinsNumberLabel.Name = "poinsNumberLabel";
            this.poinsNumberLabel.Size = new System.Drawing.Size(243, 13);
            this.poinsNumberLabel.TabIndex = 11;
            this.poinsNumberLabel.Text = "Выберите количество выходных точек от 2 до ";
            // 
            // checkingDataCorrect
            // 
            this.checkingDataCorrect.Tick += new System.EventHandler(this.checkingDataCorrect_Tick);
            // 
            // pointsNumberStatusLabel
            // 
            this.pointsNumberStatusLabel.AutoSize = true;
            this.pointsNumberStatusLabel.Location = new System.Drawing.Point(148, 396);
            this.pointsNumberStatusLabel.Name = "pointsNumberStatusLabel";
            this.pointsNumberStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.pointsNumberStatusLabel.TabIndex = 13;
            // 
            // csvNameStatusLabel
            // 
            this.csvNameStatusLabel.AutoSize = true;
            this.csvNameStatusLabel.Location = new System.Drawing.Point(443, 396);
            this.csvNameStatusLabel.Name = "csvNameStatusLabel";
            this.csvNameStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.csvNameStatusLabel.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.aboutButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vtkOpenButton,
            this.exitButton});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // vtkOpenButton
            // 
            this.vtkOpenButton.Name = "vtkOpenButton";
            this.vtkOpenButton.Size = new System.Drawing.Size(140, 22);
            this.vtkOpenButton.Text = "Открыть vtk";
            this.vtkOpenButton.Click += new System.EventHandler(this.vtkOpenButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 22);
            this.exitButton.Text = "Выход";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(94, 20);
            this.aboutButton.Text = "О программе";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // typeConverter
            // 
            this.typeConverter.Controls.Add(this.tabPage1);
            this.typeConverter.Controls.Add(this.tabPage2);
            this.typeConverter.Location = new System.Drawing.Point(8, 48);
            this.typeConverter.Name = "typeConverter";
            this.typeConverter.SelectedIndex = 0;
            this.typeConverter.Size = new System.Drawing.Size(484, 297);
            this.typeConverter.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.poinsNumberLabel);
            this.tabPage1.Controls.Add(this.pointsNumberTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выборка случайных точек";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 65);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.exConfigButton6);
            this.tabPage2.Controls.Add(this.exConfigButton4);
            this.tabPage2.Controls.Add(this.exConfigButton2);
            this.tabPage2.Controls.Add(this.exConfigButton5);
            this.tabPage2.Controls.Add(this.exConfigButton3);
            this.tabPage2.Controls.Add(this.exConfigButton1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.zRecStep);
            this.tabPage2.Controls.Add(this.yRecStep);
            this.tabPage2.Controls.Add(this.xRecStep);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.zRecOffset);
            this.tabPage2.Controls.Add(this.yRecOffset);
            this.tabPage2.Controls.Add(this.xRecOffset);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.zRecSize);
            this.tabPage2.Controls.Add(this.yRecSize);
            this.tabPage2.Controls.Add(this.xRecSize);
            this.tabPage2.Controls.Add(this.dimensionLabel);
            this.tabPage2.Controls.Add(this.infoLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выборка параллелепипеда";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // exConfigButton6
            // 
            this.exConfigButton6.Location = new System.Drawing.Point(349, 226);
            this.exConfigButton6.Name = "exConfigButton6";
            this.exConfigButton6.Size = new System.Drawing.Size(121, 39);
            this.exConfigButton6.TabIndex = 27;
            this.exConfigButton6.Text = "Пример 6";
            this.exConfigButton6.UseVisualStyleBackColor = true;
            this.exConfigButton6.Click += new System.EventHandler(this.exConfigButton6_Click);
            // 
            // exConfigButton4
            // 
            this.exConfigButton4.Location = new System.Drawing.Point(181, 226);
            this.exConfigButton4.Name = "exConfigButton4";
            this.exConfigButton4.Size = new System.Drawing.Size(121, 39);
            this.exConfigButton4.TabIndex = 26;
            this.exConfigButton4.Text = "Пример 4";
            this.exConfigButton4.UseVisualStyleBackColor = true;
            this.exConfigButton4.Click += new System.EventHandler(this.exConfigButton4_Click);
            // 
            // exConfigButton2
            // 
            this.exConfigButton2.Location = new System.Drawing.Point(12, 226);
            this.exConfigButton2.Name = "exConfigButton2";
            this.exConfigButton2.Size = new System.Drawing.Size(121, 39);
            this.exConfigButton2.TabIndex = 25;
            this.exConfigButton2.Text = "Пример 2";
            this.exConfigButton2.UseVisualStyleBackColor = true;
            this.exConfigButton2.Click += new System.EventHandler(this.exConfigButton2_Click);
            // 
            // exConfigButton5
            // 
            this.exConfigButton5.Location = new System.Drawing.Point(349, 181);
            this.exConfigButton5.Name = "exConfigButton5";
            this.exConfigButton5.Size = new System.Drawing.Size(121, 39);
            this.exConfigButton5.TabIndex = 24;
            this.exConfigButton5.Text = "Пример 5";
            this.exConfigButton5.UseVisualStyleBackColor = true;
            this.exConfigButton5.Click += new System.EventHandler(this.exConfigButton5_Click);
            // 
            // exConfigButton3
            // 
            this.exConfigButton3.Location = new System.Drawing.Point(181, 181);
            this.exConfigButton3.Name = "exConfigButton3";
            this.exConfigButton3.Size = new System.Drawing.Size(124, 39);
            this.exConfigButton3.TabIndex = 23;
            this.exConfigButton3.Text = "Пример 3";
            this.exConfigButton3.UseVisualStyleBackColor = true;
            this.exConfigButton3.Click += new System.EventHandler(this.exConfigButton3_Click);
            // 
            // exConfigButton1
            // 
            this.exConfigButton1.Location = new System.Drawing.Point(9, 181);
            this.exConfigButton1.Name = "exConfigButton1";
            this.exConfigButton1.Size = new System.Drawing.Size(124, 39);
            this.exConfigButton1.TabIndex = 22;
            this.exConfigButton1.Text = "Пример 1";
            this.exConfigButton1.UseVisualStyleBackColor = true;
            this.exConfigButton1.Click += new System.EventHandler(this.exConfigButton1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(346, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "y=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "z=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(346, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "x=";
            // 
            // zRecStep
            // 
            this.zRecStep.Location = new System.Drawing.Point(370, 121);
            this.zRecStep.Name = "zRecStep";
            this.zRecStep.Size = new System.Drawing.Size(100, 20);
            this.zRecStep.TabIndex = 18;
            // 
            // yRecStep
            // 
            this.yRecStep.Location = new System.Drawing.Point(370, 95);
            this.yRecStep.Name = "yRecStep";
            this.yRecStep.Size = new System.Drawing.Size(100, 20);
            this.yRecStep.TabIndex = 17;
            // 
            // xRecStep
            // 
            this.xRecStep.Location = new System.Drawing.Point(370, 69);
            this.xRecStep.Name = "xRecStep";
            this.xRecStep.Size = new System.Drawing.Size(100, 20);
            this.xRecStep.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(367, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Шаг дискретизации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "y=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "z=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "x=";
            // 
            // zRecOffset
            // 
            this.zRecOffset.Location = new System.Drawing.Point(205, 121);
            this.zRecOffset.Name = "zRecOffset";
            this.zRecOffset.Size = new System.Drawing.Size(100, 20);
            this.zRecOffset.TabIndex = 11;
            // 
            // yRecOffset
            // 
            this.yRecOffset.Location = new System.Drawing.Point(205, 95);
            this.yRecOffset.Name = "yRecOffset";
            this.yRecOffset.Size = new System.Drawing.Size(100, 20);
            this.yRecOffset.TabIndex = 10;
            // 
            // xRecOffset
            // 
            this.xRecOffset.Location = new System.Drawing.Point(205, 69);
            this.xRecOffset.Name = "xRecOffset";
            this.xRecOffset.Size = new System.Drawing.Size(100, 20);
            this.xRecOffset.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Координаты начала";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "y=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "z=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "x=";
            // 
            // zRecSize
            // 
            this.zRecSize.Location = new System.Drawing.Point(33, 121);
            this.zRecSize.Name = "zRecSize";
            this.zRecSize.Size = new System.Drawing.Size(100, 20);
            this.zRecSize.TabIndex = 4;
            // 
            // yRecSize
            // 
            this.yRecSize.Location = new System.Drawing.Point(33, 95);
            this.yRecSize.Name = "yRecSize";
            this.yRecSize.Size = new System.Drawing.Size(100, 20);
            this.yRecSize.TabIndex = 3;
            // 
            // xRecSize
            // 
            this.xRecSize.Location = new System.Drawing.Point(33, 69);
            this.xRecSize.Name = "xRecSize";
            this.xRecSize.Size = new System.Drawing.Size(100, 20);
            this.xRecSize.TabIndex = 2;
            // 
            // dimensionLabel
            // 
            this.dimensionLabel.AutoSize = true;
            this.dimensionLabel.Location = new System.Drawing.Point(30, 53);
            this.dimensionLabel.Name = "dimensionLabel";
            this.dimensionLabel.Size = new System.Drawing.Size(54, 13);
            this.dimensionLabel.TabIndex = 1;
            this.dimensionLabel.Text = "Размеры";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(6, 3);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(453, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Укажите размеры прямоугольника, координаты начальной точки и шаг дискретизации";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(497, 69);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(219, 237);
            this.messageBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Выбери один из вариантов выбора точек";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Сообщения об ошибках";
            // 
            // coverterProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.typeConverter);
            this.Controls.Add(this.csvNameStatusLabel);
            this.Controls.Add(this.pointsNumberStatusLabel);
            this.Controls.Add(this.csvNameLabel);
            this.Controls.Add(this.beginCancelButton);
            this.Controls.Add(this.vtkStatusLabel);
            this.Controls.Add(this.progressPercentLabel);
            this.Controls.Add(this.progressStatusLabel);
            this.Controls.Add(this.progressNameLabel);
            this.Controls.Add(this.csvNameTextBox);
            this.Controls.Add(this.converterProgressBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "coverterProgramm";
            this.Text = "VTK to CSV";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.typeConverter.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar converterProgressBar;
        private System.Windows.Forms.TextBox csvNameTextBox;
        private System.Windows.Forms.Label progressNameLabel;
        private System.Windows.Forms.Label progressStatusLabel;
        private System.Windows.Forms.Label progressPercentLabel;
        private System.Windows.Forms.Label vtkStatusLabel;
        private System.Windows.Forms.Button beginCancelButton;
        private System.Windows.Forms.Label csvNameLabel;
        private System.Windows.Forms.TextBox pointsNumberTextBox;
        private System.Windows.Forms.Label poinsNumberLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer checkingDataCorrect;
        private System.Windows.Forms.Label pointsNumberStatusLabel;
        private System.Windows.Forms.Label csvNameStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vtkOpenButton;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.TabControl typeConverter;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox zRecStep;
        private System.Windows.Forms.TextBox yRecStep;
        private System.Windows.Forms.TextBox xRecStep;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox zRecOffset;
        private System.Windows.Forms.TextBox yRecOffset;
        private System.Windows.Forms.TextBox xRecOffset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zRecSize;
        private System.Windows.Forms.TextBox yRecSize;
        private System.Windows.Forms.TextBox xRecSize;
        private System.Windows.Forms.Label dimensionLabel;
        private System.Windows.Forms.Button exConfigButton6;
        private System.Windows.Forms.Button exConfigButton4;
        private System.Windows.Forms.Button exConfigButton2;
        private System.Windows.Forms.Button exConfigButton5;
        private System.Windows.Forms.Button exConfigButton3;
        private System.Windows.Forms.Button exConfigButton1;
    }
}

