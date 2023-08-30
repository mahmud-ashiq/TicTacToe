using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacLab
{
    public partial class Form1 : Form
    {
        int turn = 1, count = 0, player1_score = 0, player2_score = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Player 1";
        }

        int[,] array = new int[3, 3];



        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button1.Text = "X";
                array[0, 0] = 1;
                turn = 0;
                button1.Enabled = false;
                textBox1.Text = "Player 2";
                count++;
            }
            else if (turn == 0)
            {
                button1.Text = "O";
                array[0, 0] = 2;
                turn = 1;
                button1.Enabled = false;
                textBox1.Text = "Player 1";
                count++;
            }
            Winner();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button2.Text = "X";
                array[0, 1] = 1;
                turn = 0;
                button2.Enabled = false;
                textBox1.Text = "Player 2";
                count++;
            }
            else if (turn == 0)
            {
                button2.Text = "O";
                array[0, 1] = 2;
                turn = 1;
                button2.Enabled = false;
                textBox1.Text = "Player 1";
                count++;
            }
            Winner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button3.Text = "X";
                array[0, 2] = 1;
                turn = 0;
                button3.Enabled = false;
                textBox1.Text = "Player 2";
                count++;
            }
            else if (turn == 0)
            {
                button3.Text = "O";
                array[0, 2] = 2;
                turn = 1;
                button3.Enabled = false;
                textBox1.Text = "Player 1";
                count++;
            }
            Winner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button4.Text = "X";
                array[1, 0] = 1;
                turn = 0;
                button4.Enabled = false;
                textBox1.Text = "Player 2";
                count++;
            }
            else if (turn == 0)
            {
                button4.Text = "O";
                array[1, 0] = 2;
                turn = 1;
                button4.Enabled = false;
                textBox1.Text = "Player 1";
                count++;
            }
            Winner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button5.Text = "X";
                array[1, 1] = 1;
                turn = 0;
                button5.Enabled = false;
                textBox1.Text = "Player 2";
                count++;
            }
            else if (turn == 0)
            {
                button5.Text = "O";
                array[1, 1] = 2;
                turn = 1;
                button5.Enabled = false;
                textBox1.Text = "Player 1";
                count++;
            }
            Winner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button6.Text = "X";
                array[1, 2] = 1;
                turn = 0;
                button6.Enabled = false;
                textBox1.Text = "Player 2";
                count++;

            }
            else if (turn == 0)
            {
                button6.Text = "O";
                array[1, 2] = 2;
                turn = 1;
                button6.Enabled = false;
                textBox1.Text = "Player 1";
                count++;
            }
            Winner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button7.Text = "X";
                array[2, 0] = 1;
                turn = 0;
                button7.Enabled = false;
                textBox1.Text = "Player 2";
                count++;
            }
            else if (turn == 0)
            {
                button7.Text = "O";
                array[2, 0] = 2;
                turn = 1;
                button7.Enabled = false;
                textBox1.Text = "Player 1";
                count++;
            }
            Winner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button8.Text = "X";
                array[2, 1] = 1;
                turn = 0;
                button8.Enabled = false;
                textBox1.Text = "Player 2";
                count++;
            }
            else if (turn == 0)
            {
                button8.Text = "O";
                array[2, 1] = 2;
                turn = 1;
                button8.Enabled = false;
                textBox1.Text = "Player 1";
                count++;
            }
            Winner();
        }



        private void button9_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button9.Text = "X";
                array[2, 2] = 1;
                turn = 0;
                button9.Enabled = false;
                textBox1.Text = "Player 2";
                count++;
            }
            else if (turn == 0)
            {
                button9.Text = "O";
                array[2, 2] = 2;
                turn = 1;
                button9.Enabled = false;
                textBox1.Text = "Player 1";
                count++;
            }
            Winner();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.BackColor = default(Color);
            button2.BackColor = default(Color);
            button3.BackColor = default(Color);
            button4.BackColor = default(Color);
            button5.BackColor = default(Color);
            button6.BackColor = default(Color);
            button7.BackColor = default(Color);
            button8.BackColor = default(Color);
            button9.BackColor = default(Color);

            Array.Clear(array, 0, array.Length);
        }

        public void Winner()
        {

            if (count >= 5)
            {
                if (((array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2]) && array[0, 0] == 1) ||
                    ((array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2]) && array[1, 0] == 1) ||
                    ((array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2]) && array[2, 0] == 1) ||
                    ((array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0]) && array[0, 0] == 1) ||
                    ((array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1]) && array[0, 1] == 1) ||
                    ((array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2]) && array[0, 2] == 1) ||
                    ((array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2]) && array[0, 0] == 1) ||
                    ((array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0]) && array[0, 2] == 1))

                {
                    if ((array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2]) && array[0, 0] == 1)
                    {
                        button1.BackColor = Color.Green;
                        button2.BackColor = Color.Green;
                        button3.BackColor = Color.Green;
                    }
                    else if ((array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2]) && array[1, 0] == 1)
                    {
                        button4.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button6.BackColor = Color.Green;
                    }
                    else if ((array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2]) && array[2, 0] == 1)
                    {
                        button7.BackColor = Color.Green;
                        button8.BackColor = Color.Green;
                        button9.BackColor = Color.Green;
                    }
                    else if ((array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0]) && array[0, 0] == 1)
                    {
                        button1.BackColor = Color.Green;
                        button4.BackColor = Color.Green;
                        button7.BackColor = Color.Green;
                    }
                    else if ((array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1]) && array[0, 1] == 1)
                    {
                        button2.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button8.BackColor = Color.Green;
                    }
                    else if ((array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2]) && array[0, 2] == 1)
                    {
                        button3.BackColor = Color.Green;
                        button6.BackColor = Color.Green;
                        button9.BackColor = Color.Green;
                    }
                    else if ((array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2]) && array[0, 0] == 1)
                    {
                        button1.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button9.BackColor = Color.Green;
                    }
                    else if ((array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0]) && array[0, 2] == 1)
                    {
                        button3.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button7.BackColor = Color.Green;
                    }
                    MessageBox.Show("Player1 Wins");
                    player1_score++;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    textBox2.Text = player1_score.ToString();
                    Array.Clear(array, 0, array.Length);


                }

                else if (((array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2]) && array[0, 0] == 2) ||
                         ((array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2]) && array[1, 0] == 2) ||
                         ((array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2]) && array[2, 0] == 2) ||
                         ((array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0]) && array[0, 0] == 2) ||
                         ((array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1]) && array[0, 1] == 2) ||
                         ((array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2]) && array[0, 2] == 2) ||
                         ((array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2]) && array[0, 0] == 2) ||
                         ((array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0]) && array[0, 2] == 2))

                {
                    if ((array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2])&& array[0, 0] == 2)
                    {
                        button1.BackColor = Color.Green;
                        button2.BackColor = Color.Green;
                        button3.BackColor = Color.Green;
                    }
                    else if ((array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2]) && array[1, 0] == 2)
                    {
                        button4.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button6.BackColor = Color.Green;
                    }
                    else if ((array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2]) && array[2, 0] == 2)
                    {
                        button7.BackColor = Color.Green;
                        button8.BackColor = Color.Green;
                        button9.BackColor = Color.Green;
                    }
                    else if ((array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0]) && array[0, 0] == 2)
                    {
                        button1.BackColor = Color.Green;
                        button4.BackColor = Color.Green;
                        button7.BackColor = Color.Green;
                    }
                    else if ((array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1]) && array[0, 1] == 2)
                    {
                        button2.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button8.BackColor = Color.Green;
                    }
                    else if ((array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2]) && array[0, 2] == 2)
                    {
                        button3.BackColor = Color.Green;
                        button6.BackColor = Color.Green;
                        button9.BackColor = Color.Green;
                    }
                    else if ((array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2]) && array[0, 0] == 2)
                    {
                        button1.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button9.BackColor = Color.Green;
                    }
                    else if ((array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0]) && array[0, 2] == 2)
                    {
                        button3.BackColor = Color.Green;
                        button5.BackColor = Color.Green;
                        button7.BackColor = Color.Green;
                    }
                    MessageBox.Show("Player2 Wins");
                    player2_score++;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    textBox3.Text = player2_score.ToString();
                    Array.Clear(array, 0, array.Length);

                }
            }

        }
    }
}

