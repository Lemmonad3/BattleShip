using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            tmr.Interval = 1500;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)

        {

            tmr.Stop();

            //display mainform

            StartForm st = new StartForm();

            st.Show();

            Hide();

        }
    }
}
