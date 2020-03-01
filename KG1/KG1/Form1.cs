using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KG1
{
    public partial class Form1 : Form
    {
        Bitmap image;

        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png; *.jpg;*.bmp| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {}

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
                image = newImage;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {}

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void матричныеToolStripMenuItem_Click(object sender, EventArgs e)
        {}
        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {}
        private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {}
        private void серыйToolStripMenuItem_Click(object sender, EventArgs e)
        {}
        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {}
        private void матричныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {}

        private void размытиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters f2 = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(f2);
        }

        private void фильтрГауссаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters fG = new GausFilter();
            backgroundWorker1.RunWorkerAsync(fG);
        }

        private void серыйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filters f3 = new GrayScale();
            backgroundWorker1.RunWorkerAsync(f3);
        }

        private void сепияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filters f4 = new Sepia();
            backgroundWorker1.RunWorkerAsync(f4);
        }

        private void инверсияToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InvertFilter f = new InvertFilter();
            /* Bitmap result = f.processImage(image);
             pictureBox1.Image = result;
             pictureBox1.Refresh();
             */

            backgroundWorker1.RunWorkerAsync(f);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.pictureBox1.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void увеличитьЯркостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters f5 = new bright();
            backgroundWorker1.RunWorkerAsync(f5);
        }

        private void фильтрСобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters f6 = new Sobel();
            backgroundWorker1.RunWorkerAsync(f6);
        }

        private void повыситьРезкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters f7 = new Sharpness();
            backgroundWorker1.RunWorkerAsync(f7);
        }
    }
}
