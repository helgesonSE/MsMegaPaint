namespace MsMegaPaint
{
    partial class MsMegaPaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            undoButton = new Button();
            redoButton = new Button();
            saveShapesButton = new Button();
            loadShapesButton = new Button();
            blackButton = new Button();
            whiteButton = new Button();
            orangeButton = new Button();
            redButton = new Button();
            greenButton = new Button();
            yellowButton = new Button();
            purpleButton = new Button();
            blueButton = new Button();
            selectedColorBox = new Button();
            toolBox = new GroupBox();
            pencilRadioButton = new RadioButton();
            lineRadioButton = new RadioButton();
            triangleRadioButton = new RadioButton();
            squareRadioButton = new RadioButton();
            circleRadioButton = new RadioButton();
            saveBitmapButton = new Button();
            saveBitmapDialog = new SaveFileDialog();
            saveShapesDialog = new SaveFileDialog();
            openShapesDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            toolBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(114, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(994, 676);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // undoButton
            // 
            undoButton.Location = new Point(12, 439);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(96, 28);
            undoButton.TabIndex = 6;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // redoButton
            // 
            redoButton.Location = new Point(12, 468);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(96, 28);
            redoButton.TabIndex = 7;
            redoButton.Text = "Redo";
            redoButton.UseVisualStyleBackColor = true;
            redoButton.Click += redoButton_Click;
            // 
            // saveShapesButton
            // 
            saveShapesButton.Location = new Point(12, 497);
            saveShapesButton.Name = "saveShapesButton";
            saveShapesButton.Size = new Size(96, 28);
            saveShapesButton.TabIndex = 8;
            saveShapesButton.Text = "Save";
            saveShapesButton.UseVisualStyleBackColor = true;
            saveShapesButton.Click += saveShapesButton_Click;
            // 
            // loadShapesButton
            // 
            loadShapesButton.Location = new Point(12, 526);
            loadShapesButton.Name = "loadShapesButton";
            loadShapesButton.Size = new Size(96, 28);
            loadShapesButton.TabIndex = 9;
            loadShapesButton.Text = "Load";
            loadShapesButton.UseVisualStyleBackColor = true;
            loadShapesButton.Click += loadShapesButton_Click;
            // 
            // blackButton
            // 
            blackButton.BackColor = Color.Black;
            blackButton.Location = new Point(12, 169);
            blackButton.Name = "blackButton";
            blackButton.Size = new Size(43, 40);
            blackButton.TabIndex = 10;
            blackButton.Text = "button10";
            blackButton.UseVisualStyleBackColor = false;
            blackButton.Click += blackButton_Click;
            // 
            // whiteButton
            // 
            whiteButton.BackColor = Color.White;
            whiteButton.Location = new Point(65, 169);
            whiteButton.Name = "whiteButton";
            whiteButton.Size = new Size(43, 40);
            whiteButton.TabIndex = 11;
            whiteButton.UseVisualStyleBackColor = false;
            whiteButton.Click += whiteButton_Click;
            // 
            // orangeButton
            // 
            orangeButton.BackColor = Color.DarkOrange;
            orangeButton.Location = new Point(65, 215);
            orangeButton.Name = "orangeButton";
            orangeButton.Size = new Size(43, 40);
            orangeButton.TabIndex = 13;
            orangeButton.UseVisualStyleBackColor = false;
            orangeButton.Click += orangeButton_Click;
            // 
            // redButton
            // 
            redButton.BackColor = Color.Red;
            redButton.Location = new Point(12, 215);
            redButton.Name = "redButton";
            redButton.Size = new Size(43, 40);
            redButton.TabIndex = 12;
            redButton.UseVisualStyleBackColor = false;
            redButton.Click += redButton_Click;
            // 
            // greenButton
            // 
            greenButton.BackColor = Color.LawnGreen;
            greenButton.Location = new Point(65, 261);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(43, 40);
            greenButton.TabIndex = 15;
            greenButton.UseVisualStyleBackColor = false;
            greenButton.Click += greenButton_Click;
            // 
            // yellowButton
            // 
            yellowButton.BackColor = Color.Yellow;
            yellowButton.Location = new Point(12, 261);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(43, 40);
            yellowButton.TabIndex = 14;
            yellowButton.UseMnemonic = false;
            yellowButton.UseVisualStyleBackColor = false;
            yellowButton.Click += yellowButton_Click;
            // 
            // purpleButton
            // 
            purpleButton.BackColor = Color.MediumOrchid;
            purpleButton.Location = new Point(65, 307);
            purpleButton.Name = "purpleButton";
            purpleButton.Size = new Size(43, 40);
            purpleButton.TabIndex = 17;
            purpleButton.UseVisualStyleBackColor = false;
            purpleButton.Click += purpleButton_Click;
            // 
            // blueButton
            // 
            blueButton.BackColor = Color.DodgerBlue;
            blueButton.Location = new Point(12, 307);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(43, 40);
            blueButton.TabIndex = 16;
            blueButton.UseVisualStyleBackColor = false;
            blueButton.Click += blueButton_Click;
            // 
            // selectedColorBox
            // 
            selectedColorBox.Enabled = false;
            selectedColorBox.Location = new Point(12, 353);
            selectedColorBox.Name = "selectedColourBox";
            selectedColorBox.Size = new Size(96, 80);
            selectedColorBox.TabIndex = 18;
            selectedColorBox.UseVisualStyleBackColor = true;
            // 
            // toolBox
            // 
            toolBox.Controls.Add(pencilRadioButton);
            toolBox.Controls.Add(lineRadioButton);
            toolBox.Controls.Add(triangleRadioButton);
            toolBox.Controls.Add(squareRadioButton);
            toolBox.Controls.Add(circleRadioButton);
            toolBox.Location = new Point(12, 12);
            toolBox.Name = "toolBox";
            toolBox.Size = new Size(96, 151);
            toolBox.TabIndex = 20;
            toolBox.TabStop = false;
            toolBox.Text = "Tools";
            // 
            // pencilRadioButton
            // 
            pencilRadioButton.AutoSize = true;
            pencilRadioButton.Location = new Point(18, 118);
            pencilRadioButton.Name = "pencilRadioButton";
            pencilRadioButton.Size = new Size(57, 19);
            pencilRadioButton.TabIndex = 4;
            pencilRadioButton.TabStop = true;
            pencilRadioButton.Text = "Pencil";
            pencilRadioButton.UseVisualStyleBackColor = true;
            pencilRadioButton.CheckedChanged += pencilRadioButton_CheckedChanged;
            // 
            // lineRadioButton
            // 
            lineRadioButton.AutoSize = true;
            lineRadioButton.Location = new Point(18, 95);
            lineRadioButton.Name = "lineRadioButton";
            lineRadioButton.Size = new Size(47, 19);
            lineRadioButton.TabIndex = 3;
            lineRadioButton.TabStop = true;
            lineRadioButton.Text = "Line";
            lineRadioButton.UseVisualStyleBackColor = true;
            lineRadioButton.CheckedChanged += lineRadioButton_CheckedChanged;
            // 
            // triangleRadioButton
            // 
            triangleRadioButton.AutoSize = true;
            triangleRadioButton.Location = new Point(18, 72);
            triangleRadioButton.Name = "triangleRadioButton";
            triangleRadioButton.Size = new Size(66, 19);
            triangleRadioButton.TabIndex = 2;
            triangleRadioButton.TabStop = true;
            triangleRadioButton.Text = "Triangle";
            triangleRadioButton.UseVisualStyleBackColor = true;
            triangleRadioButton.CheckedChanged += triangleRadioButton_CheckedChanged;
            // 
            // squareRadioButton
            // 
            squareRadioButton.AutoSize = true;
            squareRadioButton.Location = new Point(18, 47);
            squareRadioButton.Name = "squareRadioButton";
            squareRadioButton.Size = new Size(61, 19);
            squareRadioButton.TabIndex = 1;
            squareRadioButton.TabStop = true;
            squareRadioButton.Text = "Square";
            squareRadioButton.UseVisualStyleBackColor = true;
            squareRadioButton.CheckedChanged += squareRadioButton_CheckedChanged;
            // 
            // circleRadioButton
            // 
            circleRadioButton.AutoSize = true;
            circleRadioButton.Location = new Point(18, 22);
            circleRadioButton.Name = "circleRadioButton";
            circleRadioButton.Size = new Size(55, 19);
            circleRadioButton.TabIndex = 0;
            circleRadioButton.TabStop = true;
            circleRadioButton.Text = "Circle";
            circleRadioButton.UseVisualStyleBackColor = true;
            circleRadioButton.CheckedChanged += circleRadioButton_CheckedChanged;
            // 
            // saveBitmapButton
            // 
            saveBitmapButton.Location = new Point(12, 555);
            saveBitmapButton.Name = "saveBitmapButton";
            saveBitmapButton.Size = new Size(96, 28);
            saveBitmapButton.TabIndex = 21;
            saveBitmapButton.Text = "Save Bitmap";
            saveBitmapButton.UseVisualStyleBackColor = true;
            saveBitmapButton.Click += saveBitmapButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 700);
            Controls.Add(saveBitmapButton);
            Controls.Add(toolBox);
            Controls.Add(selectedColorBox);
            Controls.Add(purpleButton);
            Controls.Add(blueButton);
            Controls.Add(greenButton);
            Controls.Add(yellowButton);
            Controls.Add(orangeButton);
            Controls.Add(redButton);
            Controls.Add(whiteButton);
            Controls.Add(blackButton);
            Controls.Add(loadShapesButton);
            Controls.Add(saveShapesButton);
            Controls.Add(redoButton);
            Controls.Add(undoButton);
            Controls.Add(pictureBox);
            Name = "MsMegaPaint";
            Text = "MsMegaPaint";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            toolBox.ResumeLayout(false);
            toolBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button undoButton;
        private Button redoButton;
        private Button saveShapesButton;
        private Button loadShapesButton;
        private Button blackButton;
        private Button whiteButton;
        private Button orangeButton;
        private Button redButton;
        private Button greenButton;
        private Button yellowButton;
        private Button purpleButton;
        private Button blueButton;
        private Button selectedColorBox;
        private GroupBox toolBox;
        private RadioButton pencilRadioButton;
        private RadioButton lineRadioButton;
        private RadioButton triangleRadioButton;
        private RadioButton squareRadioButton;
        private RadioButton circleRadioButton;
        private Button saveBitmapButton;
        private SaveFileDialog saveBitmapDialog;
        private SaveFileDialog saveShapesDialog;
        private OpenFileDialog openShapesDialog;
    }
}