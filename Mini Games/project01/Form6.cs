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
    public partial class mm : Form
    {
        public int level=1,q;
        public double score,k;

        //question,answers and options
        string[] l1q = new string[10] { "7 + 9", "-2 - 9", "52 / 3", "-7 X -2", "10 % 61","-8.5 + 6.5","-2.5 - 3.5","10 / 6","1.6 X 1.25","3 % 23" };
        double[,] l1a = new double[10, 3] {  {15,16,17}, {6,10,11}, {4,5,6}, {-14,13,14}, {1,2,3}, {2,3,15}, {15,16,17}, {1.3,1.6,1.9}, {2,3,4}, {1,2,3}  };
        int[] l1qa = new int[10] { 3, 5, 1, 5, 1, 1, 3, 3, 1, 3 };

        string[] l2q = new string[10] { "10 + 5 - 9","10 X 8 / 5","15 + 5 / 5","1 + 12 / 3","12 / 4 % 10","-11.5 - -18 + 9.5","-10 / 1.6 / -6","13 - 2 X 5","9 - 10 / 2","9 / 13 % 10"};
        double[,] l2a = new double[10, 5] { {5,6,7,8,9},{14,15,16,17,18},{15,6,7,8,16},{2,3,4,5,6},{2,3,4,5,6},{14,15,16,17,18},{1,1.5,2,2.5,3},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}};
        int[] l2qa = new int[10] { 2,3,5,4,5,3,1,3,4,3 };
        


        public void load()
        {
            //lodes question and options to screen
             if(level==1)
             {
                 label1.Text=l1q[q];
                 button1.Text = l1a[q, 0].ToString();
                 button3.Text = l1a[q, 1].ToString();
                 button5.Text = l1a[q, 2].ToString();
             }

             else if (level == 2)
             {
                 label1.Text = l2q[q];
                 button1.Text = l2a[q, 0].ToString();
                 button2.Text = l2a[q, 1].ToString();
                 button3.Text = l2a[q, 2].ToString();
                 button4.Text = l2a[q, 3].ToString();
                 button5.Text = l2a[q, 4].ToString();
             }

        }

        public void crosscheck(int i)
        {
            //Checks for Right and wrong
            
            if (level == 1)
            {
                if (i == l1qa[q])
                {
                    //corrrect
                    this.BackColor = Color.Green;
                    SystemSounds.Asterisk.Play();
                    score += 20;
                }
                else
                { //wrong
                    this.BackColor = Color.Red;
                    SystemSounds.Hand.Play();
                   
                }
            }

            else if (level == 2)
            {
                if (i == l2qa[q])
                {//correct
                    this.BackColor = Color.Green;
                    SystemSounds.Asterisk.Play();
                    score += 40;
                }
                else
                {//wrong
                    this.BackColor = Color.Red;
                    SystemSounds.Hand.Play();
                }
            }

            timer2.Start();
            q++;
            if (q < 10)
            {
             load(); }
            else
            { gameover(); }
            

        }


        public void gameover()
        {
            //displays game over message and scores
            timer1.Stop();
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = false;
            radioButton1.Enabled = radioButton2.Enabled = start.Enabled = true;
            score += 100 - k;
            if (score < 0)
            {score = 0;}
            MessageBox.Show("game over\nyourscore: " + score.ToString(), "RESULT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        public mm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Visible = button4.Visible = false; level = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Visible = button4.Visible = true; level = 2;
        }

        private void start_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = radioButton2.Enabled = start.Enabled = false;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = true;

            score = 0; q = 0; k = 0;
            timer1.Start();
            load();
            
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            timer2.Stop();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
             MessageBox.Show("HI! WELCOME T0 \"MATH MAZE\".\n WORK UP YOUT BRAIN MUZZLES WITH SIMPLE MATH PROBLEMS IN \"MATH MAZE\" \nINSTRUCTIONS:\n1)SELECT LEVEL IN RADIO BUTTON\n2)PRESS START TO START GAME AND TIMER\n3) SEE QUESTION AND PRESS ANY OPTIONS BELOW TO ANSWER\n4) ANSWER ALL 10 QUESTIONS CORRECTLY IN BEST TIME POSSIBLE\n    ENJOY!", "INSRUCIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k += 0.1;
            textBox1.Text = (k.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crosscheck(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crosscheck(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crosscheck(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            crosscheck(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            crosscheck(5);
        }

       


    }
}
