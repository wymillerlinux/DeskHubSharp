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
        // TODO: Rename this to something more generic

        public RepoInfo()
        {

        }

        public List<string> GetRepoInfoDataGrid()
        {
            List<string> stuff = RequestList.repoDetail.Select(x => x.full_name).ToList();
            //stuff =+ RepoList.repoDetail.Select(x => x.name).ToList();
            return stuff;
        }

        // validation
        public List<string> GetBranchNameComboBox()
        {
            List<string> stuff = RequestList.branchDetail.Select(x => x.name).ToList();
            return stuff;
        }
    }
}
