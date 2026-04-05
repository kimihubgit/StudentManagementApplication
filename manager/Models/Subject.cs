using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Manager_Student.Models
{
    public class Subject
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int Credits { get; set; }
    }
}
