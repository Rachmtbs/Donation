using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShape_Click(object sender, EventArgs e)
        {
            if (Triangle.Checked)
            {
                // create triangle
                Triangle triangle = new Triangle();
                triangle.Weight = int.Parse(textBox2.Text);
                AddShapes(triangle);
            }
            else 
            {
                Quadrilateral quadrilateral = new Quadrilateral();
                quadrilateral.Weight = int.Parse(textBox2.Text);
                AddShapes(quadrilateral);
            }

            if (RightTriangle.Checked)
            {
                RightTriangle righttiangle = new RightTriangle();
                righttiangle.Weight = int.Parse(textBox2.Text);
                AddShapes(righttiangle);
            }
            else if (Rectangle.Checked)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Weight = int.Parse(textBox2.Text);
                AddShapes(rectangle);
            }
            else 
            {
                Square square = new Square();
                square.Weight = int.Parse(textBox2.Text);
                AddShapes(square);
            }
        }

        private void AddShapes(Shapes shapes)
        {
            listBox1.Items.Add(Shapes.ShowWeight + " " + shapes.GetType().ShowWeight);
            MessageBox.Show(shapes.ShowWeight());
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
