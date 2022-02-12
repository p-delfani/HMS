using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HMS
{
    public partial class splash : Form

    { 
        Timer timer;
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Shown(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 4000; // مدت زمان نمایش پنجره اسپلش بر حسب میلی ثانیه
            timer.Start();
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Form1 main = new Form1(); //کلاس پنجره اصلی برنامه
            main.Show();
            this.Hide();
        }
    }
}
