using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs82B
{
    public partial class Form1 : Form
    {
        private List<Point> ls;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Drawing Ellipse";
            ls = new List<Point>();

            this.MouseDown += new MouseEventHandler(FormMouseDown);
            this.Paint += new PaintEventHandler(FormPaint);
        }

        public void FormMouseDown(Object sender, MouseEventArgs e)
        {
            Point p = new Point();
            p.X = e.X;
            p.Y = e.Y;
            ls.Add(p);
            this.Invalidate();
        }

        public void FormPaint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen dp = new Pen(Color.Black, 1);

            foreach (Point p in ls)
            {
                g.DrawEllipse(dp, p.X, p.Y, 10, 10);
            }
        }
    }
}