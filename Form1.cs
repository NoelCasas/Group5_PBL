using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Group5_PBL.Forms;

namespace Group5_PBL
{
    public partial class Form1 : Form
    {

        private Form currentChildForm;
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

      

        private void FormLoad(object sender, EventArgs e)
        {
            currentChildForm = new CovidCountForms
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelDesktop.Controls.Add(currentChildForm);
            panelDesktop.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SignsOfInfectionForm());
            //// Main Lobbies Panels
            //whatToDoP2.Visible = true;
            //virusInfoP1.Visible = false;
            //aboutUsP3.Visible = false;
            //designersP4.Visible = false;
            //codersP5.Visible = false;
            //covidCountP6.Visible = false; // ComboBox Selection 

            //// January 
            //janMonth.Visible = false; //Jan 

            //// February

            //// March

            //// April

            ////May

            //if (whatToDoP2.Visible == true)
            //{
            //    bunifuFlatButton3.Enabled = true;             
            //    bunifuFlatButton2.Enabled = false;
            //    bunifuFlatButton4.Enabled = true;
            //    bunifuFlatButton1.Enabled = true;
            //}
        }
        private void VirusInfo(object sender, EventArgs e)
        {
            OpenChildForm(new CovidInfoForm());
            //// Main Lobbies
            //virusInfoP1.Visible = true;
            //whatToDoP2.Visible = false;
            //aboutUsP3.Visible = false;
            //designersP4.Visible = false;
            //codersP5.Visible = false;
            //covidCountP6.Visible = false; // ComboBox Selection

            //// January
            //janMonth.Visible = false; // Jan

            //// February

            //// March

            //// April

            ////May

            //if (virusInfoP1.Visible == true)
            //{
            //    bunifuFlatButton2.Enabled = true;
            //    bunifuFlatButton3.Enabled = false;
            //    bunifuFlatButton4.Enabled = true;
            //    bunifuFlatButton1.Enabled = true;
            //}
        }

