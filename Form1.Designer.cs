namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lab1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.plusLeft = new System.Windows.Forms.Label();
            this.plusRight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sum1 = new System.Windows.Forms.NumericUpDown();
            this.minuesLeft = new System.Windows.Forms.Label();
            this.minuesRight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timesLeft = new System.Windows.Forms.Label();
            this.timesRight = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sum3 = new System.Windows.Forms.NumericUpDown();
            this.dividedLeft = new System.Windows.Forms.Label();
            this.dividedRight = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.sum4 = new System.Windows.Forms.NumericUpDown();
            this.sum2 = new System.Windows.Forms.NumericUpDown();
            this.date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum2)).BeginInit();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.BackColor = System.Drawing.SystemColors.MenuText;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(546, 17);
            this.lab1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lab1.Name = "lab1";
            this.lab1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab1.Size = new System.Drawing.Size(251, 55);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Math Quiz";
            this.lab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(826, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left:";
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(1054, 156);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(274, 56);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLeft
            // 
            this.plusLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeft.Location = new System.Drawing.Point(64, 296);
            this.plusLeft.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.plusLeft.Name = "plusLeft";
            this.plusLeft.Size = new System.Drawing.Size(220, 96);
            this.plusLeft.TabIndex = 3;
            this.plusLeft.Text = "?";
            this.plusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRight
            // 
            this.plusRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRight.Location = new System.Drawing.Point(528, 296);
            this.plusRight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.plusRight.Name = "plusRight";
            this.plusRight.Size = new System.Drawing.Size(220, 96);
            this.plusRight.TabIndex = 4;
            this.plusRight.Text = "?";
            this.plusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(296, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 96);
            this.label4.TabIndex = 5;
            this.label4.Text = "+";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 96);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Red;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Control;
            this.startButton.Location = new System.Drawing.Point(478, 737);
            this.startButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(336, 75);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartQuiz_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sum1
            // 
            this.sum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum1.Location = new System.Drawing.Point(992, 313);
            this.sum1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(272, 62);
            this.sum1.TabIndex = 2;
            this.sum1.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // minuesLeft
            // 
            this.minuesLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minuesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuesLeft.Location = new System.Drawing.Point(64, 392);
            this.minuesLeft.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minuesLeft.Name = "minuesLeft";
            this.minuesLeft.Size = new System.Drawing.Size(220, 96);
            this.minuesLeft.TabIndex = 3;
            this.minuesLeft.Text = "?";
            this.minuesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minuesRight
            // 
            this.minuesRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minuesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuesRight.Location = new System.Drawing.Point(528, 392);
            this.minuesRight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minuesRight.Name = "minuesRight";
            this.minuesRight.Size = new System.Drawing.Size(220, 96);
            this.minuesRight.TabIndex = 4;
            this.minuesRight.Text = "?";
            this.minuesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 96);
            this.label6.TabIndex = 5;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(760, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 96);
            this.label7.TabIndex = 6;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeft
            // 
            this.timesLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeft.Location = new System.Drawing.Point(64, 488);
            this.timesLeft.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timesLeft.Name = "timesLeft";
            this.timesLeft.Size = new System.Drawing.Size(220, 96);
            this.timesLeft.TabIndex = 3;
            this.timesLeft.Text = "?";
            this.timesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRight
            // 
            this.timesRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRight.Location = new System.Drawing.Point(528, 488);
            this.timesRight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timesRight.Name = "timesRight";
            this.timesRight.Size = new System.Drawing.Size(220, 96);
            this.timesRight.TabIndex = 4;
            this.timesRight.Text = "?";
            this.timesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(296, 488);
            this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(220, 96);
            this.label.TabIndex = 5;
            this.label.Text = "x";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(760, 488);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 96);
            this.label11.TabIndex = 6;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum3
            // 
            this.sum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum3.Location = new System.Drawing.Point(992, 506);
            this.sum3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sum3.Name = "sum3";
            this.sum3.Size = new System.Drawing.Size(272, 62);
            this.sum3.TabIndex = 4;
            this.sum3.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // dividedLeft
            // 
            this.dividedLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividedLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeft.Location = new System.Drawing.Point(64, 585);
            this.dividedLeft.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dividedLeft.Name = "dividedLeft";
            this.dividedLeft.Size = new System.Drawing.Size(220, 96);
            this.dividedLeft.TabIndex = 3;
            this.dividedLeft.Text = "?";
            this.dividedLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRight
            // 
            this.dividedRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dividedRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRight.Location = new System.Drawing.Point(528, 585);
            this.dividedRight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dividedRight.Name = "dividedRight";
            this.dividedRight.Size = new System.Drawing.Size(220, 96);
            this.dividedRight.TabIndex = 4;
            this.dividedRight.Text = "?";
            this.dividedRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(296, 585);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 96);
            this.label14.TabIndex = 5;
            this.label14.Text = "÷";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(760, 585);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 96);
            this.label15.TabIndex = 6;
            this.label15.Text = "=";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum4
            // 
            this.sum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum4.Location = new System.Drawing.Point(992, 602);
            this.sum4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sum4.Name = "sum4";
            this.sum4.Size = new System.Drawing.Size(272, 62);
            this.sum4.TabIndex = 5;
            this.sum4.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // sum2
            // 
            this.sum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum2.Location = new System.Drawing.Point(992, 410);
            this.sum2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sum2.Name = "sum2";
            this.sum2.Size = new System.Drawing.Size(272, 62);
            this.sum2.TabIndex = 3;
            this.sum2.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // date
            // 
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(136, 156);
            this.date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(326, 56);
            this.date.TabIndex = 7;
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1360, 835);
            this.Controls.Add(this.date);
            this.Controls.Add(this.sum4);
            this.Controls.Add(this.sum3);
            this.Controls.Add(this.sum2);
            this.Controls.Add(this.sum1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dividedRight);
            this.Controls.Add(this.timesRight);
            this.Controls.Add(this.minuesRight);
            this.Controls.Add(this.plusRight);
            this.Controls.Add(this.dividedLeft);
            this.Controls.Add(this.timesLeft);
            this.Controls.Add(this.minuesLeft);
            this.Controls.Add(this.plusLeft);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Makram Ibrahim - Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label plusLeft;
        private System.Windows.Forms.Label plusRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown sum1;
        private System.Windows.Forms.Label minuesLeft;
        private System.Windows.Forms.Label minuesRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timesLeft;
        private System.Windows.Forms.Label timesRight;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown sum3;
        private System.Windows.Forms.Label dividedLeft;
        private System.Windows.Forms.Label dividedRight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown sum4;
        private System.Windows.Forms.NumericUpDown sum2;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label3;
    }
}

