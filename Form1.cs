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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //txtFirst.Text = "ChangedText";
            string temp1 = txtFirst.Text;
            string temp2 = txtSecond.Text;
            string tempconcate = temp1 + " " +temp2;
            MessageBox.Show(tempconcate);

        }
    }
}
