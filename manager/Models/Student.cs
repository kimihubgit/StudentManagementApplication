using System;
using System.Collections.Generic;
using System.Text;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Manager_Student.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string MSSV { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ClassName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ClassId { get; set; }
        public double GPA { get; set; }
        public string Status { get; set; }
    }
}
