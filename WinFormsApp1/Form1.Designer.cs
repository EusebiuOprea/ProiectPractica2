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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.trackBarBlur = new System.Windows.Forms.TrackBar();
            this.comboBoxRotate = new System.Windows.Forms.ComboBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.textBoxCropX = new System.Windows.Forms.TextBox();
            this.textBoxCropY = new System.Windows.Forms.TextBox();
            this.textBoxCropWidth = new System.Windows.Forms.TextBox();
            this.textBoxCropHeight = new System.Windows.Forms.TextBox();
            this.btnCrop = new System.Windows.Forms.Button();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxTextX = new System.Windows.Forms.TextBox();
            this.textBoxTextY = new System.Windows.Forms.TextBox();
            this.btnAddText = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.SuspendLayout();

            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;

            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(618, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(699, 12);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 2;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);

            // 
            // trackBarBlur
            // 
            this.trackBarBlur.Location = new System.Drawing.Point(618, 41);
            this.trackBarBlur.Maximum = 50;
            this.trackBarBlur.Minimum = 1;
            this.trackBarBlur.Name = "trackBarBlur";
            this.trackBarBlur.Size = new System.Drawing.Size(156, 45);
            this.trackBarBlur.TabIndex = 3;
            this.trackBarBlur.Value = 1;
            this.trackBarBlur.Scroll += new System.EventHandler(this.trackBarBlur_Scroll);

            // 
            // comboBoxRotate
            // 
            this.comboBoxRotate.FormattingEnabled = true;
            this.comboBoxRotate.Items.AddRange(new object[] {
            "90",
            "180",
            "270"});
            this.comboBoxRotate.Location = new System.Drawing.Point(618, 92);
            this.comboBoxRotate.Name = "comboBoxRotate";
            this.comboBoxRotate.Size = new System.Drawing.Size(156, 21);
            this.comboBoxRotate.TabIndex = 4;
            this.comboBoxRotate.SelectedIndexChanged += new System.EventHandler(this.comboBoxRotate_SelectedIndexChanged);

            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(618, 119);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(75, 20);
            this.textBoxWidth.TabIndex = 5;

            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(699, 119);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(75, 20);
            this.textBoxHeight.TabIndex = 6;

            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(618, 145);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(156, 23);
            this.btnResize.TabIndex = 7;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);

            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Items.AddRange(new object[] {
            "Gray",
            "Sepia"});
            this.comboBoxFilters.Location = new System.Drawing.Point(618, 174);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(156, 21);
            this.comboBoxFilters.TabIndex = 8;
            this.comboBoxFilters.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);

            // 
            // textBoxCropX
            // 
            this.textBoxCropX.Location = new System.Drawing.Point(618, 201);
            this.textBoxCropX.Name = "textBoxCropX";
            this.textBoxCropX.Size = new System.Drawing.Size(35, 20);
            this.textBoxCropX.TabIndex = 9;
            this.textBoxCropX.Text = "X";

            // 
            // textBoxCropY
            // 
            this.textBoxCropY.Location = new System.Drawing.Point(659, 201);
            this.textBoxCropY.Name = "textBoxCropY";
            this.textBoxCropY.Size = new System.Drawing.Size(35, 20);
            this.textBoxCropY.TabIndex = 10;
            this.textBoxCropY.Text = "Y";

            // 
            // textBoxCropWidth
            // 
            this.textBoxCropWidth.Location = new System.Drawing.Point(700, 201);
            this.textBoxCropWidth.Name = "textBoxCropWidth";
            this.textBoxCropWidth.Size = new System.Drawing.Size(35, 20);
            this.textBoxCropWidth.TabIndex = 11;
            this.textBoxCropWidth.Text = "Width";

            // 
            // textBoxCropHeight
            // 
            this.textBoxCropHeight.Location = new System.Drawing.Point(741, 201);
            this.textBoxCropHeight.Name = "textBoxCropHeight";
            this.textBoxCropHeight.Size = new System.Drawing.Size(35, 20);
            this.textBoxCropHeight.TabIndex = 12;
            this.textBoxCropHeight.Text = "Height";

            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(618, 227);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(156, 23);
            this.btnCrop.TabIndex = 13;
            this.btnCrop.Text = "Crop";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);

            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(618, 256);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Minimum = 1;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(156, 45);
            this.trackBarBrightness.TabIndex = 14;
            this.trackBarBrightness.Value = 50;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);

            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(618, 307);
            this.trackBarContrast.Maximum = 100;
            this.trackBarContrast.Minimum = 1;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(156, 45);
            this.trackBarContrast.TabIndex = 15;
            this.trackBarContrast.Value = 50;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);

            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(618, 358);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(156, 20);
            this.textBoxText.TabIndex = 16;

            // 
            // textBoxTextX
            // 
            this.textBoxTextX.Location = new System.Drawing.Point(618, 384);
            this.textBoxTextX.Name = "textBoxTextX";
            this.textBoxTextX.Size = new System.Drawing.Size(35, 20);
            this.textBoxTextX.TabIndex = 17;
            this.textBoxTextX.Text = "X";

            // 
            // textBoxTextY
            // 
            this.textBoxTextY.Location = new System.Drawing.Point(659, 384);
            this.textBoxTextY.Name = "textBoxTextY";
            this.textBoxTextY.Size = new System.Drawing.Size(35, 20);
            this.textBoxTextY.TabIndex = 18;
            this.textBoxTextY.Text = "Y";

            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(700, 384);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(74, 23);
            this.btnAddText.TabIndex = 19;
            this.btnAddText.Text = "Add Text";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnAddText);
            this.Controls.Add(this.textBoxTextY);
            this.Controls.Add(this.textBoxTextX);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.btnCrop);
            this.Controls.Add(this.textBoxCropHeight);
            this.Controls.Add(this.textBoxCropWidth);
            this.Controls.Add(this.textBoxCropY);
            this.Controls.Add(this.textBoxCropX);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.comboBoxRotate);
            this.Controls.Add(this.trackBarBlur);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Image Editor";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxCropX;
        private System.Windows.Forms.TextBox textBoxCropY;
        private System.Windows.Forms.TextBox textBoxCropWidth;
        private System.Windows.Forms.TextBox textBoxCropHeight;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxTextX;
        private System.Windows.Forms.TextBox textBoxTextY;
        private System.Windows.Forms.Button btnAddText;
    }
}
