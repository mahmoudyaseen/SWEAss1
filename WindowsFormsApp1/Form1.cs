using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            firstCustomerControl1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            secondCustomerControl1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            firstCustomerControl1.BringToFront();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
