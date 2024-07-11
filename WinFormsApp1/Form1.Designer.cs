namespace ImageEditor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            btnLoadImage = new Button();
            btnSaveImage = new Button();
            trackBarBlur = new TrackBar();
            comboBoxRotate = new ComboBox();
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            btnResize = new Button();
            comboBoxFilters = new ComboBox();
            trackBarBrightness = new TrackBar();
            trackBarContrast = new TrackBar();
            textBoxText = new TextBox();
            textBoxTextX = new TextBox();
            textBoxTextY = new TextBox();
            btnAddText = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(600, 400);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(618, 12);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(75, 23);
            btnLoadImage.TabIndex = 1;
            btnLoadImage.Text = "Load Image";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(699, 12);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(75, 23);
            btnSaveImage.TabIndex = 2;
            btnSaveImage.Text = "Save Image";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // trackBarBlur
            // 
            trackBarBlur.Location = new Point(618, 41);
            trackBarBlur.Maximum = 50;
            trackBarBlur.Minimum = 1;
            trackBarBlur.Name = "trackBarBlur";
            trackBarBlur.Size = new Size(156, 56);
            trackBarBlur.TabIndex = 3;
            trackBarBlur.Value = 1;
            trackBarBlur.Scroll += trackBarBlur_Scroll;
            // 
            // comboBoxRotate
            // 
            comboBoxRotate.FormattingEnabled = true;
            comboBoxRotate.Items.AddRange(new object[] { "90", "180", "270" });
            comboBoxRotate.Location = new Point(618, 92);
            comboBoxRotate.Name = "comboBoxRotate";
            comboBoxRotate.Size = new Size(156, 28);
            comboBoxRotate.TabIndex = 4;
            comboBoxRotate.SelectedIndexChanged += comboBoxRotate_SelectedIndexChanged;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(618, 134);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(75, 27);
            textBoxWidth.TabIndex = 5;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(699, 134);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(75, 27);
            textBoxHeight.TabIndex = 6;
            // 
            // btnResize
            // 
            btnResize.Location = new Point(618, 167);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(156, 23);
            btnResize.TabIndex = 7;
            btnResize.Text = "Resize";
            btnResize.UseVisualStyleBackColor = true;
            btnResize.Click += btnResize_Click;
            // 
            // comboBoxFilters
            // 
            comboBoxFilters.FormattingEnabled = true;
            comboBoxFilters.Items.AddRange(new object[] { "Gray", "Sepia" });
            comboBoxFilters.Location = new Point(618, 208);
            comboBoxFilters.Name = "comboBoxFilters";
            comboBoxFilters.Size = new Size(156, 28);
            comboBoxFilters.TabIndex = 8;
            comboBoxFilters.SelectedIndexChanged += comboBoxFilters_SelectedIndexChanged;
            // 
            // trackBarBrightness
            // 
            trackBarBrightness.Location = new Point(618, 256);
            trackBarBrightness.Maximum = 100;
            trackBarBrightness.Minimum = 1;
            trackBarBrightness.Name = "trackBarBrightness";
            trackBarBrightness.Size = new Size(156, 56);
            trackBarBrightness.TabIndex = 14;
            trackBarBrightness.Value = 50;
            trackBarBrightness.Scroll += trackBarBrightness_Scroll;
            // 
            // trackBarContrast
            // 
            trackBarContrast.Location = new Point(618, 307);
            trackBarContrast.Maximum = 100;
            trackBarContrast.Minimum = 1;
            trackBarContrast.Name = "trackBarContrast";
            trackBarContrast.Size = new Size(156, 56);
            trackBarContrast.TabIndex = 15;
            trackBarContrast.Value = 50;
            trackBarContrast.Scroll += trackBarContrast_Scroll;
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(618, 351);
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(156, 27);
            textBoxText.TabIndex = 16;
            // 
            // textBoxTextX
            // 
            textBoxTextX.Location = new Point(618, 384);
            textBoxTextX.Name = "textBoxTextX";
            textBoxTextX.Size = new Size(35, 27);
            textBoxTextX.TabIndex = 17;
            textBoxTextX.Text = "X";
            // 
            // textBoxTextY
            // 
            textBoxTextY.Location = new Point(659, 384);
            textBoxTextY.Name = "textBoxTextY";
            textBoxTextY.Size = new Size(35, 27);
            textBoxTextY.TabIndex = 18;
            textBoxTextY.Text = "Y";
            // 
            // btnAddText
            // 
            btnAddText.Location = new Point(700, 384);
            btnAddText.Name = "btnAddText";
            btnAddText.Size = new Size(74, 23);
            btnAddText.TabIndex = 19;
            btnAddText.Text = "Add Text";
            btnAddText.UseVisualStyleBackColor = true;
            btnAddText.Click += btnAddText_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(812, 644);
            Controls.Add(btnAddText);
            Controls.Add(textBoxTextY);
            Controls.Add(textBoxTextX);
            Controls.Add(textBoxText);
            Controls.Add(trackBarContrast);
            Controls.Add(trackBarBrightness);
            Controls.Add(comboBoxFilters);
            Controls.Add(btnResize);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Controls.Add(comboBoxRotate);
            Controls.Add(trackBarBlur);
            Controls.Add(btnSaveImage);
            Controls.Add(btnLoadImage);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Image Editor";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlur).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarContrast).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.TrackBar trackBarBlur;
        private System.Windows.Forms.ComboBox comboBoxRotate;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxTextX;
        private System.Windows.Forms.TextBox textBoxTextY;
        private System.Windows.Forms.Button btnAddText;
    }
}
