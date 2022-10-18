using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        
        private string OpName;
        private bool OpClicked;

        private void Repeated_Click(object sender, EventArgs e)
        {
            Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;
            Result.Text += button.Text;
           
        }


        private void Clear_Clicked(object sender, EventArgs e)
        {
            Result.Text = "";
            OpClicked = false;
       
        }



        private void CommonOperation_Clicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;
            Result.Text += button.Text;
            
        }

        private void Equal_Clicked(object sender, EventArgs e)
        {
            Expression Equation = new Expression(Result.Text);
            if (Equation.checkSyntax())
            {
                Result.Text = Equation.calculate().ToString();
            }
            else
            {
                Result.Text = "INVALID";
            }
            
        }

        private async void Percentage_Clicked(object sender, EventArgs e)
        {
            try
            {
                string number = Result.Text;
                if (number != "0")
                {
                    decimal percentValue = Convert.ToDecimal(number);
                    string result = (percentValue / 100).ToString("0.##");
                    Result.Text = result;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("INVALID", ex.Message, "OKAY");
            }
        }

        private void Times_X_Clicked(object sender, EventArgs e)
        {
            string number = Result.Text;
            if (number != "0")
            {
                number = number.Remove(number.Length - 1, 1);
                if (string.IsNullOrEmpty(number))
                {
                    Result.Text = "0";
                }
                else
                {
                    Result.Text = number;
                }
            }
        }

        public decimal Calculatation(decimal firstNum, decimal secondNum)
        {
            decimal result = 0;
            if (OpName == "+")
            {
                result = firstNum + secondNum;
            }
            else if (OpName == "-")
            {
                result = firstNum - secondNum;
            }
            else if (OpName == "*")
            {
                result = firstNum * secondNum;
            }
            else if (OpName == "/")
            {
                result = firstNum / secondNum;
            }
            return result;
        }
    }
}

