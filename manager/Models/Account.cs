using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace manager.Models
{
    public class Account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Admin", "Teacher" , "Student" 3 loai tai khoan
        public string FullName { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ReferenceId { get; set; }

    }
}
