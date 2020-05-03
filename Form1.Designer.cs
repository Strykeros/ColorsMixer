namespace ColorsMixer
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
            this.RedBox = new System.Windows.Forms.PictureBox();
            this.GreenBox = new System.Windows.Forms.PictureBox();
            this.BlueBox = new System.Windows.Forms.PictureBox();
            this.RandomRed = new System.Windows.Forms.Button();
            this.RandomGreen = new System.Windows.Forms.Button();
            this.RandomBlue = new System.Windows.Forms.Button();
            this.RandomMix = new System.Windows.Forms.Button();
            this.RedSlider = new System.Windows.Forms.TrackBar();
            this.GreenSlider = new System.Windows.Forms.TrackBar();
            this.BlueSlider = new System.Windows.Forms.TrackBar();
            this.ResetColors = new System.Windows.Forms.Button();
            this.RedTimer = new System.Windows.Forms.Timer(this.components);
            this.RedTimerStart = new System.Windows.Forms.Button();
            this.BlueTimerStart = new System.Windows.Forms.Button();
            this.GreenTimerStart = new System.Windows.Forms.Button();
            this.GreenTimer = new System.Windows.Forms.Timer(this.components);
            this.BlueTimer = new System.Windows.Forms.Timer(this.components);
            this.DiscoButton = new System.Windows.Forms.Button();
            this.DiscoTimer = new System.Windows.Forms.Timer(this.components);
            this.DiscoTimer2 = new System.Windows.Forms.Timer(this.components);
            this.DiscoTimer3 = new System.Windows.Forms.Timer(this.components);
            this.DiscoTimer4 = new System.Windows.Forms.Timer(this.components);
            this.DiscoTimer5 = new System.Windows.Forms.Timer(this.components);
            this.DiscoTimer6 = new System.Windows.Forms.Timer(this.components);
            this.DiscoTimer7 = new System.Windows.Forms.Timer(this.components);
            this.DiscoTimer8 = new System.Windows.Forms.Timer(this.components);
            this.DiscoStop = new System.Windows.Forms.Button();
            this.DiscoTimer9 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // RedBox
            // 
            this.RedBox.Location = new System.Drawing.Point(12, 12);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(200, 200);
            this.RedBox.TabIndex = 0;
            this.RedBox.TabStop = false;
            // 
            // GreenBox
            // 
            this.GreenBox.Location = new System.Drawing.Point(466, 12);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(200, 200);
            this.GreenBox.TabIndex = 1;
            this.GreenBox.TabStop = false;
            // 
            // BlueBox
            // 
            this.BlueBox.Location = new System.Drawing.Point(242, 12);
            this.BlueBox.Name = "BlueBox";
            this.BlueBox.Size = new System.Drawing.Size(200, 200);
            this.BlueBox.TabIndex = 2;
            this.BlueBox.TabStop = false;
            // 
            // RandomRed
            // 
            this.RandomRed.Location = new System.Drawing.Point(12, 269);
            this.RandomRed.Name = "RandomRed";
            this.RandomRed.Size = new System.Drawing.Size(200, 55);
            this.RandomRed.TabIndex = 3;
            this.RandomRed.Text = "Random Red";
            this.RandomRed.UseVisualStyleBackColor = true;
            this.RandomRed.Click += new System.EventHandler(this.RandomRed_Click);
            // 
            // RandomGreen
            // 
            this.RandomGreen.Location = new System.Drawing.Point(466, 280);
            this.RandomGreen.Name = "RandomGreen";
            this.RandomGreen.Size = new System.Drawing.Size(200, 55);
            this.RandomGreen.TabIndex = 4;
            this.RandomGreen.Text = "Random Green";
            this.RandomGreen.UseVisualStyleBackColor = true;
            this.RandomGreen.Click += new System.EventHandler(this.RandomGreen_Click);
            // 
            // RandomBlue
            // 
            this.RandomBlue.Location = new System.Drawing.Point(242, 280);
            this.RandomBlue.Name = "RandomBlue";
            this.RandomBlue.Size = new System.Drawing.Size(200, 55);
            this.RandomBlue.TabIndex = 5;
            this.RandomBlue.Text = "Random Blue";
            this.RandomBlue.UseVisualStyleBackColor = true;
            this.RandomBlue.Click += new System.EventHandler(this.RandomBlue_Click);
            // 
            // RandomMix
            // 
            this.RandomMix.Location = new System.Drawing.Point(12, 397);
            this.RandomMix.Name = "RandomMix";
            this.RandomMix.Size = new System.Drawing.Size(195, 77);
            this.RandomMix.TabIndex = 6;
            this.RandomMix.Text = "Random mix";
            this.RandomMix.UseVisualStyleBackColor = true;
            this.RandomMix.Click += new System.EventHandler(this.RandomMix_Click);
            // 
            // RedSlider
            // 
            this.RedSlider.Location = new System.Drawing.Point(12, 218);
            this.RedSlider.Maximum = 255;
            this.RedSlider.Name = "RedSlider";
            this.RedSlider.Size = new System.Drawing.Size(200, 45);
            this.RedSlider.TabIndex = 7;
            this.RedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedSlider.Scroll += new System.EventHandler(this.RedSlider_Scroll);
            // 
            // GreenSlider
            // 
            this.GreenSlider.Location = new System.Drawing.Point(466, 229);
            this.GreenSlider.Maximum = 255;
            this.GreenSlider.Name = "GreenSlider";
            this.GreenSlider.Size = new System.Drawing.Size(200, 45);
            this.GreenSlider.TabIndex = 8;
            this.GreenSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenSlider.Scroll += new System.EventHandler(this.GreenSlider_Scroll);
            // 
            // BlueSlider
            // 
            this.BlueSlider.Location = new System.Drawing.Point(242, 229);
            this.BlueSlider.Maximum = 255;
            this.BlueSlider.Name = "BlueSlider";
            this.BlueSlider.Size = new System.Drawing.Size(200, 45);
            this.BlueSlider.TabIndex = 9;
            this.BlueSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueSlider.Scroll += new System.EventHandler(this.BlueSlider_Scroll);
            // 
            // ResetColors
            // 
            this.ResetColors.Location = new System.Drawing.Point(12, 501);
            this.ResetColors.Name = "ResetColors";
            this.ResetColors.Size = new System.Drawing.Size(195, 77);
            this.ResetColors.TabIndex = 10;
            this.ResetColors.Text = "Reset colors";
            this.ResetColors.UseVisualStyleBackColor = true;
            this.ResetColors.Click += new System.EventHandler(this.ResetColors_Click);
            // 
            // RedTimer
            // 
            this.RedTimer.Tick += new System.EventHandler(this.RedTimer_Tick);
            // 
            // RedTimerStart
            // 
            this.RedTimerStart.Location = new System.Drawing.Point(12, 336);
            this.RedTimerStart.Name = "RedTimerStart";
            this.RedTimerStart.Size = new System.Drawing.Size(200, 55);
            this.RedTimerStart.TabIndex = 11;
            this.RedTimerStart.Text = "Red party";
            this.RedTimerStart.UseVisualStyleBackColor = true;
            this.RedTimerStart.Click += new System.EventHandler(this.RedTimerStart_Click);
            // 
            // BlueTimerStart
            // 
            this.BlueTimerStart.Location = new System.Drawing.Point(242, 341);
            this.BlueTimerStart.Name = "BlueTimerStart";
            this.BlueTimerStart.Size = new System.Drawing.Size(200, 55);
            this.BlueTimerStart.TabIndex = 12;
            this.BlueTimerStart.Text = "Blue party";
            this.BlueTimerStart.UseVisualStyleBackColor = true;
            this.BlueTimerStart.Click += new System.EventHandler(this.BlueTimerStart_Click);
            // 
            // GreenTimerStart
            // 
            this.GreenTimerStart.Location = new System.Drawing.Point(466, 341);
            this.GreenTimerStart.Name = "GreenTimerStart";
            this.GreenTimerStart.Size = new System.Drawing.Size(200, 55);
            this.GreenTimerStart.TabIndex = 13;
            this.GreenTimerStart.Text = "Green party";
            this.GreenTimerStart.UseVisualStyleBackColor = true;
            this.GreenTimerStart.Click += new System.EventHandler(this.GreenTimerStart_Click);
            // 
            // GreenTimer
            // 
            this.GreenTimer.Tick += new System.EventHandler(this.GreenTimer_Tick);
            // 
            // BlueTimer
            // 
            this.BlueTimer.Tick += new System.EventHandler(this.BlueTimer_Tick);
            // 
            // DiscoButton
            // 
            this.DiscoButton.Location = new System.Drawing.Point(262, 413);
            this.DiscoButton.Name = "DiscoButton";
            this.DiscoButton.Size = new System.Drawing.Size(167, 61);
            this.DiscoButton.TabIndex = 14;
            this.DiscoButton.Text = "DISCO!";
            this.DiscoButton.UseVisualStyleBackColor = true;
            this.DiscoButton.Click += new System.EventHandler(this.DiscoButton_Click);
            // 
            // DiscoTimer
            // 
            this.DiscoTimer.Interval = 250;
            this.DiscoTimer.Tick += new System.EventHandler(this.DiscoTimer_Tick);
            // 
            // DiscoTimer2
            // 
            this.DiscoTimer2.Interval = 250;
            this.DiscoTimer2.Tick += new System.EventHandler(this.DiscoTimer2_Tick);
            // 
            // DiscoTimer3
            // 
            this.DiscoTimer3.Interval = 250;
            this.DiscoTimer3.Tick += new System.EventHandler(this.DiscoTimer3_Tick);
            // 
            // DiscoTimer4
            // 
            this.DiscoTimer4.Interval = 250;
            this.DiscoTimer4.Tick += new System.EventHandler(this.DiscoTimer4_Tick);
            // 
            // DiscoTimer5
            // 
            this.DiscoTimer5.Interval = 250;
            this.DiscoTimer5.Tick += new System.EventHandler(this.DiscoTimer5_Tick);
            // 
            // DiscoTimer6
            // 
            this.DiscoTimer6.Interval = 250;
            this.DiscoTimer6.Tick += new System.EventHandler(this.DiscoTimer6_Tick);
            // 
            // DiscoTimer7
            // 
            this.DiscoTimer7.Interval = 250;
            this.DiscoTimer7.Tick += new System.EventHandler(this.DiscoTimer7_Tick);
            // 
            // DiscoTimer8
            // 
            this.DiscoTimer8.Interval = 250;
            this.DiscoTimer8.Tick += new System.EventHandler(this.DiscoTimer8_Tick);
            // 
            // DiscoStop
            // 
            this.DiscoStop.Location = new System.Drawing.Point(476, 413);
            this.DiscoStop.Name = "DiscoStop";
            this.DiscoStop.Size = new System.Drawing.Size(190, 60);
            this.DiscoStop.TabIndex = 15;
            this.DiscoStop.Text = "AAAH!!! MY EYES!!! STOP THE DISCO!!!";
            this.DiscoStop.UseVisualStyleBackColor = true;
            this.DiscoStop.Click += new System.EventHandler(this.DiscoStop_Click);
            // 
            // DiscoTimer9
            // 
            this.DiscoTimer9.Interval = 250;
            this.DiscoTimer9.Tick += new System.EventHandler(this.DiscoTimer9_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 634);
            this.Controls.Add(this.DiscoStop);
            this.Controls.Add(this.DiscoButton);
            this.Controls.Add(this.GreenTimerStart);
            this.Controls.Add(this.BlueTimerStart);
            this.Controls.Add(this.RedTimerStart);
            this.Controls.Add(this.ResetColors);
            this.Controls.Add(this.BlueSlider);
            this.Controls.Add(this.GreenSlider);
            this.Controls.Add(this.RedSlider);
            this.Controls.Add(this.RandomMix);
            this.Controls.Add(this.RandomBlue);
            this.Controls.Add(this.RandomGreen);
            this.Controls.Add(this.RandomRed);
            this.Controls.Add(this.BlueBox);
            this.Controls.Add(this.GreenBox);
            this.Controls.Add(this.RedBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedBox;
        private System.Windows.Forms.PictureBox GreenBox;
        private System.Windows.Forms.PictureBox BlueBox;
        private System.Windows.Forms.Button RandomRed;
        private System.Windows.Forms.Button RandomGreen;
        private System.Windows.Forms.Button RandomBlue;
        private System.Windows.Forms.Button RandomMix;
        private System.Windows.Forms.TrackBar RedSlider;
        private System.Windows.Forms.TrackBar GreenSlider;
        private System.Windows.Forms.TrackBar BlueSlider;
        private System.Windows.Forms.Button ResetColors;
        private System.Windows.Forms.Timer RedTimer;
        private System.Windows.Forms.Button RedTimerStart;
        private System.Windows.Forms.Button BlueTimerStart;
        private System.Windows.Forms.Button GreenTimerStart;
        private System.Windows.Forms.Timer GreenTimer;
        private System.Windows.Forms.Timer BlueTimer;
        private System.Windows.Forms.Button DiscoButton;
        private System.Windows.Forms.Timer DiscoTimer;
        private System.Windows.Forms.Timer DiscoTimer2;
        private System.Windows.Forms.Timer DiscoTimer3;
        private System.Windows.Forms.Timer DiscoTimer4;
        private System.Windows.Forms.Timer DiscoTimer5;
        private System.Windows.Forms.Timer DiscoTimer6;
        private System.Windows.Forms.Timer DiscoTimer7;
        private System.Windows.Forms.Timer DiscoTimer8;
        private System.Windows.Forms.Button DiscoStop;
        private System.Windows.Forms.Timer DiscoTimer9;
    }
}

