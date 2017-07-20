using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project01
{
    public partial class ttt : Form
    {
        public int  x = 0;
        public void wincheck()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text) { win(button1.Text); }
            else if (button4.Text == button5.Text && button5.Text==button6.Text) { win(button4.Text); }
            else if (button7.Text == button8.Text && button8.Text==button9.Text) { win(button7.Text); }
            else if (button1.Text == button4.Text && button4.Text==button7.Text) { win(button1.Text); }
            else if (button2.Text == button5.Text && button5.Text==button8.Text) { win(button2.Text); }
            else if (button3.Text == button6.Text && button6.Text==button9.Text) { win(button3.Text); }
            else if (button1.Text == button5.Text && button5.Text==button9.Text) { win(button1.Text); }
            else if (button3.Text == button5.Text && button5.Text==button7.Text) { win(button3.Text); }
        }

        public void win(string s)
        {
            if (s != "")
            {
                if (s == "X")
                { MessageBox.Show("congo!\nplayer 1 WINS!"); textBox1.Text = "W"; }
                else if (s == "O")
                { MessageBox.Show("congo!\nplayer 2 WINS!"); textBox1.Text = "W"; }
                else
                    MessageBox.Show("Good Game!\nits a DRAW!!");
            }
            if (x == 9)
            {
                x = 0;
                res(button1); res(button2); res(button3); res(button4); res(button5);
                res(button6); res(button7); res(button8); res(button9);
            }
            
        }

        public void res(Button b)
        {
            b.Text = ""; b.ForeColor = Color.Black;
        }

        public void but(Button b)
        {
            if (b.Text == "")
            {
                if (x %2== 0)
                { b.ForeColor = Color.Blue; b.Text = "X"; x++; }
                else if (x % 2 != 0)
                { b.ForeColor = Color.Red; b.Text = "O"; x++; }
            }
            wincheck();
            if (x == 9)
            { win("draw"); }
        }

        public ttt()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {
            but(button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            but(button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            but(button7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            but(button6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            but(button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            but(button4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            but(button3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            but(button2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            but(button1);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Visible = false; radioButton4.Visible = false; 
            label1.Text = "PLAYER 1"; label2.Text = "PLAYER 2";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Visible = true; radioButton4.Visible = true; 
            label1.Text = "WINS"; label2.Text = "LOOSE";
        }

        

       

       
       
    }
}
