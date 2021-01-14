using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Projectt
{
    public partial class SplassScreen : Form
    {
        public int i = 0;
        public SplassScreen()
        {
            InitializeComponent();
        }

        private void SplassScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(5);

            if (progressBar1.Value == 200)
            {
                timer1.Stop();
                this.Close();
            }
       
        }
            private void SplashScreen_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

  
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
