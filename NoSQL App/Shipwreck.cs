﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoSQL_App
{
    [BsonIgnoreExtraElements]
    public class Shipwreck
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("feature_type")]
        public string FeatureType { get; set; }
        [BsonElement("chart")]
        public string Chart { get; set; }
        [BsonElement("latdec")]
        public double Latitude { get; set; }
        [BsonElement("longdec")]
        public double Longitude { get; set; }

       // [BsonExtraElements]
       // public object[] bucket { get; set; }

    }
}
