using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;
using Mtg.DataModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QuickType;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;

namespace Mtg.Repositories
{
    public class SetRepository
    {
        public readonly string _apiConnection = "https://api.scryfall.com";

        public readonly string _setRouteAer = "/sets/aer";

        public Set GetSet()
        {
            var client = new RestClient(_apiConnection);

            var request = new RestRequest(_setRouteAer, DataFormat.Json);

            var response = client.Get(request).Content;

            var jsonObj = JsonConvert.DeserializeObject(response);

            var set = Set.FromJson(jsonObj.ToString());

            return set;
        }
    }
}
