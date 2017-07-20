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
    public partial class pipes : Form
    {
        public int[] o = new int[26];
        
        double k,score;
        int level;
        
        public int turns (Button b , int i )
        {
            //turns image upon click
            SystemSounds.Asterisk.Play();
            if (i < 0)
            {
               
                switch (i)
                {
                    case -1: i=-2; b.BackgroundImage = Properties.Resources.side; break;
                    case -2: i=-1; b.BackgroundImage = Properties.Resources.Up; break;
                }

            }
            else if (i > 0)
            {
                switch (i)
                {
                    case 1: i=2; b.BackgroundImage = Properties.Resources.DR; break;
                    case 2: i=3; b.BackgroundImage = Properties.Resources.DL; break;
                    case 3: i=4; b.BackgroundImage = Properties.Resources.UL; break;
                    case 4: i=1; b.BackgroundImage = Properties.Resources.UR; break;
                }
            }

            crosscheck();
            return i;
        }

        public void load()
        {
            k = 15;
            label7.Text = level.ToString();
            timer1.Start();
            switch (level)
            {
                case 1: int[] l = {0, -1,-1,-1,1,1,-1,1,1,-1,1,1,-1,1,-1,-1,-1,1,1,-1,-1,1,-1,-1,1,2}; o=l;  break;
                case 2: int[] ll = {0, -2,-2,1,-1,1,-1,1,-1,1,1,-1,1,1,-1,-1,-1,1,1,-1,-1,1,1,-1,1,-1}; o=ll; break;
                case 3: int[] lll = {0,1,-1,-1,1,-1,1,-1,-1,1,-1,-1,1,1,-1,1,-1,-1,1,-1,1,1,1,-1,-1,2 }; o = lll; break;
            }


            //loads levels data
            for(int z=0;z<26;z++){
                
                switch (z)
                {
                    case 0: break;
                    case 1: buttonset(button1, o[z]); break;
                    case 2: buttonset(button2, o[z]); break;
                    case 3: buttonset(button3, o[z]); break;
                    case 4: buttonset(button4, o[z]); break;
                    case 5: buttonset(button5, o[z]); break;
                    case 6: buttonset(button6, o[z]); break;
                    case 7: buttonset(button7, o[z]); break;
                    case 8: buttonset(button8, o[z]); break;
                    case 9: buttonset(button9, o[z]); break;
                    case 10: buttonset(button10, o[z]); break;
                    case 11: buttonset(button11, o[z]); break;
                    case 12: buttonset(button12, o[z]); break;
                    case 13: buttonset(button13, o[z]); break;
                    case 14: buttonset(button14, o[z]); break;
                    case 15: buttonset(button15, o[z]); break;
                    case 16: buttonset(button16, o[z]); break;
                    case 17: buttonset(button17, o[z]); break;
                    case 18: buttonset(button18, o[z]); break;
                    case 19: buttonset(button19, o[z]); break;
                    case 20: buttonset(button20, o[z]); break;
                    case 21: buttonset(button21, o[z]); break;
                    case 22: buttonset(button22, o[z]); break;
                    case 23: buttonset(button23, o[z]); break;
                    case 24: buttonset(button24, o[z]); break;
                    case 25: buttonset(button25, o[z]); break;
                    case 26: MessageBox.Show("error! 26"); break;
                    default: MessageBox.Show("error!"); break;
                   
                }
            }


            
        }

        public void buttonset(Button b, int i)
        {
            // assigns images buttons to passed buttons
            switch (i)
            {
                case -2: b.BackgroundImage = Properties.Resources.side; break;
                case -1: b.BackgroundImage = Properties.Resources.Up; break;
                case 0: b.BackgroundImage = Properties.Resources.f3_0; break;
                case 1: b.BackgroundImage = Properties.Resources.UR; break;
                case 2: b.BackgroundImage = Properties.Resources.DR; break;
                case 3: b.BackgroundImage = Properties.Resources.DL; break;
                case 4: b.BackgroundImage = Properties.Resources.UL; break;
            }

        }


        public void crosscheck()
        {
            if (level == 1)
            {
                if (o[1] == -1 && o[6] == -1 && o[8] == 2 && o[9] == -2 && o[10] == 3 && o[11] == 1 && o[12] == -2 && o[13] == 4 && o[15] == -1 && o[20] == -1 && o[25] == 4)
                { endgame(); }
            }
            if (level == 2)
            {
                if (o[1] == -1 && o[6] == -1 && o[7] == 2 && o[8] == -2 && o[9] == 3 && o[11] == -1 && o[12] == 1 && o[13] == 3 && o[14] == -1 && o[16] == -1 && o[17] == 2 && o[18] == 4 && o[19] == -1 && o[21] == 1 && o[22] == 4 && o[24] == 1 && o[25] == -1)
                { endgame(); }
            }
            if (level == 3)
            {
                if (o[1] == 1 && o[2] == -2 && o[3] == -2 && o[4] == 3 && o[6] == 2 && o[7] == -2 && o[8] == -2 && o[9] == 4 && o[11] == -1 && o[12] == 2 && o[13] == 3 && o[16] == -1 && o[17] == -1 && o[18] == 1 && o[19] == -2 && o[20] == 3 && o[21] == 1 && o[22] == 4 && o[25] == 4)
                { endgame(); }
            }
        }



        public void endgame()
        {
            //displays game over messages and scores

            if (level < 3)
            {
                timer1.Stop();
                score += k;
                MessageBox.Show("time left" + textBox1.Text + "\ncontinuing to next lexel");
                level++;

                load();
                
                
               
            }
            else if (level == 3)
            {
                timer1.Stop();
                MessageBox.Show("time left" + textBox1.Text + "\nGame Over\n\n\nfinal score  " + score.ToString());
                start.Enabled = true;
            }
        }


        public pipes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            o[1] = turns(button1, o[1]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            o[2] = turns(button2, o[2]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            o[3] = turns(button3, o[3]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            o[4] = turns(button4, o[4]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            o[5] = turns(button5, o[5]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            o[6] = turns(button6, o[6]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            o[7] = turns(button7, o[7]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            o[8] = turns(button8, o[8]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            o[9] = turns(button9, o[9]);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            o[10] = turns(button10, o[10]);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            o[11] = turns(button11, o[11]);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            o[12] = turns(button12, o[12]);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            o[13] = turns(button13, o[13]);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            o[14] = turns(button14, o[14]);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            o[15] = turns(button15, o[15]);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            o[16] = turns(button16, o[16]);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            o[17] = turns(button17, o[17]);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            o[18] = turns(button18, o[18]);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            o[19] = turns(button19, o[19]);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            o[20] = turns(button20, o[20]);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            o[21] = turns(button21, o[21]);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            o[22] = turns(button22, o[22]);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            o[23] = turns(button23, o[23]);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            o[24] = turns(button24, o[24]);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            o[25] = turns(button25, o[25]);
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
                k = 0; endgame();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            level = 1;
            start.Enabled = false;
            load();
        }

        private void pipes_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HI! WELCOME T0 \"PIPES\".\nBECOME A PLUMBER AND CONNECT THE PIPES BETWEEN THE PUMP AND TAP IN \"PIPES\" \nINSTRUCTIONS:\n\n1)PRESS START TO START GAME AND TIMER\n2) PRESS ANY PIPE TO ROTATE IT\n3) CONNECT START WITH END TO COMPLETE A LEVEL\n4) THERE ARE 3 DIFFERENT LEVELS\n5) YOU HAVE 15 SECONDS TO COMPLETE EACH LEVEL\n6) COMPLETE ALL LEVELS IN BEST POSSIBLE TIME\n    ENJOY!", "INSRUCIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
