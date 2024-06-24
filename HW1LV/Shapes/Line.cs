using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW1LV.Shapes
{
    internal class Line : Shape


    {
        private static int count = 0;
        private int shapeNum;
        private int x;
        private int y;
        private bool Selected;
        private int index;
        private int size;

        private Point p1;
        private Point p2;

        public Line()
        {
            count++;
            shapeNum=count;
            this.x = new Random().Next(0, 700);
            this.y = new Random().Next(0, 500);
            
            p1 = new Point(x, y);
            p2 = new Point(new Random().Next(0, 700), new Random().Next(0, 500));

            size = Math.Abs(p2.X - p1.X + p2.Y - p1.Y);

            Selected = false;
            index = ShapeCollection.getSize();
        }
        public static int getCount()
        {
            return count;
        }

        public override int GetCount()
        {
            return shapeNum;
        }

        public override int getSize()
        {
            return size;
        }

        public override string getType1()
        {
            return "Line ";
        }

        public override int getX()
        {
            return x;
        }

        public override int getY()
        {
            return y;
        }

        public override void drow(Graphics g)
        {

            Pen blackPen = new Pen(Color.Black);
            g.DrawLine(blackPen, p1, p2);

        }

        public override void selected(Point point, Graphics g, ListBox listbox)
        {
            float delta = Math.Abs((p2.Y-p1.Y) * point.X - (p2.X-p1.X) * point.Y + p2.X * p1.Y - p2.Y * p1.X) /
                          (float)Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));

            // Define a threshold for distance
            float threshold = 5f;

            // Check if the distance is within the threshold
            if (delta < threshold & !Selected)
            {
                Pen Redpen = new Pen(Color.Red);
                highlight(Redpen,g);
                listbox.SetSelected(index, true);
                Selected = true;
            }
            
        }

        
        public override void selected(Graphics g, ListBox listbox)
        {
            if (!Selected)
            {
                Pen Redpen = new Pen(Color.Red);
                highlight(Redpen, g);
                Selected = true;
            }
            else if (Selected)
            {
                Pen blackPen = new Pen(Color.Black);
                highlight(blackPen, g);
                Selected = false;
            }
        }

        internal override void highlight(Pen Pen, Graphics g)
        {
             g.DrawLine(Pen, p1, p2);
        }
    }
}
