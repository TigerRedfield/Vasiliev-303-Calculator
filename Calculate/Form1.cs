using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int a, b, res = 0;

            a = Convert.ToInt32(FirstDigit.Text);
            b = Convert.ToInt32(SecondDigit.Text);

            switch((sender as Button).Text)
            {
                case "+": 
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break;
            }
            LabelRes.Text = "Ответ: " + res.ToString();
        }
    }
}
