using Manager_Student.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace manager.DataAccess
{
    public class SemesterRepository
    {
        private readonly IMongoCollection<Semester> _semesterCollection;

        public SemesterRepository()
        {
            MongoContext context = new MongoContext();
            _semesterCollection = context.GetCollection<Semester>("Semesters");
        }

        public List<Semester> GetAllSemesters()
        {
            return _semesterCollection.Find(FilterDefinition<Semester>.Empty).ToList();
        }

        public Semester GetSemesterById(string id)
        {
            var filter = Builders<Semester>.Filter.Eq(s => s.Id, id);
            return _semesterCollection.Find(filter).FirstOrDefault();
        }

        public void InsertSemester(Semester semester)
        {
            _semesterCollection.InsertOne(semester);
        }

        public void UpdateSemester(string id, Semester semester)
        {
            var filter = Builders<Semester>.Filter.Eq(s => s.Id, id);
            var update = Builders<Semester>.Update
                .Set(s => s.SemesterName, semester.SemesterName)
                .Set(s => s.SchoolYear, semester.SchoolYear)
                .Set(s => s.StartDate, semester.StartDate)
                .Set(s => s.EndDate, semester.EndDate);

            _semesterCollection.UpdateOne(filter, update);
        }

        public void DeleteSemester(string id)
        {
            var filter = Builders<Semester>.Filter.Eq(s => s.Id, id);
            _semesterCollection.DeleteOne(filter);
        }

        public List<Semester> SearchSemesters(string keyword)
        {
            var filter = Builders<Semester>.Filter.Regex(s => s.SemesterName, new MongoDB.Bson.BsonRegularExpression(keyword, "i"));
            return _semesterCollection.Find(filter).ToList();
        }
    }
}
