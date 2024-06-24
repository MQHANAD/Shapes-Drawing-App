using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms.VisualStyles;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HW1LV.Shapes
{
    internal class Triangle : Shape

    {
        private static int count = 0;
        private int shapeNum;
        private int x;
        private int y;
        private int size;
        private Point p1;
        private Point p2;
        private Point p3;
        private Point[] points= new Point[4];
        private bool Selected;
        private int index;

        public Triangle() 
        {
            count++;
            shapeNum = count;
            this.x = new Random().Next(0, 700);
            this.y = new Random().Next(0, 500);
            this.size = new Random().Next(10, 80);
            p1 = new Point(x, y);
            p2 = new Point(x+2*size, y);
            p3 = new Point(x+size, y-size);
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p1;

            Selected = false;
            index = ShapeCollection.getSize();
        }
        public Point[] GetPoints()
        {
            return points;
        }
        public override int getX()
        {
            return x;
        }
        public override int getY()
        {
            return y;
        }
        public override int getSize()
        {
            return size;
        }
        public static int getCount()
        {
            return count;
        }

        public override int GetCount()
        {
            return shapeNum;
        }

        public override string getType1()
        {
            return "Triangle ";
        }

        public override void drow(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black);
            g.DrawLines(blackPen, points);
        }

        public override void selected(Point point, Graphics g, ListBox listbox)
        {
            if (IsPointInTriangle(point, points) & !Selected)
            {
                Pen RedPen = new Pen(Color.Red);
                highlight(RedPen,g);
                listbox.SetSelected(index, true);
                Selected = true;
            }
            


        }
        private bool IsPointInTriangle(Point p, Point[] triangle)
        {
            double x = p.X;
            double y = p.Y;

            double x1 = triangle[0].X;
            double y1 = triangle[0].Y;
            double x2 = triangle[1].X;
            double y2 = triangle[1].Y;
            double x3 = triangle[2].X;
            double y3 = triangle[2].Y;

            double denominator = ((y2 - y3) * (x1 - x3) + (x3 - x2) * (y1 - y3));
            double a = ((y2 - y3) * (x - x3) + (x3 - x2) * (y - y3)) / denominator;
            double b = ((y3 - y1) * (x - x3) + (x1 - x3) * (y - y3)) / denominator;
            double c = 1 - a - b;

            return a >= 0 && a <= 1 && b >= 0 && b <= 1 && c >= 0 && c <= 1;
        }

        

        public override void selected(Graphics g, ListBox listbox)
        {
            if (!Selected)
            {
                Pen RedPen = new Pen(Color.Red);
                highlight(RedPen, g);
                Selected = true;
            }
            else if (Selected)
            {
                Pen BlackPen = new Pen(Color.Black);
                highlight(BlackPen, g);
                Selected = false;
            }
        }

        internal override void highlight(Pen Pen, Graphics g)
        {
            g.DrawLines(Pen, points);
        }
    }
}
