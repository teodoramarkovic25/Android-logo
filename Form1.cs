using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DusDus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics O = e.Graphics;
            Pen DusDus = new Pen(Brushes.Lime);
            DusDus.Width = 5.00f;

            Pen Skif = new Pen(Brushes.White);
            Skif.Width = 5.00f;

            Pen Dzoni = new Pen(Brushes.Lime);
            Dzoni.Width = 10.00f;

            O.DrawRectangle(DusDus, 150, 150, 180, 150);
            O.DrawRectangle(DusDus, 170, 300, 140, 15);

            O.FillRectangle(Brushes.Lime, 150, 150, 180, 150);
            O.FillRectangle(Brushes.Lime, 170, 300, 140, 15);

            O.DrawPie(DusDus, 150, 285, 30, 30, 60, 120);
            O.DrawPie(DusDus, 300, 285, 30, 30, 0, 120);

            O.FillPie(Brushes.Lime, 150, 285, 30, 30, 60, 120);
            O.FillPie(Brushes.Lime, 300, 285, 30, 30, 0, 120);

            O.DrawRectangle(DusDus, 170, 300, 40, 80);
            O.DrawRectangle(DusDus, 270, 300, 40, 80);
            O.FillRectangle(Brushes.Lime, 170, 300, 40, 80);
            O.FillRectangle(Brushes.Lime, 270, 300, 40, 80);

            O.DrawPie(DusDus, 170, 360, 40, 40, 0, 180);
            O.DrawPie(DusDus, 270, 360, 40, 40, 0, 180);
            O.FillPie(Brushes.Lime, 170, 360, 40, 40, 0, 180);
            O.FillPie(Brushes.Lime, 270, 360, 40, 40, 0, 180);

            O.DrawRectangle(DusDus, 90, 180, 40, 100);
            O.DrawRectangle(DusDus, 350, 180, 40, 100);
            O.DrawPie(DusDus, 90, 260, 40, 40, 0, 180);
            O.DrawPie(DusDus, 350, 260, 40, 40, 0, 180);
            O.DrawPie(DusDus, 90, 160, 40, 40, 180, 180);
            O.DrawPie(DusDus, 350, 160, 40, 40, 180, 180);

            O.FillRectangle(Brushes.Lime, 90, 180, 40, 100);
            O.FillRectangle(Brushes.Lime, 350, 180, 40, 100);
            O.FillPie(Brushes.Lime, 90, 260, 40, 40, 0, 180);
            O.FillPie(Brushes.Lime, 350, 260, 40, 40, 0, 180);
            O.FillPie(Brushes.Lime, 90, 160, 40, 40, 180, 180);
            O.FillPie(Brushes.Lime, 350, 160, 40, 40, 180, 180);

            O.DrawPie(DusDus, 150, 70, 180, 130, 180, 180);
            O.FillPie(Brushes.Lime, 150, 70, 180, 130, 180, 180);

            O.DrawEllipse(Skif, 190, 100, 15, 15);
            O.DrawEllipse(Skif, 273, 100, 15, 15);
            O.FillEllipse(Brushes.White, 190, 100, 15, 15);
            O.FillEllipse(Brushes.White, 273, 100, 15, 15);

            O.DrawLine(Dzoni, 180, 40, 200, 80);
            O.DrawLine(Dzoni, 290, 40, 270, 80);
        }
    }
}
