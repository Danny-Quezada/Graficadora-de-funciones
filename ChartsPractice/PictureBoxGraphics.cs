using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartsPractice
{
	public partial class PictureBoxGraphics : Form
	{
		public PictureBoxGraphics()
		{
			InitializeComponent();
		}

		private void PictureBoxGraphics_Load(object sender, EventArgs e)
		{
			
		}
		private float x1,y1,x2,y2,delta=0.1f;
		private void button1_Click(object sender, EventArgs e)
		{
			Graphics a = pictureBox1.CreateGraphics();
			
			float xm, ym;
			xm = pictureBox1.Width / 2;
			ym = pictureBox1.Height / 2;
			a.TranslateTransform(xm, ym);
		
			//dibujando eje x
			a.DrawLine(Pens.Black, -xm, 0, xm, 0);
			//dibujando eje y
			a.DrawLine(Pens.Black, 0, -ym, 0, ym);
			float x1 = -xm;
			while (x1<xm)
			{
				y1 = fx(x1);
				x2 = x1 + delta;
				y2 = fx(x2);
				a.DrawLine(Pens.Black, x1, y1, x2, y2);
				x1 = x2;
			}
			
		}
		private float fx(float x)
		{
			//x^2+3x+3
			float y = x * x + (3 * x) + 3;

			return y;
		}
	}
}
