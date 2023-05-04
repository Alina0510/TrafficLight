namespace TrafficLights
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            userControl11 = new CustomComponents.UserControl1();
            userControl12 = new CustomComponents.UserControl1();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.IsManual = false;
            userControl11.IsNight = false;
            userControl11.Location = new Point(36, 48);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(78, 133);
            userControl11.TabIndex = 0;
            userControl11.TimeBlank = 1000;
            userControl11.TimeGreen = 1000;
            userControl11.TimeRed = 2000;
            userControl11.TimeYellow = 3000;
            // 
            // userControl12
            // 
            userControl12.IsManual = false;
            userControl12.IsNight = true;
            userControl12.Location = new Point(159, 51);
            userControl12.Name = "userControl12";
            userControl12.Size = new Size(77, 130);
            userControl12.TabIndex = 1;
            userControl12.TimeBlank = 1000;
            userControl12.TimeGreen = 1000;
            userControl12.TimeRed = 1000;
            userControl12.TimeYellow = 1000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Automatic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 20);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Night";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(252, 15);
            label3.TabIndex = 4;
            label3.Text = "You can set delays in properties for Traffic light";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userControl12);
            Controls.Add(userControl11);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomComponents.UserControl1 userControl11;
        private CustomComponents.UserControl1 userControl12;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}