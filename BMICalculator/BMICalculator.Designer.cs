namespace BMICalculator
{
    partial class BMICalculator
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
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MyHeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BMITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 2;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.Controls.Add(this.ResultLabel, 0, 5);
            this.BMITableLayoutPanel.Controls.Add(this.ResetButton, 1, 4);
            this.BMITableLayoutPanel.Controls.Add(this.MyWeightTextBox, 1, 3);
            this.BMITableLayoutPanel.Controls.Add(this.MetricRadioButton, 1, 1);
            this.BMITableLayoutPanel.Controls.Add(this.BMICalculatorLabel, 0, 0);
            this.BMITableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 1);
            this.BMITableLayoutPanel.Controls.Add(this.MyHeightLabel, 0, 2);
            this.BMITableLayoutPanel.Controls.Add(this.MyWeightLabel, 0, 3);
            this.BMITableLayoutPanel.Controls.Add(this.MyHeightTextBox, 1, 2);
            this.BMITableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 4);
            this.BMITableLayoutPanel.Controls.Add(this.textBox1, 1, 5);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(2, 0);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 6;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(302, 447);
            this.BMITableLayoutPanel.TabIndex = 0;
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorLabel.BackColor = System.Drawing.Color.MediumPurple;
            this.BMITableLayoutPanel.SetColumnSpan(this.BMICalculatorLabel, 2);
            this.BMICalculatorLabel.Location = new System.Drawing.Point(3, 0);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(296, 74);
            this.BMICalculatorLabel.TabIndex = 0;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            this.BMICalculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 77);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(145, 68);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(154, 77);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(145, 68);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 148);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(145, 74);
            this.MyHeightLabel.TabIndex = 3;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 222);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(145, 74);
            this.MyWeightLabel.TabIndex = 4;
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightTextBox.Location = new System.Drawing.Point(154, 151);
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(145, 38);
            this.MyHeightTextBox.TabIndex = 5;
            this.MyHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MyWeightTextBox
            // 
            this.MyWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightTextBox.Location = new System.Drawing.Point(154, 225);
            this.MyWeightTextBox.Name = "MyWeightTextBox";
            this.MyWeightTextBox.Size = new System.Drawing.Size(145, 38);
            this.MyWeightTextBox.TabIndex = 6;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 299);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(145, 68);
            this.CalculateBMIButton.TabIndex = 7;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(154, 299);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(145, 68);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(3, 370);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(145, 77);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(154, 373);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 71);
            this.textBox1.TabIndex = 10;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.TextBox MyWeightTextBox;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox MyHeightTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

