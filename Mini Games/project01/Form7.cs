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
    public partial class SW : Form
    {
        public int bombsleft=6, shipsleft=5;
        public double k;
        public int[] l = new int[25];
        
        public int[] l3 = new int[10] { 0,8,0,0,4,0,0,10,5,2 };
        public int[] l4 = new int[17]{ 0,3,7,0,0,2,9,1,0,0,8,5,4,0,0,0,10 };
        public int[] l5 = new int[26]{ 0,0,2,10,0,8,0,0,0,0,0,2,10,1,6,9,4,0,0,0,0,0,0,4,5,8 };

        void setbnum()
        {
            //sets number of bombs and ships remaining
            string s="";
            for (int i = 0; i < bombsleft; i++)
            {              s += "u\n";            }
            bleft.Text = s;

            s = "";
            for (int i = 0; i < shipsleft; i++)
            {              s += "u\n";            }
            sleft.Text = s;
            
        }

        public void throwbomb(Button b,int i)
        {
            //checks for ships presence


            if (l[i] == 0)
            { 
                b.BackgroundImage = Properties.Resources.f7_null;
                SystemSounds.Hand.Play();
            }
            else
            {
                SystemSounds.Asterisk.Play();
                shipsleft--;
                switch (l[i])
                {
                    
                    case 1: b.BackgroundImage = Properties.Resources.f7_fu; break;
                    case 2: b.BackgroundImage = Properties.Resources.f7_fr; break;
                    case 3: b.BackgroundImage = Properties.Resources.f7_fd; break;
                    case 4: b.BackgroundImage = Properties.Resources.f7_fl; break;
                    case 5: b.BackgroundImage = Properties.Resources.f7_side;break;
                    case 6: b.BackgroundImage = Properties.Resources.f7_up; break;
                    case 7: b.BackgroundImage = Properties.Resources.f7_bu; break;
                    case 8: b.BackgroundImage = Properties.Resources.f7_br; break;
                    case 9: b.BackgroundImage = Properties.Resources.f7_bd; break;
                    case 10:b.BackgroundImage = Properties.Resources.f7_bl; break;
                }
            }
            
            bombsleft--;
            
            setbnum();
            

            if (bombsleft == 0||shipsleft==0)
                gameover();
        }

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
            start.Enabled = v;
        }


        public void gameover()
        {
            foreach (Control ctr1 in this.Controls)
            {
                ctr1.BackgroundImage = null;
                ctr1.Enabled = false;
            }
            radioButton1.Checked = false;

            levelselect(true);
            if (shipsleft == 0)
            {
                MessageBox.Show("clear", "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
            else
            {
                MessageBox.Show("fail", "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

           

        }

        public SW()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HI! WELCOME T0 \"SHIP WRECK\".\nUNLEASH THE SOLDIRE INSIDE YOU BY BOMBING ON ENEMY SHIPS HIDING IN SEA \nINSTRUCTIONS:\n\n1) SELECT LEVEL IN RADIO BUTTON\n2) PRESS START TO START GAME AND TIMER\n3) PRESS A BOX TO BOMB IT AND REVEAL ITS PICTURE\n4) FIND ALL SHIPS BEFORE BOMBS/TIMER RUNS OUT\n    ENJOY!", "INSRUCIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            levels(3); shipsleft = 5; bombsleft = 6; l = l3; k = 15;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            levels(4); shipsleft = 9; bombsleft = 11; l = l4; k = 20;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            levels(5); shipsleft = 12; bombsleft = 15; l = l5; k = 25;
        }

        private void start_Click(object sender, EventArgs e)
        {
            foreach (Control ctr2 in this.Controls)
            {
                ctr2.Enabled = true;
            }
            setbnum();
            levelselect(false);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            throwbomb(button11, 11);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            throwbomb(button24, 24);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            throwbomb(button23, 23);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            throwbomb(button22, 22);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            throwbomb(button21, 21);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            throwbomb(button20, 20);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            throwbomb(button19, 19);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            throwbomb(button18, 18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            throwbomb(button17, 17);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            throwbomb(button16, 16);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            throwbomb(button15, 15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            throwbomb(button14, 14);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            throwbomb(button13, 13);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            throwbomb(button12, 12);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            throwbomb(button25, 25);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            throwbomb(button10, 10);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            throwbomb(button9, 9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            throwbomb(button8, 8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            throwbomb(button7, 7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            throwbomb(button6, 6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throwbomb(button5, 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throwbomb(button4, 4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throwbomb(button3, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throwbomb(button2, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throwbomb(button1, 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k -= 0.1;
            textBox1.Text = (k.ToString());
            if (k < 0)
            {
                timer1.Stop();
                SystemSounds.Hand.Play();
                MessageBox.Show("Time up!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                k = 0; gameover();
            }
        }

       
    }
}
