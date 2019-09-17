using Core.DB_Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.DB_Model
{
    public class BaseObj : IBaseObj
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string IBaseObj.Id { get; set; }
    }
}