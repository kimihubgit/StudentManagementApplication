using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Manager_Student.Models
{
    public class Major
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string MajorCode { get; set; }
        public string MajorName { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string FacultyId { get; set; }
    }
}
