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
            if (comboBox1.SelectedIndex == 0)
            {
                startDate = DateTime.Parse("2021/01/01");
                endDate = DateTime.Parse("2021/01/31");
            }
        }
    }
}
