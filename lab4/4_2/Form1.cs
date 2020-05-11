using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point line(Graphics g, Pen p, Point begin, int length, int V_H, int direction) {//1-V 0-H
            length *= 10;
            Point end;
            if (V_H == 1)//Vertical
                if (direction == 0)//вверх
                    end = new Point(begin.X, begin.Y - length);
                else end = new Point(begin.X, begin.Y + length);

            else //Horizontal
                if (direction == 0)
                    end = new Point(begin.X-length, begin.Y);
                else end = new Point(begin.X+length, begin.Y);
            g.DrawLine(p, begin, end);
            return end;
        }
        private Point rectangle(Graphics g, Pen p, Point begin, int V_H, int direction) {
            Point point1 =  new Point();
            Point point2 = new Point();
            Point point3 = new Point();
            Point point4 = new Point();
            Rectangle rect;
            if (V_H == 1)
            {
                if (direction == 0)
                {//down-up
                    rect = new Rectangle(begin.X - 10, begin.Y - 50, 20, 50);
                    point1 = new Point(begin.X - 5, begin.Y - 15);
                    point2 = new Point(begin.X + 5, begin.Y - 25);
                    point3 = new Point(begin.X - 5, begin.Y - 25);
                    point4 = new Point(begin.X + 5, begin.Y - 35);
                }
                else
                {
                    rect = new Rectangle(begin.X - 10, begin.Y, 20, 50);
                    point1 = new Point(begin.X + 5, begin.Y + 15);
                    point2 = new Point(begin.X - 5, begin.Y + 25);
                    point3 = new Point(begin.X + 5, begin.Y + 25);
                    point4 = new Point(begin.X + 5, begin.Y + 45);
                }
                
            }
            else
            {
                if (direction == 0)
                {//left-right
                    rect = new Rectangle(begin.X - 50, begin.Y - 10, 50, 20);
                    point1 = new Point(begin.X + 15, begin.Y - 5);
                    point2 = new Point(begin.X + 25, begin.Y + 5);
                    point3 = new Point(begin.X + 25, begin.Y - 5);
                    point4 = new Point(begin.X + 35, begin.Y + 5);
                }
                else
                {
                    rect = new Rectangle(begin.X, begin.Y - 10, 50, 20);
                    point1 = new Point(begin.X + 15, begin.Y - 5);
                    point2 = new Point(begin.X + 25, begin.Y + 5);
                    point3 = new Point(begin.X + 25, begin.Y - 5);
                    point4 = new Point(begin.X + 35, begin.Y + 5);
                }
            }
            g.DrawRectangle(p, rect);
            g.DrawLine(p, point1, point2);
            g.DrawLine(p, point3, point4);
            return begin;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            Font font = new Font("Arial", 12, FontStyle.Italic);
            int i = 550;
            Point point = new Point();
            Point old_point = new Point();
            Point temp_point = new Point();
            SolidBrush b = new SolidBrush(Color.Black);
            Point[] triangle = new Point[3];
            
            Pen p = new Pen(Brushes.Black, 2);
            //XS2
            Point point1 = new Point(20, 10+i);
            Point point2 = new Point(30, 20+i);
            g.DrawString("XS2", font, b, point1.X - 10, point1.Y - 20);
            g.DrawLine(p, point1, point2);

            point1.Y += 20;
            g.DrawLine(p, point1, point2);
            point = line(g, p, point2, 5, 0, 1);
            point.Y -= 20;

            //C5
            g.DrawString("C5", font, b, point.X-10, point.Y - 20);
            line(g, p, point, 4, 1, 1);
            point.X += 10;
            line(g, p, point, 4, 1, 1);
            //point on 3 and 7 cells
            point.Y += 20;
            old_point = point;
            g.FillEllipse(b, point.X +25, point.Y-5, 10, 10);
            g.FillEllipse(b, point.X +105, point.Y-5, 10, 10);
            point = line(g, p, point, 23, 0, 1);
            
            point.X += 10;////////plus
            line(g, p, point, 1, 0, 1);
            point.X += 5;
            point.Y -= 5;
            line(g, p, point, 1, 1, 1);
            point.X -= 15;
            point.Y += 5;
            //////////////
            g.DrawString("DA 1.2", font, b, point.X+3, point.Y - 43);
            /////////////
            triangle[0].X = point.X;
            triangle[0].Y = point.Y + 30;
            triangle[1].X = point.X;
            triangle[1].Y = point.Y - 90;
            triangle[2].X = point.X + 120;
            triangle[2].Y = point.Y - 30;
            g.DrawPolygon(p, triangle);

            /////////////////
            point.X += 60;//line
                        
            point = line(g, p, point, 4, 1, 1);
            point.X -= 15;
            line(g, p, point, 3, 0, 1);
            point.X += 15;
            point.X -= 60;
            point.Y -= 40;
            //////////////

            point.Y -= 60;
            point.X += 10;
            line(g, p, point, 1, 0, 1);//minus
            point.X -= 10;
            point = line(g, p, point, 4, 0, 0);
            temp_point = point = line(g, p, point, 7, 1, 0);
            point.Y += 20;
            point = line(g, p, point, 8, 0, 1);
            //R8
            g.DrawString("R8", font, b, point.X, point.Y - 30);
            rectangle(g, p, point, 0, 1);
            point.X += 50;
            point = line(g, p, point, 6, 0, 1);
            point = line(g, p, point, 8, 1, 1);
            g.FillEllipse(b, point.X -5, point.Y-5, 10, 10);
            point.X -= 30;
            point = line(g, p, point, 11, 0, 1);
            ////////
            point.X -= 10;//plus
            point.Y -= 15;
            line(g, p, point, 1, 0, 0);
            point.Y -= 5;
            point.X -= 5;
            line(g, p, point, 1, 1, 1);
            point.X += 15;
            point.Y += 20;
            ///////////
            point.Y -= 20;
            //C6
            g.DrawString("C6", font, b, point.X - 15, point.Y - 20);
            line(g, p, point, 4, 1, 1);
            point.X += 10;
            line(g, p, point, 4, 1, 1);
            point.Y += 20;
            point = line(g, p, point, 3, 0, 1);
            point = line(g, p, point, 7, 1, 0);
            //BF2
            g.DrawString("BF2", font, b, point.X - 55, point.Y - 40);
            g.DrawRectangle(p, point.X - 15, point.Y - 40, 30, 40);
            point.X += 15;
            point.Y += 10;
            line(g, p, point, 6, 1, 0);
            point.X -= 15;
            point.Y -= 50;
            point = line(g, p, point, 12, 1, 0);
            //BF1
            g.DrawString("BF1", font, b, point.X - 55, point.Y - 40);
            g.DrawRectangle(p, point.X - 15, point.Y - 40, 30, 40);
            point.X += 15;
            point.Y += 10;
            line(g, p, point, 6, 1, 0);           
            point.X -= 15;
            ////////////////////////////
            point.Y += 55;
            g.FillEllipse(b, point.X -5, point.Y-5, 10, 10);
            point = line(g, p, point, 6, 0, 0);
            point = line(g, p, point, 2, 1, 1);
            point.X -= 15;
            line(g, p, point, 3, 0, 1);
            ///////////////////////////
            point.Y -= 125;
            point.X += 75;
            point = line(g, p, point, 6, 1, 0);
            point = line(g, p, point, 4, 0, 0);
            ////////////////////////
            //C4
            point.Y -= 20;
            g.DrawString("C4", font, b, point.X - 25, point.Y - 20);
            line(g, p, point, 4, 1, 1);
            point.X -= 10;
            line(g, p, point, 4, 1, 1);
            point.Y += 20;
            ///
            point.X -= 10;//plus 
            point.Y -= 15;
            line(g, p, point, 1, 0, 0);
            point.Y -= 5;
            point.X -= 5;
            line(g, p, point, 1, 1, 1);
            point.X += 15;
            point.Y += 20;
            ///
            point = line(g, p, point, 10, 0, 0);

            point.Y -= 30;
            point.X -= 60;
            point = line(g, p, point, 13, 1, 0);
            point.Y += 50;
            point.X -= 25;
            point = line(g, p, point, 5, 0, 1);
            g.FillEllipse(b, point.X - 30, point.Y - 5, 10, 10);
            g.FillEllipse(b, point.X - 30, point.Y - 55, 10, 10);
            g.FillEllipse(b, point.X - 210, point.Y - 55, 10, 10);
            //C2
            point.Y -= 20;
            ///
            point.X -= 15;//plus
            line(g, p, point, 1, 1, 1);
            point.X -= 5;
            point.Y += 5;
            line(g, p, point, 1, 0, 1);
            point.X += 20;
            point.Y -= 5;
            ///
            g.DrawString("C2", font, b, point.X - 15, point.Y - 20);
            line(g, p, point, 4, 1, 1);
            point.X += 10;
            line(g, p, point, 4, 1, 1);
            point.Y += 20;
            ///
            point = line(g, p, point, 3, 0, 1);
            point = line(g, p, point, 2, 1, 1);
            point.X -= 15;
            line(g, p, point, 3, 0, 1);
            point.X += 15;
            point.Y -= 20;
            point.X -= 90;
            //C1
            point.Y -= 20;
            g.DrawString("C1", font, b, point.X -20, point.Y - 20);
            line(g, p, point, 4, 1, 1);
            point.X -= 10;
            line(g, p, point, 4, 1, 1);
            point.Y += 20;
            ///
            point = line(g, p, point, 3, 0, 0);
            point = line(g, p, point, 2, 1, 1);
            point.X -= 15;
            line(g, p, point, 3, 0, 1);
            //////////////////////
            //R7
            
            point = temp_point;
            g.FillEllipse(b, point.X - 5, point.Y + 15, 10, 10);
            g.DrawString("R7", font, b, point.X + 10, point.Y - 50);
            rectangle(g, p, point, 1, 0);
            point.Y -= 50;
            point=line(g, p, point, 3, 1, 0);
            //R4
            g.DrawString("R4", font, b, point.X + 10, point.Y - 50);
            rectangle(g, p, point, 1, 0);
            point.Y -= 50;
            point = line(g, p, point, 7, 1, 0);

            point = line(g, p, point, 4, 0, 1);
            point.X += 10;
            line(g, p, point, 1, 0, 1);
            point.X -= 50;
            /////////////////////////////////////////////
            triangle[0].X = point.X + 40;
            triangle[0].Y = point.Y + 30;
            triangle[1].X = point.X + 40;
            triangle[1].Y = point.Y - 90;
            triangle[2].X = point.X + 160;
            triangle[2].Y = point.Y - 30;
            g.DrawPolygon(p, triangle);
            ///////////////////////////////////////////////
            g.DrawString("DA 1.1", font, b, point.X + 43, point.Y - 43);
            
            ///
            point.Y += 50;
            g.FillEllipse(b, point.X-5, point.Y - 5, 10, 10);
            point = line(g, p, point,8, 0, 1);
            //R5
            g.DrawString("R5", font, b, point.X, point.Y - 30);
           
            rectangle(g, p, point, 0, 1);
            point.X += 50;
            
            point = line(g, p, point, 6, 0, 1);
            point = line(g, p, point, 8, 1, 0);
            g.FillEllipse(b, point.X - 5, point.Y - 5, 10, 10);
            ///////////////////////////////////
            point = old_point;
            point.X += 30;
            //first vertical line

            point = line(g, p, point, 26, 1, 0);
            //R2
            g.DrawString("R2", font, b, point.X + 10, point.Y - 50);
            rectangle(g, p, point, 1, 0);

            point.Y -= 50;
            old_point = point = line(g, p, point, 21, 1, 0);
          
            //XS1
            point.Y += 140;
            point.X -= 100;
            g.DrawString("XS1", font, b, point.X -10, point.Y - 40);
            point2.Y = point.Y - 10;
            point2.X = point.X + 10;
            
            g.DrawLine(p, point, point2);
            point.Y -= 20;
            g.DrawLine(p, point, point2);

            point = point2;
            point=line(g, p, point, 5, 0, 1);
            //C3

            point.Y -= 20;
            g.DrawString("C3", font, b, point.X - 10, point.Y - 20);
            line(g, p, point, 4, 1, 1);
            point.X += 10;
            line(g, p, point, 4, 1, 1);

            point.Y += 20;
            //point on 3 and 7 cells
            g.FillEllipse(b, point.X + 25, point.Y-5, 10, 10);
            g.FillEllipse(b, point.X + 105, point.Y-5, 10, 10);
            point = line(g, p, point, 23, 0, 1);

            point.X += 10;//plus
            line(g, p, point, 1, 0, 1);
            point.X += 5;
            point.Y -= 5;
            line(g, p, point, 1, 1, 1);

            point = old_point;
            //point on 7 and 18 cells
            point = line(g, p, point, 45, 0, 1);

            ////////////
            point.Y -= 15;//plus

            g.DrawString("XP1", font, b, point.X + 10, point.Y - 13);
            line(g, p, point, 1, 0, 1);
            point.X += 5;
            point.Y -= 5;
            line(g, p, point, 1, 1, 1);
            point.X -= 5;
            point.Y += 20;
           
            /////////////
            //+XP1
            point2 = point;
            point.Y -= 10;
            point.X -= 10;
            g.DrawLine(p, point, point2);
            point.Y += 20;
            g.DrawLine(p, point, point2);

            //XP2
            point2.Y += 50;
            point.Y += 50;
            g.DrawString("XP2", font, b, point.X + 10, point.Y - 33);
            g.DrawLine(p, point, point2);
            point.Y -= 20;
            g.DrawLine(p, point, point2);
            point = point2;
            ///////////
            point = line(g, p, point, 3, 0, 0);
            point = line(g, p, point, 2, 1, 1);
            point.X -= 15;
            line(g, p, point, 3, 0, 1);
            ////////////////////
           
            //вторая ветка
            point.Y = 570;//низ
            point.X = 200;
            point = line(g, p, point, 8, 1, 0);
            //R6
            g.DrawString("R6", font, b, point.X + 10, point.Y - 50);
            rectangle(g, p, point, 1, 0);
            point.Y -= 50;
            old_point = point;
            point = line(g, p, point, 13, 1, 0);
            //R3
            g.DrawString("R3", font, b, point.X + 10, point.Y - 50);
            rectangle(g, p, point, 1, 0);
            point.Y -= 50;
            point = line(g, p, point, 12, 1, 0);
            //R1
            g.DrawString("R1", font, b, point.X + 10, point.Y - 50);
            rectangle(g, p, point, 1, 0);

            point.Y -= 50;
            line(g, p, point, 4, 1, 0);

            point = old_point;
            point.Y -= 65;
            g.FillEllipse(b, point.X - 5, point.Y - 5, 10, 10);
            g.FillEllipse(b, point.X + 75, point.Y - 5, 10, 10);
            point = line(g, p, point, 15, 0, 1);
            point = line(g, p, point, 2, 1, 1);
            point.X -= 15;
            line(g, p, point, 3, 0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
