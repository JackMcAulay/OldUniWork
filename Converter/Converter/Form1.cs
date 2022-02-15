using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertLbsKg_Click(object sender, EventArgs e)
        {
            double lbsValue = double.Parse(tbLbs.Text);
            double kgValue = lbsValue * 0.453592;
            tbKg.Text = kgValue.ToString("0.00");
        }

        private void btnConvertFtM_Click(object sender, EventArgs e)
        {
            double ftValue = double.Parse(tbFt.Text);
            double mValue = ftValue * 0.3048;
            tbM.Text = mValue.ToString("0.00");
        }

        private void btnConvertPtL_Click(object sender, EventArgs e)
        {
            double ptValue = double.Parse(tbPt.Text);
            double lValue = ptValue * 0.568261;
            tbL.Text = lValue.ToString("0.00");
        }
    }
}
