using Manager_Student.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace manager.DataAccess
{
    public class FacultyRepository
    {
        private readonly IMongoCollection<Faculty> _facultyCollection;

        public FacultyRepository()
        {
            MongoContext context = new MongoContext();
            _facultyCollection = context.GetCollection<Faculty>("Faculties");
        }
        // Lấy tất cả danh sách Khoa
        public List<Faculty> GetAllFaculties()
        {
            return _facultyCollection.Find(FilterDefinition<Faculty>.Empty).ToList();
        }

        // Thêm Khoa mới
        public void InsertFaculty(Faculty faculty)
        {
            _facultyCollection.InsertOne(faculty);
        }

        // Cập nhật Khoa
        public void UpdateFaculty(string id, Faculty faculty)
        {
            var filter = Builders<Faculty>.Filter.Eq(f => f.Id, id);
            var update = Builders<Faculty>.Update
                .Set(f => f.FacultyCode, faculty.FacultyCode)
                .Set(f => f.FacultyName, faculty.FacultyName)
                .Set(f => f.FoundedYear, faculty.FoundedYear);

            _facultyCollection.UpdateOne(filter, update);
        }

        // Xóa Khoa
        public void DeleteFaculty(string id)
        {
            var filter = Builders<Faculty>.Filter.Eq(f => f.Id, id);
            _facultyCollection.DeleteOne(filter);
        }
    }
}
