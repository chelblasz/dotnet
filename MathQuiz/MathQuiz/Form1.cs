using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
            // Create a Random object called randomizer 
            // to generate random numbers.
            Random randomizer = new Random();
            int addend1;
            int addend2;
            int minuend;
            int subtrahend;
            int multiplicand;
            int multiplier;
            int dividend;
            int divisor;
            int timeLeft;


        public Form1()
            {
                InitializeComponent();
                this.Text = System.DateTime.Today.ToString("dd/MM/yyyy ") + " Chelsea Blaszczyk's Math Quiz";


        }

            public void StartTheQuiz()
            {

            //fill in addition problem
                addend1 = randomizer.Next(51);
                addend2 = randomizer.Next(51);

                // Convert the two randomly generated numbers into strings so that they can be displayed in the label controls.
                plusLeftLabel.Text = addend1.ToString();
                plusRightLabel.Text = addend2.ToString();

                // 'sum' is the name of the NumericUpDown control. This step makes sure its value is zero before adding any values to it.
                sum.Value = 0;

                // Fill in the subtraction problem.
                minuend = randomizer.Next(1, 101);
                subtrahend = randomizer.Next(1, minuend);
                minusLeftLabel.Text = minuend.ToString();
                minusRightLabel.Text = subtrahend.ToString();
                difference.Value = 0;

                // Fill in the multiplication problem.
                multiplicand = randomizer.Next(2, 11);
                multiplier = randomizer.Next(2, 11);
                multiplyLeft.Text = multiplicand.ToString();
                multiplyRight.Text = multiplier.ToString();
                product.Value = 0;

                // Fill in the division problem.
                divisor = randomizer.Next(2, 11);
                int temporaryQuotient = randomizer.Next(2, 11);
                dividend = divisor * temporaryQuotient;
                divisionLeft.Text = dividend.ToString();
                divisionRight.Text = divisor.ToString();
                quotient.Value = 0;

            // Start the timer.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

        }
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) 
                && (minuend - subtrahend == difference.Value) 
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }

        //Start button event_______________________
        private void StartButton_Click(object sender, EventArgs e)
        {
                StartTheQuiz();
                startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() return false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show 
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
                if (timeLeft <= 5) { timeLabel.BackColor = Color.Red; }
                
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

//____________________________________________________________________________________________________________
        //BAD CODE_____________________
        private void label1_Click(object sender, EventArgs e)
        { }

        private void TimeLeft_Click(object sender, EventArgs e)
        { }
        //Bad CODE____________________________
    }

    }

