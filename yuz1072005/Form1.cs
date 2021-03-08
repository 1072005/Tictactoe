using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuz1072005
{
    public partial class Form1 : Form
    {
 

        int num = 0;
        int[] record = new int[9];
        int[] pos = new int[9];
       

        private void button3_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                button3.Text = "O";
                num++;
                pos[2] = 5;
                button3.Enabled = false;
            }
            else if (num == 1)
            {
                button3.Text = "X";
                num++;
                pos[2] = 6;
                button3.Enabled = false;
            }
            else if (num == 2)
            {
                button3.Text = "O";
                num++;
                pos[2] = 5;
                button3.Enabled = false;
            }
            else if (num == 3)
            {
                button3.Text = "X";
                num++;
                pos[2] = 6;
                button3.Enabled = false;
            }
            else if (num == 4)
            {
                button3.Text = "O";
                pos[2] = 5;
                num++;
                if(pos[0]==pos[1]&&pos[0]==pos[2]|| pos[2] == pos[5] && pos[2] == pos[8]|| pos[2] == pos[4] && pos[2] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button3.Enabled = false;

            }
            else if (num == 5)
            {
                button3.Text = "X";
                num++;
                pos[2] = 6;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[2] == pos[5] && pos[2] == pos[8] || pos[2] == pos[4] && pos[2] == pos[6])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button3.Enabled = false;
            }
            else if (num == 6)
            {
                button3.Text = "O";
                num++;
                pos[2] = 5;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[2] == pos[5] && pos[2] == pos[8] || pos[2] == pos[4] && pos[2] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button3.Enabled = false;
            }
            else if (num == 7)
            {
                button3.Text = "X";
                num++;
                pos[2] = 6;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[2] == pos[5] && pos[2] == pos[8] || pos[2] == pos[4] && pos[2] == pos[6])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button3.Enabled = false;
            }
            else if (num == 8)
            {
                button3.Text = "O";
                pos[2] = 5;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[2] == pos[5] && pos[2] == pos[8] || pos[2] == pos[4] && pos[2] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                else
                {
                    MessageBox.Show("平手");
                }
                button3.Enabled = false;
            }
        }

        
        
        public Form1()
        {
            InitializeComponent();
            

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                button1.Text = "O";
                num++;
                pos[0] = 5;
                button1.Enabled = false;
            }
            else if (num == 1)
            {
                button1.Text = "X";
                num++;
                pos[0] = 6;
                button1.Enabled = false;
            }
            else if (num == 2)
            {
                button1.Text = "O";
                num++;
                pos[0] = 5;
                button1.Enabled = false;
            }
            else if (num == 3)
            {
                button1.Text = "X";
                num++;
                pos[0] = 6;
                button1.Enabled = false;
            }
            else if (num == 4)
            {
                button1.Text = "O";
                num++;
                pos[0] = 5;
                if ( pos[0] == pos[1] && pos[0] == pos[2]|| pos[0] == pos[3] && pos[0] == pos[6]|| pos[0] == pos[4] && pos[0] == pos[8])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button1.Enabled = false;
            }
            else if (num == 5)
            {
                button1.Text = "X";
                num++;
                pos[0] = 6;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[0] == pos[3] && pos[0] == pos[6] || pos[0] == pos[4] && pos[0] == pos[8])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button1.Enabled = false;
            }
            else if (num == 6)
            {
                button1.Text = "O";
                num++;
                pos[0] = 5;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[0] == pos[3] && pos[0] == pos[6] || pos[0] == pos[4] && pos[0] == pos[8])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button1.Enabled = false;
            }
            else if (num == 7)
            {
                button1.Text = "X";
                num++;
                pos[0] = 6;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[0] == pos[3] && pos[0] == pos[6] || pos[0] == pos[4] && pos[0] == pos[8])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button1.Enabled = false;
            }
            else if (num == 8)
            {
                button1.Text = "O";
                pos[0] = 5;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[0] == pos[3] && pos[0] == pos[6] || pos[0] == pos[4] && pos[0] == pos[8])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                else
                {
                    MessageBox.Show("平手");
                }
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num == 0)
            {
                button2.Text = "O";
                num++;
                pos[1] = 5;
                button2.Enabled = false;
            }
            else if (num == 1)
            {
                button2.Text = "X";
                num++;
                pos[1] = 6;
                button2.Enabled = false;
            }
            else if(num==2)
            {
                button2.Text = "O";
                num++;
                pos[1] = 5;
                button2.Enabled = false;
            }
            else if (num == 3)
            {
                button2.Text = "X";
                num++;
                pos[1] = 6;
                button2.Enabled = false;
            }
            else if (num == 4)
            {
                button2.Text = "O";
                num++;
                pos[1] = 5;
                if ( pos[0] == pos[1] && pos[0] == pos[2]|| pos[1] == pos[4] && pos[1]==pos[7])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button2.Enabled = false;
            }
            else if (num == 5)
            {
                button2.Text = "X";
                num++;
                pos[1] = 6;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[1] == pos[4] && pos[1] == pos[7])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button2.Enabled = false;
            }
            else if (num == 6)
            {
                button2.Text = "O";
                num++;
                pos[1] = 5;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[1] == pos[4] && pos[1] == pos[7])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button2.Enabled = false;
            }
            else if (num == 7)
            {
                button2.Text = "X";
                num++;
                pos[1] = 6;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[1] == pos[4] && pos[1] == pos[7])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button2.Enabled = false;
            }
            else if (num == 8)
            {
                button2.Text = "O";
                pos[1] = 5;
                if (pos[0] == pos[1] && pos[0] == pos[2] || pos[1] == pos[4] && pos[1] == pos[7])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                else
                {
                    MessageBox.Show("平手");
                }
                button2.Enabled = false;
            }
        }

         private void button4_Click(object sender, EventArgs e)
         {
            if (num == 0)
            {
                button4.Text = "O";
                num++;
                pos[3] = 5;
                button4.Enabled = false;
            }
            else if (num == 1)
            {
                button4.Text = "X";
                num++;
                pos[3] = 6;
                button4.Enabled = false;
            }
            else if (num == 2)
            {
                button4.Text = "O";
                num++;
                pos[3] = 5;
                button4.Enabled = false;

            }
            else if (num == 3)
            {
                button4.Text = "X";
                num++;
                pos[3] = 6;
                button4.Enabled = false;
            }
            else if (num == 4)
            {
                button4.Text = "O";
                num++;
                pos[3] = 5;
                if ( pos[3] == pos[4] && pos[3] == pos[5] || pos[0] == pos[3] && pos[3] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button4.Enabled = false;

            }
            else if (num == 5)
            {
                button4.Text = "X";
                num++;
                pos[3] = 6;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[0] == pos[3] && pos[3] == pos[6])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button4.Enabled = false;
            }
            else if (num == 6)
            {
                button4.Text = "O";
                num++;
                pos[3] = 5;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[0] == pos[3] && pos[3] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button4.Enabled = false;
            }
            else if (num == 7)
            {
                button4.Text = "X";
                num++;
                pos[3] = 6;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[0] == pos[3] && pos[3] == pos[6])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button4.Enabled = false;
            }
            else if (num == 8)
            {
                button4.Text = "O";
                pos[3] = 5;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[0] == pos[3] && pos[3] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                else
                {
                    MessageBox.Show("平手");
                }
                button4.Enabled = false;
            }

        }


          private void button5_Click(object sender, EventArgs e)
          {
            if (num == 0)
            {
                button5.Text = "O";
                num++;
                pos[4] = 5;
                button5.Enabled = false;
            }
            else if (num == 1)
            {
                button5.Text = "X";
                num++;
                pos[4] = 6;
                button5.Enabled = false;
            }
            else if (num == 2)
            {
                button5.Text = "O";
                num++;
                pos[4] = 5;
                button5.Enabled = false;
            }
            else if (num == 3)
            {
                button5.Text = "X";
                num++;
                pos[4] = 6;
                button5.Enabled = false;
            }
            else if (num == 4)
            {
                button5.Text = "O";
                num++;
                pos[4] = 5;
                if (pos[3] == pos[4] && pos[3] == pos[5]|| pos[1] == pos[4] && pos[4] == pos[7]|| pos[0] == pos[4] && pos[4] == pos[8]|| pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button5.Enabled = false;
            }
            else if (num == 5)
            {
                button5.Text = "X";
                num++;
                pos[4] = 6;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[1] == pos[4] && pos[4] == pos[7] || pos[0] == pos[4] && pos[4] == pos[8] || pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button5.Enabled = false;
            }
            else if (num == 6)
            {
                button5.Text = "O";
                num++;
                pos[4] = 5;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[1] == pos[4] && pos[4] == pos[7] || pos[0] == pos[4] && pos[4] == pos[8] || pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button5.Enabled = false;
            }
            else if (num == 7)
            {
                button5.Text = "X";
                num++;
                pos[4] = 6;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[1] == pos[4] && pos[4] == pos[7] || pos[0] == pos[4] && pos[4] == pos[8] || pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button5.Enabled = false;
            }
            else if (num == 8)
            {
                button5.Text = "O";
                pos[4] = 5;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[1] == pos[4] && pos[4] == pos[7] || pos[0] == pos[4] && pos[4] == pos[8] || pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                else
                {
                    MessageBox.Show("平手");
                }
                button5.Enabled = false;
            }
        }

          private void button6_Click(object sender, EventArgs e)
          {
            if (num == 0)
            {
                button6.Text = "O";
                num++;
                pos[5] = 5;
                button6.Enabled = false;
            }
            else if (num == 1)
            {
                button6.Text = "X";
                num++;
                pos[5] = 6;
                button6.Enabled = false;
            }
            else if (num == 2)
            {
                button6.Text = "O";
                num++;
                pos[5] = 5;
                button6.Enabled = false;
            }
            else if (num == 3)
            {
                button6.Text = "X";
                num++;
                pos[5] = 6;
                button6.Enabled = false;
            }
            else if (num == 4)
            {
                button6.Text = "O";
                num++;
                pos[5] = 5;
                if (pos[3] == pos[4] && pos[3] == pos[5]|| pos[2] == pos[5] && pos[5] == pos[8])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button6.Enabled = false;
            }
            else if (num == 5)
            {
                button6.Text = "X";
                num++;
                pos[5] = 6;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[2] == pos[5] && pos[5] == pos[8])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button6.Enabled = false;
            }
            else if (num == 6)
            {
                button6.Text = "O";
                num++;
                pos[5] = 5;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[2] == pos[5] && pos[5] == pos[8])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button6.Enabled = false;
            }
            else if (num == 7)
            {
                button6.Text = "X";
                num++;
                pos[5] = 6;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[2] == pos[5] && pos[5] == pos[8])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button6.Enabled = false;
            }
            else if (num == 8)
            {
                button6.Text = "O";
                pos[5] = 5;
                if (pos[3] == pos[4] && pos[3] == pos[5] || pos[2] == pos[5] && pos[5] == pos[8])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                else
                {
                    MessageBox.Show("平手");
                }
                button6.Enabled = false;
            }
        }
          private void button7_Click(object sender, EventArgs e)
          {
            if (num == 0)
            {
                button7.Text = "O";
                num++;
                pos[6] = 5;
                button7.Enabled = false;
            }
            else if (num == 1)
            {
                button7.Text = "X";
                num++;
                pos[6] = 6;
                button7.Enabled = false;
            }
            else if (num == 2)
            {
                button7.Text = "O";
                num++;
                pos[6] = 5;
                button7.Enabled = false;
            }
            else if (num == 3)
            {
                button7.Text = "X";
                num++;
                pos[6] = 6;
                button7.Enabled = false;
            }
            else if (num == 4)
            {
                button7.Text = "O";
                num++;
                pos[6] = 5;
                if (pos[6] == pos[7] && pos[6] == pos[8]|| pos[0] == pos[6] && pos[6] == pos[3]|| pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button7.Enabled = false;
            }
            else if (num == 5)
            {
                button7.Text = "X";
                num++;
                pos[6] = 6;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[0] == pos[6] && pos[6] == pos[3] || pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button7.Enabled = false;
            }
            else if (num == 6)
            {
                button7.Text = "O";
                num++;
                pos[6] = 5;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[0] == pos[6] && pos[6] == pos[3] || pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button7.Enabled = false;
            }
            else if (num == 7)
            {
                button7.Text = "X";
                num++;
                pos[6] = 6;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[0] == pos[6] && pos[6] == pos[3] || pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button7.Enabled = false;
            }
            else if (num == 8)
            {
                button7.Text = "O";
                pos[6] = 5;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[0] == pos[6] && pos[6] == pos[3] || pos[2] == pos[4] && pos[4] == pos[6])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                else
                {
                    MessageBox.Show("平手");
                }
                button7.Enabled = false;
            }
        }

          private void button8_Click(object sender, EventArgs e)
          {
            if (num == 0)
            {
                button8.Text = "O";
                num++;
                pos[7] = 5;
                button8.Enabled = false;
            }
            else if (num == 1)
            {
                button8.Text = "X";
                num++;
                pos[7] = 6;
                button8.Enabled = false;
            }
            else if (num == 2)
            {
                button8.Text = "O";
                num++;
                pos[7] = 5;
                button8.Enabled = false;
            }
            else if (num == 3)
            {
                button8.Text = "X";
                num++;
                pos[7] = 6;
                button8.Enabled = false;
            }
            else if (num == 4)
            {
                button8.Text = "O";
                num++;
                pos[7] = 5;
                if (pos[6] == pos[7] && pos[6] == pos[8]|| pos[1] == pos[4] && pos[4] == pos[7])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button8.Enabled = false;
            }
            else if (num == 5)
            {
                button8.Text = "X";
                num++;
                pos[7] = 6;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[1] == pos[4] && pos[4] == pos[7])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button8.Enabled = false;
            }
            else if (num == 6)
            {
                button8.Text = "O";
                num++;
                pos[7] = 5;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[1] == pos[4] && pos[4] == pos[7])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button8.Enabled = false;
            }
            else if (num == 7)
            {
                button8.Text = "X";
                num++;
                pos[7] = 6;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[1] == pos[4] && pos[4] == pos[7])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button8.Enabled = false;
            }
            else if (num == 8)
            {
                button8.Text = "O";
                pos[7] = 5;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[1] == pos[4] && pos[4] == pos[7])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                else
                {
                    MessageBox.Show("平手");
                }
                button8.Enabled = false;
            }
        }

         private void button9_Click(object sender, EventArgs e)
         {
            if (num == 0)
            {
                button9.Text = "O";
                num++;
                pos[8] = 5;
                button9.Enabled = false;
            }
            else if (num == 1)
            {
                button9.Text = "X";
                num++;
                pos[8] = 6;
                button9.Enabled = false;
            }
            else if (num == 2)
            {
                button9.Text = "O";
                num++;
                pos[8] = 5;
                button9.Enabled = false;
            }
            else if (num == 3)
            {
                button9.Text = "X";
                num++;
                pos[8] = 6;
                button9.Enabled = false;
            }
            else if (num == 4)
            {
                button9.Text = "O";
                num++;
                pos[8] = 5;
                if (pos[6] == pos[7] && pos[6] == pos[8]|| pos[2] == pos[5] && pos[5] == pos[8]|| pos[0] == pos[4] && pos[4] == pos[8])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button9.Enabled = false;
            }
            else if (num == 5)
            {
                button9.Text = "X";
                num++;
                pos[8] = 6;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[2] == pos[5] && pos[5] == pos[8] || pos[0] == pos[4] && pos[4] == pos[8])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button9.Enabled = false;
            }
            else if (num == 6)
            {
                button9.Text = "O";
                num++;
                pos[8] = 5;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[2] == pos[5] && pos[5] == pos[8] || pos[0] == pos[4] && pos[4] == pos[8])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                button9.Enabled = false;
            }
            else if (num == 7)
            {
                button9.Text = "X";
                num++;
                pos[8] = 6;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[2] == pos[5] && pos[5] == pos[8] || pos[0] == pos[4] && pos[4] == pos[8])
                {
                    MessageBox.Show("X 贏囉^^");

                }
                button9.Enabled = false;
            }
            else if (num == 8)
            {
                button9.Text = "O";
                pos[8] = 5;
                if (pos[6] == pos[7] && pos[6] == pos[8] || pos[2] == pos[5] && pos[5] == pos[8] || pos[0] == pos[4] && pos[4] == pos[8])
                {
                    MessageBox.Show("O 贏囉^^");

                }
                else
                {
                    MessageBox.Show("平手");
                }
                button9.Enabled = false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
           

        }
        
       
    }
}
