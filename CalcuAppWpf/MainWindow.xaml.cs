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

namespace CalcuAppWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp = 0;

        string operation = "";

        public string output = "";

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;
            
            switch(name)
            {
                case "ZeroBtn":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;
                case "OneBtn":
                    output += "1";
                    OutputTextBlock.Text = output;
                    break;
                case "TwoBtn":
                    output += "2";
                    OutputTextBlock.Text = output;
                    break;
                case "ThreeBtn":
                    output += "3";
                    OutputTextBlock.Text = output;
                    break;
                case "FourBtn":
                    output += "4";
                    OutputTextBlock.Text = output;
                    break;
                case "FiveBtn":
                    output += "5";
                    OutputTextBlock.Text = output;
                    break;
                case "SixBtn":
                    output += "6";
                    OutputTextBlock.Text = output;
                    break;
                case "SevenBtn":
                    output += "7";
                    OutputTextBlock.Text = output;
                    break;
                case "EightBtn":
                    output += "8";
                    OutputTextBlock.Text = output;
                    break;
                case "NineBtn":
                    output += "9";
                    OutputTextBlock.Text = output;
                    break;
            }
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Divide";
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
           if(output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Add";
            }
        }

        private void MultiplyBtn_Click(object sender, RoutedEventArgs e)
        {
           if(output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Multiply";
            }
        }

        private void SubtractBtn_Click(object sender, RoutedEventArgs e)
        {
            if(output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Minus";
            }
        }
        
        private void SquareBtn_Click(object sender, RoutedEventArgs e)
        {
            if(output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Square";
            }
        }
    

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double tempOutput;

            switch(operation)
            {
                case "Minus":
                    tempOutput = temp - double.Parse(output);
                    output = tempOutput.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Add":
                    tempOutput = temp + double.Parse(output);
                    output = tempOutput.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Multiply":
                    tempOutput = temp * double.Parse(output);
                    output = tempOutput.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Divide":
                    if(double.Parse(output) != 0)
                    {
                        tempOutput = temp / double.Parse(output);
                        output = tempOutput.ToString();
                        OutputTextBlock.Text = output;
                    }
                    break; 
                case "Square":
                    double square = temp * temp;
                    OutputTextBlock.Text = square.ToString();
                    break;
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            temp = 0;
            output = "";
            operation = "";
            OutputTextBlock.Text = "0";
        }
    }
}
