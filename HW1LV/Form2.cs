using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using HW1LV.Shapes;

namespace HW1LV

{
    public partial class Form2 : Form
    {
        private Form1 form;
        private List<Shape> shapes = ShapeCollection.GetShapeList();


        public Form2(Form1 form1)
        {
            this.form = form1;
            InitializeComponent();
            foreach (Shape shape in shapes)
            {
                textBox1.Text += shape.getType1() + shape.GetCount() + " (X= " + shape.getX() + ", Y= " + shape.getY() + ", size= " + shape.getSize() + ")" + Environment.NewLine;
            }
        }
        private void DrawModeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
            this.Close();
        }
    }
}
