using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskHubSharp
{
    public class Sort
    {
        public Sort()
        {
            
        }

        public List<string> GetSortTerms()
        {
            List<string> sortTerms = new List<string>();
            sortTerms.Add("A - Z");
            sortTerms.Add("Least to most Stars");
            sortTerms.Add("Least to most Forks");
            sortTerms.Add("Least to most Watchers");

            return sortTerms;
        }
    }
}
