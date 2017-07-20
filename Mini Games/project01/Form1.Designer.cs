namespace project01
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smashTheStarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberSwapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathMazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticTacToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipWreckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allGamesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allGamesToolStripMenuItem
            // 
            this.allGamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smashTheStarToolStripMenuItem,
            this.numberSwapToolStripMenuItem,
            this.mathMazeToolStripMenuItem,
            this.ticTacToeToolStripMenuItem,
            this.shipWreckToolStripMenuItem,
            this.pipesToolStripMenuItem});
            this.allGamesToolStripMenuItem.Name = "allGamesToolStripMenuItem";
            this.allGamesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.allGamesToolStripMenuItem.Text = "All Games";
            // 
            // smashTheStarToolStripMenuItem
            // 
            this.smashTheStarToolStripMenuItem.Name = "smashTheStarToolStripMenuItem";
            this.smashTheStarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.smashTheStarToolStripMenuItem.Text = "Smash The Star";
            this.smashTheStarToolStripMenuItem.Click += new System.EventHandler(this.smashTheStarToolStripMenuItem_Click);
            // 
            // numberSwapToolStripMenuItem
            // 
            this.numberSwapToolStripMenuItem.Name = "numberSwapToolStripMenuItem";
            this.numberSwapToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.numberSwapToolStripMenuItem.Text = "Picture Mixture";
            this.numberSwapToolStripMenuItem.Click += new System.EventHandler(this.numberSwapToolStripMenuItem_Click);
            // 
            // mathMazeToolStripMenuItem
            // 
            this.mathMazeToolStripMenuItem.Name = "mathMazeToolStripMenuItem";
            this.mathMazeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.mathMazeToolStripMenuItem.Text = "Math Maze";
            this.mathMazeToolStripMenuItem.Click += new System.EventHandler(this.mathMazeToolStripMenuItem_Click);
            // 
            // ticTacToeToolStripMenuItem
            // 
            this.ticTacToeToolStripMenuItem.Name = "ticTacToeToolStripMenuItem";
            this.ticTacToeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ticTacToeToolStripMenuItem.Text = "Tic Tac Toe";
            this.ticTacToeToolStripMenuItem.Click += new System.EventHandler(this.ticTacToeToolStripMenuItem_Click);
            // 
            // shipWreckToolStripMenuItem
            // 
            this.shipWreckToolStripMenuItem.Name = "shipWreckToolStripMenuItem";
            this.shipWreckToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.shipWreckToolStripMenuItem.Text = "Ship Wreck";
            this.shipWreckToolStripMenuItem.Click += new System.EventHandler(this.shipWreckToolStripMenuItem_Click);
            // 
            // pipesToolStripMenuItem
            // 
            this.pipesToolStripMenuItem.Name = "pipesToolStripMenuItem";
            this.pipesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pipesToolStripMenuItem.Text = "Pipes";
            this.pipesToolStripMenuItem.Click += new System.EventHandler(this.pipesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(757, 382);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MINI GAMES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smashTheStarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberSwapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathMazeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticTacToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shipWreckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pipesToolStripMenuItem;
    }
}

