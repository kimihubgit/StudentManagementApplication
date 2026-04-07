using MongoDB.Driver;
using Manager_Student.Models;
using System.Collections.Generic;
using MongoDB.Bson;
using System;

namespace manager.DataAccess
{
    public class ClassroomRepository
    {
        private readonly IMongoCollection<ClassRoom> _ClassroomCollection;

        public ClassroomRepository()
        {
            try
            {
                MongoContext context = new MongoContext();
                _ClassroomCollection = context.GetCollection<ClassRoom>("ClassRooms");
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể kết nối đến MongoDB: " + ex.Message);
            }
        }

        public List<ClassRoom> GetAllClassRooms()
        {
            return _ClassroomCollection.Find(_ => true).ToList();
        }

        public void InsertClassRoom(ClassRoom classroom)
        {
            _ClassroomCollection.InsertOne(classroom);
        }

        public void UpdateClassRoom(string id, ClassRoom classroom)
        {
            var filter = Builders<ClassRoom>.Filter.Eq(c => c.Id, id);

            var update = Builders<ClassRoom>.Update
                .Set(c => c.ClassCode, classroom.ClassCode)
                .Set(c => c.ClassName, classroom.ClassName)
                .Set(c => c.AcademicYear, classroom.AcademicYear)
                .Set(c => c.MajorId, classroom.MajorId)
                .Set(c => c.HomeroomTeacherId, classroom.HomeroomTeacherId);

            _ClassroomCollection.UpdateOne(filter, update);
        }

        public void DeleteClassRoom(string id)
        {
            var filter = Builders<ClassRoom>.Filter.Eq("_id", ObjectId.Parse(id));
            _ClassroomCollection.DeleteOne(filter);
        }
    }
}