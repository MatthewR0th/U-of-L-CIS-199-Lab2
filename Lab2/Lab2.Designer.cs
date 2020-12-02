namespace Lab2
{
    partial class Lab2
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
            this.PriceOfMealLabel = new System.Windows.Forms.Label();
            this.PriceOfMealTextBox = new System.Windows.Forms.TextBox();
            this.FifteenLabel = new System.Windows.Forms.Label();
            this.EighteenLabel = new System.Windows.Forms.Label();
            this.TwentyLabel = new System.Windows.Forms.Label();
            this.FifteenTextBox = new System.Windows.Forms.Label();
            this.EighteenTextBox = new System.Windows.Forms.Label();
            this.TwentyTextBox = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PriceOfMealLabel
            // 
            this.PriceOfMealLabel.AutoSize = true;
            this.PriceOfMealLabel.Location = new System.Drawing.Point(190, 80);
            this.PriceOfMealLabel.Name = "PriceOfMealLabel";
            this.PriceOfMealLabel.Size = new System.Drawing.Size(95, 13);
            this.PriceOfMealLabel.TabIndex = 0;
            this.PriceOfMealLabel.Text = "Enter price of meal";
            // 
            // PriceOfMealTextBox
            // 
            this.PriceOfMealTextBox.Location = new System.Drawing.Point(291, 77);
            this.PriceOfMealTextBox.Name = "PriceOfMealTextBox";
            this.PriceOfMealTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceOfMealTextBox.TabIndex = 1;
            // 
            // FifteenLabel
            // 
            this.FifteenLabel.AutoSize = true;
            this.FifteenLabel.Location = new System.Drawing.Point(258, 111);
            this.FifteenLabel.Name = "FifteenLabel";
            this.FifteenLabel.Size = new System.Drawing.Size(27, 13);
            this.FifteenLabel.TabIndex = 2;
            this.FifteenLabel.Text = "15%";
            this.FifteenLabel.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // EighteenLabel
            // 
            this.EighteenLabel.AutoSize = true;
            this.EighteenLabel.Location = new System.Drawing.Point(258, 164);
            this.EighteenLabel.Name = "EighteenLabel";
            this.EighteenLabel.Size = new System.Drawing.Size(27, 13);
            this.EighteenLabel.TabIndex = 3;
            this.EighteenLabel.Text = "18%";
            // 
            // TwentyLabel
            // 
            this.TwentyLabel.AutoSize = true;
            this.TwentyLabel.Location = new System.Drawing.Point(258, 216);
            this.TwentyLabel.Name = "TwentyLabel";
            this.TwentyLabel.Size = new System.Drawing.Size(27, 13);
            this.TwentyLabel.TabIndex = 4;
            this.TwentyLabel.Text = "20%";
            // 
            // FifteenTextBox
            // 
            this.FifteenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FifteenTextBox.Location = new System.Drawing.Point(291, 111);
            this.FifteenTextBox.Name = "FifteenTextBox";
            this.FifteenTextBox.Size = new System.Drawing.Size(100, 23);
            this.FifteenTextBox.TabIndex = 5;
            // 
            // EighteenTextBox
            // 
            this.EighteenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EighteenTextBox.Location = new System.Drawing.Point(291, 164);
            this.EighteenTextBox.Name = "EighteenTextBox";
            this.EighteenTextBox.Size = new System.Drawing.Size(100, 23);
            this.EighteenTextBox.TabIndex = 6;
            // 
            // TwentyTextBox
            // 
            this.TwentyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TwentyTextBox.Location = new System.Drawing.Point(291, 216);
            this.TwentyTextBox.Name = "TwentyTextBox";
            this.TwentyTextBox.Size = new System.Drawing.Size(100, 23);
            this.TwentyTextBox.TabIndex = 7;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(261, 278);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(81, 23);
            this.CalcButton.TabIndex = 8;
            this.CalcButton.Text = "Calculate Tip";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 377);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.TwentyTextBox);
            this.Controls.Add(this.EighteenTextBox);
            this.Controls.Add(this.FifteenTextBox);
            this.Controls.Add(this.TwentyLabel);
            this.Controls.Add(this.EighteenLabel);
            this.Controls.Add(this.FifteenLabel);
            this.Controls.Add(this.PriceOfMealTextBox);
            this.Controls.Add(this.PriceOfMealLabel);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceOfMealLabel;
        private System.Windows.Forms.TextBox PriceOfMealTextBox;
        private System.Windows.Forms.Label FifteenLabel;
        private System.Windows.Forms.Label EighteenLabel;
        private System.Windows.Forms.Label TwentyLabel;
        private System.Windows.Forms.Label FifteenTextBox;
        private System.Windows.Forms.Label EighteenTextBox;
        private System.Windows.Forms.Label TwentyTextBox;
        private System.Windows.Forms.Button CalcButton;
    }
}

