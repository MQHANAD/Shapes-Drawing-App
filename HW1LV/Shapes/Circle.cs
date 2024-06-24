using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HW1LV.Shapes
{
    internal class Circle : Shape
    {
        private static int count = 0; // number of circles  
        private int shapeNum; //circle number with respect to other circles 
        private int index; // index of the circle in the shape collection  
        private int x;
        private int y;
        private int size; //size of the circle 
        private RectangleF cir; //circle object for drowing
        private bool Selected;


        public Circle() 
        {
            count++;
            shapeNum=count; 
            this.x = new Random().Next(0, 700);
            this.y = new Random().Next(0, 500);
            this.size = new Random().Next(10,80);
            cir = new RectangleF(x, y, size, size);
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
            return "Circle ";
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
            g.DrawEllipse(BlackPen, cir);

        }

        

        public override void selected(Point point, Graphics g,ListBox listbox) //to check if the circle was selected from the panel 
        {
            if (cir.Contains(point) & !Selected)
            {
                Pen RedPen = new Pen(Color.Red);
                highlight(RedPen,g);
                listbox.SetSelected(index,true);
                Selected = true;
            }
        }
        public override void selected(Graphics g, ListBox listbox) // to check if the circle was selected from the listBox
        {
            if (!Selected)
            {
                Pen RedPen = new Pen(Color.Red);
                highlight(RedPen, g);
                Selected = true;
            }
            else if ( Selected)
            {
                Pen BlackPen = new Pen(Color.Black);
                highlight(BlackPen, g);
                Selected = false;
            }
        }

        internal override void highlight(Pen Pen, Graphics g) // to highlight 
        {
            g.DrawEllipse(Pen, cir);
        }
    }
}
