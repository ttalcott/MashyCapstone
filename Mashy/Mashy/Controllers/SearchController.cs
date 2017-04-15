using Mashy.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Http;

namespace Mashy.Controllers
{
    public class SearchController 
    {
        //Get
        public List<Mashy.Models.YelpSearch> Get()
        {
            var model = new List<Mashy.Models.YelpSearch>();

            string request = YelpAPI.PerformRequest();

            DataContractJsonSerializer serialize =
                new DataContractJsonSerializer(typeof(Mashy.Models.YelpSearch));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(request)))
            {
                var searchResults = (Mashy.Models.YelpSearch)serialize.ReadObject(ms);
                model.Add(searchResults);
            }

            return model;
        }

    }
}