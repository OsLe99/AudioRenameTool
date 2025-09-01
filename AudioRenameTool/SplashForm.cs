using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioRenameTool
{
    public partial class SplashForm : Form
    {
        private System.Windows.Forms.Timer splashTimer;
        public SplashForm()
        {
            InitializeComponent();
            splashTimer = new System.Windows.Forms.Timer();
            splashTimer.Interval = 3000;
            splashTimer.Tick += SplashTimer_Tick;
            splashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop();
            splashTimer.Dispose();
            this.Close();
        }
    }
}
