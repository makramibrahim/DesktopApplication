/***********************************************************
 * Author: Makram Ibrahim
 * Instructor: Brother Blazzard
 * CIT 365 - .NET Software Development
 * Summary:
 * This is a discktop application to display a math quiz
 * on Visual Studio C#. 
 * *********************************************************/
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
        // create some variables to store numbers
        int timer = 30;
        int numAddition1, numAddition2;
        int numSubtract1, numSubtract2;
        int numMultiply1, numMultiply2;
        int numDivision1, numDivision2;
       
        int plus, subtract, divide, multiply;

        /**************************************
         * Display the Form quiz on the screen.
         **************************************/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    
        /********************************************
         * StartButton(): On click the quiz will start.
         *******************************************/
        private void StartQuiz_Click(object sender, EventArgs e)
        {
            StartTheQuiz();

            var time = DateTime.Now.ToString("dd MMMM yyyy");
            date.Text = time;

            startButton.Enabled = false;
            timeLabel.Text = "30 Seconds";

        }

        /*******************************************
         * RandomNumber(): Generates a random number.
         *******************************************/
        public void RandomNumber()
        {
            Random randomNum = new Random();

            numAddition1 = randomNum.Next(51);
            numAddition2 = randomNum.Next(51);

            numSubtract1 = randomNum.Next(1, 101);
            numSubtract2 = randomNum.Next(1, numSubtract1);

            numMultiply1 = randomNum.Next(2, 11);
            numMultiply2 = randomNum.Next(2, 11);

            numDivision1 = randomNum.Next(2, 11);
            numDivision2 = randomNum.Next(2, 11);


            plusLeft.Text = numAddition1.ToString();
            plusRight.Text = numAddition2.ToString();

            minuesLeft.Text = numSubtract1.ToString();
            minuesRight.Text = numSubtract2.ToString();

            timesLeft.Text = numMultiply1.ToString();
            timesRight.Text = numMultiply2.ToString();

            dividedLeft.Text = numDivision1.ToString();
            dividedRight.Text = numDivision2.ToString();

        }

        /******************************************
         * Quiz(): Start the quiz from here
         ****************************************/
        public void StartTheQuiz()
        {
            // call random number function here.
            RandomNumber();

            // int plus, subtract, divide, multiply, 
             plus = numAddition1 + numAddition2;
             subtract = numSubtract1 - numSubtract2;
             multiply = numMultiply1 * numMultiply2;
             divide = numDivision1 / numDivision2;
           
            timer = 30;
            sum1.Value = 0;
            sum2.Value = 0;
            sum3.Value = 0;
            sum4.Value = 0;
            timer1.Start();

        }

        /*************************************************
         * Timer(): Will start to countdown from 30 seconds.
         ************************************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            double points = Feedback();
            //Console.WriteLine(myPoints);
            if (CheckTheAnswer())
            {
                timer1.Stop();
                startButton.Enabled = true;
                MessageBox.Show($"You got all the answers right! {points} / {100}",
                              "Congratulations!");
            }
            
            else if (timer > 0)
            {
                timer --;
               
                timeLabel.Text = timer + " Seconds";
            } 
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time is Up!";
                MessageBox.Show($"Sorry you didn't finish in time! {points} / {100}");
                sum1.Value =  plus;
                sum2.Value = subtract;
                sum3.Value = multiply;
                sum4.Value = divide;
                startButton.Enabled = true;

                sum1.BackColor = Color.LightGreen;
                sum2.BackColor = Color.LightGreen;
                sum3.BackColor = Color.LightGreen;
                sum4.BackColor = Color.LightGreen;
                
            }

            if (timer <= 5)
            {
                timeLabel.BackColor = Color.OrangeRed;
            }

        }
      
        /**************************************************
         * Check(): Will check the answer.
         **************************************************/
        private bool CheckTheAnswer()
        {
            // int plus, subtract, divide, multiply, module, plusdivide;
            if ((plus == sum1.Value) && (subtract == sum2.Value) &&
                 (multiply == sum3.Value) && (divide == sum4.Value)
               )
            {
                return true;
            }

            else
                return false;

        }

        /**************************************************
       * Check(): Return points for the user!
       **************************************************/
        private double Feedback()
        {
            double totalScores = 25;
            // Console.WriteLine("=========== " + myScores + " ======");

            double points = 0;

            if (plus == sum1.Value)
            {
                 points += totalScores;
            }

            if (subtract == sum2.Value)
            {
               points +=  totalScores;
            }

            if (multiply == sum3.Value)
            {
                points += totalScores;
            }

            if (divide == sum4.Value)
            {
                points += totalScores;
            }
          
            return points;
            
        }
    }
}
 