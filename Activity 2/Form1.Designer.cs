namespace Activity_2
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
            label1 = new Label();
            label2 = new Label();
            textBox_EarthWeight = new TextBox();
            textBox_MarsWeight = new TextBox();
            button_Convert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(252, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter your weight on Earth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(67, 110);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 1;
            label2.Text = "Your weight on Mars";
            // 
            // textBox_EarthWeight
            // 
            textBox_EarthWeight.Location = new Point(270, 37);
            textBox_EarthWeight.Name = "textBox_EarthWeight";
            textBox_EarthWeight.Size = new Size(100, 23);
            textBox_EarthWeight.TabIndex = 2;
            // 
            // textBox_MarsWeight
            // 
            textBox_MarsWeight.Location = new Point(270, 112);
            textBox_MarsWeight.Name = "textBox_MarsWeight";
            textBox_MarsWeight.Size = new Size(100, 23);
            textBox_MarsWeight.TabIndex = 3;
            // 
            // button_Convert
            // 
            button_Convert.ForeColor = SystemColors.HotTrack;
            button_Convert.Location = new Point(295, 145);
            button_Convert.Name = "button_Convert";
            button_Convert.Size = new Size(75, 23);
            button_Convert.TabIndex = 4;
            button_Convert.Text = "Convert";
            button_Convert.UseVisualStyleBackColor = true;
            button_Convert.Click += button_Convert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(388, 184);
            Controls.Add(button_Convert);
            Controls.Add(textBox_MarsWeight);
            Controls.Add(textBox_EarthWeight);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Your Weight on Mars";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_EarthWeight;
        private TextBox textBox_MarsWeight;
        private Button button_Convert;
    }
}