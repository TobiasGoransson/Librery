using Domain;
using Infrastructur.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBook
{
    public class BookMethod
    {
        private readonly FakeDatabase _fakedatabase;
        public BookMethod()
        {
            
        }
        public BookMethod(FakeDatabase fakedatabase)
        {
            _fakedatabase = fakedatabase;
        }   

        public  Book AddNewBook()
        {
            Book newBookToAdd = new Book(1, "TobyBook", "Book of Toby");
            return _fakedatabase.AddNewBook(newBookToAdd);
        }
    }
}
