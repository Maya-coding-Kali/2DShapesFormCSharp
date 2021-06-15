using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _2DShapes.Shapes[] ShapeArray = new _2DShapes.Shapes[5];

            _2DShapes.Square SquareObj = new _2DShapes.Square(5);
            //SquareObj.SetSide(5);
            _2DShapes.Triangle TriangleObj = new _2DShapes.Triangle();
            TriangleObj.SetBase(10);
            TriangleObj.SetHeight(12);
            TriangleObj.SetA(10);
            TriangleObj.SetB(12);
            TriangleObj.SetC(12);
            _2DShapes.Circle CircleObj = new _2DShapes.Circle();
            CircleObj.Setr(10);
            _2DShapes.Parallelogram ParallelogramObj = new _2DShapes.Parallelogram();
            ParallelogramObj.Seta(10);
            ParallelogramObj.Setb(5);
            ParallelogramObj.Seth(10);


            _2DShapes.Rectangle RectangleObj = new _2DShapes.Rectangle();
            ShapeArray[0] = SquareObj;
            ShapeArray[1] = TriangleObj;
            ShapeArray[2] = CircleObj;
            ShapeArray[3] = ParallelogramObj;
            ShapeArray[4] = RectangleObj;
            
            for (int i = 0; i < 5; i++)
            {
                richTextBox1.Text = richTextBox1.Text + "The Name is ";
                richTextBox1.Text = richTextBox1.Text + ShapeArray[i].Name() + "\n";
                richTextBox1.Text = richTextBox1.Text + "The Area is ";
                richTextBox1.Text = richTextBox1.Text + ShapeArray[i].Area() + "\n";
                richTextBox1.Text = richTextBox1.Text + "The Perimeter is ";
                richTextBox1.Text = richTextBox1.Text + ShapeArray[i].Perimeter() + "\n\n\n";

               
            }
        }
    }
}

