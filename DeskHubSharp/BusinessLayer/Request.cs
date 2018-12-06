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

        public Request(string query)
        {
            _query = query;
            _api = new ApiDataService(_query);
        }

        public void PerformSearchRequest()
        {
            _api.SearchRequest();
        }

        public void PerformUserRequest()
        {
            _api.UserRequest();
        }

        public void PerformBranchRequest()
        {
            _api.BranchRequest();
        }

        public Owner GetUserData()
        {
            Owner owner = new Owner();
            return owner;
        }

    }
}
