using System.Collections.Generic;
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

        [BsonExtraElements]
        public BsonDocument CatchAll { get; set; } // TODO: Figure out an elegant way to use this

        // public string OrphanGet(string key) // Maybe? (have to do multiples)
        // {
        //     if (CatchAll.Contains(key)) { return CatchAll.GetElement(key).Value.ToString(); }
        //     return null;
        // }
    }
}