using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NPlot;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double [] ys1 = new double[]{0, 1681, 1970, 933, 1030, 3381, 6155, 7485, 4912, 2853, 2591, 2086, 2281, 397, 27, 20, 12, 108, 337, 593, 31, 30, 30, 407, 1852, 715, 101, 181, 612, 878, 514, 393, 540, 542, 478, 1816, 3122, 2238, 2506, 3807, 5705, 6506, 5386, 3176, 1309, 1514, 1512, 322, 29, 30, 26, 31, 70, 251, 50, 68, 34, 204, 445, 1429, 310, 170, 920, 1453, 1784, 1430, 585, 528, 448, 1291, 4186, 5073, 4072, 3718, 3719, 5205, 5882, 3036, 298, 260, 613, 404, 45, 64, 34, 33, 25, 37, 30, 45, 31, 64, 290, 288, 1132, 652, 1360, 2612, 2865, 3126};
            double[] ys2 = new double[] { 0, 245, 79, 71, 54, 88, 107, 418, 1444, 367, 1290, 927, 1329, 962, 979, 1169, 1370, 883, 1060, 672, 167, 175, 231, 135, 56, 295, 188, 150, 176, 235, 227, 95, 37, 31, 102, 81, 205, 152, 76, 67, 78, 71, 821, 1302, 324, 932, 1555, 1287, 1415, 1373, 1136, 965, 535, 496, 524, 139, 95, 67, 54, 56, 277, 173, 146, 167, 124, 116, 123, 62, 30, 78, 82, 183, 203, 220, 77, 469, 487, 975, 1370, 1562, 1313, 1658, 1449, 1175, 1075, 734, 604, 318, 309, 153, 112, 86, 73, 62, 43, 249, 162, 133, 185, 138, };
            double [] xs = new double[ys1.Length];
            for(int i = 0; i < xs.Length; i++)
            {
                xs[i] = i;
            }

            LinePlot lp = new LinePlot( ys1, xs );
            lp.Pen = new Pen(Color.Blue);
            LinePlot lp2 = new LinePlot( ys2, xs );
            lp2.Pen = new Pen(Color.Red);

            this.plotSurface2D1.Add(lp);
            this.plotSurface2D1.Add(lp2);
        }
    }
}