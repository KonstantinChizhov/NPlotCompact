﻿using System;
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
            ushort[] ys1 = new ushort[] { 0, 31, 48, 45, 42, 40, 43, 50, 36, 52, 31, 43, 54, 98, 150, 168, 37, 24, 23, 45, 19, 112, 44, 49, 55, 52, 44, 38, 16, 35, 34, 36, 41, 43, 39, 47, 47, 39, 48, 44, 41, 45, 44, 49, 49, 51, 64, 41, 49, 94, 149, 252, 37, 37, 24, 41, 21, 187, 44, 59, 52, 56, 53, 51, 25, 37, 33, 47, 45, 49, 41, 64, 43, 48, 32, 54, 40, 45, 45, 63, 37, 42, 46, 64, 66, 112, 137, 114, 30, 24, 23, 33, 100, 252, 45, 55, 49, 54, 37, 27, 0, 39, 42, 54, 31, 90, 951, 1316, 1702, 2092, 354, 67, 43, 46, 43, 61, 45, 45, 42, 1978, 2559, 1516, 87, 77, 99, 143, 141, 103, 70, 973, 3605, 3132, 1275, 43, 48, 50, 41, 38, 45, 54, 653, 1131, 2479, 1791, 499, 94, 74, 43, 48, 38, 44, 36, 40, 601, 39, 26, 41, 34, 33, 66, 89, 208, 353, 270, 256, 25, 27, 46, 74, 47, 1620, 1055, 352, 156, 1155, 1009, 72, 69, 76, 43, 350, 1328, 2169, 1220, 39, 37, 48, 45, 48, 44, 46, 38, 45, 152, 94, 33, 173, 417, 1437, 1629, 0, 2162, 545, 41, 47, 74, 46, 48, 50, 62, 47, 26, 281, 5383, 6401, 3751, 1347, 246, 494, 47, 40, 34, 58, 41, 40, 31, 30, 59, 289, 948, 6850, 9269, 9516, 4576, 73, 113, 87, 140, 254, 58, 47, 8759, 17580, 14441, 7098, 946, 60, 26, 29, 27, 43, 42, 497, 15540, 18649, 17498, 14921, 11183, 5316, 45, 35, 29, 45, 30, 40, 48, 5966, 8135, 11836, 19808, 23439, 14853, 85, 144, 250, 55, 675, 827, 51, 47, 48, 47, 34, 27, 23, 25, 38, 15011, 23951, 20665, 13975, 8545, 6139, 1031, 27, 44, 21, 31, 28, 8254, 0, 12191, 11354, 11333, 4787, 67, 40, 26, 15, 17, 17501, 26507, 26587, 29186, 31856, 25380, 5137, 49, 54, 78, 70, 40, 44, 36, 15663, 30639, 38779, 38215, 27257, 9947, 25, 34, 34, 33, 32, 34, 44, 7652, 21039, 20980, 10572, 58, 73, 92, 85, 15, 21, 34, 30, 10604, 19543, 9712, 43, 48, 61, 65, 217, 459, 51, 2197, 15410, 20152, 6090, 49, 43, 50, 52, 39, 35, 41, 2342, 29692, 41287, 32959, 14446, 57, 44, 58, 88, 83, 80, 19, 19, 132, 19275, 27414, 27080, 24200, 23165, 20930, 11833, 70, 61, 66, 41, 45, 41, 74, 39, 18481, 0, 49405, 42033, 19701, 52, 44, 31, 24, 38, 110, 215, 46, 5855, 30781, 40964, 39394, 33416, 25807, 15313, 215, 77, 59, 40, 43, 28, 61, 64, 9017, 23048, 34453, 37799, 25799, 2865, 63, 41, 47, 40, 63, 28, 50, 838, 21286, 29928, 23564, 11482, 191, 244, 42, 51, 87, 103, 62, 57, 38, 7404, 11095, 13090, 14167, 16140, 14212, 6672, 31, 50, 73, 168, 364, 47, 42, 43, 13919, 28232, 32319, 24274, 8878, 44, 30, 40, 34, 30, 33, 45, 9891, 33253, 42922, 38582, 24088, 7343, 56, 34, 36, 31, 40, 39, 67, 10512, 29604, 38052, 36728, 28767, 16124 };
            ushort[] ys2 = new ushort[] { 0, 31, 48, 45, 42, 40, 43, 50, 36, 52, 31, 43, 54, 98, 150, 168, 37, 24, 23, 45, 19, 112, 44, 49, 55, 52, 44, 38, 16, 35, 34, 36, 41, 43, 39, 47, 47, 39, 48, 44, 41, 45, 44, 49, 49, 51, 64, 41, 49, 94, 149, 252, 37, 37, 24, 41, 21, 187, 44, 59, 52, 56, 53, 51, 25, 37, 33, 47, 45, 49, 41, 64, 43, 48, 32, 54, 40, 45, 45, 63, 37, 42, 46, 64, 66, 112, 137, 114, 30, 24, 23, 33, 100, 252, 45, 55, 49, 54, 37, 27, 0, 39, 42, 54, 31, 90, 951, 1316, 1702, 2092, 354, 67, 43, 46, 43, 61, 45, 45, 42, 1978, 2559, 1516, 87, 77, 99, 143, 141, 103, 70, 973, 3605, 3132, 1275, 43, 48, 50, 41, 38, 45, 54, 653, 1131, 2479, 1791, 499, 94, 74, 43, 48, 38, 44, 36, 40, 601, 39, 26, 41, 34, 33, 66, 89, 208, 353, 270, 256, 25, 27, 46, 74, 47, 1620, 1055, 352, 156, 1155, 1009, 72, 69, 76, 43, 350, 1328, 2169, 1220, 39, 37, 48, 45, 48, 44, 46, 38, 45, 152, 94, 33, 173, 417, 1437, 1629, 0, 2162, 545, 41, 47, 74, 46, 48, 50, 62, 47, 26, 281, 5383, 6401, 3751, 1347, 246, 494, 47, 40, 34, 58, 41, 40, 31, 30, 59, 289, 948, 6850, 9269, 9516, 4576, 73, 113, 87, 140, 254, 58, 47, 8759, 17580, 14441, 7098, 946, 60, 26, 29, 27, 43, 42, 497, 15540, 18649, 17498, 14921, 11183, 5316, 45, 35, 29, 45, 30, 40, 48, 5966, 8135, 11836, 19808, 23439, 14853, 85, 144, 250, 55, 675, 827, 51, 47, 48, 47, 34, 27, 23, 25, 38, 15011, 23951, 20665, 13975, 8545, 6139, 1031, 27, 44, 21, 31, 28, 8254, 0, 12191, 11354, 11333, 4787, 67, 40, 26, 15, 17, 17501, 26507, 26587, 29186, 31856, 25380, 5137, 49, 54, 78, 70, 40, 44, 36, 15663, 30639, 38779, 38215, 27257, 9947, 25, 34, 34, 33, 32, 34, 44, 7652, 21039, 20980, 10572, 58, 73, 92, 85, 15, 21, 34, 30, 10604, 19543, 9712, 43, 48, 61, 65, 217, 459, 51, 2197, 15410, 20152, 6090, 49, 43, 50, 52, 39, 35, 41, 2342, 29692, 41287, 32959, 14446, 57, 44, 58, 88, 83, 80, 19, 19, 132, 19275, 27414, 27080, 24200, 23165, 20930, 11833, 70, 61, 66, 41, 45, 41, 74, 39, 18481, 0, 49405, 42033, 19701, 52, 44, 31, 24, 38, 110, 215, 46, 5855, 30781, 40964, 39394, 33416, 25807, 15313, 215, 77, 59, 40, 43, 28, 61, 64, 9017, 23048, 34453, 37799, 25799, 2865, 63, 41, 47, 40, 63, 28, 50, 838, 21286, 29928, 23564, 11482, 191, 244, 42, 51, 87, 103, 62, 57, 38, 7404, 11095, 13090, 14167, 16140, 14212, 6672, 31, 50, 73, 168, 364, 47, 42, 43, 13919, 28232, 32319, 24274, 8878, 44, 30, 40, 34, 30, 33, 45, 9891, 33253, 42922, 38582, 24088, 7343, 56, 34, 36, 31, 40, 39, 67, 10512, 29604, 38052, 36728, 28767, 16124 };
            ushort[] xs = new ushort[ys1.Length];

            //for (int j = 0; j < 5; j++)
                for (int i = 1; i < ys1.Length - 1; i++)
                {
                    ys1[i] = (ushort)((ys1[i] * 4 + ys1[i - 1] * 2 + ys1[i + 1] * 2) / 8);
                }

            LinePlot lp = new LinePlot(ys1, new StartStep(0.0f, 1.0f));
            lp.Pen = new Pen(Color.Blue);
            LinePlot lp2 = new LinePlot(ys2, new StartStep(0.0f, 1.0f));
            lp2.Pen = new Pen(Color.Red);

            Grid myGrid = new Grid();
            myGrid.VerticalGridType = Grid.GridType.Fine;
            myGrid.HorizontalGridType = Grid.GridType.Fine;

            this.plotSurface2D1.Add(myGrid);

            this.plotSurface2D1.Add(lp);
            this.plotSurface2D1.Add(lp2);
        }

        private void plotSurface2D1_Resize(object sender, EventArgs e)
        {
            this.plotSurface2D1.Invalidate();
        }
    }
}