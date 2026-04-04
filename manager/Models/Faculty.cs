using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Manager_Student.Models
{
    public class Faculty
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FacultyCode { get; set; }
        public string FacultyName { get; set; }
        public DateTime FoundedYear { get; set; }
    }
}
