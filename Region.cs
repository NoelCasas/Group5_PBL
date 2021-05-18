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
    public partial class Region : Form
    {
        public Region()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == comboBox1.Items[0].ToString())
            {
                this.Hide();
                Form1 mainScreen = new Form1(this);
                mainScreen.ShowDialog();
                
            }
            else
            {

            }
        }
    }
}
