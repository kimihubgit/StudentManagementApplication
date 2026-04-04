using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager_Student.Models
{
    public class TeachingAssignment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string TeacherId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string SubjectId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string ClassId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string SemesterId { get; set; }
    }
}
