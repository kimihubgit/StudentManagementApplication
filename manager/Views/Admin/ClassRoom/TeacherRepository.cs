using MongoDB.Bson;
using MongoDB.Driver;

public class TeacherRepository
{
    private readonly IMongoCollection<BsonDocument> _collection;

    public TeacherRepository()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("SchoolManagerDB");
        _collection = database.GetCollection<BsonDocument>("Teachers");
    }

    public List<dynamic> GetAllTeachers()
    {
        var list = _collection.Find(new BsonDocument()).ToList();
        var result = new List<dynamic>();
        foreach (var doc in list)
        {
            result.Add(new
            {
                Id = doc["_id"].ToString(),
                FullName = doc["FullName"].ToString()
            });
        }
        return result;
    }
}