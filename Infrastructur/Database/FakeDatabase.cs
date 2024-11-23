using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructur.Database
{
    public class FakeDatabase
    {

        public List<Book> Books{ get { return allBooksFromDB; } set { allBooksFromDB = value; } }

        private static List<Book> allBooksFromDB = new List<Book>
        {
            new Book(1, "TobyBook", "Book of Toby"),
            new Book(2, "TobyBook2", "Book of Toby2"),
            new Book(3, "TobyBook3", "Book of Toby3"),
            new Book(4, "TobyBook4", "Book of Toby4"),
            new Book(5, "TobyBook5", "Book of Toby5"),
        };
        public Book AddNewBook(Book book)
        {
            allBooksFromDB.Add(book);
            return book;
        }

    }
}
