using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik2020
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            splashScreenTimer.Start();
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            splashScreenTimer.Stop();
            this.Close();
        }
    }
}
