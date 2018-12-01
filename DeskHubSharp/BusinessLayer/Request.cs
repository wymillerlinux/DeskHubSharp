using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace DeskHubSharp
{
    class Request
    {
        // TODO: this is rudimentary, fix it
        // i.e. try catch statements\
        // TODO: find how to access a list index
        // TODO: find how to access the deserialized 

        private string _apiEndpoint = "https://api.github.com/";
        private string _query;

        public List<RepoDetail> RepoDetail { get; set; }

        public Request(string query)
        {
            _query = query;
        }

        //public Request(string query, Object function)
        //{
        //    _query = query;
        //} 

        /// <summary>
        /// Calls API for repo and user data an stores it in RepoList
        /// </summary>
        /// <returns></returns>
        public void SearchRequest()
        {
            try
            {
                var client = new RestClient(_apiEndpoint);
                RestRequest requestRepo = new RestRequest($"users/{_query}/repos", Method.GET);

                var response = client.Execute(requestRepo);
                var x = response.Content;
                var deserialized = JsonConvert.DeserializeObject<ObservableCollection<RepoDetail>>(x);

                //ObservableCollection<RepoDetail> test = new ObservableCollection<RepoDetail>()
                //{
                //    new RepoDetail()
                //    {
                //        Login = "John",
                //        Password = "pw"
                //    }
                //};

                if (deserialized.Count() == 0)
                {
                    throw new Exception();
                }
                else
                {
                    RepoList.repoDetail = deserialized;
                }
            }
            catch (Exception)
            {
                ErrorWindow err = new ErrorWindow();
                err.txtblk_error.Text = "We can't gather repository data. Please try again";
            }
        }


        /// <summary>
        /// Calls API for detailed user data
        /// </summary>
        public void UserRequest()
        {
            try
            {
                var client = new RestClient(_apiEndpoint);

                RestRequest requestUser = new RestRequest($"users/{_query}", Method.GET);

                var response = client.Execute(requestUser);
                string x = response.Content;
                var deserailized = JsonConvert.DeserializeObject<User>(x);

                if (deserailized == null)
                {
                    throw new Exception();
                }
                else
                {
                    RepoList.userDetail = deserailized;
                }

            }
            catch (Exception)
            {
                ErrorWindow err = new ErrorWindow();
                err.txtblk_error.Text = "We can't gather user data. Please try again.";
            }

        }

    }
}
