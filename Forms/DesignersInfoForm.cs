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
    public partial class DesignersInfoForm : Form
    {
        public DesignersInfoForm()
        {
            InitializeComponent();
        }

        private Form childForm;
        private void button4_Click(object sender, EventArgs e)
        {
            childForm = new DesignersInfoForm();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            designersP4.Controls.Add(childForm);
            designersP4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
