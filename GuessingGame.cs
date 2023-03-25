using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        private int guess;
        private int target;
        private int countofGuesses;
        private Random ranValue;

        public GuessingGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ranValue = new Random();
            target = ranValue.Next(0, 101);
            countofGuesses = 0;


        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtGuess.Text, out guess) == false)
            {
                lblmsg.Text = "Value must be numberic";
            }
            else
            {
                lblmsg.Text = "";
                lblAnswer.Text = (++countofGuesses).ToString();

                if (guess == target)
                {
                    BackColor = Color.Purple;
                    MessageBox.Show(" Your guess is " + guess + " You got it... You won!");
                    lblmsg.Text = "Reset the game to start again";



                }
                else
                {
                    txtGuess.Clear();
                    txtGuess.Focus();
                    while (target != guess)
                     
                        {
                            if (guess > target)
                            {

                                {
                                if ( target %2==0)
                                {
                                    MessageBox.Show(guess + " is too high" + " The answer is Even");
                                    BackColor = Color.Red;
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show(guess + " is too high" + " The answer is Odd");
                                    BackColor = Color.Red;
                                    break;
                                }
                               
                                   
                                }

                            }


                            else
                            {
                            if (target % 2 == 0)
                            {
                                MessageBox.Show(guess + " is too low" + " The answer is Even");
                                BackColor = Color.Green;
                                break;
                            }
                            else
                            {
                                MessageBox.Show(guess + " is too low" + " The answer is Odd");
                                BackColor = Color.Green;
                                break;
                            }


                            }



                        }


                }
            }





        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            target = ranValue.Next(0, 101);
            countofGuesses = 0;
            BackColor = Color.Purple;
            txtGuess.Clear();
            lblAnswer.Text = "";
            lblmsg.Text = "";
            txtGuess.Focus();
        }
    }
}
