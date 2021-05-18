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
    public partial class Form1 : Form
    {
        
        private Region RegionForm;
        public Form1(Region regionForm)
        {
            this.RegionForm = regionForm;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //yes
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 55)
            {
                sideMenu.Visible = false;
                PanelAnimator.ShowSync(sideMenu);
                sideMenu.Width = 240;
            }
            else
            {
                sideMenu.Visible = false;
                sideMenu.Width = 55;
                PanelAnimator.ShowSync(sideMenu);
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.RegionForm.Close();
            this.Close();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            
            
            
            if (panel3.Visible == true)
            {
                bunifuFlatButton3.Enabled = true;             
                bunifuFlatButton2.Enabled = false;
                bunifuFlatButton4.Enabled = true;
            
            }
            else
            {
                bunifuFlatButton2.Enabled = false;
                bunifuFlatButton3.Enabled = true;
                bunifuFlatButton4.Enabled = true;
            }
            
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            

            if (panel2.Visible == true)
            {
                bunifuFlatButton2.Enabled = true;
                bunifuFlatButton3.Enabled = false;
                bunifuFlatButton4.Enabled = true;
            }
            else
            {
                bunifuFlatButton3.Enabled = true;
                bunifuFlatButton2.Enabled = false;
                bunifuFlatButton4.Enabled = true;
            }


        }
    }
}
