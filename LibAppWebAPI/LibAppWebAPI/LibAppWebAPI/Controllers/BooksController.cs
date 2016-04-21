using LibAppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Web.Http;
using MongoDB.Bson;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace LibAppWebAPI.Controllers
{
    public class BooksController : ApiController
    {
        //List<Book> books = new List<Book>
        //{
        //    new Book { ISBN = 123456,
        //    Type = "Pocket",
        //    Category = "deckare",
        //    Title = "dret",
        //    Authors = new List<Author> { new Author {Surname = "Kalle", Lastname ="Kula" }, new Author { Surname = "Dret", Lastname = "dretson" } }
        //    }
        //};

        public IEnumerable<BookListOK> Get()
        {
            var data = new MongoDBController().GetAllBooks();
            return data;
        }

        public  Book Get(int ISBN)
        {
            //string URL = "http://libris.kb.se/xsearch?query=978-91-44-00848-6&format=json";
            //HttpWebRequest request = WebRequest.Create("http://libris.kb.se/xsearch?query=978-91-44-00848-6&format=json") as HttpWebRequest;
            //using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            //{
            //    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(IXmlJsonReaderInitializer.)
            //    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
            //    //Response jsonResponse
            //    //= objResponse as Response;

            //}

            return new Book();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                string URL = "http://libris.kb.se/xsearch?query=978-91-44-00848-6&format=json";
                client.BaseAddress = new Uri("http://libris.kb.se/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("xsearch?query=978-91-44-00848-6&format=json");
                if (response.IsSuccessStatusCode)
                {
                    response.Content.ToString();
                }
            }
        }
    }
}
