using HW1LV.Shapes;
using System.Xml.Serialization;
using System.Xml;
using System.Windows.Forms;

namespace HW1LV
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private int prevIndex = -1;

        public Form1()
        {
            InitializeComponent();
            g = DrawingArea.CreateGraphics();
        }


        private void InfoModeButton_Click(object sender, EventArgs e)
        {
            var myform = new Form2(this);
            myform.Show();
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            Triangle tri = new Triangle();
            ShapeCollection.GetShapeList().Add(tri);
            tri.drow(g);
            this.refresh();

        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Line line = new Line();
            ShapeCollection.GetShapeList().Add(line);
            line.drow(g);
            this.refresh();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            ShapeCollection.GetShapeList().Add(circle);
            circle.drow(g);
            this.refresh();

        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Shapes.Rectangle rectangle = new Shapes.Rectangle();
            ShapeCollection.GetShapeList().Add(rectangle);
            rectangle.drow(g);
            this.refresh();


        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            ShapeCollection.GetShapeList().Add(square);
            square.drow(g);
            this.refresh();
        }

        private void DrawingArea_Click(object sender, EventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.selected(DrawingArea.PointToClient(Cursor.Position), g, listBox1);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prevIndex != -1)
            {
                shapes[prevIndex].selected(g, listBox1);
            }
            shapes[listBox1.SelectedIndex].selected(g, listBox1);
            prevIndex = listBox1.SelectedIndex;
        }

    }
}
