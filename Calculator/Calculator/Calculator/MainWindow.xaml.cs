using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string enteredValue; // Contains the current value being entered into the calculator
        float valueOne, valueTwo, answer; // The first value entered, the second value entered, and the answer 
        string op;
        bool valueOneEntered = false; // To check if valueOne has been entered
        bool valueTwoEntered = false; // To check if ValueTwo has been entered
        
    
        // Addition 

        private float Sum(float valueOne, float valueTwo)
        {
            return valueOne + valueTwo;
        }

        // Subtraction

        private float Sub(float valueOne, float valueTwo)
        {
            return valueOne - valueTwo;
        }

        // Division

        private float Div(float valueOne, float valueTwo)
        {
            return valueOne / valueTwo;
        }

        // Multiply

        private float Mult(float valueOne, float valueTwo)
        {
            return valueOne * valueTwo;
        }

        // Remainder (modulo)

        private float Remainder(float valueOne, float valueTwo)
        {
            return valueOne % valueTwo;
        }

        // Convert enteredValue into a Float (for valueOne or valueTwo)

        private float EnteredValueConversion(string enteredValue)
        {
            return float.Parse(enteredValue);
        }

        // Initialize main window components

        public MainWindow()
        {
            InitializeComponent();
        }

        // Buttons

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '0';
            Output.Text += '0';
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '1';
            Output.Text += '1';
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '2';
            Output.Text += '2';
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '3';
            Output.Text += '3';
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '4';
            Output.Text += '4';
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '5';
            Output.Text += '5';
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '6';
            Output.Text += '6';
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '7';
            Output.Text += '7';
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '8';
            Output.Text += '8';
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '9';
            Output.Text += '9';
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            enteredValue += '.';
            Output.Text += '.';
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            op = "Addition";
            if (valueOneEntered == false)
            {
                valueOne = EnteredValueConversion(enteredValue);
            }
            else
            {
                valueTwo = EnteredValueConversion(enteredValue);
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            op = "Subtract";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            op = "Multiply";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            op = "Divide";
        }

        private void Modulo_Click(object sender, RoutedEventArgs e)
        {
            op = "Modulo";
        }

        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (op == "Addition") {
                answer = Sum(valueOne, valueTwo);
            }
            else if (op == "Subtract")
            {
                answer = Sub(valueOne, valueTwo);
            }
            else if (op == "Multiply")
            {
                answer = Mult(valueOne, valueTwo);
            }
            else if (op == "Divide")
            {
                answer = Div(valueOne, valueTwo);
            }
            else if (op == "Modulo")
            {
                answer = Remainder(valueOne, valueTwo);
            }

            Output.Text = answer.ToString();
            op = "";
            valueOne = answer;
            valueTwo = new float();
        }

        private void AllClear_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = "";
            op = "";
            valueOne = new float();
            valueTwo = new float();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
