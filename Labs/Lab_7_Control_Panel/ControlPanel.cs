﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPerson temp = new SearchPerson();
            temp.ShowDialog();
        }
    }
}
