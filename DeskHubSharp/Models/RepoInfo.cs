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

        public ObservableCollection<RepoDetail> GetRepoInfoDataGrid()
        {
            ObservableCollection<RepoDetail> repoStuff = new ObservableCollection<RepoDetail>();
            RepoDetail repo = new RepoDetail();
            //repoStuff.Add(RepoList.repoDetail[3]);
            //repoStuff.Add(repo.url);

            return repoStuff;
        }

    }
}
