//Grading ID: K1791
//Lab 2
//13 September 2020
//CIS 199-02
//A simple GUI application that calculates tip from the price of a meal.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void Fifteen_Click(object sender, EventArgs e) //IGNORE THIS, IT IS UNRELATED, BUT I CANNOT REMOVE IT WITHOUT IT BREAKING EVERYTHING!
        {
        }

        private void CalcButton_Click(object sender, EventArgs e) //When the Calculate Tip button is pressed, the following lines of code below will execute.
        {
            double tipfifteen = .15; //Fifteen percent
            double tipeighteen = .18; //Eighteen percent
            double tiptwenty = .20; //Twenty Percent


            string input;
            input = PriceOfMealTextBox.Text; //The value that the user inputs is assigned as an input.

            double priceOfMeal = double.Parse(input); //Takes the input for the above, and makes it a double to be used for the calculations below.

            double fifteenCalculation = priceOfMeal * tipfifteen; //Calculates the tip for 15% of the Price of the Meal
            double eighteenCalculation = priceOfMeal * tipeighteen; //Calculates the tip for 18% of the Price of the Meal
            double twentyCalculation = priceOfMeal * tiptwenty; //Calculates the tip for 20% of the Price of the Meal

            FifteenTextBox.Text = fifteenCalculation.ToString("C"); //Displays the calculed tip for 15% of the meal price
            EighteenTextBox.Text = eighteenCalculation.ToString("C"); //Displays the calculed tip for 15% of the meal price
            TwentyTextBox.Text = twentyCalculation.ToString("C"); //Displays the calculed tip for 15% of the meal price
        }
    }
}
