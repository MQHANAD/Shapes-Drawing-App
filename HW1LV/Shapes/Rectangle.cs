using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1LV.Shapes
{
    internal class Rectangle : Shape
    {
        private static int count = 0;
        private int shapeNum;
        private int x;
        private int y;
        private int size;
        private RectangleF rec;
        private bool Selected;
        private int index;
        public Rectangle()
        {
            count++;
            shapeNum = count;
            this.x =new Random().Next(0, 700);
            this.y =new Random().Next(0, 500);
            this.size = new Random().Next(10, 80);
            rec = new RectangleF(x, y, size * 2, size);
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
            return "Rectangle ";
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

            Pen BlackPen = new Pen(Color.Black);
            g.DrawRectangle(BlackPen, rec);

        }

        public override void selected(Point point, Graphics g, ListBox listbox) 
        {
            if (rec.Contains(point) & ! Selected) 
            {
                Pen RedPen = new Pen(Color.Red);
                highlight(RedPen, g);
                listbox.SetSelected(index, true);
                Selected = true;
            }
            
        }

        

        public override void selected(Graphics g, ListBox listbox)
        {
            if ( !Selected)
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
            };
        }

        internal override void highlight(Pen Pen, Graphics g)
        {
            g.DrawRectangle(Pen, rec);
        }
    }
}
