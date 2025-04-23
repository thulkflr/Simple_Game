using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuylkflProject
{

    public partial class Form1 : Form
    {
        

        int counter;
        int timer;
        int x;
        int y;
        int x1 ;
        int y1 ;
        int x2;
        int y2;
        int x3;
        int y3;
        int x4;
        int y4;
        int x5;
        int y5;
        int x6;
        int y6;
        
        public Form1()
        {
            InitializeComponent();
            x = 354;
            y = 334;
            y1 = 26;
            y2 = 26;
            y3 = 26;
            y4 = 26;
            y5 = 26;
            y6 = 26;
            counter = 6;
            timer = 60;

            //x1 = 73;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           // label1.Text = e.Button.ToString();
           // label1.Text = e.X +" , "+e.Y;
           //label1.Location =  e.Location;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer -= 2;
            label2.Text=timer.ToString();


            pictureBox1.Location = new Point(73, y1 += 10);
            pictureBox2.Location = new Point(555, y2 += 10);
            pictureBox3.Location = new Point(424, y3 += 10);
            pictureBox4.Location = new Point(317, y4 += 10);
            pictureBox5.Location = new Point(198, y5 += 10);
            pictureBox6.Location = new Point(665, y6 += 10);

            Random randomInteger = new Random();
            x1 = randomInteger.Next(26, 925);
            pictureBox1.Left = x1;
             Random randomInteger1 = new Random();
            x2 = randomInteger.Next(555, 925);
            pictureBox2.Left = x2;
             Random randomInteger2 = new Random();
            x3 = randomInteger.Next(424, 925);
            pictureBox3.Left = x3;
             Random randomInteger3 = new Random();
            x4 = randomInteger.Next(317, 925);
            pictureBox4.Left = x4;
             Random randomInteger4 = new Random();
            x5 = randomInteger.Next(198, 925);
            pictureBox5.Left = x5;
             Random randomInteger5 = new Random();
            x6 = randomInteger.Next(665, 925);
            pictureBox6.Left = x6;

            if ((pictureBox7.Bounds.IntersectsWith(pictureBox1.Bounds) == true)|| (pictureBox7.Bounds.IntersectsWith(pictureBox2.Bounds) == true)|| (pictureBox7.Bounds.IntersectsWith(pictureBox3.Bounds) == true)|| (pictureBox7.Bounds.IntersectsWith(pictureBox4.Bounds) == true)|| (pictureBox7.Bounds.IntersectsWith(pictureBox5.Bounds) == true)|| (pictureBox7.Bounds.IntersectsWith(pictureBox6.Bounds) == true) )
            {
                label1.Text = counter.ToString();
                counter--;
                if (counter == 0)
                {
                    //   label1.Text = counter.ToString();
                    MessageBox.Show("Game Over", "LOST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    timer1.Stop();

                }
               

            }
            if (timer == 0 && counter != 0)
            {

                MessageBox.Show("Winner Winner Checken dinner", "WIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                timer1.Stop();


            }

            //    timer1.Tick += new EventHandler(timer1_Tick);
            //     for (counter = 0; counter <= 60; counter += 2)

            //    timer1.Enabled = false;
            //  MessageBox.Show("game Over", "Win", MessageBoxButtons.OK, MessageBoxIcon.Hand);



            // y1 = 73;
            // pictureBox1.Image = new Point(x1, y1);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
         

            if (e.KeyCode == Keys.Up)
            {
                y -= 10;
              pictureBox7.Location = new Point(x,y );
                //timer1.Enabled = true;

            }
            if (e.KeyCode == Keys.Down)
            {
                y += 10;
                 pictureBox7.Location = new Point(x, y);
                //timer1.Enabled = true;

            }
            if (e.KeyCode == Keys.Right)
            {
                x+=10;
                pictureBox7.Location = new Point(x, y);
              //  timer1.Enabled = true;

            }
            if (e.KeyCode == Keys.Left)
            {
                x -= 10;

                pictureBox7.Location = new Point(x,  y);
                timer1.Start();
               
              
              

            }

        }

        private void pictureBox7_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


          



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Move(object sender, EventArgs e)
        {
            //pictureBox1.Top = y1;

            //Random randomInteger = new Random();
            //x1 = randomInteger.Next(26, 925);
            //pictureBox1.Left = x1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
