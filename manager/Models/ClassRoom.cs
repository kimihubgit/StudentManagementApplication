using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Manager_Student.Models
{
    public class ClassRoom
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public int AcademicYear { get; set; }
        public string MajorId { get; set; }
        public string HomeroomTeacherId { get; set; }
    }
}