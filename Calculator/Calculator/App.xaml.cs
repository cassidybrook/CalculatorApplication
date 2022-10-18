using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class SimpleCalculator
    {
        public static double Calculate(double value1, double value2, string mathOperator)
        {
            double result = 0;

            switch (mathOperator)
            {
                case "÷":
                    result = value1 / value2;
                    break;
                case "×":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
            }

            return result;
        }
    }
}

namespace Calculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
