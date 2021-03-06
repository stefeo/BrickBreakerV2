﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker.Screens
{
    public partial class HighscoreScreen : UserControl
    {
        public HighscoreScreen()
        {
            InitializeComponent();
            OnLoad();
        }

        private void HighscoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MenuScreen ms = new MenuScreen();
                Form form = this.FindForm();

                form.Controls.Add(ms);
                form.Controls.Remove(this);   

                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
            }
        }

        private void OnLoad()
        {
            for (int i = 0; i < Form1.highscoreList.Count; i++)
            {
                if (i < 5)
                {
                    top5Output.Text += (i + 1) + ".  " + Form1.highscoreList[i].name + " " + Form1.highscoreList[i].level + " " + Form1.highscoreList[i].score + "\n";
                }
                else if (i >= 5 && i < 10)
                {
                    if ((i + 1) == 10)
                    {
                        next5Output.Text += (i + 1) + ". " + Form1.highscoreList[i].name + " " + Form1.highscoreList[i].level + " " + Form1.highscoreList[i].score + "\n";
                    }
                    else
                    {
                        next5Output.Text += (i + 1) + ".  " + Form1.highscoreList[i].name + " " + Form1.highscoreList[i].level + " " + Form1.highscoreList[i].score + "\n";
                    }
                }
            }
        }
    }
}
