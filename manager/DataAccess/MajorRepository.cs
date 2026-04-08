using Manager_Student.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using manager.DataAccess;

namespace manager.DataAccess
{
    public class MajorRepository
    {
        private readonly IMongoCollection<Major> _majorCollection;

        public MajorRepository()
        {
            MongoContext context = new MongoContext();
            _majorCollection = context.GetCollection<Major>("Majors");
        }

        public List<Major> GetAllMajors()
        {
            try
            {
                return _majorCollection.Find(FilterDefinition<Major>.Empty).ToList();
            }
            catch (Exception)
            {
                return new List<Major>();
            }
        }

        public Major GetMajorById(string id)
        {
            var filter = Builders<Major>.Filter.Eq(m => m.Id, id);
            return _majorCollection.Find(filter).FirstOrDefault();
        }

        public void InsertMajor(Major major)
        {
            _majorCollection.InsertOne(major);
        }

        public void UpdateMajor(string id, Major major)
        {
            var filter = Builders<Major>.Filter.Eq(m => m.Id, id);
            var update = Builders<Major>.Update
                .Set(m => m.MajorCode, major.MajorCode)
                .Set(m => m.MajorName, major.MajorName)
                .Set(m => m.FacultyId, major.FacultyId);

            _majorCollection.UpdateOne(filter, update);
        }

        public void DeleteMajor(string id)
        {
            var filter = Builders<Major>.Filter.Eq(m => m.Id, id);
            _majorCollection.DeleteOne(filter);
        }

        public List<Major> SearchMajors(string keyword)
        {
            var filter = Builders<Major>.Filter.Or(
                Builders<Major>.Filter.Regex(m => m.MajorName, new MongoDB.Bson.BsonRegularExpression(keyword, "i")),
                Builders<Major>.Filter.Regex(m => m.MajorCode, new MongoDB.Bson.BsonRegularExpression(keyword, "i"))
            );
            return _majorCollection.Find(filter).ToList();
        }
    }
}
