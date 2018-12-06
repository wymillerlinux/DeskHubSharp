using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHubSharp
{
    public class Request
    {
        private ApiDataService _api;
        private string _query;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="query"></param>
        public Request(string query)
        {
            _query = query;
            _api = new ApiDataService(_query);
        }

        /// <summary>
        /// Performs the search request 
        /// </summary>
        public void PerformSearchRequest()
        {
            _api.SearchRequest();
        }

        /// <summary>
        /// Performs the user request
        /// </summary>
        public void PerformUserRequest()
        {
            _api.UserRequest();
        }

        /// <summary>
        /// Performs the branch request
        /// </summary>
        public void PerformBranchRequest()
        {
            _api.BranchRequest();
        }

        /// <summary>
        /// Performs the local owner request
        /// </summary>
        /// <returns></returns>
        public Owner GetUserData()
        {
            Owner owner = new Owner();
            return owner;
        }

    }
}
