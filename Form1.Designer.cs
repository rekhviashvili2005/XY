namespace TicTac
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(69, 80);
            button1.Name = "button1";
            button1.Size = new Size(96, 87);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonClick;
            // 
            // button2
            // 
            button2.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(198, 80);
            button2.Name = "button2";
            button2.Size = new Size(96, 87);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonClick;
            // 
            // button3
            // 
            button3.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(320, 80);
            button3.Name = "button3";
            button3.Size = new Size(96, 87);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonClick;
            // 
            // button4
            // 
            button4.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(69, 184);
            button4.Name = "button4";
            button4.Size = new Size(96, 87);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonClick;
            // 
            // button5
            // 
            button5.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(198, 184);
            button5.Name = "button5";
            button5.Size = new Size(96, 87);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonClick;
            // 
            // button6
            // 
            button6.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(320, 184);
            button6.Name = "button6";
            button6.Size = new Size(96, 87);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonClick;
            // 
            // button7
            // 
            button7.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(69, 286);
            button7.Name = "button7";
            button7.Size = new Size(96, 87);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonClick;
            // 
            // button8
            // 
            button8.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(198, 286);
            button8.Name = "button8";
            button8.Size = new Size(96, 87);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonClick;
            // 
            // button9
            // 
            button9.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(320, 277);
            button9.Name = "button9";
            button9.Size = new Size(96, 87);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonClick;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(119, 410);
            button10.Name = "button10";
            button10.Size = new Size(243, 45);
            button10.TabIndex = 9;
            button10.Text = "restart Game";
            button10.UseVisualStyleBackColor = true;
            button10.Click += RestartGame;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(128, 27);
            label1.Name = "label1";
            label1.Size = new Size(96, 38);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(563, 584);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
    }
}
