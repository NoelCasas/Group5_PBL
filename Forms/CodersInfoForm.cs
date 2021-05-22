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
    public partial class CodersInfoForm : Form
    {
        public CodersInfoForm()
        {
            InitializeComponent();
        }
        private Form childForm;
        private void button5_Click(object sender, EventArgs e)
        {
            childForm = new DesignersInfoForm();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            codersP5.Controls.Add(childForm);
            codersP5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
