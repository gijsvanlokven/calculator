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
        int firstNumber = 0;
        int secondNumber = 0;
        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }


        // function for adding the selected number to the correct storage
        private void ChangeNumber(int number)
        {
            // Check which number needs to be updated based on if there is an operator present
            if (operation == "")
            {
                firstNumber = (firstNumber * 10) + number;
            }
            else
            {
                secondNumber = (secondNumber * 10) + number;
            }
            // update screen with new value
            UpdateScreen();
        }
        

        
        // function for updating the screen output to the new value
        private void UpdateScreen()
        {
            // Check whether to display the first or second number based on if there is an operator
            if(operation == "")
            {
                MainOutput.Text = firstNumber.ToString();
            }
            else
            {
                MainOutput.Text = secondNumber.ToString();
            }
        }

        // Function for computing basic operands
        private void BasicOperands()
        {
            switch (operation)
            {
                case "+":
                    MainOutput.Text = (firstNumber + secondNumber).ToString();
                    break;

                case "-":
                    MainOutput.Text = (firstNumber - secondNumber).ToString();
                    break;

                case "*":
                    MainOutput.Text = (firstNumber * secondNumber).ToString();
                    break;

                case "/":
                    MainOutput.Text = (firstNumber / secondNumber).ToString();
                    break;


                default:
                    break;
            }
        }


        // Button events for numbers

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(9);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(6);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(3);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            ChangeNumber(0);
        }


        // Button events for clear
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            // Check whether to clear the first or second entry
            if(operation == "")
            {
                firstNumber = 0;
            }
            else
            {
                secondNumber = 0;
            }
            // Update screen with the new value
            UpdateScreen();
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            // Clear all input
            firstNumber = 0;
            secondNumber = 0;
            operation = "";

            // Update screen with new values
            UpdateScreen();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            // Check whether which number we are removing
            if(operation == "")
            {
                firstNumber = firstNumber / 10;
            }
            else
            {
                secondNumber = secondNumber / 10;
            }
            // Update screen with new values
            UpdateScreen();
        }


        // Events for the basic operators

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            // Check if the operation belongs to the basic operands
            if(operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                // Check if both numbers are filled
                if(firstNumber > 0 && secondNumber > 0)
                {
                    BasicOperands();
                }
            }
        }
    }
}
