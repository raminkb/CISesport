﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISesport
{
    public partial class FormTeamInfo : Form
    {
        public FormTeamInfo()
        {
            InitializeComponent();
        }

        private void buttonFindmembers_Click(object sender, EventArgs e)
        {
           /* ApplicationForm applicationForm = new ApplicationForm();
            applicationForm.MdiParent= this;
            applicationForm.ShowDialog();*/

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationForm applicationForm = new ApplicationForm();
            
            applicationForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationForm applicationForm = new ApplicationForm();

            applicationForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplicationForm applicationForm = new ApplicationForm();

            applicationForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApplicationForm applicationForm = new ApplicationForm();

            applicationForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ApplicationForm applicationForm = new ApplicationForm();

            applicationForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                // do something with the selected file
            }
        }
    }
}
