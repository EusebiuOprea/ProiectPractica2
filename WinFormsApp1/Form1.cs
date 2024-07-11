using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> originalImage;
        private Image<Bgr, byte> editedImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Image<Bgr, byte>(openFileDialog.FileName);
                    editedImage = originalImage.Clone();
                    pictureBox.Image = editedImage.ToBitmap();
                }
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    editedImage.Save(saveFileDialog.FileName);
                }
            }
        }

        private void trackBarBlur_Scroll(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                int blurAmount = trackBarBlur.Value;
                editedImage = originalImage.SmoothBlur(blurAmount, blurAmount);
                pictureBox.Image = editedImage.ToBitmap();
            }
        }

        private void comboBoxRotate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                int angle = int.Parse(comboBoxRotate.SelectedItem.ToString());
                editedImage = originalImage.Rotate(angle, new Bgr(Color.White));
                pictureBox.Image = editedImage.ToBitmap();
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                int newWidth = int.Parse(textBoxWidth.Text);
                int newHeight = int.Parse(textBoxHeight.Text);
                editedImage = originalImage.Resize(newWidth, newHeight, Inter.Linear);
                pictureBox.Image = editedImage.ToBitmap();
            }
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                switch (comboBoxFilters.SelectedItem.ToString())
                {
                    case "Gray":
                        editedImage = originalImage.Convert<Gray, byte>().Convert<Bgr, byte>();
                        break;
                    case "Sepia":
                        editedImage = ApplySepiaFilter(originalImage);
                        break;
                }
                pictureBox.Image = editedImage.ToBitmap();
            }
        }
        private Image<Bgr, byte> ApplySepiaFilter(Image<Bgr, byte> image)
        {
            // Create an empty image with the same size as the original
            Image<Bgr, byte> sepiaImage = new Image<Bgr, byte>(image.Size);

            // Define the sepia transformation matrix
            float[] sepiaKernel = new float[]
            {
        0.272f, 0.534f, 0.131f,
        0.349f, 0.686f, 0.168f,
        0.393f, 0.769f, 0.189f
            };

            // Create a Mat object for the sepiaKernel
            Mat sepiaMat = new Mat(3, 3, DepthType.Cv32F, 1);
            sepiaMat.SetTo(sepiaKernel);

            // Apply the sepia filter using the transformation matrix
            CvInvoke.Transform(image, sepiaImage, sepiaMat);

            return sepiaImage;
        }



       /* private void btnCrop_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                int x = int.Parse(textBoxCropX.Text);
                int y = int.Parse(textBoxCropY.Text);
                int width = int.Parse(textBoxCropWidth.Text);
                int height = int.Parse(textBoxCropHeight.Text);
                Rectangle rect = new Rectangle(x, y, width, height);
                // editedImage = new Image<Bgr, byte>(originalImage.Bitmap).GetSubRect(rect);
                pictureBox.Image = editedImage.ToBitmap();
            }
        }*/

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                double brightness = trackBarBrightness.Value / 50.0;
                editedImage = originalImage.Mul(brightness);
                pictureBox.Image = editedImage.ToBitmap();
            }
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                double contrast = trackBarContrast.Value / 50.0;
                CvInvoke.AddWeighted(originalImage, contrast, originalImage, 0, 0, editedImage);
                pictureBox.Image = editedImage.ToBitmap();
            }
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                string text = textBoxText.Text;
                int x = int.Parse(textBoxTextX.Text);
                int y = int.Parse(textBoxTextY.Text);
                CvInvoke.PutText(editedImage, text, new Point(x, y), FontFace.HersheySimplex, 1.0, new Bgr(Color.Blue).MCvScalar);
                pictureBox.Image = editedImage.ToBitmap();
            }
        }
    }
}
