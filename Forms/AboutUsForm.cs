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
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();
        }

        private Form childForm;

        private void DesignerInfo(object sender, EventArgs e)
        {
            childForm = new DesignersInfoForm();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            aboutUsP3.Controls.Add(childForm);
            aboutUsP3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CodersInfo(object sender, EventArgs e)
        {
            childForm = new CodersInfoForm();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            aboutUsP3.Controls.Add(childForm);
            aboutUsP3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
