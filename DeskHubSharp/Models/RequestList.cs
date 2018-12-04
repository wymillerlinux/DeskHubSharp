using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHubSharp
{
    class RequestList
    {
        public static User userDetail { get; set; }

        public static ObservableCollection<Branch> branchDetail { get; set; }

        public static ObservableCollection<RepoDetail> repoDetail { get; set; }
    }
}
