using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5_PBL
{
    public partial class LoadScreen : Form
    {
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
    }

    void timer1_Tick(object sender, EventArgs e)
    {
        if (progressBar1.Value != 10)
        {
            progressBar1.Value++;
        }
        else
        {
                timer1.Stop();
                this.Close();
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
  
        }
    }
}
