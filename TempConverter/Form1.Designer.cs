namespace TempConverter
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
            this.Fahrenheit = new System.Windows.Forms.GroupBox();
            this.fahrButton = new System.Windows.Forms.Button();
            this.fahrText = new System.Windows.Forms.TextBox();
            this.Celsius = new System.Windows.Forms.GroupBox();
            this.celsButton = new System.Windows.Forms.Button();
            this.celsText = new System.Windows.Forms.TextBox();
            this.Kelvin = new System.Windows.Forms.GroupBox();
            this.kelvButton = new System.Windows.Forms.Button();
            this.kelvText = new System.Windows.Forms.TextBox();
            this.Fahrenheit.SuspendLayout();
            this.Celsius.SuspendLayout();
            this.Kelvin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.Controls.Add(this.fahrButton);
            this.Fahrenheit.Controls.Add(this.fahrText);
            this.Fahrenheit.Location = new System.Drawing.Point(13, 13);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(245, 245);
            this.Fahrenheit.TabIndex = 0;
            this.Fahrenheit.TabStop = false;
            this.Fahrenheit.Text = "Fahrenheit";
            // 
            // fahrButton
            // 
            this.fahrButton.Location = new System.Drawing.Point(16, 203);
            this.fahrButton.Name = "fahrButton";
            this.fahrButton.Size = new System.Drawing.Size(75, 23);
            this.fahrButton.TabIndex = 1;
            this.fahrButton.Text = "Convert";
            this.fahrButton.UseVisualStyleBackColor = true;
            this.fahrButton.Click += new System.EventHandler(this.fahrButton_Click);
            // 
            // fahrText
            // 
            this.fahrText.Location = new System.Drawing.Point(16, 70);
            this.fahrText.Name = "fahrText";
            this.fahrText.Size = new System.Drawing.Size(100, 20);
            this.fahrText.TabIndex = 0;
            // 
            // Celsius
            // 
            this.Celsius.Controls.Add(this.celsButton);
            this.Celsius.Controls.Add(this.celsText);
            this.Celsius.Location = new System.Drawing.Point(279, 13);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(245, 245);
            this.Celsius.TabIndex = 1;
            this.Celsius.TabStop = false;
            this.Celsius.Text = "Celsius";
            // 
            // celsButton
            // 
            this.celsButton.Location = new System.Drawing.Point(16, 203);
            this.celsButton.Name = "celsButton";
            this.celsButton.Size = new System.Drawing.Size(75, 23);
            this.celsButton.TabIndex = 1;
            this.celsButton.Text = "Convert";
            this.celsButton.UseVisualStyleBackColor = true;
            this.celsButton.Click += new System.EventHandler(this.celsButton_Click);
            // 
            // celsText
            // 
            this.celsText.Location = new System.Drawing.Point(16, 70);
            this.celsText.Name = "celsText";
            this.celsText.Size = new System.Drawing.Size(100, 20);
            this.celsText.TabIndex = 0;
            // 
            // Kelvin
            // 
            this.Kelvin.Controls.Add(this.kelvButton);
            this.Kelvin.Controls.Add(this.kelvText);
            this.Kelvin.Location = new System.Drawing.Point(543, 13);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(245, 245);
            this.Kelvin.TabIndex = 2;
            this.Kelvin.TabStop = false;
            this.Kelvin.Text = "Kelvin";
            // 
            // kelvButton
            // 
            this.kelvButton.Location = new System.Drawing.Point(16, 203);
            this.kelvButton.Name = "kelvButton";
            this.kelvButton.Size = new System.Drawing.Size(75, 23);
            this.kelvButton.TabIndex = 1;
            this.kelvButton.Text = "Convert";
            this.kelvButton.UseVisualStyleBackColor = true;
            this.kelvButton.Click += new System.EventHandler(this.kelvButton_Click);
            // 
            // kelvText
            // 
            this.kelvText.Location = new System.Drawing.Point(16, 70);
            this.kelvText.Name = "kelvText";
            this.kelvText.Size = new System.Drawing.Size(100, 20);
            this.kelvText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 274);
            this.Controls.Add(this.Kelvin);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.Fahrenheit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Fahrenheit.ResumeLayout(false);
            this.Fahrenheit.PerformLayout();
            this.Celsius.ResumeLayout(false);
            this.Celsius.PerformLayout();
            this.Kelvin.ResumeLayout(false);
            this.Kelvin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Fahrenheit;
        private System.Windows.Forms.GroupBox Celsius;
        private System.Windows.Forms.GroupBox Kelvin;
        private System.Windows.Forms.Button fahrButton;
        private System.Windows.Forms.TextBox fahrText;
        private System.Windows.Forms.Button celsButton;
        private System.Windows.Forms.TextBox celsText;
        private System.Windows.Forms.Button kelvButton;
        private System.Windows.Forms.TextBox kelvText;
    }
}

