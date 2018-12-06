using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHubSharp
{
    // TODO: The RequestList class is called from code behind, fix it
    public class RequestList
    {
        /// <summary>
        /// Stores everything in User, typically from the request
        /// </summary>
        public static User userDetail { get; set; }

        /// <summary>
        /// Stores everything sent in Branch, typically from request
        /// </summary>
        public static ObservableCollection<Branch> branchDetail { get; set; }

        /// <summary>
        /// Stores everything sent in RepoDetail, typically from request
        /// </summary>
        public static ObservableCollection<RepoDetail> repoDetail { get; set; }
    }
}
