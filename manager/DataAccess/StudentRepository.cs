using manager.DataAccess;
using Manager_Student.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace manager.DataAccess
{
    public class StudentRepository
    {
        private readonly IMongoCollection<Student> _studentCollection;

        public StudentRepository()
        {
            // Khởi tạo kết nối thông qua MongoContext
            MongoContext context = new MongoContext();
            _studentCollection = context.GetCollection<Student>("Students");
        }

        // 1. Lấy tất cả danh sách sinh viên
        public List<Student> GetAllStudents()
        {
            return _studentCollection.Find(FilterDefinition<Student>.Empty).ToList();
        }

        // 2. Lấy danh sách sinh viên theo Lớp
        public List<Student> GetStudentsByClass(string classId)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.ClassId, classId);
            return _studentCollection.Find(filter).ToList();
        }

        // 3. Thêm sinh viên mới
        public void InsertStudent(Student student)
        {
            _studentCollection.InsertOne(student);
        }

        // 4. Cập nhật thông tin sinh viên
        public void UpdateStudent(string id, Student student)
        {
            // Filter chính xác theo ID của bản ghi
            var filter = Builders<Student>.Filter.Eq(s => s.Id, id);

            var update = Builders<Student>.Update
                .Set(s => s.MSSV, student.MSSV)
                .Set(s => s.FullName, student.FullName)
                .Set(s => s.Gender, student.Gender)
                .Set(s => s.Address, student.Address)
                .Set(s => s.ClassName, student.ClassName)
                .Set(s => s.DateOfBirth, student.DateOfBirth)
                .Set(s => s.ClassId, student.ClassId)
                .Set(s => s.GPA, student.GPA)
                .Set(s => s.Status, student.Status);

            _studentCollection.UpdateOne(filter, update);
        }

        // 5. Xóa sinh viên
        public void DeleteStudent(string id)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.Id, id);
            _studentCollection.DeleteOne(filter);
        }

        // 6. Tìm kiếm sinh viên theo Tên hoặc MSSV (Không phân biệt hoa thường)
        public List<Student> SearchStudents(string keyword)
        {
            // Tạo regex tìm kiếm chứa từ khóa, tùy chọn "i" là không phân biệt hoa thường
            var queryExpr = new BsonRegularExpression(keyword, "i");

            var filter = Builders<Student>.Filter.Or(
                Builders<Student>.Filter.Regex(s => s.FullName, queryExpr),
                Builders<Student>.Filter.Regex(s => s.MSSV, queryExpr)
            );

            return _studentCollection.Find(filter).ToList();
        }

        // 7. Kiểm tra MSSV trùng
        public bool IsMSSVExists(string mssv)
        {
            var filter = Builders<Student>.Filter.Eq(s => s.MSSV, mssv);
            return _studentCollection.Find(filter).Any();
        }
    }
}