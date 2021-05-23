
namespace Group5_PBL.Forms
{
    partial class AboutUsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aboutUsP3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.aboutUsP3.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutUsP3
            // 
            this.aboutUsP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(219)))));
            this.aboutUsP3.Controls.Add(this.label8);
            this.aboutUsP3.Controls.Add(this.label7);
            this.aboutUsP3.Controls.Add(this.button3);
            this.aboutUsP3.Controls.Add(this.button2);
            this.aboutUsP3.Controls.Add(this.label6);
            this.aboutUsP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUsP3.Location = new System.Drawing.Point(0, 0);
            this.aboutUsP3.Name = "aboutUsP3";
            this.aboutUsP3.Size = new System.Drawing.Size(684, 475);
            this.aboutUsP3.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(42, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(517, 120);
            this.label8.TabIndex = 4;
            this.label8.Text = "McTech is a company made by the students of \r\niACADEMY, in completion for their P" +
    "BL Output\r\n it composes of two groups the Designers and\r\nthe Coders, click the b" +
    "uttons to learn more about\r\nthem.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(39, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 41);
            this.label7.TabIndex = 3;
            this.label7.Text = "McTech";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(294, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Designers";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.DesignerInfo);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(486, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Coders ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CodersInfo);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(340, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Meet The Developers!";
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 475);
            this.Controls.Add(this.aboutUsP3);
            this.Name = "AboutUsForm";
            this.Text = "AboutUsForm";
            this.aboutUsP3.ResumeLayout(false);
            this.aboutUsP3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aboutUsP3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}