using LibAppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibAppWebAPI.Controllers
{
    public class BooksController : ApiController
    {
        List<Book> books = new List<Book>
        {
            new Book { ISBN = 123456,
            Type = "Pocket",
            Category = "deckare",
            Title = "dret",
            Authors = new List<Author> { new Author {Surname = "Kalle", Lastname ="Kula" }, new Author { Surname = "Dret", Lastname = "dretson" } }
            }
        };

        public IEnumerable<Book> GetAllBooks()
        {
            return books;
        }
    }
}
