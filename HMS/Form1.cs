using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
      
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_doctors add = new add_doctors();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_patient patient = new add_patient();
            patient.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctor_list list = new doctor_list();
            list.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patient_list twolist = new patient_list();
            twolist.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ایا به خروج از برنامه اطمینان دارید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes) this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("  06633219605  در صورت بروز هر گونه مشکل یا سوال از برنامه با تماس حاصل فرمایید","گزارش",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            help komak = new help();
            komak.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aboutus us = new aboutus();
            us.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
         
        }
    }
}
