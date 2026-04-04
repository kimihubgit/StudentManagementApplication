using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using System;
using System.Configuration;

namespace manager.DataAccess
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database;
        public MongoContext()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MongoDbConnection"].ConnectionString;
                string databaseName = ConfigurationManager.AppSettings["DatabaseName"];
                var client = new MongoClient(connectionString);
                _database = client.GetDatabase(databaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Không thể kết nối đến MongoDB: " + ex.Message);
            }
        }
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
