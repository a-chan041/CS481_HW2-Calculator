using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int state = 1;
        string calculateoperator;
        double num1, num2 = 0;
        double result = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void NumberSelect(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            this.resultText.Text += pressed;
            double num;
            if (double.TryParse(this.resultText.Text, out num))
            {
                this.resultText.Text = num.ToString("");

                if (state == 1)
                {
                    num1 = num;
                }
                else
                {
                    num2 = num;
                }

            }
        }

        void divide(System.Object sender, System.EventArgs e)
        {
            state = 2;

            Button button = (Button)sender;
            string pressed = button.Text;
            calculateoperator = pressed;
            this.resultText.Text = "0";
            this.resultText.Text = result.ToString("");
        }

        void multiply(System.Object sender, System.EventArgs e)
        {
            state = 3;

            Button button = (Button)sender;
            string pressed = button.Text;
            calculateoperator = pressed;
            this.resultText.Text = "0";
            this.resultText.Text = result.ToString("");
        }

        void sub(System.Object sender, System.EventArgs e)
        {
            state = 4;

            Button button = (Button)sender;
            string pressed = button.Text;
            calculateoperator = pressed;
            this.resultText.Text = "0";
            this.resultText.Text = result.ToString("");
        }

        void add(System.Object sender, System.EventArgs e)
        {
            state = 5;

            Button button = (Button)sender;
            string pressed = button.Text;
            calculateoperator = pressed;
            this.resultText.Text = "0";
            this.resultText.Text = result.ToString("");
        }

        void mod(System.Object sender, System.EventArgs e)
        {
            state = 6;

            Button button = (Button)sender;
            string pressed = button.Text;
            calculateoperator = pressed;
            this.resultText.Text = "0";
            this.resultText.Text = result.ToString("");
        }

        void Math(System.Object sender, System.EventArgs e)
        {
            switch (state)
            {
                case 2:
                    result = num1 / num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 - num2;
                    break;
                case 5:
                    result = num1 + num2;
                    break;
                case 6:result = num1 % num2;
                    break;
                default:
                    break;
            }
            this.resultText.Text = result.ToString("");
        }
        void Clear(System.Object sender, System.EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            state = 1;
            result = 0;
            this.resultText.Text = result.ToString("");
        }
    }
}