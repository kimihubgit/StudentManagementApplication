using System;
using System.Collections.Generic;
using System.Text;
using manager.DataAccess;
using manager.Models;
using Manager_Student.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Manager_Student.DataAccess
{
    public class TeacherRepository
    {
        private readonly IMongoCollection<Teacher> _teacherCollection;

        public TeacherRepository()
        {
            MongoContext context = new MongoContext();
            _teacherCollection = context.GetCollection<Teacher>("Teachers");
        }

        // 1. Lấy toàn bộ danh sách giảng viên
        public List<Teacher> GetAllTeachers()
        {
            return _teacherCollection.Find(FilterDefinition<Teacher>.Empty).ToList();
        }

        // 2. Thêm giảng viên mới
        public void InsertTeacher(Teacher teacher)
        {
            _teacherCollection.InsertOne(teacher);
        }

        // 3. Cập nhật thông tin giảng viên
        public void UpdateTeacher(string id, Teacher teacher)
        {
            var filter = Builders<Teacher>.Filter.Eq(t => t.Id, id);
            var update = Builders<Teacher>.Update
                .Set(t => t.TeacherCode, teacher.TeacherCode)
                .Set(t => t.FullName, teacher.FullName)
                .Set(t => t.Email, teacher.Email)
                .Set(t => t.Phone, teacher.Phone)
                .Set(t => t.Degree, teacher.Degree) // Lưu ý: Cần thêm field Degree vào Model Teacher
                .Set(t => t.FacultyId, teacher.FacultyId);

            _teacherCollection.UpdateOne(filter, update);
        }

        // 4. Xóa giảng viên
        public void DeleteTeacher(string id)
        {
            var filter = Builders<Teacher>.Filter.Eq(t => t.Id, id);
            _teacherCollection.DeleteOne(filter);
        }

        // 5. Tìm kiếm giảng viên theo tên hoặc mã (Hỗ trợ cho nút Tìm kiếm trên UI)
        public List<Teacher> SearchTeachers(string keyword)
        {
            var filter = Builders<Teacher>.Filter.Or(
                Builders<Teacher>.Filter.Regex(t => t.FullName, new BsonRegularExpression(keyword, "i")),
                Builders<Teacher>.Filter.Regex(t => t.TeacherCode, new BsonRegularExpression(keyword, "i"))
            );
            return _teacherCollection.Find(filter).ToList();
        }
    }
}