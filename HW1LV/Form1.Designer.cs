using HW1LV.Shapes;

namespace HW1LV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DrawingArea = new Panel();
            shapesColection = new Panel();
            SquareButton = new Button();
            RectangleButton = new Button();
            CircleButton = new Button();
            TriangleButton = new Button();
            LineButton = new Button();
            label1 = new Label();
            DrawModeButton = new Button();
            InfoModeButton = new Button();
            listBox1 = new ListBox();
            shapesColection.SuspendLayout();
            SuspendLayout();
            // 
            // DrawingArea
            // 
            DrawingArea.Anchor = AnchorStyles.None;
            DrawingArea.BackColor = SystemColors.Window;
            DrawingArea.Location = new Point(271, 81);
            DrawingArea.Name = "DrawingArea";
            DrawingArea.Size = new Size(788, 587);
            DrawingArea.TabIndex = 0;
            DrawingArea.Click += DrawingArea_Click;

            // 
            // shapesColection
            // 
            shapesColection.Anchor = AnchorStyles.None;
            shapesColection.BackColor = SystemColors.Window;
            shapesColection.Controls.Add(SquareButton);
            shapesColection.Controls.Add(RectangleButton);
            shapesColection.Controls.Add(CircleButton);
            shapesColection.Controls.Add(TriangleButton);
            shapesColection.Controls.Add(LineButton);
            shapesColection.Location = new Point(51, 81);
            shapesColection.Name = "shapesColection";
            shapesColection.Size = new Size(177, 587);
            shapesColection.TabIndex = 1;
            // 
            // SquareButton
            // 
            SquareButton.Anchor = AnchorStyles.None;
            SquareButton.Location = new Point(3, 163);
            SquareButton.Name = "SquareButton";
            SquareButton.Size = new Size(85, 74);
            SquareButton.TabIndex = 4;
            SquareButton.Text = "Square";
            SquareButton.UseVisualStyleBackColor = true;
            SquareButton.Click += SquareButton_Click;
            // 
            // RectangleButton
            // 
            RectangleButton.Anchor = AnchorStyles.None;
            RectangleButton.Location = new Point(89, 83);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(85, 74);
            RectangleButton.TabIndex = 3;
            RectangleButton.Text = "Rectangle";
            RectangleButton.UseVisualStyleBackColor = true;
            RectangleButton.Click += RectangleButton_Click;
            // 
            // CircleButton
            // 
            CircleButton.Anchor = AnchorStyles.None;
            CircleButton.Location = new Point(3, 83);
            CircleButton.Name = "CircleButton";
            CircleButton.Size = new Size(85, 74);
            CircleButton.TabIndex = 2;
            CircleButton.Text = "Circle";
            CircleButton.UseVisualStyleBackColor = true;
            CircleButton.Click += CircleButton_Click;
            // 
            // TriangleButton
            // 
            TriangleButton.Anchor = AnchorStyles.None;
            TriangleButton.Location = new Point(89, 3);
            TriangleButton.Name = "TriangleButton";
            TriangleButton.Size = new Size(85, 74);
            TriangleButton.TabIndex = 1;
            TriangleButton.Text = "Triangle";
            TriangleButton.UseVisualStyleBackColor = true;
            TriangleButton.Click += TriangleButton_Click;
            // 
            // LineButton
            // 
            LineButton.Anchor = AnchorStyles.None;
            LineButton.Location = new Point(3, 3);
            LineButton.Name = "LineButton";
            LineButton.Size = new Size(85, 74);
            LineButton.TabIndex = 0;
            LineButton.Text = "Line";
            LineButton.UseVisualStyleBackColor = true;
            LineButton.Click += LineButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(1141, 101);
            label1.Name = "label1";
            label1.Size = new Size(98, 35);
            label1.TabIndex = 0;
            label1.Text = "Shapes";
            // 
            // DrawModeButton
            // 
            DrawModeButton.Anchor = AnchorStyles.None;
            DrawModeButton.Location = new Point(51, 21);
            DrawModeButton.Name = "DrawModeButton";
            DrawModeButton.Size = new Size(135, 41);
            DrawModeButton.TabIndex = 3;
            DrawModeButton.Text = "Draw Mode";
            DrawModeButton.UseVisualStyleBackColor = true;
            // 
            // InfoModeButton
            // 
            InfoModeButton.Anchor = AnchorStyles.None;
            InfoModeButton.Location = new Point(192, 21);
            InfoModeButton.Name = "InfoModeButton";
            InfoModeButton.Size = new Size(135, 41);
            InfoModeButton.TabIndex = 4;
            InfoModeButton.Text = "Info Mode";
            InfoModeButton.UseVisualStyleBackColor = true;
            InfoModeButton.Click += InfoModeButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(1109, 139);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(175, 524);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1355, 710);
            Controls.Add(listBox1);
            Controls.Add(InfoModeButton);
            Controls.Add(DrawModeButton);
            Controls.Add(label1);
            Controls.Add(shapesColection);
            Controls.Add(DrawingArea);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Draw App";
            shapesColection.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private List<Shape> shapes = ShapeCollection.GetShapeList();
        
        public void refresh()
        {
            listBox1.Items.Clear();
            foreach (Shape shape in shapes)
            {
                listBox1.Items.Add(shape.getType1() + shape.GetCount());
            }
        }

        #endregion
        private Panel shapesColection;
        private Label label1;
        private Button DrawModeButton;
        private Button InfoModeButton;
        private Button LineButton;
        private Button SquareButton;
        private Button RectangleButton;
        private Button CircleButton;
        private Button TriangleButton;
        private Panel DrawingArea;
        private ListBox listBox1;
    }
}
