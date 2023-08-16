using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int counter = 0;

        
        public Form1()
        {
            InitializeComponent();
            Lblname3.Text = counter.ToString();

        }


        private void btnName1_Click(object sender, EventArgs e)
        {
            Lblname2.Text = "Nastya♥";

        }

        private void btnName2_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            Lblname3.Text = counter.ToString();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Lblname1.Text = "Hello world♥";
        }
    }
}
