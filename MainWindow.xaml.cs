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
        string output = "";
        double temp = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            DivideBtn.Content = "\u00F7";
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
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
                case "ZeroBtn":
                    output += "0";
                    OutputTextBlock.Text = output;
                    break;
                default:
                    break;
            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
            }
            operation = "Minus";
        }


        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {

            double outputTemp;

            switch (operation)
            {
                case "Minus":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString(); 
                    OutputTextBlock.Text = output;
                    break;
                case "Plus":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Product":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;
                case "Divide":
                    if (double.Parse(output) != 0)
                    {
                        outputTemp = temp / double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                    }
                    break;
                default:
                    break;
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
            }
            operation = "Plus";
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
            }
            operation = "Product";
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
            }
            operation = "Divide";

        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            OutputTextBlock.Text = output;
        }

        private void SquareBtn_Click(object sender, RoutedEventArgs e)
        {
            double square = double.Parse(output);
            output = (square*square).ToString();
            OutputTextBlock.Text = output;
        }

        private void InverseBtn_Click(object sender, RoutedEventArgs e)
        {
            double inverse = double.Parse(output);
            output = (1/inverse).ToString();
            OutputTextBlock.Text = output;

        }

        private void BackspaceBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputTextBlock.Text.Length > 0) 
            {
                OutputTextBlock.Text = OutputTextBlock.Text.Substring(0, OutputTextBlock.Text.Length - 1);
                output = OutputTextBlock.Text;
            }
        }
    }
}
