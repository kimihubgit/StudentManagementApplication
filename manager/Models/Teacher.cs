using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace manager.Models
{
    public class Teacher
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string TeacherCode { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Degree { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string FacultyId { get; set; }
    }
}
