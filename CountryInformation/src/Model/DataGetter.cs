using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace CountryInformation.Model
{
    class DataGetter
    {
        public static List<Country> getData()
        {
            var client = new RestClient("https://ajayakv-rest-countries-v1.p.rapidapi.com/rest/v1/all");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "ajayakv-rest-countries-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "5faa3cc975mshbc7f95227c71e0ep12bddajsne882287dbeba");

            var response = client.Execute(request);
            var data = JsonConvert.DeserializeObject<List<Country>>(response.Content);
            return data;
        }
    }
}
