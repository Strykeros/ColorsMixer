using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorsMixer
{

    public partial class Form1 : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        int lightblue = 0;
        int purple = 0;
        int pink = 0;
        int lightyellow = 0;
        int darkgrey = 0;
        int redStep = 1;
        int greenStep = 1;
        int blueStep = 1;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void RandomRed_Click(object sender, EventArgs e)
        {
            int red = rand.Next(0, 256);
            RedSlider.Value = red;
            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RandomGreen_Click(object sender, EventArgs e)
        {
            int green = rand.Next(0, 256);
            GreenSlider.Value = green;
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RandomBlue_Click(object sender, EventArgs e)
        {
            int blue = rand.Next(0, 256);
            BlueSlider.Value = blue;
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RandomMix_Click(object sender, EventArgs e)
        {
            red = rand.Next(0, 256);
            green = rand.Next(0, 256);
            blue = rand.Next(0, 256);

            RedSlider.Value = red;
            GreenSlider.Value = green;
            BlueSlider.Value = blue;

            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RedSlider_Scroll(object sender, EventArgs e)
        {
            UpdateRed();
        }

        private void GreenSlider_Scroll(object sender, EventArgs e)
        {
            UpdateGreen();
        }

        private void BlueSlider_Scroll(object sender, EventArgs e)
        {
            UpdateBlue();
        }

        private void ResetColors_Click(object sender, EventArgs e)
        {
            red = 255;
            green = 255;
            blue = 255;

            RedSlider.Value = red;
            GreenSlider.Value = green;
            BlueSlider.Value = blue;

            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
            RedTimer.Stop();
            BlueTimer.Stop();
            GreenTimer.Stop();
        }

        private void RedTimer_Tick(object sender, EventArgs e)
        {
            if (RedSlider.Value == RedSlider.Maximum)
            {
                redStep = -1;
            }
            else if (RedSlider.Value == RedSlider.Minimum)
            {
                redStep = 1;
            }

            RedSlider.Value += redStep;
            UpdateRed();
        }

        private void RedTimerStart_Click(object sender, EventArgs e)
        {
            RedTimer.Start();
        }


        private void UpdateRed()
        {
            red = RedSlider.Value;
            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void UpdateGreen()
        {
            green = GreenSlider.Value;
            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void UpdateBlue()
        {
            blue = BlueSlider.Value;
            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void GreenTimer_Tick(object sender, EventArgs e)
        {
            if (GreenSlider.Value == GreenSlider.Maximum)
            {
                greenStep = -1;
            }
            else if (GreenSlider.Value == GreenSlider.Minimum)
            {
                greenStep = 1;
            }

            GreenSlider.Value += greenStep;
            UpdateBlue();
        }

        private void GreenTimerStart_Click(object sender, EventArgs e)
        {
            GreenTimer.Interval = 10;
            GreenTimer.Start();
        }

        private void BlueTimerStart_Click(object sender, EventArgs e)
        {
            BlueTimer.Interval = 20;
            BlueTimer.Start();
        }

        private void BlueTimer_Tick(object sender, EventArgs e)
        {
            if (BlueSlider.Value == BlueSlider.Maximum)
            {
                blueStep = -1;
            }
            else if(BlueSlider.Value == BlueSlider.Minimum)
            {
                blueStep = 1;
            }

            BlueSlider.Value += blueStep;
            UpdateBlue();
        }

        private void DiscoColors()
        {
            
        }
        

        private void DiscoButton_Click(object sender, EventArgs e)
        {
            DiscoTimer.Start();
        }

        private void DiscoTimer_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.Red; //red
            DiscoTimer2.Start();
            DiscoTimer.Stop();
        }

        private void DiscoTimer2_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 0); //yellow
            DiscoTimer2.Stop();
            DiscoTimer3.Start();
        }

        private void DiscoTimer3_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 255, 0);  //green
            DiscoTimer3.Stop();
            DiscoTimer4.Start();
        }

        private void DiscoTimer4_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(138, 43, 226);  //purple
            DiscoTimer4.Stop();
            DiscoTimer5.Start();
        }

        private void DiscoTimer5_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 165, 0); //orange
            DiscoTimer5.Stop();
            DiscoTimer6.Start();
        }

        private void DiscoTimer6_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 255, 0);  //green
            DiscoTimer6.Stop();
            DiscoTimer7.Start();
        }

        private void DiscoTimer7_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 100, 0); //dark green
            DiscoTimer7.Stop();
            DiscoTimer8.Start();
        }

        private void DiscoTimer8_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 250, 154); //medium spring green
            DiscoTimer8.Stop();
            DiscoTimer9.Start();
        }

        private void DiscoStop_Click(object sender, EventArgs e)
        {
            DiscoTimer.Stop();
            DiscoTimer2.Stop();
            DiscoTimer3.Stop();
            DiscoTimer4.Stop();
            DiscoTimer5.Stop();
            DiscoTimer6.Stop();
            DiscoTimer7.Stop();
            DiscoTimer8.Stop();
            DiscoTimer9.Stop();
            this.BackColor = Color.White;
        }

        private void DiscoTimer9_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
            DiscoTimer9.Stop();
            DiscoTimer.Start();
        }
    }
}
