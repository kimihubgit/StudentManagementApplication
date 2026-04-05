
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

using manager.DataAccess;
using Manager_Student.Models;

namespace manager.DataAccess
{
    public class SubjectRepository
    {
        private readonly IMongoCollection<Subject> _subjectCollection;

        public SubjectRepository()
        {
            MongoContext context = new MongoContext();
            _subjectCollection = context.GetCollection<Subject>("Subjects");
        }

        // Lấy toàn bộ danh sách môn học
        public List<Subject> GetAllSubjects()
        {
            return _subjectCollection.Find(FilterDefinition<Subject>.Empty).ToList();
        }

        // Thêm môn học mới
        public void InsertSubject(Subject subject)
        {
            _subjectCollection.InsertOne(subject);
        }

        // Cập nhật môn học
        public void UpdateSubject(string id, Subject subject)
        {
            var filter = Builders<Subject>.Filter.Eq(s => s.Id, id);
            var update = Builders<Subject>.Update
                .Set(s => s.SubjectCode, subject.SubjectCode)
                .Set(s => s.SubjectName, subject.SubjectName)
                .Set(s => s.Credits, subject.Credits);

            _subjectCollection.UpdateOne(filter, update);
        }

        // Xóa môn học
        public void DeleteSubject(string id)
        {
            var filter = Builders<Subject>.Filter.Eq(s => s.Id, id);
            _subjectCollection.DeleteOne(filter);
        }
    }
}