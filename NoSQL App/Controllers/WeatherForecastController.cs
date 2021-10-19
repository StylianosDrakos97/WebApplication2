using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoSQL_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private IMongoCollection<Shipwreck> __shipwreckCollection;

        public WeatherForecastController(IMongoClient client)
        {
            var database = client.GetDatabase("sample_geospatial");
            __shipwreckCollection = database.GetCollection<Shipwreck>("shipwrecks");
        }

        [HttpGet]
        public IEnumerable<Shipwreck> Get()
        {
                    
            return __shipwreckCollection.Find(s => s.FeatureType == "Wrecks - Visible").ToList();
        
        }
    }
}
