using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drowing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pen my_pen = new Pen(Color.Blue, 2);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics my_graphic = Graphics.FromImage(pictureBox1.Image);
            my_graphic.DrawRectangle(my_pen, 10, 10, 40, 100);
            my_graphic.Clear(Color.Pink);
            my_pen.Color = Color.Black;
            my_pen.Width = 5;
            my_graphic.DrawRectangle(my_pen, 20, 20, 180, 100);
            SolidBrush my_brush = new SolidBrush(Color.DarkCyan);
            my_graphic.FillRectangle(my_brush, 30, 30, 160, 80);
            my_brush.Color = Color.Black;
            my_graphic.FillEllipse(my_brush, 50, 50, 120, 40);
            my_pen.Color = Color.DarkViolet;
            my_graphic.DrawLine(my_pen, 410, 10, 40, 307);
            my_graphic.DrawArc(my_pen, 10, 20, 200, 250, 40, 150);
            Font my_font = new Font("Arial", 22, FontStyle.Bold);
            my_graphic.DrawString("Hello World", my_font, my_brush, 10, 300);
        }
    }
}
