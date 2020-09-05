using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayCast
{
    class meshScq {
        int x, y, w, h;
        public bool testColission(int X,int Y){
            if (x < X && y < Y && X < x + w && Y < y + h) {
                return true;
            }
            return false;
        }
        public meshScq(int x,int y, int W, int H) {
            X = x;
            Y = y;
            W = w;
            H = h;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int W { get => w; set => w = value; }
        public int H { get => h; set => h = value; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < Pixels.GetLength(0); i++)
            {
                for (int j = 0; j < Pixels.GetLength(1); j++)
                {
                    Pixels[i, j] = Color.White;
                }
            }
            for (int i = 0; i < Pixels.GetLength(0); i++)
            {
                for (int j = 0; j < Pixels.GetLength(1); j++)
                {
                    Pixels[i, j] = Color.White;
                }
            }
            update();
        }
        Color[,] Pixels = new Color[460, 460];
        public void update() {
            Bitmap bitmap = new Bitmap(460, 460);
            Graphics graph = Graphics.FromImage(bitmap);
            for (int i = 0; i < Pixels.GetLength(0); i++)
            {
                for (int j = 0; j < Pixels.GetLength(1); j++)
                {
                    Pen pen = new Pen(Pixels[i, j]);
                    graph.DrawLine(pen, i,j,i+1,j+1);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            update();
        }
    }
}
