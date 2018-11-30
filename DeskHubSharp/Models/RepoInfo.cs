using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHubSharp
{
    class RepoInfo
    {
        public RepoInfo()
        {

        }

        public ObservableCollection<string> GetRepoInfoDataGrid()
        {
            ObservableCollection<string> repoStuff = new ObservableCollection<string>();
            RepoDetail repo = new RepoDetail();
            repoStuff.Add(Convert.ToString(RepoList.repoDetail.Select(x => x.name)));
            //repoStuff.Add(repo.url);

            return repoStuff;
        }

    }
}
