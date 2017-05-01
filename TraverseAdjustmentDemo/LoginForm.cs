using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraverseAdjustmentDemo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btu_Close_Click(object sender, EventArgs e)
        {
            MainForm mainForm=new MainForm();
            mainForm.Type = 2;
            mainForm.Text = "闭合导线计算";
            mainForm.Show();
        }

        private void Btu_NoClose_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Type = 1;
            mainForm.Text = "附和导线计算";
            mainForm.Show();
        }
    }
}
