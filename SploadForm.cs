﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentmgt
{
    public partial class SploadForm : Form
    {
        public SploadForm()
        {
            InitializeComponent();
        }

        private void SploadForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressIndicator1.Start();
            if(startpoint > 40)
            {
                LogoForm login = new LogoForm();
                ProgressIndicator1.Stop();
                timer1.Stop();
                this.Hide();
                login.Show();
            }
        }
    }
}
