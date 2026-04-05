using System;
using System.Collections.Generic;
using System.Text;
using manager.DataAccess;
using Manager_Student.Models;
using MongoDB.Driver;

namespace Manager_Student.DataAccess
{
    public class FacultyRepository
    {
        private readonly IMongoCollection<Faculty> _facultyCollection;

        public FacultyRepository()
        {
            // Khởi tạo kết nối thông qua MongoContext
            MongoContext context = new MongoContext();
            _facultyCollection = context.GetCollection<Faculty>("Faculties");
        }

        // 1. Lấy toàn bộ danh sách Khoa (Dùng để đổ vào ComboBox trên Winform)
        public List<Faculty> GetAllFaculties()
        {
            try
            {
                return _facultyCollection.Find(FilterDefinition<Faculty>.Empty).ToList();
            }
            catch (Exception ex)
            {
                // Bạn có thể log lỗi ở đây nếu cần
                return new List<Faculty>();
            }
        }

        // 2. Lấy thông tin một Khoa theo ID (Dùng khi cần tìm tên khoa từ FacultyId)
        public Faculty GetFacultyById(string id)
        {
            var filter = Builders<Faculty>.Filter.Eq(f => f.Id, id);
            return _facultyCollection.Find(filter).FirstOrDefault();
        }

        // 3. Thêm Khoa mới
        public void InsertFaculty(Faculty faculty)
        {
            _facultyCollection.InsertOne(faculty);
        }

        // 4. Cập nhật thông tin Khoa
        public void UpdateFaculty(string id, Faculty faculty)
        {
            var filter = Builders<Faculty>.Filter.Eq(f => f.Id, id);
            var update = Builders<Faculty>.Update
                .Set(f => f.FacultyCode, faculty.FacultyCode)
                .Set(f => f.FacultyName, faculty.FacultyName)
                .Set(f => f.FoundedYear, faculty.FoundedYear);

            _facultyCollection.UpdateOne(filter, update);
        }

        // 5. Xóa Khoa
        public void DeleteFaculty(string id)
        {
            var filter = Builders<Faculty>.Filter.Eq(f => f.Id, id);
            _facultyCollection.DeleteOne(filter);
        }

        // 6. Tìm kiếm Khoa theo tên hoặc mã khoa
        public List<Faculty> SearchFaculties(string keyword)
        {
            var filter = Builders<Faculty>.Filter.Or(
                Builders<Faculty>.Filter.Regex(f => f.FacultyName, new MongoDB.Bson.BsonRegularExpression(keyword, "i")),
                Builders<Faculty>.Filter.Regex(f => f.FacultyCode, new MongoDB.Bson.BsonRegularExpression(keyword, "i"))
            );
            return _facultyCollection.Find(filter).ToList();
        }
    }
}