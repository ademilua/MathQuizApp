using System;
using System.Windows.Forms;

namespace TMathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();
        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;
        //These interger variables store the numbers
        //for the subtraction problem.
        int minuend;
        int subtrahend;
        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;
        
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            //plusleftlabel and plusrightlabel is the name of the first ? on the form/
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            //Note:Tostring() is used here to convert the number to a text
            // because On the design form we used Label controls and label controls only display text not numbers.
            //Text here is the Text Property we left blank on the design form.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            // 'sum' is the name of the NumericUpDown control on design property.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;
            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            differences.Value = 0;
            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            divideRightlabel.Text = divisor.ToString();
            quotient.Value = 0;
            // Start the timer.
            timeLeft = 30;
        
            timelabel.Text = " 30 seconds";
            timer1.Start();

        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == differences.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))

                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
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
                timelabel.Text = timeLeft + " seconds";
               
                timelabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                // If the user ran out of time, stop the timer, show 
                // a MessageBox, and fill in the answers.


                timer1.Stop();
                timelabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                differences.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                timelabel.ForeColor = System.Drawing.Color.Black;
                startButton.Enabled = true;
            }
        }
        // event handler handles wen the user enter correct answer for sum
        private void sum_ValueChanged(object sender, EventArgs e)
        {
           // NumericUpDown answerBox = sender as NumericUpDown;
            if (addend1 + addend2 == sum.Value)
                
            {
               
               // CheckTheAnswer();
                //int lengthOfAnswer = answerBox.Value.ToString().Length;
                
              System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\yes.wav");
                player.Play();
               
            }
            else if (addend1 + addend2 != sum.Value)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\ak47.wav");
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
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\cat.wav");
               // player.Play();

            }

        }






        private void colour_change(object sender, EventArgs e)
        {
            if (timeLeft < 3)
            {
                timelabel.ForeColor = System.Drawing.Color.Pink;
            }


        }

        private void differences_ValueChanged(object sender, EventArgs e)
        {
            if (minuend - subtrahend == differences.Value)
            {
                 System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\yes.wav");
                player.Play();
            }
            else if (minuend - subtrahend != differences.Value)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\ak47.wav");
                player.Play();
            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (multiplicand * multiplier == product.Value)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\yes.wav");
                player.Play();
            }
            else if(multiplicand * multiplier != product.Value)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\ak47.wav");
                player.Play();
                
            }
        }

        private void quotient_ValueChanged(object sender, EventArgs e)
        {
            if (dividend / divisor == quotient.Value)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\yes.wav");
                player.Play();
            }
            else if (dividend / divisor != quotient.Value)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\ak47.wav");
                player.Play();

            }
        }
    }
}






