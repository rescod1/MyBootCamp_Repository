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
    public partial class Menu : Form
    {
        const string OurPassword = "pop";
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        enterPasword:
            string Password = password.Show();
            if(Password == "")
            {
                this.Close();
            }
            if(Password != OurPassword && Password != "")
            {
                MessageBox.Show("Попробуйте еще раз!", "Пароль неверный!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto enterPasword;

            }
        }

        private void lblLinkCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Calculator();
            frm.Show();
        }
    }
}
