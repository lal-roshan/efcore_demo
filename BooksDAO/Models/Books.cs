using System;
using System.Collections.Generic;

namespace BooksDAO.Models
{
    public partial class Books
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int Pages { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
    }
}
