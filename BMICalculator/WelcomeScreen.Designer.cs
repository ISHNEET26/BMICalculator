namespace BMICalculator
{
    partial class WelcomeScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WelcomeScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeScreenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeScreenTimer
            // 
            this.WelcomeScreenTimer.Interval = 3000;
            this.WelcomeScreenTimer.Tick += new System.EventHandler(this.WelcomeScreenTimer_Tick);
            // 
            // WelcomeScreenLabel
            // 
            this.WelcomeScreenLabel.AutoSize = true;
            this.WelcomeScreenLabel.Location = new System.Drawing.Point(76, 59);
            this.WelcomeScreenLabel.Name = "WelcomeScreenLabel";
            this.WelcomeScreenLabel.Size = new System.Drawing.Size(192, 31);
            this.WelcomeScreenLabel.TabIndex = 0;
            this.WelcomeScreenLabel.Text = "BMI Calculator";
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.ControlBox = false;
            this.Controls.Add(this.WelcomeScreenLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "WelcomeScreen";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Screen";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer WelcomeScreenTimer;
        private System.Windows.Forms.Label WelcomeScreenLabel;
    }
}