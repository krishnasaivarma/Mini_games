using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace project01
{
    public partial class sts : Form
    {
        public double i;
        public int x=3,k=0;
        Button b= new Button();

        public void buttonclick()
        {
            if (b.Text == "*")
            {
                b.BackColor = Color.Lime;
                SystemSounds.Asterisk.Play();
                b.Text = "";
                k++;

                if (k < 15)
                    gamealg();
                else
                {
                    levelselect(true);
                    k = 0; i = 0;
                    timer1.Stop();
                    MessageBox.Show("Congo!\nyour time - " + textBox1.Text, "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                b.BackColor = Color.Red;
                SystemSounds.Hand.Play();
            }
            timer2.Start();
           
           
        }

        public void levelselect(bool v)
        {
            radioButton1.Enabled = v;
            radioButton2.Enabled = v;
            radioButton3.Enabled = v;
        }

        public void levels()
        {


            bool val = false;
            bool val1 = false;
            
            if (x == 3)
            { val = false; val1 = false; }
            else if (x == 4)
            { val = true; val1 = false; }
            else if (x == 5)
            { val = true; val1 = true; }
            
            button10.Visible = val; button11.Visible = val; button12.Visible = val;
            button13.Visible = val; button14.Visible = val; button15.Visible = val;
            button16.Visible = val; button17.Visible = val1; button18.Visible = val1;
            button19.Visible = val1; button20.Visible = val1; button21.Visible = val1;
            button22.Visible = val1; button23.Visible = val1; button24.Visible = val1;
            button25.Visible = val1;
        }


        public void gamealg()
        {
            Random ran = new Random();
            int r=0;
            if (x == 3)
            { r = ran.Next(1, 10); }
            else if (x == 4)
            { r = ran.Next(1, 17); }
            else if (x == 5)
            { r = ran.Next(1, 26); }
            
            switch(r)
            {
                case 0: break;
                case 1: button1.Text="*"; break;
                case 2: button2.Text = "*"; break;
                case 3: button3.Text = "*"; break;
                case 4: button4.Text = "*"; break;
                case 5: button5.Text = "*"; break;
                case 6: button6.Text = "*"; break;
                case 7: button7.Text = "*"; break;
                case 8: button8.Text = "*"; break;
                case 9: button9.Text = "*"; break;
                case 10: button10.Text = "*"; break;
                case 11: button11.Text = "*"; break;
                case 12: button12.Text = "*"; break;
                case 13: button13.Text = "*"; break;
                case 14: button14.Text = "*"; break;
                case 15: button15.Text = "*"; break;
                case 16: button16.Text = "*"; break;
                case 17: button17.Text = "*"; break;
                case 18: button18.Text = "*"; break;
                case 19: button19.Text = "*"; break;
                case 20: button20.Text = "*"; break;
                case 21: button21.Text = "*"; break;
                case 22: button22.Text = "*"; break;
                case 23: button23.Text = "*"; break;
                case 24: button24.Text = "*"; break;
                case 25: button25.Text = "*"; break;
            }

        }


        public sts()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 0.1;
            textBox1.Text=(i.ToString());
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            levelselect(false);
            gamealg();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            b.BackColor = Color.White;
            timer2.Stop();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            x = 3; levels();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            x = 4; levels();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            x = 5; levels();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            b = button1; buttonclick(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = button2; buttonclick(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = button3; buttonclick(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = button4; buttonclick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b = button5; buttonclick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b = button6; buttonclick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b = button7; buttonclick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            b = button8; buttonclick();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            b = button9; buttonclick();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            b = button10; buttonclick();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b = button11; buttonclick();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = button12; buttonclick();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            b = button13; buttonclick();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            b = button14; buttonclick();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            b = button15; buttonclick();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            b = button16; buttonclick();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            b = button17; buttonclick();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            b = button18; buttonclick();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            b = button19; buttonclick();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            b = button20; buttonclick();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            b = button21; buttonclick();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            b = button22; buttonclick();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            b = button23; buttonclick();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            b = button24; buttonclick();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            b = button25; buttonclick();
        }

        private void sts_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HI! WELCOME T0 \"SMASH THE STAR\".\nBE A HERO AND SMASH ALL THE FALLING STARS FROM SPACE AND SAVE EARTH IN THE \"SMASH THE STAR\" \nINSTRUCTIONS:\n1)SELECT LEVEL IN RADIO BUTTON\n2)PRESS START TO START GAME AND TIMER\n3)SMASH ALL 15 STARS IN BEST TIME POSSIBLE\n    ENJOY!","INSRUCIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



       
    }
}
