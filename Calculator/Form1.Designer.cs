namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screenLabel = new System.Windows.Forms.Label();
            this.N1Button = new System.Windows.Forms.Button();
            this.N3Button = new System.Windows.Forms.Button();
            this.N2Button = new System.Windows.Forms.Button();
            this.N5Button = new System.Windows.Forms.Button();
            this.N6Button = new System.Windows.Forms.Button();
            this.N4Button = new System.Windows.Forms.Button();
            this.N8Button = new System.Windows.Forms.Button();
            this.N9Button = new System.Windows.Forms.Button();
            this.N7Button = new System.Windows.Forms.Button();
            this.N0Button = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screenLabel
            // 
            this.screenLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.screenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.screenLabel.Location = new System.Drawing.Point(25, 22);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(317, 39);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Text = "0";
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // N1Button
            // 
            this.N1Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N1Button.Location = new System.Drawing.Point(25, 78);
            this.N1Button.Name = "N1Button";
            this.N1Button.Size = new System.Drawing.Size(75, 65);
            this.N1Button.TabIndex = 1;
            this.N1Button.Text = "1";
            this.N1Button.UseVisualStyleBackColor = false;
            this.N1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // N3Button
            // 
            this.N3Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N3Button.Location = new System.Drawing.Point(187, 78);
            this.N3Button.Name = "N3Button";
            this.N3Button.Size = new System.Drawing.Size(75, 65);
            this.N3Button.TabIndex = 3;
            this.N3Button.Text = "3";
            this.N3Button.UseVisualStyleBackColor = false;
            this.N3Button.Click += new System.EventHandler(this.N3Button_Click);
            // 
            // N2Button
            // 
            this.N2Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N2Button.Location = new System.Drawing.Point(106, 78);
            this.N2Button.Name = "N2Button";
            this.N2Button.Size = new System.Drawing.Size(75, 65);
            this.N2Button.TabIndex = 4;
            this.N2Button.Text = "2";
            this.N2Button.UseVisualStyleBackColor = false;
            this.N2Button.Click += new System.EventHandler(this.N2Button_Click);
            // 
            // N5Button
            // 
            this.N5Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N5Button.Location = new System.Drawing.Point(105, 145);
            this.N5Button.Name = "N5Button";
            this.N5Button.Size = new System.Drawing.Size(75, 65);
            this.N5Button.TabIndex = 7;
            this.N5Button.Text = "5";
            this.N5Button.UseVisualStyleBackColor = false;
            this.N5Button.Click += new System.EventHandler(this.N5Button_Click);
            // 
            // N6Button
            // 
            this.N6Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N6Button.Location = new System.Drawing.Point(186, 145);
            this.N6Button.Name = "N6Button";
            this.N6Button.Size = new System.Drawing.Size(75, 65);
            this.N6Button.TabIndex = 6;
            this.N6Button.Text = "6";
            this.N6Button.UseVisualStyleBackColor = false;
            this.N6Button.Click += new System.EventHandler(this.N6Button_Click);
            // 
            // N4Button
            // 
            this.N4Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N4Button.Location = new System.Drawing.Point(24, 145);
            this.N4Button.Name = "N4Button";
            this.N4Button.Size = new System.Drawing.Size(75, 65);
            this.N4Button.TabIndex = 5;
            this.N4Button.Text = "4";
            this.N4Button.UseVisualStyleBackColor = false;
            this.N4Button.Click += new System.EventHandler(this.N4Button_Click);
            // 
            // N8Button
            // 
            this.N8Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N8Button.Location = new System.Drawing.Point(106, 216);
            this.N8Button.Name = "N8Button";
            this.N8Button.Size = new System.Drawing.Size(75, 65);
            this.N8Button.TabIndex = 10;
            this.N8Button.Text = "8";
            this.N8Button.UseVisualStyleBackColor = false;
            this.N8Button.Click += new System.EventHandler(this.N8Button_Click);
            // 
            // N9Button
            // 
            this.N9Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N9Button.Location = new System.Drawing.Point(187, 216);
            this.N9Button.Name = "N9Button";
            this.N9Button.Size = new System.Drawing.Size(75, 65);
            this.N9Button.TabIndex = 9;
            this.N9Button.Text = "9";
            this.N9Button.UseVisualStyleBackColor = false;
            this.N9Button.Click += new System.EventHandler(this.N9Button_Click);
            // 
            // N7Button
            // 
            this.N7Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N7Button.Location = new System.Drawing.Point(25, 216);
            this.N7Button.Name = "N7Button";
            this.N7Button.Size = new System.Drawing.Size(75, 65);
            this.N7Button.TabIndex = 8;
            this.N7Button.Text = "7";
            this.N7Button.UseVisualStyleBackColor = false;
            this.N7Button.Click += new System.EventHandler(this.N7Button_Click);
            // 
            // N0Button
            // 
            this.N0Button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.N0Button.Location = new System.Drawing.Point(27, 287);
            this.N0Button.Name = "N0Button";
            this.N0Button.Size = new System.Drawing.Size(73, 65);
            this.N0Button.TabIndex = 13;
            this.N0Button.Text = "0";
            this.N0Button.UseVisualStyleBackColor = false;
            this.N0Button.Click += new System.EventHandler(this.N0Button_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.MistyRose;
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.equalButton.Location = new System.Drawing.Point(189, 287);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(73, 65);
            this.equalButton.TabIndex = 12;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Sienna;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.clearButton.Location = new System.Drawing.Point(109, 287);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(73, 65);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.Coral;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.divisionButton.Location = new System.Drawing.Point(268, 287);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 65);
            this.divisionButton.TabIndex = 17;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Coral;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.multiplyButton.Location = new System.Drawing.Point(268, 216);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 65);
            this.multiplyButton.TabIndex = 16;
            this.multiplyButton.Text = "X";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Coral;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.minusButton.Location = new System.Drawing.Point(267, 145);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(75, 65);
            this.minusButton.TabIndex = 15;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Coral;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.plusButton.Location = new System.Drawing.Point(268, 78);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 65);
            this.plusButton.TabIndex = 14;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 374);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.N0Button);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.N8Button);
            this.Controls.Add(this.N9Button);
            this.Controls.Add(this.N7Button);
            this.Controls.Add(this.N5Button);
            this.Controls.Add(this.N6Button);
            this.Controls.Add(this.N4Button);
            this.Controls.Add(this.N2Button);
            this.Controls.Add(this.N3Button);
            this.Controls.Add(this.N1Button);
            this.Controls.Add(this.screenLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label screenLabel;
        private System.Windows.Forms.Button N1Button;
        private System.Windows.Forms.Button N3Button;
        private System.Windows.Forms.Button N2Button;
        private System.Windows.Forms.Button N5Button;
        private System.Windows.Forms.Button N6Button;
        private System.Windows.Forms.Button N4Button;
        private System.Windows.Forms.Button N8Button;
        private System.Windows.Forms.Button N9Button;
        private System.Windows.Forms.Button N7Button;
        private System.Windows.Forms.Button N0Button;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
    }
}

