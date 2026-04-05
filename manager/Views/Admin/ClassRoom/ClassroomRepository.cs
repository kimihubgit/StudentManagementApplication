using MongoDB.Driver;
using Manager_Student.Models;
using System.Collections.Generic;
using MongoDB.Bson;
using System;

namespace manager.DataAccess
{
    public class ClassroomRepository
    {
        private readonly IMongoCollection<ClassRoom> _collection;

        public ClassroomRepository()
        {
            try
            {
                // Nên để chuỗi kết nối vào một file cấu hình, nhưng hiện tại để đây cũng được
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("SchoolManagerDB");
                _collection = database.GetCollection<ClassRoom>("ClassRooms");
            }
            catch (Exception ex)
            {
                // Log lỗi nếu không kết nối được DB
                throw new Exception("Không thể kết nối đến MongoDB: " + ex.Message);
            }
        }

        public List<ClassRoom> GetAllClassRooms()
        {
            // Trả về danh sách lớp học, sắp xếp theo tên hoặc mã nếu cần
            return _collection.Find(new BsonDocument()).ToList();
        }

        public void InsertClassRoom(ClassRoom classroom)
        {
            _collection.InsertOne(classroom);
        }

        public void UpdateClassRoom(string id, ClassRoom classroom)
        {
            var filter = Builders<ClassRoom>.Filter.Eq("_id", ObjectId.Parse(id));

            // Ghi đè dữ liệu mới
            _collection.ReplaceOne(filter, classroom);
        }

        public void DeleteClassRoom(string id)
        {
            // Ép kiểu về ObjectId để thực hiện lệnh xóa chính xác
            var filter = Builders<ClassRoom>.Filter.Eq("_id", ObjectId.Parse(id));
            _collection.DeleteOne(filter);
        }
    }
}