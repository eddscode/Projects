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

namespace ReverseComplementDNA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string text = "";
        bool isReversed = false;
        bool isComplemented = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        static string Reverse(string text)
        // The reverse complement of a DNA string 's' is the string 'sc'
        // formed by reversing the symvbols of 's'.
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        static string ConvertToDNAComplement(string text)
        // In DNA strings, symbols 'A' and 'T'; are complements of each 
        // other, as are 'C' and 'G'.
        {
            char[] array = text.ToCharArray();
            string complementedString = "";

            foreach (char c in array)
            {
                if (c == 'A' || c == 'a')
                {
                    complementedString += 'T';
                }
                else if (c == 'T' || c == 't')
                {
                    complementedString += 'A';
                }
                else if (c == 'C' || c == 'c')
                {
                    complementedString += 'G';
                }
                else if (c == 'G' || c == 'g')
                {
                    complementedString += 'C';
                }
                else
                {
                    MessageBox.Show("Please enter a valid DNA strand.");
                    text = "";
                    break;
                }
            }

            return complementedString;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text = Convert.ToString(UserInputText.Text);
            if (isReversed == true)
            {
                text = Reverse(text);
            }
            if (isComplemented == true)
            {
                text = ConvertToDNAComplement(text);
            }
            
            TextOutput.Text = text;
            text = "";
        }
   
        private void ReverseCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (ReverseCheckBox.IsChecked == true)
            {
                isReversed = true;
            }
            else if (ReverseCheckBox.IsChecked == false)
            {
                isReversed = false;
            }
        }

        private void ComplementCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (ComplementCheckBox.IsChecked == true)
            {
                isComplemented = true;
            }
            else if (ComplementCheckBox.IsChecked == false)
            {
                isComplemented = false;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            text = "";
            UserInputText.Text = "";
            TextOutput.Text = "";
            isReversed = false;
            isComplemented = false;
            ReverseCheckBox.IsChecked = false;
            ComplementCheckBox.IsChecked = false;
        }
    }
}
