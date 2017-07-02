using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    public class Book
    {
        private string title;
        private string author;
        private string isbnNumber;
        private string summary;
        private int rating;
        private DateTime createdDate;
        private DateTime deletedDate;

        public Book(string title, string author, string isbnNumber, string summary, int rating)
        {
            this.title = title;
            this.author = author;
            this.isbnNumber = isbnNumber;
            this.summary = summary;
            this.rating = rating;
            this.createdDate = DateTime.Now;
        }

    }
}
