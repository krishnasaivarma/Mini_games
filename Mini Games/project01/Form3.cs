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
    public partial class picmix : Form
    {
        public double k;
        public Button b1, b2, b3, b4;
        public int l=9;


        public void levels(int x)
        {
            //selects button visabilty depending on radiobuttons

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

        public void levelselect(bool v)
        {
            //turns radiobutton visability on and off
            radioButton1.Enabled = v;
            radioButton2.Enabled = v;
            radioButton3.Enabled = v;
        }


        public void buttonpass(int a, int b, int c, int d)
        {
            //takes 4 sides of a button and passes them to buttonset
            SystemSounds.Asterisk.Play();
            int i = 0;
            int[] z = new int[4];
            z[0] = a; z[1] = b; z[2] = c; z[3] = d;
            for (int j = 0; j < 4; j++)
            {
                if (z[i] > l)
                    z[i] = 0;

                switch (z[i])
                {
                    case 0: buttonset(dummy, i); break;
                    case 1: buttonset(button1, i); break;
                    case 2: buttonset(button2, i); break;
                    case 3: buttonset(button3, i); break;
                    case 4: buttonset(button4, i); break;
                    case 5: buttonset(button5, i); break;
                    case 6: buttonset(button6, i); break;
                    case 7: buttonset(button7, i); break;
                    case 8: buttonset(button8, i); break;
                    case 9: buttonset(button9, i); break;
                    case 10: buttonset(button10, i); break;
                    case 11: buttonset(button11, i); break;
                    case 12: buttonset(button12, i); break;
                    case 13: buttonset(button13, i); break;
                    case 14: buttonset(button14, i); break;
                    case 15: buttonset(button15, i); break;
                    case 16: buttonset(button16, i); break;
                    case 17: buttonset(button17, i); break;
                    case 18: buttonset(button18, i); break;
                    case 19: buttonset(button19, i); break;
                    case 20: buttonset(button20, i); break;
                    case 21: buttonset(button21, i); break;
                    case 22: buttonset(button22, i); break;
                    case 23: buttonset(button23, i); break;
                    case 24: buttonset(button24, i); break;
                    case 25: buttonset(button25, i); break;
                    default: i--; break;
                }
                i++;


            }
        }

        public void buttonset(Button b, int i)
        {
            // assigns b1-4 buttons to passed values
            switch (i)
            {
                case 0: b1 = b; break;
                case 1: b2 = b; break;
                case 2: b3 = b; break;
                case 3: b4 = b; break;
            }

        }

        public void crosscheck(Button b)
        {
            //does swapping and checks for game over

            if (b1.Text == "")
            {
                b1.Text = b.Text;
                b.Text = "";
                b1.BackgroundImage = b.BackgroundImage;
                b.BackgroundImage = Properties.Resources.f3_0;
            }
            else if (b2.Text == "")
            {
                b2.Text = b.Text;
                b.Text = "";
                b2.BackgroundImage = b.BackgroundImage;
                b.BackgroundImage = Properties.Resources.f3_0;
            }

            else if (b3.Text == "")
            {
                b3.Text = b.Text;
                b.Text = "";
                b3.BackgroundImage = b.BackgroundImage;
                b.BackgroundImage = Properties.Resources.f3_0;
            }
            else if (b4.Text == "")
            {
                b4.Text = b.Text;
                b.Text = "";
                b4.BackgroundImage = b.BackgroundImage;
                b.BackgroundImage = Properties.Resources.f3_0;
            }

            gameover();
        }


        public void gameover()
        {

            //displays game over messages and scores

            int w = 0;
            if(l>8){
                if (button1.Text == "1" && button4.Text == "2" && button5.Text == "3" && button2.Text == "6" && button3.Text == "7" && button6.Text == "8" && button9.Text == "11" && button8.Text == "12")
                {
                    w = 1;
                }
            }
            if (l > 15)
            {
                w = 0;
                if ( button16.Text == "4"  && button15.Text == "9" &&  button7.Text == "13" && button14.Text == "14" && button10.Text == "16"&& button11.Text == "17" && button12.Text == "18" )
                {
                    w = 1;
                }
            }
            if (l > 24)
            {
                w = 0;
                if ( button17.Text == "5" && button18.Text == "10" && button19.Text == "15" && button13.Text == "19" && button20.Text == "20" && button25.Text == "21" && button24.Text == "22" && button23.Text == "23" && button22.Text == "24")
                {
                    w = 1;
                }
            }
            if(w==1)
            { timer1.Stop();
                    MessageBox.Show("CONGO! YOU WIN\nyour time " + textBox1.Text, "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            
                    dummy.Visible = false;
                    levelselect(true);
            }
        }

        public picmix()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            // loads images on start

            k = 0;
            levelselect(false);
            timer1.Start();
            dummy.Visible = true;

            button1.Text = "1"; button1.BackgroundImage = Properties.Resources.f3_1;
            button2.Text = "6"; button2.BackgroundImage = Properties.Resources.f3_6;
            button3.Text = "7"; button3.BackgroundImage = Properties.Resources.f3_7;
            button4.Text = "2"; button4.BackgroundImage = Properties.Resources.f3_2;
            button5.Text = "3"; button5.BackgroundImage = Properties.Resources.f3_3;
            button6.Text = "8"; button6.BackgroundImage = Properties.Resources.f3_8;
            button7.Text = "12"; button7.BackgroundImage = Properties.Resources.f3_12;
            button8.Text = ""; button8.BackgroundImage = Properties.Resources.f3_0;
            button9.Text = "11"; button9.BackgroundImage = Properties.Resources.f3_11;
            button10.Text = "18"; button10.BackgroundImage = Properties.Resources.f3_18;
            button11.Text = "9"; button11.BackgroundImage = Properties.Resources.f3_9;
            button12.Text = "16"; button12.BackgroundImage = Properties.Resources.f3_16;
            button13.Text = "13"; button13.BackgroundImage = Properties.Resources.f3_13;
            button14.Text = "14"; button14.BackgroundImage = Properties.Resources.f3_14;
            button15.Text = "4"; button15.BackgroundImage = Properties.Resources.f3_4;
            button16.Text = "17"; button16.BackgroundImage = Properties.Resources.f3_17;
            button17.Text = "22"; button17.BackgroundImage = Properties.Resources.f3_22;
            button18.Text = "10"; button18.BackgroundImage = Properties.Resources.f3_10;
            button19.Text = "20"; button19.BackgroundImage = Properties.Resources.f3_20;
            button20.Text = "24"; button20.BackgroundImage = Properties.Resources.f3_24;
            button21.Text = "19"; button21.BackgroundImage = Properties.Resources.f3_19;
            button22.Text = "15"; button22.BackgroundImage = Properties.Resources.f3_15;
            button23.Text = "23"; button23.BackgroundImage = Properties.Resources.f3_23;
            button24.Text = "21"; button24.BackgroundImage = Properties.Resources.f3_21;
            button25.Text = "5"; button25.BackgroundImage = Properties.Resources.f3_5;
           
            
           
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            l = 9; levels(3);
            dummy.BackgroundImage = Properties.Resources.f3_3x3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            l = 16; levels(4);
            dummy.BackgroundImage = Properties.Resources.f3_4x4;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            l = 25; levels(5);
            dummy.BackgroundImage = Properties.Resources.f3_5x5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonpass(0, 4, 2, 0);
             crosscheck( button1 );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonpass(1, 3, 9, 0);
            crosscheck(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonpass(4,6,8,2);
            crosscheck(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonpass(0,5,3,1);
            crosscheck(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonpass(16,6,4,0);
            crosscheck(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonpass(5,15,7,3);
            crosscheck(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonpass(6,14,12,8);
            crosscheck(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonpass(3,7,11,9);
            crosscheck(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonpass(2,8,10,0);
            crosscheck(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonpass(9,11,25,0);
            crosscheck(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttonpass(8,12,24,10);
            crosscheck(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonpass(7,13,23,11);
            crosscheck(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonpass(14,20,22,12);
            crosscheck(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttonpass(15,19,13,7);
            crosscheck(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonpass(16,18,14,6);
            crosscheck(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttonpass(0,17,15,5);
            crosscheck(button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            buttonpass(0,0,18,16);
            crosscheck(button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            buttonpass(17,0,19,15);
            crosscheck(button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            buttonpass(18,0,20,14);
            crosscheck(button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttonpass(19,0,21,13);
            crosscheck(button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buttonpass(20,0,0,22);
            crosscheck(button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            buttonpass(13,21,0,23);
            crosscheck(button22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            buttonpass(12,22,0,24);
            crosscheck(button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            buttonpass(11,23,0,25);
            crosscheck(button24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            buttonpass(10,24,0,0);
            crosscheck(button25);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k += 0.1;
            textBox1.Text = (k.ToString());
        }

        private void swap_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HI! WELCOME T0 \"PICTURE MIXTURE\".\nUNVEIL THE ARTEST IN YOU AND FIND THE TRUE IMAGE BY REARRANGING THE PARTS OF A PICTURE IN THE \"PICTURE MIXTURE\" \nINSTRUCTIONS:\n\n1) SELECT LEVEL IN RADIO BUTTON\n2) PRESS START TO START GAME AND TIMER\n3) PRESS A PICTURE BESIDE SPACE TO MOVE IT INTO THE SPACE\n4) DRAG WINDOW RIGHT TO SEE SAMPLE PICTURE\n5) ARRANGE PARTS INTO PICTURE IN BEST TIME POSSIBLE\n    ENJOY!", "INSRUCIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


       

    }
}