        private void AboutUsButton(object sender, EventArgs e)
        {
            OpenChildForm(new AboutUsForm());
            //// Main Lobbies
            //aboutUsP3.Visible = true;
            //virusInfoP1.Visible = false;
            //whatToDoP2.Visible = false;
            //designersP4.Visible = false;
            //codersP5.Visible = false;
            //covidCountP6.Visible = false; // ComboBox Selection

            //// January
            //janMonth.Visible = false; // Jan

            //// February

            //// March

            //// April

            //// May

            //if (aboutUsP3.Visible == true)
            //{
            //    bunifuFlatButton2.Enabled = true;
            //    bunifuFlatButton4.Enabled = false;
            //    bunifuFlatButton3.Enabled = true;
            //    bunifuFlatButton1.Enabled = true;
            //}
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    // Main Lobbies
        //    designersP4.Visible = true;
        //    virusInfoP1.Visible = false;
        //    whatToDoP2.Visible = false;
        //    aboutUsP3.Visible = false;
        //    codersP5.Visible = false;
        //    covidCountP6.Visible = false; // ComboBox Selection

        //    // January
        //    janMonth.Visible = false; // Jan

        //    // February

        //    // March

        //    // April

        //    //May
        //}

        //private void panel6_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void pictureBox4_Click(object sender, EventArgs e)
        //{

        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    // Main Lobbies
        //    aboutUsP3.Visible = true;
        //    virusInfoP1.Visible = false;
        //    whatToDoP2.Visible = false;
        //    designersP4.Visible = false;
        //    codersP5.Visible = false;
        //    covidCountP6.Visible = false;

        //    // January
        //    janMonth.Visible = false; // Jan

        //    // February

        //    // March

        //    // April

        //    //May

        //}

        //private void label26_Click(object sender, EventArgs e)
        //{

        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    // Main Lobbies
        //    aboutUsP3.Visible = true;
        //    virusInfoP1.Visible = false;
        //    whatToDoP2.Visible = false;
        //    designersP4.Visible = false;
        //    codersP5.Visible = false;
        //    covidCountP6.Visible = false; // ComboBox Selection

        //    // January
        //    janMonth.Visible = false; // Jan

        //    // February

        //    // March

        //    // April

        //    //May
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    // Main Lobbies
        //    codersP5.Visible = true;
        //    virusInfoP1.Visible = false;
        //    whatToDoP2.Visible = false;
        //    designersP4.Visible = false;
        //    aboutUsP3.Visible = false;
        //    covidCountP6.Visible = false; // ComboBox Selection 

        //    // January
        //    janMonth.Visible = false; // Jan

        //    // February

        //    // March

        //    // April

        //    //May

        //}

        //private void label27_Click(object sender, EventArgs e)
        //{

        //}

        private void OpenChildForm(Form childForm)
        {
            currentChildForm?.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }

        private void CovidCountClick(object sender, EventArgs e)
        {
            OpenChildForm(new CovidCountForms());
            //// Main Lobbies
            //covidCountP6.Visible = true; //ComboBox selection
            //virusInfoP1.Visible = false;
            //whatToDoP2.Visible = false;
            //designersP4.Visible = false;
            //codersP5.Visible = false;
            //aboutUsP3.Visible = false;

            //// January
            //janMonth.Visible = false; // Jan

            //// February

            //// March

            //// April

            ////May


            //if (covidCountP6.Visible == true)

            //{
            //    bunifuFlatButton4.Enabled = true;
            //    bunifuFlatButton1.Enabled = false;
            //    bunifuFlatButton3.Enabled = true;
            //    bunifuFlatButton2.Enabled = true;
            //}
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void label31_Click(object sender, EventArgs e)
        //{

        //}

        //private void label30_Click(object sender, EventArgs e)
        //{

        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Nakakalito ang regions section because the data is for all of Philippines!");
        //}

        //private void chart2_Click(object sender, EventArgs e)
        //{

        //}

        //private void chart1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
                                               
        //}

        //private void bunifuFlatButton5_Click(object sender, EventArgs e)
        //{
        //    if (comboBox1.Text == comboBox1.Items[0].ToString())
        //    {
        //        // Main Lobby
        //        covidCountP6.Visible = false; //ComboBox Selection
        //        virusInfoP1.Visible = false;
        //        whatToDoP2.Visible = false;
        //        designersP4.Visible = false;
        //        codersP5.Visible = false;
        //        aboutUsP3.Visible = false;

        //        // January
        //        janMonth.Visible = true; // Jan
        //        StreamReader janMonthStreamReader = new StreamReader("C:\\NewCases_Deaths_January_Month.txt");
        //        string janMonthCasesString = janMonthStreamReader.ReadLine();
        //        string[] janMonthCases = janMonthCasesString.Split('\t');
        //        while (janMonthStreamReader.Peek() != -1)
        //        {
        //            chart1.Series["New Cases"].Points.AddXY(janMonthCases[0], janMonthCases[1]);
        //            chart2.Series["New Deaths"].Points.AddXY(janMonthCases[0], janMonthCases[2]);
        //        }
        //        janMonthStreamReader.Close();
        //    }
        //}

        //private void label37_Click(object sender, EventArgs e)
        //{

        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    // Main Lobbies
        //    covidCountP6.Visible = true; //ComboBox Selection
        //    codersP5.Visible = false;
        //    designersP4.Visible = false;
        //    aboutUsP3.Visible = false;
        //    whatToDoP2.Visible = false;
        //    virusInfoP1.Visible = false;

        //    // January
        //    janMonth.Visible = false; // Jan

        //    // February

        //    // March

        //    // April

        //    //May
        //}

        //private void label28_Click(object sender, EventArgs e)
        //{

        //}

        //private void designersP4_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void janMonth_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
    }
