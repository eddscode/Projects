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

namespace BookManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string title;
        private string author;
        private string isbnNumber;
        private string summary;
        private int rating;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TitleField_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void AuthorField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ISBNNumberField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SummaryField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RatingField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            title = TitleField.Text;
            author = AuthorField.Text;
            isbnNumber = ISBNNumberField.Text;
            summary = SummaryField.Text;
            rating = Int32.Parse(RatingField.Text);

            BookDataContext db = new BookDataContext();

            Book book = new Book(title, author, isbnNumber, summary, rating);
            db.T_Books.InsertOnSubmit(book);
        }

    }
}
