using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHubSharp
{
    public interface IDataService
    {
        //List<Search> ReadAll();
        //void WriteAll(List<Search> user);

        void SearchRequest();
        void UserRequest();
        void BranchRequest();
    }
}
