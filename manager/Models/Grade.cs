using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Manager_Student.Models
{
    public class Grade
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string StudentId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string SubjectId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string SemesterId { get; set; }

        public double AttendanceScore { get; set; }
        public double MidtermScore { get; set; }
        public double FinalScore { get; set; }
        public double AverageScore { get; set; }
    }
}
