using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osuSTDEVpp
{
    public partial class osuSTDEVpp : Form
    {
        public osuSTDEVpp()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int pp1, pp2, pp3, pp4, totalpp;
            double mean, xi1, xi2, xi3, xi4, square, stdev, stdevpp;

            try
            {   
                pp1 = int.Parse(edt1.Text);
                pp2 = int.Parse(edt2.Text);
                pp3 = int.Parse(edt3.Text);
                pp4 = int.Parse(edt4.Text);

                totalpp = pp1 + pp2 + pp3 + pp4;

                mean = (pp1 + pp2 + pp3 + pp4) / 4;
                xi1 = pp1 - mean;
                xi2 = pp2 - mean;
                xi3 = pp3 - mean;
                xi4 = pp4 - mean;
                square = xi1 * xi1 + xi2 * xi2 + xi3 * xi3 + xi4 * xi4;
                stdev = Math.Sqrt(square / 3);
                stdevpp = totalpp - stdev * 2;

                memo.Clear();
                memo.AppendText("Total pp:\n" + totalpp.ToString("0pp\n\n"));
                memo.AppendText("STDEVpp:\n" + stdevpp.ToString("0pp"));
                memo.SelectAll();
                memo.SelectionAlignment = HorizontalAlignment.Center;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("You must enter valid numbers. Example: 14873");
                edt1.Clear();
                edt2.Clear();
                edt3.Clear();
                edt4.Clear();
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Sure, big numbers are very funny...Are you done messing around yet?");
                edt1.Clear();
                edt2.Clear();
                edt3.Clear();
                edt4.Clear();
            }
        }
        private void whatsStandardDeviatedPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Standard Deviated PP are a method of ranking players that play all 4 gamemodes of osu!\n\n" +
                            "The formula is: \"Totalpp - stdev.s*2\"\n\n" +
                            "If you want to know more about what standard deviation is, I suggest googling it(khanacademy.org has a very easy to understand explaination if you can find it)");
        }
        //Code in region allows pressing enter on Textboxes
        #region
        private void edt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCalculate.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void edt2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCalculate.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void edt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCalculate.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void edt4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCalculate.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        #endregion
    }
}
