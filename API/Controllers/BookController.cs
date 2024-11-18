using ApplicationBook;
using Domain;
using Infrastructur.Database;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
       

        [HttpPost]

        public Book AddBook()
        {
            BookMethod applicationLayerBookMethods = new BookMethod();
            return applicationLayerBookMethods.AddNewBook();

        }
    }
}
