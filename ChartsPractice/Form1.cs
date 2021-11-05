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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double x=0; //Valor de x
			double y = 0; // Valor de y
			

			//En este for gráfico la ecuación.
			for (double i=-10; i<10; i+=0.1)
			{
				
			
				x = i;
				
				y=Math.Pow(x,2); // Esto es y=x^2
				chart1.Series["Series1"].Color = Color.Black;
				chart1.Series["Series1"].Points.AddXY(x,y);
			

			}

			//En este gráfico el eje de coordena.
			for(double i=-200.001; i<200.0001; i++)
			{
				
				chart1.Series["Series2"].Color = Color.Blue; // Le doy color al eje
				chart1.Series["Series3"].Color = Color.Blue; // Le doy color al eje
				chart1.Series["Series2"].Points.AddXY(0,i); // Eje Y (i va a ir variando (0,1),(0,2) )
				chart1.Series["Series3"].Points.AddXY(i, 0); // Eje X (i va a ir variando (1,0), (2,0) )
			}

			
			double xA = 0; //Variable ocupada para graficar el area sombreada
			double yA = 0; //Variable ocupada para graficar el area sombreada


			//En este for se grafica el area sombreada
			for(double i=0.0; i<4.8; i+=0.1) // la variable i son los limites. donde empieza y donde termina
			{
				 xA= i; 
				yA = xA*xA; //Esta misma ecuación es la primera que esta en el for de graficar la ecuación lo que quiere decir que cada vez que querramos el area sombreada tendremos que cambiar aquí también

				chart1.Series["Series4"].Points.AddXY(xA, yA);  //Aqui se grafica el area sombreada.

			}
			
		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

			chart1.Series["Series4"].Color = Color.Gray; // Este es el color del área sombreada
			chart1.ChartAreas["ChartArea1"].AxisX.Minimum = -10.0; // Estos son los valores del eje x en los negativos
			chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.5; // Este es el intervalo con lo que van a ir saliendo, ejemplo: -10.5, -11, -11.5
			chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 10.0; // Este es el valor máximo del eje x positivo.
			
			
			chart1.ChartAreas["ChartArea1"].AxisY.Interval = 0.5; // Intervalo en el eje Y
			chart1.ChartAreas["ChartArea1"].AxisY.Minimum = -10.0; // Valores del eje Y en los negativos. 
			chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 10.0; // Valores del eje Y en los positivos.
		}
	}
}
