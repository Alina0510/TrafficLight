using static System.Net.Mime.MediaTypeNames;

namespace CustomComponents
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        public int TimeGreen { get; set; } = 1000;
        public int TimeYellow { get; set; } = 1000;
        public int TimeRed { get; set; } = 1000;
        public int TimeBlank { get; set; } = 1000;
        public bool IsManual { get; set; } = false;
        public bool IsNight { get; set; } = false;

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private async void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.GreenLight;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 131);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Name = "UserControl1";
            Size = new Size(77, 130);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private async void StartLight()
        {
            Thread.Sleep(1000);
            while (true)
            {
                if (IsNight)
                {
                    pictureBox1.Invoke(async delegate
                    {
                        pictureBox1.Image = null;

                        pictureBox1.BackgroundImage = Properties.Resources.YellowLight;
                        pictureBox1.Refresh();
                    });
                    await Task.Delay(TimeYellow);
                    pictureBox1.Invoke(async delegate
                    {
                        pictureBox1.Image = null;

                        pictureBox1.BackgroundImage = Properties.Resources.BlankLight;
                        pictureBox1.Refresh();
                    });
                    await Task.Delay(TimeBlank);
                }
                else
                {
                    pictureBox1.Invoke(async delegate
                    {
                        pictureBox1.Image = null;

                        pictureBox1.BackgroundImage = Properties.Resources.GreenLight;
                        pictureBox1.Refresh();
                    });
                    await Task.Delay(TimeGreen);
                    pictureBox1.Invoke(async delegate
                    {
                        pictureBox1.Image = null;

                        pictureBox1.BackgroundImage = Properties.Resources.YellowLight;
                        pictureBox1.Refresh();
                    });
                    await Task.Delay(TimeYellow);
                    pictureBox1.Invoke(async delegate
                    {
                        pictureBox1.Image = null;

                        pictureBox1.BackgroundImage = Properties.Resources.RedLight;
                        pictureBox1.Refresh();
                    });
                    await Task.Delay(TimeRed);
                    pictureBox1.Invoke(async delegate
                    {
                        pictureBox1.Image = null;

                        pictureBox1.BackgroundImage = Properties.Resources.YellowLight;
                        pictureBox1.Refresh();
                    });
                    await Task.Delay(TimeYellow);
                }
                

            }

        }

        #endregion
        private PictureBox pictureBox1;
    }
}