﻿namespace KG1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьЯркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повыситьРезкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коррекцияЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.идеальныйОтражательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коррекцияСОпорнымЦветомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.эффектСтеклоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1139, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.отменаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.открытьToolStripMenuItem.Text = "Открыть ";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить ";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem1,
            this.серыйМирToolStripMenuItem,
            this.коррекцияЦветаToolStripMenuItem,
            this.идеальныйОтражательToolStripMenuItem,
            this.коррекцияСОпорнымЦветомToolStripMenuItem,
            this.эффектСтеклоToolStripMenuItem,
            this.motionBlurToolStripMenuItem,
            this.резкостьToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры ";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.серыйToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.увеличитьЯркостьToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(337, 24);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click_1);
            // 
            // серыйToolStripMenuItem
            // 
            this.серыйToolStripMenuItem.Name = "серыйToolStripMenuItem";
            this.серыйToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.серыйToolStripMenuItem.Text = "Серый";
            this.серыйToolStripMenuItem.Click += new System.EventHandler(this.серыйToolStripMenuItem_Click_1);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click_1);
            // 
            // увеличитьЯркостьToolStripMenuItem
            // 
            this.увеличитьЯркостьToolStripMenuItem.Name = "увеличитьЯркостьToolStripMenuItem";
            this.увеличитьЯркостьToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.увеличитьЯркостьToolStripMenuItem.Text = "Увеличить яркость ";
            this.увеличитьЯркостьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьЯркостьToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem1
            // 
            this.матричныеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem1,
            this.фильтрГауссаToolStripMenuItem1,
            this.фильтрСобеляToolStripMenuItem,
            this.повыситьРезкостьToolStripMenuItem});
            this.матричныеToolStripMenuItem1.Name = "матричныеToolStripMenuItem1";
            this.матричныеToolStripMenuItem1.Size = new System.Drawing.Size(337, 24);
            this.матричныеToolStripMenuItem1.Text = "Матричные";
            this.матричныеToolStripMenuItem1.Click += new System.EventHandler(this.матричныеToolStripMenuItem1_Click);
            // 
            // размытиеToolStripMenuItem1
            // 
            this.размытиеToolStripMenuItem1.Name = "размытиеToolStripMenuItem1";
            this.размытиеToolStripMenuItem1.Size = new System.Drawing.Size(216, 24);
            this.размытиеToolStripMenuItem1.Text = "Размытие";
            this.размытиеToolStripMenuItem1.Click += new System.EventHandler(this.размытиеToolStripMenuItem1_Click);
            // 
            // фильтрГауссаToolStripMenuItem1
            // 
            this.фильтрГауссаToolStripMenuItem1.Name = "фильтрГауссаToolStripMenuItem1";
            this.фильтрГауссаToolStripMenuItem1.Size = new System.Drawing.Size(216, 24);
            this.фильтрГауссаToolStripMenuItem1.Text = "Фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem1.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem1_Click);
            // 
            // фильтрСобеляToolStripMenuItem
            // 
            this.фильтрСобеляToolStripMenuItem.Name = "фильтрСобеляToolStripMenuItem";
            this.фильтрСобеляToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.фильтрСобеляToolStripMenuItem.Text = "Фильтр Собеля";
            this.фильтрСобеляToolStripMenuItem.Click += new System.EventHandler(this.фильтрСобеляToolStripMenuItem_Click);
            // 
            // повыситьРезкостьToolStripMenuItem
            // 
            this.повыситьРезкостьToolStripMenuItem.Name = "повыситьРезкостьToolStripMenuItem";
            this.повыситьРезкостьToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.повыситьРезкостьToolStripMenuItem.Text = "Повысить резкость ";
            this.повыситьРезкостьToolStripMenuItem.Click += new System.EventHandler(this.повыситьРезкостьToolStripMenuItem_Click);
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(337, 24);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
            // 
            // коррекцияЦветаToolStripMenuItem
            // 
            this.коррекцияЦветаToolStripMenuItem.Name = "коррекцияЦветаToolStripMenuItem";
            this.коррекцияЦветаToolStripMenuItem.Size = new System.Drawing.Size(337, 24);
            this.коррекцияЦветаToolStripMenuItem.Text = "Линейное растяжение гистограммы ";
            this.коррекцияЦветаToolStripMenuItem.Click += new System.EventHandler(this.коррекцияЦветаToolStripMenuItem_Click);
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            this.идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            this.идеальныйОтражательToolStripMenuItem.Size = new System.Drawing.Size(337, 24);
            this.идеальныйОтражательToolStripMenuItem.Text = "Идеальный отражатель";
            this.идеальныйОтражательToolStripMenuItem.Click += new System.EventHandler(this.ИдеальныйОтражательToolStripMenuItem_Click);
            // 
            // коррекцияСОпорнымЦветомToolStripMenuItem
            // 
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Name = "коррекцияСОпорнымЦветомToolStripMenuItem";
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Size = new System.Drawing.Size(337, 24);
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Text = "Коррекция с опорным цветом";
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Click += new System.EventHandler(this.КоррекцияСОпорнымЦветомToolStripMenuItem_Click);
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.отменаToolStripMenuItem.Text = "Отмена";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 595);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1139, 16);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // эффектСтеклоToolStripMenuItem
            // 
            this.эффектСтеклоToolStripMenuItem.Name = "эффектСтеклоToolStripMenuItem";
            this.эффектСтеклоToolStripMenuItem.Size = new System.Drawing.Size(337, 24);
            this.эффектСтеклоToolStripMenuItem.Text = "Эффект Стекло";
            this.эффектСтеклоToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклоToolStripMenuItem_Click);
            // 
            // motionBlurToolStripMenuItem
            // 
            this.motionBlurToolStripMenuItem.Name = "motionBlurToolStripMenuItem";
            this.motionBlurToolStripMenuItem.Size = new System.Drawing.Size(337, 24);
            this.motionBlurToolStripMenuItem.Text = "Motion Blur";
            this.motionBlurToolStripMenuItem.Click += new System.EventHandler(this.motionBlurToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(337, 24);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1163, 623);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem серыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem увеличитьЯркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСобеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повыситьРезкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коррекцияЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коррекцияСОпорнымЦветомToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem эффектСтеклоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
    }
}

