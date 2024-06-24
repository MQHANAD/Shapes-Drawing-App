using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1LV.Shapes
{
    internal abstract class Shape
    {
        private static int index = 0; //index of the shape in the shape list
        
        public abstract void drow(Graphics g);
        public abstract int GetCount();
        public abstract int getX();

        public abstract int getY();

        public abstract int getSize();

        public abstract String getType1();
       
        public abstract void selected(Point point, Graphics g, ListBox listbox);
        public abstract void selected( Graphics g, ListBox listbox);
        internal abstract void highlight(Pen Pen, Graphics g);
    }
}
