using MongoDB.Bson;
using MongoDB.Driver;

public class MajorRepository
{
    private readonly IMongoCollection<BsonDocument> _collection;

    public MajorRepository()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("SchoolManagerDB");
        _collection = database.GetCollection<BsonDocument>("Majors");
    }

    public List<dynamic> GetAllMajors()
    {
        var list = _collection.Find(new BsonDocument()).ToList();
        var result = new List<dynamic>();
        foreach (var doc in list)
        {
            result.Add(new
            {
                Id = doc["_id"].ToString(),
                MajorName = doc["MajorName"].ToString()
            });
        }
        return result;
    }
}