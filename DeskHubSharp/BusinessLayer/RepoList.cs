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

        /// <summary>
        /// Return a list for the list box
        /// </summary>
        /// <returns></returns>
        public List<string> GetRepoInfoList()
        {
            List<string> stuff = new List<string>();

            try
            {
                stuff = RequestList.repoDetail.Select(x => x.full_name).ToList();
            }
            catch (Exception)
            {
                ErrorWindow err = new ErrorWindow();
                err.txtblk_error.Text = "We couldn't gather any data. Does the user exist?";
                err.ShowDialog();
            }

            return stuff;
        }

        /// <summary>
        /// Return a list for the combo box
        /// </summary>
        /// <returns></returns>
        public List<string> GetBranchNameComboBox()
        {
            List<string> stuff = RequestList.branchDetail.Select(x => x.name).ToList();
            return stuff;
        }
    }
}
