using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindACouple
{
    public partial class PlayAgainForm : Form
    {
        private double timerCount;

        
        public PlayAgainForm(double timerCount)
        {
            InitializeComponent();
            this.timerCount = timerCount;
            labelForTime.Text = timerCount.ToString();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) 
                { 
                    timer.Stop(); 
                }
            });
            timer.Interval = 100;
            timer.Start();           
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Opacity = 1;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((send, events) =>
            {
                if ((Opacity -= 0.05d) == 0)
                {
                    Close();
                    timer.Stop();
                }
            });
            timer.Interval = 100;
            timer.Start();           
            this.DialogResult = DialogResult.OK;
        }
    }
}
