using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4_1
{
    public partial class Form1 : Form
    {
        StatisticalData data = new StatisticalData();
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdLargest_Click(object sender, EventArgs e)
        {
            data.Num1 = int.Parse(TxtNum1.Text);
            data.Num2 = int.Parse(TxtNum2.Text);
            data.Num3 = int.Parse(TxtNum3.Text);

            data.FindLargest();

            MessageBox.Show("The Largest Number is " + data.Largest);
        }

        private void CmdSmallest_Click(object sender, EventArgs e)
        {
            data.Num1 = int.Parse(TxtNum1.Text);
            data.Num2 = int.Parse(TxtNum2.Text);
            data.Num3 = int.Parse(TxtNum3.Text);

            data.FindSmallest();

            MessageBox.Show("The Smallest Number is " + data.Smallest);
        }

        private void CmdAverage_Click(object sender, EventArgs e)
        {
            data.Num1 = int.Parse(TxtNum1.Text);
            data.Num2 = int.Parse(TxtNum2.Text);
            data.Num3 = int.Parse(TxtNum3.Text);

            data.CalculateAverage();

            MessageBox.Show("The Average is " + data.Average);
        }
    }
}
