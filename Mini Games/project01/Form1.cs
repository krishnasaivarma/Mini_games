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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void smashTheStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sts f2 = new sts();
            f2.MdiParent = this;
            f2.Show();
        }

        private void ticTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ttt f4 = new ttt();
            f4.MdiParent = this;
            f4.Show();
        }

        private void numberSwapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picmix f3 = new picmix();
            f3.MdiParent = this;
            f3.Show();
        }

        private void pipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pipes f5 = new pipes();
            f5.MdiParent = this;
            f5.Show();
        }

        private void mathMazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mm f6 = new mm();
            f6.MdiParent = this;
            f6.Show();
        }

        private void shipWreckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SW f7 = new SW();
            f7.MdiParent = this;
            f7.Show();
        }



        

       
       

        

       

        
        

       
       

      

     

       

       
           
    }
}
