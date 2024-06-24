using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1LV.Shapes
{
    internal class ShapeCollection 
    {
        private static List<Shape> shapesList = new List<Shape>();
        

        private ShapeCollection() { }

        public static List<Shape> GetShapeList() { return shapesList; }
        public static int getSize() {  return shapesList.Count; }
    }
}
