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
        public string Id { get; set; } // Giữ nguyên cái này vì đây là khóa chính của MongoDB

        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public int AcademicYear { get; set; }

        // XÓA DÒNG [BsonRepresentation...] Ở ĐÂY
        public string MajorId { get; set; }

        // XÓA DÒNG [BsonRepresentation...] Ở ĐÂY
        public string HomeroomTeacherId { get; set; }
    }
}