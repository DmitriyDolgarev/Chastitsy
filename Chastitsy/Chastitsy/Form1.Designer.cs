namespace Chastitsy
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            picDisplay = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            tbDirection = new TrackBar();
            lblDirection = new Label();
            tbSpreading = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpreading).BeginInit();
            SuspendLayout();
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(874, 499);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            picDisplay.Click += picDisplay_Click;
            picDisplay.MouseClick += picDisplay_MouseClick;
            picDisplay.MouseMove += picDisplay_MouseMove;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // tbDirection
            // 
            tbDirection.Location = new Point(12, 528);
            tbDirection.Maximum = 359;
            tbDirection.Name = "tbDirection";
            tbDirection.Size = new Size(274, 56);
            tbDirection.TabIndex = 1;
            tbDirection.Scroll += tbDirection_Scroll;
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.Location = new Point(292, 528);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new Size(0, 20);
            lblDirection.TabIndex = 2;
            // 
            // tbSpreading
            // 
            tbSpreading.Location = new Point(364, 528);
            tbSpreading.Maximum = 359;
            tbSpreading.Name = "tbSpreading";
            tbSpreading.Size = new Size(257, 56);
            tbSpreading.TabIndex = 3;
            tbSpreading.Scroll += tbSpreading_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(627, 528);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 605);
            Controls.Add(label1);
            Controls.Add(tbSpreading);
            Controls.Add(lblDirection);
            Controls.Add(tbDirection);
            Controls.Add(picDisplay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirection).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpreading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbDirection;
        private Label lblDirection;
        private TrackBar tbSpreading;
        private Label label1;
    }
}
