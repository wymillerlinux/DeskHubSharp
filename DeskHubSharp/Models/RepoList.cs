using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHubSharp
{
    class RepoList
    {
        private static ObservableCollection<RepoDetail> _repoDetail;

        public static ObservableCollection<RepoDetail> repoDetail
        {
            get { return _repoDetail; }
            set { _repoDetail = value; }
        }
    }
}
