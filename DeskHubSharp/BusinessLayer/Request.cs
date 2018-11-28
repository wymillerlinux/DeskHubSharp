using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DeskHubSharp
{
    class Request
    {
        // TODO: this is rudimentary, fix it
        // i.e. try catch statements

        private string _apiEndpoint = "https://api.github.com/";
        private string _query;

        public Request(string query)
        {
            _query = query;
        }

        public void SearchRequest()
        {
            var client = new RestClient(_apiEndpoint);

            RestRequest requestRepo = new RestRequest($"users//{_query}//repos", Method.GET);

            var response = client.Execute(requestRepo).ToString();

            Deserialize(response);

        }

        public void UserRequest()
        {
            var client = new RestClient(_apiEndpoint);

            RestRequest requestUser = new RestRequest($"users//{_query}", Method.GET);

            string response = client.Execute(requestUser).ToString();

            Deserialize(response);
        }

        private void Deserialize(string response)
        {
            var deserialized = JsonConvert.DeserializeObject<RepoDetail>(response);
        }

    }
}
