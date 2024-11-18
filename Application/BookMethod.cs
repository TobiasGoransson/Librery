using Book;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class BookMethod
    {
        public void AddNewBook()
        {
            Book.Book book = new Book.Book();
            book.Id = 1;
            book.Title = "C# Programming";
            book.Description = "This is a book about C# programming";
        }
    }
}
