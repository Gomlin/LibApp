using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAppWebAPI.Models
{
    public class BookListOK
    {
        
        public ObjectId Id { get; set; }

        [BsonElement("Author")]
        public Author Author { get; set; }

        [BsonElement("Title")]
        public string Titel { get; set; }

        [BsonElement("Year")]
        public string Year { get; set; }
        
        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("Category")]
        public string Category { get; set; }
    }
}