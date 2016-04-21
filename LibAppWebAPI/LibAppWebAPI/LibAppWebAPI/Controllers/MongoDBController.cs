using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using LibAppWebAPI.Models;

namespace LibAppWebAPI.Controllers
{
    public class MongoDBController : Controller
    {
        readonly IMongoDatabase mongoDatabase;

        public MongoDBController()
        {

            string databaseConnectionString = "mongodb://" + CredentialsHandler.DBUser + ":" + CredentialsHandler.DBPassword + "@ds058048.mlab.com:58048/libraryapp";
            var client = new MongoClient(databaseConnectionString);
            mongoDatabase = client.GetDatabase("libraryapp");
        }

        public IEnumerable<BookListOK> GetAllBooks()
        {
            var data = mongoDatabase.GetCollection<BookListOK>("BooklistOK").Find(new BsonDocument()).ToListAsync();
            return data.Result;
        }
    }
}