using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		const double k = 0.05;
		Random rand = new Random();

		double r1, r2;

		private void btStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}

		private void btStart_Click(object sender, EventArgs e)
		{
			double rate = (double)edRate1.Value;

			r1 = rate;
			rate = (double)edRate2.Value;
			r2 = rate;
			chart1.Series[0].Points.Clear();
			chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.AddXY(0, r1);
            chart1.Series[1].Points.AddXY(0, r2);
            timer1.Start();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{

            r1 = r1 * (1 + k * (rand.NextDouble() - 0.5));
			r2 = r2 * (1 + k * (rand.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(0, r1);
			chart1.Series[1].Points.AddXY(0, r2);
        }
	}
}
