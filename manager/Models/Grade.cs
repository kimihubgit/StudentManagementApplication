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

        public double ProgressScore1 { get; set; } // Thường xuyên 1 (TX1)
        public double ProgressScore2 { get; set; } // Thường xuyên 2 (TX2)
        public double MidtermScore { get; set; }   // Giữa kỳ
        public double FinalScore { get; set; }     // Cuối kỳ (Kết thúc học phần)
        public double AverageScore10 { get; set; } // Điểm tổng kết hệ 10
        public double AverageScore4 { get; set; }  // Thang điểm 4
        public string LetterGrade { get; set; }    // Điểm chữ (A, B, C, D, F)
        public string Classification { get; set; } // Xếp loại (Giỏi, Khá, Trung bình...)

        public string Note { get; set; }           // Ghi chú
    }
}
