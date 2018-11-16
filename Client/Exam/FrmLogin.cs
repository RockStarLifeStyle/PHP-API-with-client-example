using Exam.Core;
using Exam.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tbUname.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Require login and password fields!");
                return;
            }
            if (cbReg.Checked)
            {
                if (tbEmail.Text == "")
                {
                    MessageBox.Show("Require email field!");
                    return;
                }
                if (Network.Register(tbUname.Text, tbPass.Text, tbEmail.Text))
                {
                    FrmMain main = new FrmMain(tbUname.Text);
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                if (Network.Login(tbUname.Text, tbPass.Text))
                {
                    FrmMain main = new FrmMain(tbUname.Text);
                    main.Show();
                    this.Hide();
                }
            }
        }

        private void cbReg_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReg.Checked)
            {
                bLogin.Text = "Register";
                tbEmail.ReadOnly = false;
            }
            else 
            {
                bLogin.Text = "Login";
                tbEmail.ReadOnly = true;
            }
        }
    }
}
