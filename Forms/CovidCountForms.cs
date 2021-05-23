using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5_PBL.Forms
{
    public partial class CovidCountForms : Form
    {
        private Form childForm;
        private DateTime startDate;
        private DateTime endDate;

        public CovidCountForms()
        {
            InitializeComponent();
        }

        

        private void GoToCharts(object sender, EventArgs e)
        {
            childForm = new CovidChartsForm(startDate, endDate);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            covidCountP6.Controls.Add(childForm);
            covidCountP6.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // January
            {
                startDate = new DateTime(2021, 1, 1);
                endDate = new DateTime(2021, 1, 31);
            }
            if (comboBox1.SelectedIndex == 1) // January 1st Week
            {
                startDate = new DateTime(2021,1,3);
                endDate = new DateTime(2021,1,9);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                startDate = new DateTime(2021, 1, 10);
                endDate = new DateTime(2021, 1, 16);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                startDate = new DateTime(2021, 1, 17);
                endDate = new DateTime(2021, 1, 23);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                startDate = new DateTime(2021, 1, 24);
                endDate = new DateTime(2021, 1, 30);
            }
            if (comboBox1.SelectedIndex == 5) // February
            {
                startDate = new DateTime(2021, 2, 1); 
                endDate = new DateTime(2021, 2, 28);
            }
            if (comboBox1.SelectedIndex == 6) // February 1st Week
            {
                startDate = new DateTime(2021, 2, 7);
                endDate = new DateTime(2021, 2, 13);
            }
            if (comboBox1.SelectedIndex == 7)
            {
                startDate = new DateTime(2021, 2, 14);
                endDate = new DateTime(2021, 2, 20);
            }
            if (comboBox1.SelectedIndex == 8)
            {
                startDate = new DateTime(2021, 2, 21);
                endDate = new DateTime(2021, 2, 27);
            }
            if (comboBox1.SelectedIndex == 9) 
            {
                startDate = new DateTime(2021, 2, 28);
                endDate = new DateTime(2021, 3, 6);
            }
            if (comboBox1.SelectedIndex == 10) // March
            {
                startDate = new DateTime(2021, 3, 1);
                endDate = new DateTime(2021, 3, 31);
            }
            if (comboBox1.SelectedIndex == 11) // March 1st Week
            {
                startDate = new DateTime(2021, 3, 7);
                endDate = new DateTime(2021, 3, 13);
            }
            if (comboBox1.SelectedIndex == 12)
            {
                startDate = new DateTime(2021, 3, 14);
                endDate = new DateTime(2021, 3, 20);
            }
            if (comboBox1.SelectedIndex == 13)
            {
                startDate = new DateTime(2021, 3, 21);
                endDate = new DateTime(2021, 3, 27);
            }
            if (comboBox1.SelectedIndex == 14)
            {
                startDate = new DateTime(2021, 3, 28);
                endDate = new DateTime(2021, 4, 3);
            }


        }
    }
}
